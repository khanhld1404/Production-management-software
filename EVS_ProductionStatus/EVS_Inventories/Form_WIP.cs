
using EVS_Management.Class;
using EVS_Management.Data_EVS;
using EVS_Management.EVS_Inventories.Class;
using EVS_Management.EVS_Inventories.Model;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace EVS_Management
{
    public partial class Form_WIP : UserControl
    {
        public Form_WIP()
        {
            InitializeComponent();
        }
        string entityConnString = clConnection.connectEntity2;
        // Nếu loc là một trong hai giá trị ở dưới thì trả về kết quả là true, còn lại là false
        bool IsTargetLoc(string loc)
        {
            var l = loc?.Trim();
            return l == "3010";
        }
        // Kiểm tra trạng thái, do trạng thái có thể viết là Passed hoặc PASSED thì ta cần phải cho in hoa hết hoặc in thường hết  để kiểm tra được chính xác
        string NoWIPalizeStatus(string status)
        {
            if (status == null) return null;
            return status.ToUpperInvariant();
        }

        // Mô tả nhóm header để chia vùng cho datagridview 
        class HeaderGroup
        {
            public string Text { get; set; }
            public string[] ColumnNames { get; set; }
        }

        // Danh sách nhóm cho grid WIP/WIP
        private readonly List<HeaderGroup> _WIPwipGroups = new List<HeaderGroup>
        {
            new HeaderGroup { Text = "Bộ Phận EVS", ColumnNames = new [] { "Total_EVS","Blocked","UU","QI","Restricted" } },
            new HeaderGroup { Text = "Ngoài EVS", ColumnNames = new [] { "Total_NSX","Blocked_NSX","UU_NSX","QI_NSX","Restricted_NSX" } }
        };

        // Vẽ lại "nhãn cột" ở nửa dưới header
        private void Data_Main_WIP_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                var dgv = (DataGridView)sender;

                // Vẽ nền mặc định cả ô trước
                e.PaintBackground(e.CellBounds, true);

                // Nửa dưới dành cho nhãn cột
                Rectangle lowerRect = e.CellBounds;
                lowerRect.Y += dgv.ColumnHeadersHeight / 2;
                lowerRect.Height = dgv.ColumnHeadersHeight / 2;

                // Vẽ text nhãn cột (HeaderText)
                TextRenderer.DrawText(
                    e.Graphics,
                    dgv.Columns[e.ColumnIndex].HeaderText,
                    dgv.ColumnHeadersDefaultCellStyle.Font,
                    lowerRect,
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );

                //// Vẽ viền tổng thể ô header (tránh phần trên trống viền)
                e.Paint(e.CellBounds, DataGridViewPaintParts.Border);

                e.Handled = true; // chúng ta đã tự vẽ
            }
        }

        // Vẽ "nhóm" ở nửa trên header
        private void Data_Main_WIP_Paint(object sender, PaintEventArgs e)
        {
            var dgv = (DataGridView)sender;
            int topHeight = dgv.ColumnHeadersHeight / 2;

            foreach (var group in _WIPwipGroups)
            {
                // Lấy các cột thuộc nhóm (khớp Name hoặc DataPropertyName)
                // Tìm các cột đối ứng.Ví dụ Sản xuất sẽ gồm có ba cột là "Total_EVS","Pass","Hold"
                var cols = group.ColumnNames
                    .Select(name => FindColumn(dgv, name))
                    .Where(c => c != null)
                    .ToList();

                if (cols.Count == 0) continue;

                // Tính rectangle bao trùm từ cột đầu tiên đến cuối cùng
                Rectangle rStart = dgv.GetCellDisplayRectangle(cols.First().Index, -1, true);
                Rectangle rEnd = dgv.GetCellDisplayRectangle(cols.Last().Index, -1, true);

                int x = rStart.X;
                int y = rStart.Y;
                int width = (rEnd.X + rEnd.Width) - rStart.X;
                int height = topHeight;

                Rectangle groupRect = new Rectangle(x, y, width, height);

                // Vẽ nền + viền cho nhóm (nửa trên)
                using (SolidBrush back = new SolidBrush(dgv.ColumnHeadersDefaultCellStyle.BackColor))
                using (Pen border = new Pen(dgv.GridColor))
                {
                    e.Graphics.FillRectangle(back, groupRect);
                    e.Graphics.DrawRectangle(border, groupRect);
                }

                // Vẽ chữ nhóm (canh giữa)
                TextRenderer.DrawText(
                    e.Graphics,
                    group.Text,
                    dgv.ColumnHeadersDefaultCellStyle.Font,
                    groupRect,
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        // Hỗ trợ: tìm cột theo Name hoặc DataPropertyName (case-insensitive)
        private DataGridViewColumn FindColumn(DataGridView dgv, string name)
        {
            foreach (DataGridViewColumn c in dgv.Columns)
            {
                if (string.Equals(c.Name, name, StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(c.DataPropertyName, name, StringComparison.OrdinalIgnoreCase))
                {
                    return c;
                }
            }
            return null;
        }

        // Bắt sự kiện để vẽ lại khi cuộn / đổi width
        private void Data_Main_WIP_Scroll(object sender, ScrollEventArgs e) => ((DataGridView)sender).Invalidate();


        //Xây dựng và  gọi api để load và  cập nhật dữ liệu lên thẻ eink
        //Đường dẫn
        private static readonly HttpClient http = new HttpClient
        {
            BaseAddress = new Uri("http://172.31.9.31/test_api/"),
            Timeout = TimeSpan.FromSeconds(100)
        };

        //Gọi API để cập nhật dữ liệu trong bảng product
        private async Task<string> PostDataAsync(string endpoint, IEnumerable<Product_Eink> items) // Thêm thông tin product rồi trả về giastrij id vừa tạo
        {

            if (items == null || !items.Any())
            {
                MessageBox.Show("Danh sách sản phẩm trống. Không gửi lên server.");
                return null;
            }
            http.DefaultRequestHeaders.Accept.Clear();
            http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = false
            };

            var json = JsonSerializer.Serialize(items, options);
            using (var content = new StringContent(json, Encoding.UTF8, "application/json"))
            {
                HttpResponseMessage resp;
                try
                {
                    resp = await http.PostAsync(endpoint, content);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không gọi được API: {ex.Message}");
                    return null;
                }

                var body = await resp.Content.ReadAsStringAsync();
                if (!resp.IsSuccessStatusCode)
                {
                    MessageBox.Show(
                    $"Cập nhật thất bại!\nEndpoint: {endpoint}\nStatus: {(int)resp.StatusCode} {resp.StatusCode}\nResponse:\n{body}");
                    return null;
                }
                return body;
            }
        }

        //Dữ liệu được truyền lên
        //private async Task Set_Eink()
        //{
        //    using (var mb = new Manage_evsEntities(clConnection.connectString2))
        //    {
        //        var ListProduct = mb.EVS_Stock
        //        .Where(x => x.STORAGE_LOCATION == "04010" || x.STORAGE_LOCATION == "04015")
        //        .Select(item => new Product_Eink
        //        {
        //            ItemCode = item.MATERIAL_CODE,
        //            LotNo = item.LotNo,
        //            R_float1 = item.Qty,
        //            R_float2 = item.Qty_Allocate
        //        })
        //        .ToList();
        //        await PostDataAsync("api/product/Stock/", ListProduct);
        //    }
        //}

        //Load dữ liệu ban đầu
        private void FoWIP_WIP_Load(object sender, EventArgs e)
        {
            //Set_Eink();
            Load_Data();
            Placeholder.SetupPlaceholder(txt_Search_ItemCode, "ItemCode");
            Placeholder.SetupPlaceholder(txt_Search_Lotno, "LotNo");
        }
        private void Load_Data()
        {
            txt_Search_ItemCode.AutoSize = false;
            txt_Search_Lotno.AutoSize = false;
            Manage_evsEntities mb = new Manage_evsEntities(entityConnString);

            var summary1 = mb.EVS_Stock
                .Where(x => x.MATERIAL_TYPE == "ZHAL")
                .Select(p => new
                {
                    Qty = p.STOCK_QUANTITY,                  // giả định decimal?
                    status = p.STOCK_TYPE,            // string
                    //Qty_Allocate = p.Qty_Allocate,
                    STORAGE_LOCATION = p.STORAGE_LOCATION                   // string
                })
                .ToList();

            // Tổng ngoài SX
            var Total_NSX = Math.Round(
                summary1
                    .Where(x => !IsTargetLoc(x.STORAGE_LOCATION))
                    .Select(x => x.Qty.GetValueOrDefault())
                    .Sum(),
                1
            );

            // Blocked ngoài SX
            var Blocked_NSX = Math.Round(
                summary1
                    .Where(x => !IsTargetLoc(x.STORAGE_LOCATION) && NoWIPalizeStatus(x.status) == "BLOCKED")
                    .Select(x => x.Qty.GetValueOrDefault())
                    .Sum(),
                1
            );

            // UU ngoài SX
            var UU_NSX = Math.Round(
                summary1
                    .Where(x => !IsTargetLoc(x.STORAGE_LOCATION) && NoWIPalizeStatus(x.status) == "UU")
                    .Select(x => x.Qty.GetValueOrDefault())
                    .Sum(),
                1
            );

            // QI ngoài SX
            var QI_NSX = Math.Round(
                summary1
                    .Where(x => !IsTargetLoc(x.STORAGE_LOCATION) && NoWIPalizeStatus(x.status) == "QI")
                    .Select(x => x.Qty.GetValueOrDefault())
                    .Sum(),
                1
            );
            // Restricted ngoài SX
            var Restricted_NSX = Math.Round(
                summary1
                    .Where(x => !IsTargetLoc(x.STORAGE_LOCATION) && NoWIPalizeStatus(x.status) == "RESTRICTED")
                    .Select(x => x.Qty.GetValueOrDefault())
                    .Sum(),
                1
            );

            // Tổng trong SX (EVS)
            var Total_EVS = Math.Round(
                summary1
                    .Where(x => IsTargetLoc(x.STORAGE_LOCATION))
                    //.Where(x =>
                    //{
                    //    var st = NoWIPalizeStatus(x.status);
                    //    return st == "PASSED" || st == "HOLD";
                    //})
                    .Select(x => x.Qty.GetValueOrDefault())
                    .Sum(),
                1
            );

            // Blocked trong SX
            var Blocked = Math.Round(
                summary1
                    .Where(x => IsTargetLoc(x.STORAGE_LOCATION) && NoWIPalizeStatus(x.status) == "BLOCKED")
                    .Select(x => x.Qty.GetValueOrDefault())
                    .Sum(),
                1
            );

            // UU trong SX
            var UU = Math.Round(
                summary1
                    .Where(x => IsTargetLoc(x.STORAGE_LOCATION) && NoWIPalizeStatus(x.status) == "UU")
                    .Select(x => x.Qty.GetValueOrDefault())
                    .Sum(),
                1
            );

            // QI trong SX
            var QI = Math.Round(
                summary1
                    .Where(x => IsTargetLoc(x.STORAGE_LOCATION) && NoWIPalizeStatus(x.status) == "QI")
                    .Select(x => x.Qty.GetValueOrDefault())
                    .Sum(),
                1
            );
            // Restricted trong SX
            var Restricted = Math.Round(
                summary1
                    .Where(x => IsTargetLoc(x.STORAGE_LOCATION) && NoWIPalizeStatus(x.status) == "RESTRICTED")
                    .Select(x => x.Qty.GetValueOrDefault())
                    .Sum(),
                1
            );

            // Tổng chung
            var Total_TVC = Math.Round(summary1.Select(x => x.Qty.GetValueOrDefault()).Sum(), 1);

            var result = new
            {
                Total_TVC,
                Total_EVS,
                Blocked,
                UU,
                QI,
                Restricted,
                Total_NSX,
                Blocked_NSX,
                UU_NSX,
                QI_NSX,
                Restricted_NSX
            };

            Dgv_Main_WIP.DataSource = new List<object> { result };



            Dgv_Main_WIP.Height = Dgv_Main_WIP.ColumnHeadersHeight +
                                  Dgv_Main_WIP.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + 2;

            // Header 2 tầng: nửa trên cho nhóm, nửa dưới cho nhãn cột
            Dgv_Main_WIP.EnableHeadersVisualStyles = false;
            Dgv_Main_WIP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Dgv_Main_WIP.ColumnHeadersHeight = 52;

            // Căn giữa nhãn cột
            Dgv_Main_WIP.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Gắn event owner-draw
            Dgv_Main_WIP.CellPainting += Data_Main_WIP_CellPainting;
            Dgv_Main_WIP.Paint += Data_Main_WIP_Paint;
            Dgv_Main_WIP.Scroll += Data_Main_WIP_Scroll;

        }

        int a = 0; //Xác định chỗ thêm cột ( từ cột 1 đến 3 là có thêm còn lại ko với a = 1 là thêm, a = 0 là ko thêm)
        int b = 0; //Xác định giá  trị tìm kiếm (b = 0 là bảng ko tìm kiếm, b = 1 là có do ở đây có 2 loại bảng là tổng quan với chi tiết)
        int c = 0; //Xác định cột được bấm
        int r = 0; //Xác định hàng được bấm

        //Danh sách dữ liệu 
        private List<RM_WIP_Overview> Data_Overview;
        private List<RM_WIP_Detail> Data_Detail;
        private List<RM_WIP_Elink> Data_Eink;


        private List<RM_WIP_Overview> Data_Search_Overview;
        private List<RM_WIP_Detail> Data_Search_Detail;
        private List<RM_WIP_Elink> Data_Search_Eink;
        private void Data_Details_Load(int row, int column)
        {
            Manage_evsEntities mb = new Manage_evsEntities(entityConnString);
            string sum_type = Dgv_Main_WIP.Columns[column].Name;
            var targetLocs = new[] { "3010"};

            Data_Overview = (from in_e in mb.EVS_Stock
                             where (in_e.MATERIAL_TYPE == "ZHAL") &&
                                     (
                                     (sum_type == "Total_EVS" && targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
                                     (sum_type == "Total_TVC") ||
                                     (sum_type == "Blocked" && in_e.STOCK_TYPE.ToUpper() == "BLOCKED" && targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
                                     (sum_type == "UU" && in_e.STOCK_TYPE.ToUpper() == "UU" && targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
                                     (sum_type == "QI" && in_e.STOCK_TYPE.ToUpper() == "QI" && targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
                                     (sum_type == "Restricted" && in_e.STOCK_TYPE.ToUpper() == "RESTRICTED" && targetLocs.Contains(in_e.STORAGE_LOCATION)) ||

                                     (sum_type == "Total_NSX" && !targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
                                     (sum_type == "Blocked_NSX" && in_e.STOCK_TYPE.ToUpper() == "BLOCKED" && !targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
                                     (sum_type == "UU_NSX" && in_e.STOCK_TYPE.ToUpper() == "UU" && !targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
                                     (sum_type == "QI_NSX" && in_e.STOCK_TYPE.ToUpper() == "QI" && !targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
                                     (sum_type == "Restricted_NSX" && in_e.STOCK_TYPE.ToUpper() == "RESTRICTED" && !targetLocs.Contains(in_e.STORAGE_LOCATION))
                                     )
                             group in_e by in_e.MATERIAL_CODE into g
                             orderby g.Key
                             select new RM_WIP_Overview
                             {
                                 MATERIAL_CODE = g.Key,
                                 Total = Math.Round(g.Sum(x => x.STOCK_QUANTITY) ?? 0m, 2),
                                 Blocked = Math.Round(g.Sum(x => x.STOCK_TYPE.ToUpper() == "BLOCKED" ? x.STOCK_QUANTITY : 0m) ?? 0m),
                                 UU = Math.Round(g.Sum(x => x.STOCK_TYPE.ToUpper() == "UU" ? x.STOCK_QUANTITY : 0m) ?? 0m),
                                 QI = Math.Round(g.Sum(x => x.STOCK_TYPE.ToUpper() == "QI" ? x.STOCK_QUANTITY : 0m) ?? 0m),
                                 Restricted = Math.Round(g.Sum(x => x.STOCK_TYPE.ToUpper() == "RESTRICTED" ? x.STOCK_QUANTITY : 0m) ?? 0m)
                             }
                        ).ToList();
            if (column >= 1 && column <= 5)
            {
                Data_Eink = (from in_e in mb.EVS_Stock
                             where (in_e.MATERIAL_TYPE == "ZHAL") &&
                                     (
                                    (sum_type == "Total_EVS" && targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
                                    (sum_type == "Blocked" && in_e.STOCK_TYPE.ToUpper() == "BLOCKED" && targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
                                    (sum_type == "UU" && in_e.STOCK_TYPE.ToUpper() == "UU" && targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
                                    (sum_type == "QI" && in_e.STOCK_TYPE.ToUpper() == "QI" && targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
                                    (sum_type == "Restricted" && in_e.STOCK_TYPE.ToUpper() == "RESTRICTED" && targetLocs.Contains(in_e.STORAGE_LOCATION))
                                     )
                             group in_e by new { in_e.MATERIAL_CODE, in_e.BATCH_NUMBER, in_e.STOCK_TYPE, in_e.CONNECT_STATUS } into g
                             orderby g.Key.MATERIAL_CODE
                             select new RM_WIP_Elink
                             {
                                 MATERIAL_CODE = g.Key.MATERIAL_CODE,
                                 Lotno = g.Key.BATCH_NUMBER,
                                 Status = g.Key.STOCK_TYPE,
                                 Total = Math.Round(g.Sum(x => x.STOCK_QUANTITY) ?? 0m, 2),
                                 Blocked = Math.Round(g.Sum(x => x.STOCK_TYPE.ToUpper() == "BLOCKED" ? x.STOCK_QUANTITY : 0m) ?? 0m),
                                 UU = Math.Round(g.Sum(x => x.STOCK_TYPE.ToUpper() == "UU" ? x.STOCK_QUANTITY : 0m) ?? 0m),
                                 QI = Math.Round(g.Sum(x => x.STOCK_TYPE.ToUpper() == "QI" ? x.STOCK_QUANTITY : 0m) ?? 0m),
                                 Restricted = Math.Round(g.Sum(x => x.STOCK_TYPE.ToUpper() == "RESTRICTED" ? x.STOCK_QUANTITY : 0m) ?? 0m),
                                 Eink = g.Key.CONNECT_STATUS
                             }).ToList();
            }
            else
            {
                Data_Detail = (from in_e in mb.EVS_Stock
                               where (in_e.MATERIAL_TYPE == "ZHAL") &&
                                       (
                                       (sum_type == "Total_TVC") ||
                                       (sum_type == "Total_NSX" && !targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
                                       (sum_type == "Blocked_NSX" && in_e.STOCK_TYPE.ToUpper() == "BLOCKED" && !targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
                                       (sum_type == "UU_NSX" && in_e.STOCK_TYPE.ToUpper() == "UU" && !targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
                                       (sum_type == "QI_NSX" && in_e.STOCK_TYPE.ToUpper() == "QI" && !targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
                                       (sum_type == "Restricted_NSX" && in_e.STOCK_TYPE.ToUpper() == "RESTRICTED" && !targetLocs.Contains(in_e.STORAGE_LOCATION))
                                       )
                               group in_e by new { in_e.MATERIAL_CODE, in_e.BATCH_NUMBER, in_e.STOCK_TYPE } into g
                               orderby g.Key.MATERIAL_CODE
                               select new RM_WIP_Detail
                               {
                                   MATERIAL_CODE = g.Key.MATERIAL_CODE,
                                   Lotno = g.Key.BATCH_NUMBER,
                                   Status = g.Key.STOCK_TYPE,
                                   Total = Math.Round(g.Sum(x => x.STOCK_QUANTITY) ?? 0m, 2),
                                   Total_Blocked = Math.Round(g.Sum(x => x.STOCK_TYPE.ToUpper() == "BLOCKED" ? x.STOCK_QUANTITY : 0m) ?? 0m),
                                   Total_UU = Math.Round(g.Sum(x => x.STOCK_TYPE.ToUpper() == "UU" ? x.STOCK_QUANTITY : 0m) ?? 0m),
                                   Total_QI = Math.Round(g.Sum(x => x.STOCK_TYPE.ToUpper() == "QI" ? x.STOCK_QUANTITY : 0m) ?? 0m),
                                   Total_Restricted = Math.Round(g.Sum(x => x.STOCK_TYPE.ToUpper() == "RESTRICTED" ? x.STOCK_QUANTITY : 0m) ?? 0m)
                               }).ToList();
            }
            if (Dgv_Details_WIP.DataSource == null || Dgv_Details_WIP.Tag.ToString() == "WIP_Overview" || Dgv_Details_WIP.Tag.ToString() == "RM_WIP_Overview_elink")
            {
                Lab_Details_WIP.Text = "Thông tin WIP (Tổng Quan)";
                Dgv_Details_WIP.DataSource = null;
                Dgv_Details_WIP.Columns.Clear();
                Dgv_Details_WIP.Refresh();
                if (b == 0)
                {
                    Dgv_Details_WIP.DataSource = Data_Overview;
                }
                else
                {
                    Search();
                }
                Dgv_Details_WIP.Tag = "WIP_Overview";
                if (column >= 1 && column <= 5)
                {
                    a = 1;
                }
            }
            else if (Dgv_Details_WIP.Tag.ToString() == "WIP_Detail")
            {
                Dgv_Details_WIP.DataSource = null;
                Dgv_Details_WIP.Columns.Clear();
                Dgv_Details_WIP.Refresh();

                if (column >= 1 && column <= 5)
                {
                    if (b == 0)
                    {
                        Dgv_Details_WIP.DataSource = Data_Eink;
                    }
                    else
                    {
                        Search();
                    }
                    label_suggest.Text = @"
                    Lưu ý : Khi click vào allocate thì sẽ hiện ra thêm các id
                    của lot đó
                    ";
                    var btnCol = new DataGridViewButtonColumn();
                    btnCol.Name = "Action";                  // Tên nội bộ cột
                    btnCol.HeaderText = "Thao tác";          // Tiêu đề cột hiển thị
                    btnCol.Text = "Xử lý";                    // Text của nút (áp dụng cho tất cả hàng)
                    btnCol.UseColumnTextForButtonValue = true;
                    Dgv_Details_WIP.Columns.Add(btnCol);
                    a = 1;
                }
                else
                {
                    label_suggest.Text = null;
                    Dgv_Details_WIP.DataSource = Data_Detail;
                }
            }
        }
        private void Data_Main_WIP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                a = 0; b = 0;
                c = e.ColumnIndex;
                r = e.RowIndex;
                Data_Details_Load(r, c);
            }
        }

        private void Btn_Total_Click(object sender, EventArgs e)
        {
            if (Dgv_Details_WIP.DataSource == null)
            {
                MessageBox.Show("Chưa có dữ liệu. Mời bạn nhấn bên trên");
                return;
            }
            Lab_Details_WIP.Text = "Thông tin WIP (Tổng Quan)";
            label_suggest.Text = "";
            Dgv_Details_WIP.DataSource = null;
            Dgv_Details_WIP.Columns.Clear();
            Dgv_Details_WIP.Refresh();
            if (b != 1)
            {
                Dgv_Details_WIP.DataSource = Data_Overview;
            }
            else
            {
                Dgv_Details_WIP.DataSource = Data_Search_Overview;
            }
            Dgv_Details_WIP.Tag = "WIP_Overview";
        }


        private void Btn_Details_Click(object sender, EventArgs e)
        {
            if (Dgv_Details_WIP.DataSource == null)
            {
                MessageBox.Show("Chưa có dữ liệu. Mời bạn nhấn bên trên");
                return;
            }
            Lab_Details_WIP.Text = "Thông tin WIP (Chi Tiết)";
            label_suggest.Text = @"
            Lưu ý : Khi click vào allocate thì sẽ hiện ra thêm các id
            của lot đó
            ";
            label_suggest.ForeColor = Color.Red;
            label_suggest.Font = new Font("Arial", 10);
            Dgv_Details_WIP.DataSource = null;
            Dgv_Details_WIP.Columns.Clear();
            Dgv_Details_WIP.Refresh();
            Dgv_Details_WIP.Tag = "WIP_Detail";
            if (b != 1)
            {
                if (a == 0)
                {
                    label_suggest.Text = null;
                    Dgv_Details_WIP.DataSource = Data_Detail;
                }
                else if (a == 1)
                {
                    Dgv_Details_WIP.DataSource = Data_Eink;
                    var btnCol = new DataGridViewButtonColumn();
                    btnCol.Name = "Action";                  // Tên nội bộ cột
                    btnCol.HeaderText = "Thao tác";          // Tiêu đề cột hiển thị
                    btnCol.Text = "Xử lý";                    // Text của nút (áp dụng cho tất cả hàng)
                    btnCol.UseColumnTextForButtonValue = true;
                    Dgv_Details_WIP.Columns.Add(btnCol);
                }
            }
            else
            {
                if (a == 0)
                {
                    Dgv_Details_WIP.DataSource = Data_Search_Detail;
                }
                else
                {
                    Dgv_Details_WIP.DataSource = Data_Search_Eink;
                    var btnCol = new DataGridViewButtonColumn();
                    btnCol.Name = "Action";                  // Tên nội bộ cột
                    btnCol.HeaderText = "Thao tác";          // Tiêu đề cột hiển thị
                    btnCol.Text = "Xử lý";                    // Text của nút (áp dụng cho tất cả hàng)
                    btnCol.UseColumnTextForButtonValue = true;
                    Dgv_Details_WIP.Columns.Add(btnCol);
                }
            }
        }
        // Xuất ra file excel
        private void Btn_Excel_Click(object sender, EventArgs e)
        {
            if (Dgv_Details_WIP.DataSource != null)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Excel Files|*.xlsx|All Files|*.*";
                saveFileDialog1.Title = "Chọn nơi lưu file Excel";
                saveFileDialog1.DefaultExt = "xlsx";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                    Excel_Multi_Sheet.ExportToExcel(Data_Overview, Data_Detail, saveFileDialog1.FileName);
                }
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu trong bảng, mời bạn nhấn bên trên");
            }
        }
        private async void Data_Details_WIP_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var col = Dgv_Details_WIP.Columns[e.ColumnIndex];
            if (col == null) return;

            // Xử lý sự kiện làm thẻ Eink
            if (col.Name == "Action")
            {
                var row_tt = Dgv_Details_WIP.Rows[e.RowIndex];

                double GetDouble(string colName)
                {
                    var val = row_tt.Cells[colName].Value?.ToString();
                    return double.TryParse(val, out var v) ? v : 0d;
                }

                var dto = new Product_Eink
                {
                    ItemCode = row_tt.Cells["ItemCode"].Value?.ToString(),
                    LotNo = row_tt.Cells["Lotno"].Value?.ToString(),
                    R_float1 = GetDouble("Tồn"),
                    R_float2 = GetDouble("Allocate"),
                };
                var tt_connect = row_tt.Cells["Connect_Eink"].Value?.ToString();
                //MessageBox.Show(Item_code + " " + Lot_No + " " + Qty + " " + Qty_Allowcate);

                Elink_NVL f_Elink = new Elink_NVL(dto, tt_connect);
                if (f_Elink.ShowDialog() == DialogResult.OK)
                {
                    Data_Details_Load(r, c);
                }
            }
        }
        private void Search()
        {
            string tt_ItemCode = Placeholder.GetRealText(txt_Search_ItemCode).ToString();
            string tt_Lotno = Placeholder.GetRealText(txt_Search_Lotno).ToString();

            try
            {

                if (tt_ItemCode != "" && tt_Lotno != "")
                {
                    Data_Search_Overview = Data_Overview.Where(x => x.MATERIAL_CODE == tt_ItemCode).ToList();
                    bool check_LotNo;
                    if (a == 0)
                    {
                        Data_Search_Detail = Data_Detail.Where(x => x.MATERIAL_CODE == tt_ItemCode && x.Lotno == tt_Lotno).ToList();
                        check_LotNo = Data_Detail.Any(x => x.Lotno == tt_Lotno);
                    }
                    else
                    {
                        Data_Search_Eink = Data_Eink.Where(x => x.MATERIAL_CODE == tt_ItemCode && x.Lotno == tt_Lotno).ToList();
                        check_LotNo = Data_Eink.Any(x => x.Lotno == tt_Lotno);
                    }

                    //Kiểm tra thông tin tìm kiếm có chính xác không
                    if (!Data_Search_Overview.Any() && !check_LotNo)
                    {
                        MessageBox.Show("Cả ItemCode và LotNo đều không chính xác!");
                    }
                    else if (!Data_Search_Overview.Any())
                    {
                        MessageBox.Show("ItemCode không chính xác!");
                    }
                    else if (!check_LotNo)
                    {
                        MessageBox.Show("LotNo không chính xác!");
                    }

                }
                else if (tt_ItemCode != "" && tt_Lotno == "")
                {
                    Data_Search_Overview = Data_Overview.Where(x => x.MATERIAL_CODE == tt_ItemCode).ToList();
                    if (a == 0)
                    {
                        Data_Search_Detail = Data_Detail.Where(x => x.MATERIAL_CODE == tt_ItemCode).ToList();
                    }
                    else
                    {
                        Data_Search_Eink = Data_Eink.Where(x => x.MATERIAL_CODE == tt_ItemCode).ToList();
                    }
                    if (!Data_Search_Overview.Any())
                    {
                        MessageBox.Show("ItemCode không chính xác!");
                    }
                }
                else if (tt_ItemCode == "" && tt_Lotno != "")
                {
                    if (a == 0)
                    {
                        Data_Search_Detail = Data_Detail.Where(x => x.Lotno == tt_Lotno).ToList();
                        var Item_code_return = Data_Detail.Where(x => x.Lotno == tt_Lotno)
                                .Select(x => x.MATERIAL_CODE)
                                .Distinct()
                                .ToList();

                        Data_Search_Overview = (from s in Data_Overview
                                                join code in Item_code_return
                                                    on s.MATERIAL_CODE equals code
                                                select s)
                                    .ToList();
                    }
                    else
                    {
                        Data_Search_Eink = Data_Eink.Where(x => x.Lotno == tt_Lotno).ToList();
                        var Item_code_return = Data_Eink.Where(x => x.Lotno == tt_Lotno)
                                .Select(x => x.MATERIAL_CODE)
                                .Distinct()
                                .ToList();

                        Data_Search_Overview = (from s in Data_Overview
                                                join code in Item_code_return
                                                    on s.MATERIAL_CODE equals code
                                                select s)
                                    .ToList();
                    }

                    if (!Data_Search_Overview.Any())
                    {
                        MessageBox.Show("LotNo không chính xác!");
                    }
                }
                else
                {
                    MessageBox.Show("Mời bạn nhập một trong hai ô để bắt đầu tìm kiếm!");
                    return;
                }


                b = 1; // Chuyển b =1 để biết rằng nó đã chuyển sang trạng thái tìm kiếm
                if (Dgv_Details_WIP.Tag.ToString() == "WIP_Overview")
                {
                    Dgv_Details_WIP.DataSource = Data_Search_Overview;
                }
                else if (Dgv_Details_WIP.Tag.ToString() == "WIP_Detail")
                {
                    if (a == 0)
                    {
                        Dgv_Details_WIP.DataSource = Data_Search_Detail;
                    }
                    else
                    {
                        Dgv_Details_WIP.DataSource = Data_Search_Eink;
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi dữ liệu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Rewatch()
        {
            if (Dgv_Details_WIP.Tag.ToString() == "WIP_Overview")
            {
                Dgv_Details_WIP.DataSource = Data_Overview;
                b = 0;
            }
            else if (Dgv_Details_WIP.Tag.ToString() == "WIP_Detail")
            {
                if (a == 0)
                {
                    Dgv_Details_WIP.DataSource = Data_Detail;
                }
                else
                {
                    Dgv_Details_WIP.DataSource = Data_Eink;
                }

                b = 0;
            }
        }
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (Dgv_Details_WIP.DataSource == null)
            {
                MessageBox.Show("Chưa có dữ liệu trong bảng, mời bạn nhấn bên trên");
            }
            else
            {
                Search();
            }
        }
        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Dgv_Details_WIP.DataSource == null)
                {
                    MessageBox.Show("Chưa có dữ liệu trong bảng, mời bạn nhấn bên trên");
                    return;
                }
                if (Placeholder.GetRealText(txt_Search_ItemCode) == "" && Placeholder.GetRealText(txt_Search_Lotno) == "")
                {
                    e.SuppressKeyPress = true; Rewatch();
                }
                else
                {
                    e.SuppressKeyPress = true; Search();
                }
            }
        }
    }
}
