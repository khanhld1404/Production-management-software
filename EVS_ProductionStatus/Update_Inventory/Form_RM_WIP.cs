
using EVS_ProductionStatus.Class;
using EVS_ProductionStatus.Data;
using EVS_ProductionStatus.Update_Inventory.Class;
using EVS_ProductionStatus.Update_Inventory.Model;
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
namespace EVS_ProductionStatus
{
    public partial class Form_RM_WIP : UserControl
    {
        public Form_RM_WIP()
        {
            InitializeComponent();
        }
        string entityConnString = clConnection.connectString2;
        // Nếu loc là một trong hai giá trị ở dưới thì trả về kết quả là true, còn lại là false
        bool IsTargetLoc(string loc)
        {
            var l = loc?.Trim();
            return l == "04015" || l == "04010";
        }
        // Kiểm tra trạng thái, do trạng thái có thể viết là Passed hoặc PASSED thì ta cần phải cho in hoa hết hoặc in thường hết  để kiểm tra được chính xác
        string NormalizeStatus(string status)
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

        // Danh sách nhóm cho grid RM/WIP
        private readonly List<HeaderGroup> _rmwipGroups = new List<HeaderGroup>
        {
            new HeaderGroup { Text = "Sản xuất", ColumnNames = new [] { "Total_EVS","Pass","Hold" } },
            new HeaderGroup { Text = "Ngoài sản xuất", ColumnNames = new [] { "Total_NSX","UnderQA_NSX ","Pass_NSX","Hold_NSX" } }
        };

        // Vẽ lại "nhãn cột" ở nửa dưới header
        private void Data_Main_RM_WIP_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
        private void Data_Main_RM_WIP_Paint(object sender, PaintEventArgs e)
        {
            var dgv = (DataGridView)sender;
            int topHeight = dgv.ColumnHeadersHeight / 2;

            foreach (var group in _rmwipGroups)
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
        private void Data_Main_RM_WIP_Scroll(object sender, ScrollEventArgs e) => ((DataGridView)sender).Invalidate();


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
        private async Task Set_Eink()
        {
            using (var mb = new Manage_evsEntities(clConnection.connectString2))
            {
                var ListProduct = mb.NewInventory_EVS
                .Where(x => x.loc == "04010" || x.loc == "04015")
                .Select(item => new Product_Eink
                {
                    ItemCode = item.Itemcode,
                    LotNo = item.LotNo,
                    R_float1 = item.Qty,
                    R_float2 = item.Qty_Allocate
                })
                .ToList();
                await PostDataAsync("api/product/Stock/", ListProduct);
            }
        }

        //Load dữ liệu ban đầu
        private void Form_RM_WIP_Load(object sender, EventArgs e)
        {
            Set_Eink();
            Load_Data();
            Placeholder.SetupPlaceholder(txt_Search_ItemCode,"ItemCode");
            Placeholder.SetupPlaceholder(txt_Search_Lotno, "LotNo");
        }
        private void Load_Data()
        {
            txt_Search_ItemCode.AutoSize = false;
            txt_Search_Lotno.AutoSize = false;
            Manage_evsEntities mb = new Manage_evsEntities(entityConnString);

            var summary1 = mb.NewInventory_EVS
                .Where(x => x.part_type == "RM" || x.part_type == "WIP")
                .Select(p => new
                {
                    Qty = p.Qty,                  // giả định decimal?
                    status = p.status,            // string
                    Qty_Allocate = p.Qty_Allocate,
                    loc = p.loc                   // string
                })
                .ToList();

            // Tổng ngoài SX
            var Total_NSX = Math.Round(
                summary1
                    .Where(x => !IsTargetLoc(x.loc))
                    .Select(x => x.Qty.GetValueOrDefault())
                    .Sum(),
                2
            );

            // Under QA ngoài SX
            var UnderQA_NSX = Math.Round(
                summary1
                    .Where(x => !IsTargetLoc(x.loc) && NormalizeStatus(x.status) == "UNDER QA")
                    .Select(x => x.Qty.GetValueOrDefault())
                    .Sum(),
                2
            );

            // Passed ngoài SX
            var Pass_NSX = Math.Round(
                summary1
                    .Where(x => !IsTargetLoc(x.loc) && NormalizeStatus(x.status) == "PASSED")
                    .Select(x => x.Qty.GetValueOrDefault())
                    .Sum(),
                2
            );

            // Hold ngoài SX
            var Hold_NSX = Math.Round(
                summary1
                    .Where(x => !IsTargetLoc(x.loc) && NormalizeStatus(x.status) == "HOLD")
                    .Select(x => x.Qty.GetValueOrDefault())
                    .Sum(),
                2
            );

            // Tổng trong SX (EVS)
            var Total_EVS = Math.Round(
                summary1
                    .Where(x => IsTargetLoc(x.loc))
                    .Where(x =>
                    {
                        var st = NormalizeStatus(x.status);
                        return st == "PASSED" || st == "HOLD";
                    })
                    .Select(x => x.Qty.GetValueOrDefault())
                    .Sum(),
                2
            );

            // Pass trong SX
            var Pass = Math.Round(
                summary1
                    .Where(x => IsTargetLoc(x.loc) && NormalizeStatus(x.status) == "PASSED")
                    .Select(x => x.Qty.GetValueOrDefault())
                    .Sum(),
                2
            );

            // Hold trong SX
            var Hold = Math.Round(
                summary1
                    .Where(x => IsTargetLoc(x.loc) && NormalizeStatus(x.status) == "HOLD")
                    .Select(x => x.Qty.GetValueOrDefault())
                    .Sum(),
                2
            );

            // Tổng chung
            var Total_TVC = Math.Round(summary1.Select(x => x.Qty.GetValueOrDefault()).Sum(), 2);

            var result = new
            {
                Total_TVC,
                Total_EVS,
                Pass,
                Hold,
                Total_NSX,
                UnderQA_NSX,
                Pass_NSX,
                Hold_NSX
            };

            Dgv_Main_RM_WIP.DataSource = new List<object> { result };



            Dgv_Main_RM_WIP.Height = Dgv_Main_RM_WIP.ColumnHeadersHeight +
                                  Dgv_Main_RM_WIP.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + 2;

            // Header 2 tầng: nửa trên cho nhóm, nửa dưới cho nhãn cột
            Dgv_Main_RM_WIP.EnableHeadersVisualStyles = false;
            Dgv_Main_RM_WIP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Dgv_Main_RM_WIP.ColumnHeadersHeight = 52;

            // Căn giữa nhãn cột
            Dgv_Main_RM_WIP.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Gắn event owner-draw
            Dgv_Main_RM_WIP.CellPainting += Data_Main_RM_WIP_CellPainting;
            Dgv_Main_RM_WIP.Paint += Data_Main_RM_WIP_Paint;
            Dgv_Main_RM_WIP.Scroll += Data_Main_RM_WIP_Scroll;

        }

        int a = 0; //Xác định chỗ thêm cột ( từ cột 1 đến 3 là có thêm còn lại ko với a = 1 là thêm, a = 0 là ko thêm)
        int b = 0; //Xác định giá  trị tìm kiếm (b = 0 là bảng ko tìm kiếm, b = 1 là có)
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
            string sum_type = Dgv_Main_RM_WIP.Columns[column].Name;
            var targetLocs = new[] { "04015", "04010" };

            Data_Overview = (from in_e in mb.NewInventory_EVS
                        where (in_e.part_type == "RM" || in_e.part_type == "WIP") &&
                                (
                                (sum_type == "Total_EVS" && targetLocs.Contains(in_e.loc)) ||
                                (sum_type == "Total_TVC") ||
                                (sum_type == "Pass" && in_e.status.ToUpper() == "PASSED" && targetLocs.Contains(in_e.loc)) ||
                                (sum_type == "Hold" && in_e.status.ToUpper() == "HOLD" && targetLocs.Contains(in_e.loc)) ||

                                (sum_type == "Total_NSX" && !targetLocs.Contains(in_e.loc)) ||
                                (sum_type == "UnderQA_NSX" && in_e.status.ToUpper() == "UNDER QA" && !targetLocs.Contains(in_e.loc)) ||
                                (sum_type == "Pass_NSX" && in_e.status.ToUpper() == "PASSED" && !targetLocs.Contains(in_e.loc)) ||
                                (sum_type == "Hold_NSX" && in_e.status.ToUpper() == "HOLD" && !targetLocs.Contains(in_e.loc))
                                )
                        group new { in_e } by in_e.Itemcode into g
                        orderby g.Key
                        select new RM_WIP_Overview
                        {
                            ItemCode = g.Key,
                            Total = Math.Round(g.Sum(x => x.in_e.Qty) ?? 0, 2),
                            Total_Allocate = Math.Round(g.Sum(x => x.in_e.Qty_Allocate) ?? 0, 2),
                            Total_khả_dụng = Math.Round(g.Sum(x => (x.in_e.status != "HOLD") ? ((x.in_e.Qty - x.in_e.Qty_Allocate) ?? 0) : 0), 2)
                        }
                        ).ToList();
            if (column >= 1 && column <= 3)
            {
                Data_Eink = (from in_e in mb.NewInventory_EVS
                                 where (in_e.part_type == "RM" || in_e.part_type == "WIP") &&
                                         (
                                         (sum_type == "Total_EVS" && targetLocs.Contains(in_e.loc)) ||
                                         (sum_type == "Total_TVC") ||
                                         (sum_type == "Pass" && in_e.status.ToUpper() == "PASSED" && targetLocs.Contains(in_e.loc)) ||
                                         (sum_type == "Hold" && in_e.status.ToUpper() == "HOLD" && targetLocs.Contains(in_e.loc)) ||

                                         (sum_type == "Total_NSX" && !targetLocs.Contains(in_e.loc)) ||
                                         (sum_type == "UnderQA_NSX" && in_e.status.ToUpper() == "UNDER QA" && !targetLocs.Contains(in_e.loc)) ||
                                         (sum_type == "Pass_NSX" && in_e.status.ToUpper() == "PASSED" && !targetLocs.Contains(in_e.loc)) ||
                                         (sum_type == "Hold_NSX" && in_e.status.ToUpper() == "HOLD" && !targetLocs.Contains(in_e.loc))
                                         )
                                 orderby in_e.Itemcode
                                 select new RM_WIP_Elink
                                 {
                                     ItemCode = in_e.Itemcode,
                                     Lotno = in_e.LotNo,
                                     Status = in_e.status,
                                     Tồn = in_e.Qty ?? 0,
                                     Allocate = in_e.Qty_Allocate ?? 0,
                                     Khả_dụng = Math.Round((in_e.status != "HOLD") ? ((in_e.Qty - in_e.Qty_Allocate) ?? 0) : 0, 2),
                                     Connect_Eink = in_e.connect_status
                                 }).ToList();
            }
            else
            {
                Data_Detail = (from in_e in mb.NewInventory_EVS
                            where (in_e.part_type == "RM" || in_e.part_type == "WIP") &&
                                    (
                                    (sum_type == "Total_EVS" && targetLocs.Contains(in_e.loc)) ||
                                    (sum_type == "Total_TVC") ||
                                    (sum_type == "Pass" && in_e.status.ToUpper() == "PASSED" && targetLocs.Contains(in_e.loc)) ||
                                    (sum_type == "Hold" && in_e.status.ToUpper() == "HOLD" && targetLocs.Contains(in_e.loc)) ||

                                    (sum_type == "Total_NSX" && !targetLocs.Contains(in_e.loc)) ||
                                    (sum_type == "UnderQA_NSX" && in_e.status.ToUpper() == "UNDER QA" && !targetLocs.Contains(in_e.loc)) ||
                                    (sum_type == "Pass_NSX" && in_e.status.ToUpper() == "PASSED" && !targetLocs.Contains(in_e.loc)) ||
                                    (sum_type == "Hold_NSX" && in_e.status.ToUpper() == "HOLD" && !targetLocs.Contains(in_e.loc))
                                    )
                            orderby in_e.Itemcode
                            select new RM_WIP_Detail
                            {
                                ItemCode = in_e.Itemcode,
                                Lotno = in_e.LotNo,
                                Status = in_e.status,
                                Tồn = in_e.Qty ?? 0,
                                Allocate = in_e.Qty_Allocate ?? 0,
                                Khả_dụng = Math.Round((in_e.status != "HOLD") ? ((in_e.Qty - in_e.Qty_Allocate) ?? 0) : 0, 2)
                            }).ToList();
            }
            if (Dgv_Details_RM_WIP.DataSource == null || Dgv_Details_RM_WIP.Tag.ToString() == "RM_WIP_Overview" || Dgv_Details_RM_WIP.Tag.ToString() == "RM_WIP_Overview_elink")
            {
                Lab_Details_RM_WIP.Text = "Thông tin RM và WIP (Tổng Quan)";
                Dgv_Details_RM_WIP.DataSource = null;
                Dgv_Details_RM_WIP.Columns.Clear();
                Dgv_Details_RM_WIP.Refresh();
                if(b == 0)
                {
                    Dgv_Details_RM_WIP.DataSource = Data_Overview;
                }
                else
                {
                    Search();
                }
                Dgv_Details_RM_WIP.Tag = "RM_WIP_Overview";
                if (column >= 1 && column <= 3)
                {
                    a = 1;
                }
            }
            else if (Dgv_Details_RM_WIP.Tag.ToString() == "RM_WIP_Detail")
            {
                Dgv_Details_RM_WIP.DataSource = null;
                Dgv_Details_RM_WIP.Columns.Clear();
                Dgv_Details_RM_WIP.Refresh();

                if (column >= 1 && column <= 3)
                {
                    if (b == 0)
                    {
                        Dgv_Details_RM_WIP.DataSource = Data_Eink;
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
                    Dgv_Details_RM_WIP.Columns.Add(btnCol);
                    a = 1;
                }
                else
                {
                    label_suggest.Text = null;
                    Dgv_Details_RM_WIP.DataSource = Data_Detail;
                }
            }
        }
        private void Data_Main_RM_WIP_CellClick(object sender, DataGridViewCellEventArgs e)
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
            if (Dgv_Details_RM_WIP.DataSource == null)
            {
                MessageBox.Show("Chưa có dữ liệu. Mời bạn nhấn bên trên");
                return;
            }
            Lab_Details_RM_WIP.Text = "Thông tin RM và WIP (Tổng Quan)";
            label_suggest.Text = "";
            Dgv_Details_RM_WIP.DataSource = null;
            Dgv_Details_RM_WIP.Columns.Clear();
            Dgv_Details_RM_WIP.Refresh();
            if (b != 1)
            {
                Dgv_Details_RM_WIP.DataSource = Data_Overview;
            }
            else
            {
                Dgv_Details_RM_WIP.DataSource = Data_Search_Overview;
            }
            Dgv_Details_RM_WIP.Tag = "RM_WIP_Overview";
        }


        private void Btn_Details_Click(object sender, EventArgs e)
        {
            if (Dgv_Details_RM_WIP.DataSource == null)
            {
                MessageBox.Show("Chưa có dữ liệu. Mời bạn nhấn bên trên");
                return;
            }
            Lab_Details_RM_WIP.Text = "Thông tin RM và WIP (Chi Tiết)";
            label_suggest.Text = @"
            Lưu ý : Khi click vào allocate thì sẽ hiện ra thêm các id
            của lot đó
            ";
            label_suggest.ForeColor = Color.Red;
            label_suggest.Font = new Font("Arial", 10);
            Dgv_Details_RM_WIP.DataSource = null;
            Dgv_Details_RM_WIP.Columns.Clear();
            Dgv_Details_RM_WIP.Refresh();
            Dgv_Details_RM_WIP.Tag = "RM_WIP_Detail";
            if (b != 1)
            {
                if (a == 0)
                {
                    label_suggest.Text = null;
                    Dgv_Details_RM_WIP.DataSource = Data_Detail;
                }else if(a == 1)
                {
                    Dgv_Details_RM_WIP.DataSource = Data_Eink;
                    var btnCol = new DataGridViewButtonColumn();
                    btnCol.Name = "Action";                  // Tên nội bộ cột
                    btnCol.HeaderText = "Thao tác";          // Tiêu đề cột hiển thị
                    btnCol.Text = "Xử lý";                    // Text của nút (áp dụng cho tất cả hàng)
                    btnCol.UseColumnTextForButtonValue = true;
                    Dgv_Details_RM_WIP.Columns.Add(btnCol);
                }
            }
            else
            {
                if(a == 0)
                {
                    Dgv_Details_RM_WIP.DataSource = Data_Search_Detail;
                }
                else
                {
                    Dgv_Details_RM_WIP.DataSource = Data_Search_Eink;
                    var btnCol = new DataGridViewButtonColumn();
                    btnCol.Name = "Action";                  // Tên nội bộ cột
                    btnCol.HeaderText = "Thao tác";          // Tiêu đề cột hiển thị
                    btnCol.Text = "Xử lý";                    // Text của nút (áp dụng cho tất cả hàng)
                    btnCol.UseColumnTextForButtonValue = true;
                    Dgv_Details_RM_WIP.Columns.Add(btnCol);
                }
            }
        }
        // Xuất ra file excel
        private void Btn_Excel_Click(object sender, EventArgs e)
        {
            if (Dgv_Details_RM_WIP.DataSource != null)
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
        private async void Data_Details_RM_WIP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var col = Dgv_Details_RM_WIP.Columns[e.ColumnIndex];
            if (col == null) return;

            // So khớp theo Name để ổn định
            if (col.Name == "Allocate" && a == 1)
            {
                object value = Dgv_Details_RM_WIP.Rows[e.RowIndex].Cells["Lotno"].Value;
                string lot = value.ToString();
                using (var loading = new Form
                {
                    Text = "Đang tải dữ liệu...",
                    StartPosition = FormStartPosition.CenterScreen,
                    ControlBox = false,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    ClientSize = new Size(320, 100),
                    TopMost = true
                })
                {
                    var lbl = new Label
                    {
                        Text = $"Đang tải dữ liệu cho lot: {lot}\nVui lòng chờ…",
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter,

                        Font = new Font("Arial", 10, FontStyle.Regular)
                    };
                    loading.Controls.Add(lbl);
                    loading.Show();       // show modeless để không block await
                    loading.Refresh();

                    DataTable dt = null;

                    try
                    {
                        // Load dữ liệu ở chế độ async (không đơ UI)
                        dt = await LoadAllowByLotAsync(lot);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Có lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    finally
                    {
                        loading.Close();
                    }


                    Form Form_ID_Allocate = new Form
                    {
                        Text = "Thông tin các ID đang được allocate của lot " + lot,
                        BackColor = Color.White,
                        StartPosition = FormStartPosition.CenterParent,
                        ClientSize = new Size(1100, 450)
                    };

                    DataGridView Data_ID_Allocate = new DataGridView
                    {
                        DataSource = dt,
                        RowHeadersVisible = false,
                        BackgroundColor = Color.White,
                        AllowUserToAddRows = false,
                        EnableHeadersVisualStyles = false,
                        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                        Height = 360,
                        ColumnHeadersHeight = 40,
                        Width = Form_ID_Allocate.ClientSize.Width,
                        Location = new Point(0, 0),
                        Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom// tràn ngang, cao cố định
                    };
                    Data_ID_Allocate.ColumnHeadersDefaultCellStyle.BackColor = Color.ForestGreen;
                    Data_ID_Allocate.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    Data_ID_Allocate.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
                    Data_ID_Allocate.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Regular);
                    Data_ID_Allocate.RowTemplate.Height = 30;
                    //Data_ID_Allocate.ColumnHeadersDefaultCellStyle.Padding = new Padding(7, 10, 0, 10);
                    Button Btn_Excel_ID = new Button
                    {
                        Text = "Xuất Excel",
                        Size = new Size(120, 40),
                        ForeColor = Color.White,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        BackColor = Color.Green,
                        Anchor = AnchorStyles.Right | AnchorStyles.Bottom,
                        Location = new Point(900, Data_ID_Allocate.Bottom + 30)
                    };

                    Btn_Excel_ID.Click += (s, a) =>
                    {
                        if (Data_ID_Allocate.DataSource != null)
                        {
                            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                            saveFileDialog1.Filter = "Excel Files|*.xlsx|All Files|*.*";
                            saveFileDialog1.Title = "Chọn nơi lưu file Excel";
                            saveFileDialog1.DefaultExt = "xlsx";

                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                                Excel_Only_Sheet.ExportToExcel(Data_ID_Allocate, saveFileDialog1.FileName);
                                MessageBox.Show("Xuất Excel thành công!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tồn tại dữ liệu để xuất file");
                        }
                    };

                    Form_ID_Allocate.Controls.Add(Data_ID_Allocate);
                    Form_ID_Allocate.Controls.Add(Btn_Excel_ID);

                    Form_ID_Allocate.ShowDialog();
                }
            }
            // Xử lý sự kiện làm thẻ Eink
            if (col.Name == "Action")
            {
                var row_tt = Dgv_Details_RM_WIP.Rows[e.RowIndex];

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

                Elink_NVL f_Elink = new Elink_NVL(dto,tt_connect);
                if(f_Elink.ShowDialog() == DialogResult.OK)
                {
                    Data_Details_Load(r, c);
                }
            }
        }

        //Hiển thị thông tin  các id theo allocate lot
        private async Task<DataTable> LoadAllowByLotAsync(string data_id)
        {
            var dt = new DataTable();
            string query = @"
                SELECT id
                      ,wo
                      ,wo_item
                      ,wo_lot
                      ,wo_component
                      ,qty_req
                      ,qty_iss
                      ,allocate_loc
                      ,allocate_lot
                      ,qty_allocate
                  FROM wo_allow
                  where allocate_lot = @value
                ";
            using (var conn = new SqlConnection(clConnection.connectString))
            using (var cmd = new SqlCommand(query, conn))
            {

                cmd.Parameters.Add("@value", SqlDbType.NVarChar, 100).Value = data_id;

                await conn.OpenAsync();
                using (var reader = await cmd.ExecuteReaderAsync(CommandBehavior.CloseConnection))
                {
                    dt.Load(reader); // Load thẳng từ reader vào DataTable
                }
            }
            return dt;
        }

        //Cập nhật lại dữ liệu
        private async void Btn_Refresh_Click(object sender, EventArgs e)
        {
            picLoading.Invoke(new Action(() => picLoading.Visible = true));
            var Reload_Function = new Reload_Inventory_Infor();
            bool check_connect  = await Reload_Function.CallInventoryApiAsync("http://10.239.2.10:5555/api/inventory");
            picLoading.Invoke(new Action(() => picLoading.Visible = false));
            if (check_connect)
            {
                Load_Data();
                Dgv_Details_RM_WIP.DataSource = null;
                Dgv_Details_RM_WIP.Columns.Clear();
                label_suggest.Text = null;
                Dgv_Details_RM_WIP.Refresh();
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
                    Data_Search_Overview = Data_Overview.Where(x => x.ItemCode == tt_ItemCode).ToList();
                    bool check_LotNo;
                    if (a == 0)
                    {
                        Data_Search_Detail = Data_Detail.Where(x => x.ItemCode == tt_ItemCode && x.Lotno == tt_Lotno).ToList();
                        check_LotNo = Data_Detail.Any(x => x.Lotno == tt_Lotno);
                    }
                    else
                    {
                        Data_Search_Eink = Data_Eink.Where(x => x.ItemCode == tt_ItemCode && x.Lotno == tt_Lotno).ToList();
                        check_LotNo = Data_Eink.Any(x => x.Lotno == tt_Lotno);
                    }

                    //Kiểm tra thông tin tìm kiếm có chính xác không
                    if (!Data_Search_Overview.Any() && !check_LotNo)
                    {
                        MessageBox.Show("Cả ItemCode và LotNo đều không chính xác!");
                    }else if (!Data_Search_Overview.Any())
                    {
                        MessageBox.Show("ItemCode không chính xác!");
                    }else if (!check_LotNo)
                    {
                        MessageBox.Show("LotNo không chính xác!");
                    }

                }
                else if (tt_ItemCode != "" && tt_Lotno == "")
                {
                    Data_Search_Overview = Data_Overview.Where(x => x.ItemCode == tt_ItemCode).ToList();
                    if (a == 0)
                    {
                        Data_Search_Detail = Data_Detail.Where(x => x.ItemCode == tt_ItemCode).ToList();
                    }
                    else
                    {
                        Data_Search_Eink = Data_Eink.Where(x => x.ItemCode == tt_ItemCode).ToList();
                    }
                    if (!Data_Search_Overview.Any())
                    {
                        MessageBox.Show("ItemCode không chính xác!");
                    }
                }
                else if (tt_ItemCode == "" && tt_Lotno != "")
                {
                    if(a == 0)
                    {
                        Data_Search_Detail = Data_Detail.Where(x => x.Lotno == tt_Lotno).ToList();
                        var Item_code_return = Data_Detail.Where(x => x.Lotno == tt_Lotno)
                                .Select(x => x.ItemCode)
                                .Distinct()
                                .ToList();

                        Data_Search_Overview = (from s in Data_Overview
                                    join code in Item_code_return
                                        on s.ItemCode equals code
                                    select s)
                                    .ToList();
                    }
                    else
                    {
                        Data_Search_Eink = Data_Eink.Where(x => x.Lotno == tt_Lotno).ToList();
                        var Item_code_return = Data_Eink.Where(x => x.Lotno == tt_Lotno)
                                .Select(x => x.ItemCode)
                                .Distinct()
                                .ToList();

                        Data_Search_Overview = (from s in Data_Overview
                                    join code in Item_code_return
                                        on s.ItemCode equals code
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
                if (Dgv_Details_RM_WIP.Tag.ToString() == "RM_WIP_Overview")
                {
                    Dgv_Details_RM_WIP.DataSource = Data_Search_Overview;
                }
                else if (Dgv_Details_RM_WIP.Tag.ToString() == "RM_WIP_Detail")
                {
                    if(a == 0)
                    {
                        Dgv_Details_RM_WIP.DataSource = Data_Search_Detail;
                    }
                    else
                    {
                        Dgv_Details_RM_WIP.DataSource = Data_Search_Eink;
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi dữ liệu!");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void Rewatch()
        {
            if (Dgv_Details_RM_WIP.Tag.ToString() == "RM_WIP_Overview")
            {
                Dgv_Details_RM_WIP.DataSource = Data_Overview;
                b = 0;
            }
            else if (Dgv_Details_RM_WIP.Tag.ToString() == "RM_WIP_Detail")
            {
                if(a == 0)
                {
                    Dgv_Details_RM_WIP.DataSource = Data_Detail;
                }
                else
                {
                    Dgv_Details_RM_WIP.DataSource = Data_Eink;
                }
                
                b = 0;
            }
        }
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (Dgv_Details_RM_WIP.DataSource == null)
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
            if(e.KeyCode == Keys.Enter)
            {
                if(Dgv_Details_RM_WIP.DataSource == null)
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
