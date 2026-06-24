
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
    public partial class Form_RM : UserControl
    {
        public Form_RM()
        {
            InitializeComponent();
        }
        // Đường dẫn dữ liệu
        Manage_evsEntities mb = new Manage_evsEntities(clConnection.connectEntity2);

        // Location của từng trạng thái
        List<string> Trong_SX = new List<string> { "3008", "3009", "3010", "3108", "3109", "3110", "9999" };
        List<string> Ngoai_SX = new List<string> { "1001", "1002", "2001", "2002", "4004" };
        List<string> Khong_SX = new List<string> { "5001", "5002", "5003", "5004", "5005" };

        // Dữ liệu gốc trước khi dùng để xử lý
        List<EVS_Management.Data_EVS.EVS_Inventory> Data_Root;
        // Các biến để lưu dữ liệu cho EVS
        double Blocked_EVS, UU_EVS, QI_EVS, Res_EVS, Total_EVS;
        // Các biến để lưu dữ liệu cho ngoài sản xuất
        double Blocked_NSX, UU_NSX, QI_NSX, Res_NSX, Total_NSX;
        // Các biến để lưu dữ liệu cho máy không sử dụng sản xuất
        double Blocked_KSD, UU_KSD, QI_KSD, Res_KSD, Total_KSD;

        // Thông tin trạng thái
        string Blocked_Status = "Blocked", UU_Status = "Unrestricted", QI_Status = "In Qual.Insp", Res_Status = "Restricted-Use";

        // Kiểm tra trạng thái, do trạng thái có thể viết là Passed hoặc PASSED thì ta cần phải cho in hoa hết hoặc in thường hết  để kiểm tra được chính xác
        string NormalizeStatus(string status)
        {
            if (status == null) return null;
            return status.ToUpperInvariant();
        }


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

        // Lấy giá trị tồn kho theo từng trạng thái
        public double Get_Value(List<string> location, string status)
        {
            double kq = mb.EVS_Inventory.AsEnumerable()
                 .Where(x => location.Contains(x.Storage_Location) && x.Stock_Type == status && x.MRP_Controller == "R06")
                 .Sum(x => Double.Parse(x.Inventory_Qty));
            return Math.Round(kq,1);
        }
        // Lấy giá trị tổng tồn kho
        public double Get_Total(List<string> location)
        {
            double kq = mb.EVS_Inventory.AsEnumerable()
                 .Where(x => location.Contains(x.Storage_Location) && x.MRP_Controller == "R06")
                 .Sum(x => Double.Parse(x.Inventory_Qty));
            return Math.Round(kq,1);
        }

        // Thiết lập dữ liệu cho bảng tổng quan
        private void Load_Data()
        {
            // Thiết lập location 
            location_box.Items.Add("All Location");
            location_box.SelectedIndex = 0;
            // Thiết lập comment cho ô tìm kiếm
            Placeholder.SetupPlaceholder(txt_Search_ItemCode, "Material Code");
            Placeholder.SetupPlaceholder(txt_Search_Lotno, "Batch Number");


            txt_Search_ItemCode.AutoSize = false;
            txt_Search_Lotno.AutoSize = false;

            // Tính toán những con ở trong EVS

            Blocked_EVS = Get_Value(Trong_SX, Blocked_Status);
            UU_EVS = Get_Value(Trong_SX, UU_Status);
            QI_EVS = Get_Value(Trong_SX, QI_Status);
            Res_EVS = Get_Value(Trong_SX, Res_Status);
            Total_EVS = Get_Total(Trong_SX);

            //Tính toán những con ở ngoài sản xuất
            Blocked_NSX = Get_Value(Ngoai_SX, Blocked_Status);
            UU_NSX = Get_Value(Ngoai_SX, UU_Status);
            QI_NSX = Get_Value(Ngoai_SX, QI_Status);
            Res_NSX = Get_Value(Ngoai_SX, Res_Status);
            Total_NSX = Get_Total(Ngoai_SX);

            //Tính toán những con máy không sử dụng sản xuất
            Blocked_KSD = Get_Value(Khong_SX, Blocked_Status);
            UU_KSD = Get_Value(Khong_SX, UU_Status);
            QI_KSD = Get_Value(Khong_SX, QI_Status);
            Res_KSD = Get_Value(Khong_SX, Res_Status);
            Total_KSD = Get_Total(Khong_SX);

            // Thêm giá trị vào form
            Dgv_Main_RM.Rows.Add("Trong EVS", Blocked_EVS, UU_EVS, QI_EVS, Res_EVS, Total_EVS);
            Dgv_Main_RM.Rows.Add("Ngoài sản xuất", Blocked_NSX, UU_NSX, QI_NSX, Res_NSX, Total_NSX);
            Dgv_Main_RM.Rows.Add("Không sản xuất", Blocked_KSD, UU_KSD, QI_KSD, Res_KSD, Total_KSD);

            // Tính chiều cao dựa trên số dòng + header (Giúp cho bảng hiện thị không bị thừa và cũng không bị thiếu)
            Dgv_Main_RM.Height = Dgv_Main_RM.ColumnHeadersHeight +
                                   Dgv_Main_RM.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + 2;
        }

        //Load dữ liệu ban đầu
        private void Form_RM_Load(object sender, EventArgs e)
        {
            //Set_Eink();
            Load_Data();
        }

        bool check_add_eink = false; //Xác định chỗ thêm cột ( từ cột 1 đến 3 là có thêm còn lại ko với a = 1 là thêm, a = 0 là ko thêm)
        bool check_search = false; //Xác định giá  trị tìm kiếm (b = 0 là bảng ko tìm kiếm, b = 1 là có do ở đây có 2 loại bảng là tổng quan với chi tiết)
        string Column_name = ""; //Xác định tên cột được bấm
        string CellKick_Value = ""; //Xác định giá trị được bấm (Ở đây chủ yếu được dùng để lấy giá trị cột trạng thái được bấm)

        //Danh sách dữ liệu 
        private List<RM_WIP_Overview> Data_Overview;
        private List<RM_WIP_Detail> Data_Detail;
        private List<RM_WIP_Elink> Data_Eink;


        private List<RM_WIP_Overview> Data_Search_Overview;
        private List<RM_WIP_Detail> Data_Search_Detail;
        private List<RM_WIP_Elink> Data_Search_Eink;
        private void Data_Details_Load(List<string> list, string status)
        {
            // Xóa toàn bộ lựa chọn cũ ở combobox
            location_box.Items.Clear();
            location_box.Items.Add("All Location");

            // Thêm lựa chọn vào combobox
            foreach (string item in list)
            {
                location_box.Items.Add(item);
            }

            // Dữ liệu gốc đầu vào
            if (status != "Total")
            {
                Data_Root = mb.EVS_Inventory
                .Where(x => x.Stock_Type == status && x.MRP_Controller == "R06" && list.Contains(x.Storage_Location))
                .ToList();
            }
            else
            {
                Data_Root = mb.EVS_Inventory
                            .Where(x => x.MRP_Controller == "R06" && list.Contains(x.Storage_Location))
                            .ToList();
            }

            //Data_Overview = (from in_e in mb.EVS_Stock
            //            where (in_e.MATERIAL_TYPE == "ZROH") &&
            //                    (
            //                    (sum_type == "Total_EVS" && targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
            //                    (sum_type == "Total_TVC") ||
            //                    (sum_type == "Blocked" && in_e.STOCK_TYPE.ToUpper() == "BLOCKED" && targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
            //                    (sum_type == "UU" && in_e.STOCK_TYPE.ToUpper() == "UU" && targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
            //                    (sum_type == "QI" && in_e.STOCK_TYPE.ToUpper() == "QI" && targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
            //                    (sum_type == "Restricted" && in_e.STOCK_TYPE.ToUpper() == "RESTRICTED" && targetLocs.Contains(in_e.STORAGE_LOCATION)) ||

            //                    (sum_type == "Total_NSX" && !targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
            //                    (sum_type == "Blocked_NSX" && in_e.STOCK_TYPE.ToUpper() == "BLOCKED" && !targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
            //                    (sum_type == "UU_NSX" && in_e.STOCK_TYPE.ToUpper() == "UU" && !targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
            //                    (sum_type == "QI_NSX" && in_e.STOCK_TYPE.ToUpper() == "QI" && !targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
            //                    (sum_type == "Restricted_NSX" && in_e.STOCK_TYPE.ToUpper() == "RESTRICTED" && !targetLocs.Contains(in_e.STORAGE_LOCATION)) 
            //                    )
            //            group in_e by in_e.MATERIAL_CODE into g
            //            orderby g.Key
            //            select new RM_WIP_Overview
            //            {
            //                MATERIAL_CODE = g.Key,
            //                Total = Math.Round(g.Sum(x => x.STOCK_QUANTITY) ?? 0m, 2),
            //                Blocked = Math.Round(g.Sum(x => x.STOCK_TYPE.ToUpper() == "BLOCKED" ? x.STOCK_QUANTITY : 0m) ?? 0m),
            //                UU = Math.Round(g.Sum(x => x.STOCK_TYPE.ToUpper() == "UU" ? x.STOCK_QUANTITY : 0m) ?? 0m),
            //                QI = Math.Round(g.Sum(x => x.STOCK_TYPE.ToUpper() == "QI" ? x.STOCK_QUANTITY : 0m) ?? 0m),
            //                Restricted = Math.Round(g.Sum(x => x.STOCK_TYPE.ToUpper() == "RESTRICTED" ? x.STOCK_QUANTITY : 0m) ?? 0m)
            //            }
            //            ).ToList();
            //if (column >= 1 && column <= 5)
            //{
            //    Data_Eink = (from in_e in mb.EVS_Stock
            //                     where (in_e.MATERIAL_TYPE == "ZROH") &&
            //                             (
            //                            (sum_type == "Total_EVS" && targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
            //                            (sum_type == "Blocked" && in_e.STOCK_TYPE.ToUpper() == "BLOCKED" && targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
            //                            (sum_type == "UU" && in_e.STOCK_TYPE.ToUpper() == "UU" && targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
            //                            (sum_type == "QI" && in_e.STOCK_TYPE.ToUpper() == "QI" && targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
            //                            (sum_type == "Restricted" && in_e.STOCK_TYPE.ToUpper() == "RESTRICTED" && targetLocs.Contains(in_e.STORAGE_LOCATION)) 
            //                             )
            //                     group in_e by new {in_e.MATERIAL_CODE,in_e.BATCH_NUMBER,in_e.STOCK_TYPE,in_e.CONNECT_STATUS} into g
            //                     orderby g.Key.MATERIAL_CODE
            //                     select new RM_WIP_Elink
            //                     {
            //                         MATERIAL_CODE = g.Key.MATERIAL_CODE,
            //                         Lotno = g.Key.BATCH_NUMBER,
            //                         Status = g.Key.STOCK_TYPE,
            //                         Total = Math.Round(g.Sum(x => x.STOCK_QUANTITY) ?? 0m, 2),
            //                         Blocked = Math.Round(g.Sum(x => x.STOCK_TYPE.ToUpper() == "BLOCKED" ? x.STOCK_QUANTITY : 0m) ?? 0m),
            //                         UU = Math.Round(g.Sum(x => x.STOCK_TYPE.ToUpper() == "UU" ? x.STOCK_QUANTITY : 0m) ?? 0m),
            //                         QI = Math.Round(g.Sum(x => x.STOCK_TYPE.ToUpper() == "QI" ? x.STOCK_QUANTITY : 0m) ?? 0m),
            //                         Restricted = Math.Round(g.Sum(x => x.STOCK_TYPE.ToUpper() == "RESTRICTED" ? x.STOCK_QUANTITY : 0m) ?? 0m),
            //                         Eink = g.Key.CONNECT_STATUS
            //                     }).ToList();
            //}
            //else 
            //{
            //    Data_Detail = (from in_e in mb.EVS_Stock
            //                where (in_e.MATERIAL_TYPE == "ZROH") &&
            //                        (
            //                        (sum_type == "Total_TVC") ||
            //                        (sum_type == "Total_NSX" && !targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
            //                        (sum_type == "Blocked_NSX" && in_e.STOCK_TYPE.ToUpper() == "BLOCKED" && !targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
            //                        (sum_type == "UU_NSX" && in_e.STOCK_TYPE.ToUpper() == "UU" && !targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
            //                        (sum_type == "QI_NSX" && in_e.STOCK_TYPE.ToUpper() == "QI" && !targetLocs.Contains(in_e.STORAGE_LOCATION)) ||
            //                        (sum_type == "Restricted_NSX" && in_e.STOCK_TYPE.ToUpper() == "RESTRICTED" && !targetLocs.Contains(in_e.STORAGE_LOCATION))
            //                        )
            //                group in_e by new { in_e.MATERIAL_CODE, in_e.BATCH_NUMBER, in_e.STOCK_TYPE} into g
            //                orderby g.Key.MATERIAL_CODE
            //                select new RM_WIP_Detail
            //                {
            //                    MATERIAL_CODE = g.Key.MATERIAL_CODE,
            //                    Lotno = g.Key.BATCH_NUMBER,
            //                    Status = g.Key.STOCK_TYPE,
            //                    Total = Math.Round(g.Sum(x => x.STOCK_QUANTITY) ?? 0m, 2),
            //                    Total_Blocked = Math.Round(g.Sum(x => x.STOCK_TYPE.ToUpper() == "BLOCKED" ? x.STOCK_QUANTITY : 0m) ?? 0m),
            //                    Total_UU = Math.Round(g.Sum(x => x.STOCK_TYPE.ToUpper() == "UU" ? x.STOCK_QUANTITY : 0m) ?? 0m),
            //                    Total_QI = Math.Round(g.Sum(x => x.STOCK_TYPE.ToUpper() == "QI" ? x.STOCK_QUANTITY : 0m) ?? 0m),
            //                    Total_Restricted = Math.Round(g.Sum(x => x.STOCK_TYPE.ToUpper() == "RESTRICTED" ? x.STOCK_QUANTITY : 0m) ?? 0m)
            //                }).ToList();
            //}
            if (Dgv_Details_RM.DataSource == null || Dgv_Details_RM.Tag.ToString() == "RM_Overview" || Dgv_Details_RM.Tag.ToString() == "RM_Overview_elink")
            {
                Lab_Details_RM.Text = "Thông tin RM (Tổng Quan)";
                Dgv_Details_RM.DataSource = null;
                Dgv_Details_RM.Columns.Clear();
                Dgv_Details_RM.Refresh();
                if(!check_search)
                {
                    Dgv_Details_RM.DataSource = Data_Overview;
                }
                else
                {
                    Search();
                }
                Dgv_Details_RM.Tag = "RM_Overview";
                if (CellKick_Value == "Trong EVS")
                {
                    check_add_eink = true;
                }
            }
            else if (Dgv_Details_RM.Tag.ToString() == "RM_Detail")
            {
                Dgv_Details_RM.DataSource = null;
                Dgv_Details_RM.Columns.Clear();
                Dgv_Details_RM.Refresh();

                if (CellKick_Value == "Trong EVS")
                {
                    if (!check_search)
                    {
                        Dgv_Details_RM.DataSource = Data_Eink;
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
                    Dgv_Details_RM.Columns.Add(btnCol);
                    check_add_eink = true;
                }
                else
                {
                    label_suggest.Text = null;
                    Dgv_Details_RM.DataSource = Data_Detail;
                }
            }
        }
        private void Data_Main_RM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                // Lấy thông tin tên cột và hàng được chọn 
                CellKick_Value = Dgv_Main_RM.Rows[e.RowIndex].Cells["TT"].Value.ToString();
                Column_name = Dgv_Main_RM.Columns[e.ColumnIndex].Name;

                // Chỉnh lại thông tin status đối với từng cột trạng thái được bấm
                if (Column_name == "QI")
                {
                    Column_name = "In Qual.Insp";
                }
                if (Column_name == "Restricted")
                {
                    Column_name = "Restricted-Use";
                }

                check_add_eink = false; check_search = false;

                // Lọc dữ liệu theo trạng thái và tình trạng
                if (CellKick_Value == "Trong EVS")
                {
                    Data_Details_Load(Trong_SX, Column_name);
                }
                else if (CellKick_Value == "Ngoài sản xuất")
                {
                    Data_Details_Load(Ngoai_SX, Column_name);
                }
                else
                {
                    Data_Details_Load(Khong_SX, Column_name);
                }

            }
        }

        private void Btn_Total_Click(object sender, EventArgs e)
        {
            if (Dgv_Details_RM.DataSource == null)
            {
                MessageBox.Show("Chưa có dữ liệu. Mời bạn nhấn bên trên");
                return;
            }
            Lab_Details_RM.Text = "Thông tin RM (Tổng Quan)";
            label_suggest.Text = "";
            Dgv_Details_RM.DataSource = null;
            Dgv_Details_RM.Columns.Clear();
            Dgv_Details_RM.Refresh();
            if (!check_search)
            {
                Dgv_Details_RM.DataSource = Data_Overview;
            }
            else
            {
                Dgv_Details_RM.DataSource = Data_Search_Overview;
            }
            Dgv_Details_RM.Tag = "RM_Overview";
        }


        private void Btn_Details_Click(object sender, EventArgs e)
        {
            if (Dgv_Details_RM.DataSource == null)
            {
                MessageBox.Show("Chưa có dữ liệu. Mời bạn nhấn bên trên");
                return;
            }
            Lab_Details_RM.Text = "Thông tin RM (Chi Tiết)";
            label_suggest.Text = @"
            Lưu ý : Khi click vào allocate thì sẽ hiện ra thêm các id
            của lot đó
            ";
            label_suggest.ForeColor = Color.Red;
            label_suggest.Font = new Font("Arial", 10);
            Dgv_Details_RM.DataSource = null;
            Dgv_Details_RM.Columns.Clear();
            Dgv_Details_RM.Refresh();
            Dgv_Details_RM.Tag = "RM_Detail";
            if (!check_search)
            {
                if (!check_add_eink)
                {
                    label_suggest.Text = null;
                    Dgv_Details_RM.DataSource = Data_Detail;
                }else
                {
                    Dgv_Details_RM.DataSource = Data_Eink;
                    var btnCol = new DataGridViewButtonColumn();
                    btnCol.Name = "Action";                  // Tên nội bộ cột
                    btnCol.HeaderText = "Thao tác";          // Tiêu đề cột hiển thị
                    btnCol.Text = "Xử lý";                    // Text của nút (áp dụng cho tất cả hàng)
                    btnCol.UseColumnTextForButtonValue = true;
                    Dgv_Details_RM.Columns.Add(btnCol);
                }
            }
            else
            {
                if(!check_add_eink)
                {
                    Dgv_Details_RM.DataSource = Data_Search_Detail;
                }
                else
                {
                    Dgv_Details_RM.DataSource = Data_Search_Eink;
                    var btnCol = new DataGridViewButtonColumn();
                    btnCol.Name = "Action";                  // Tên nội bộ cột
                    btnCol.HeaderText = "Thao tác";          // Tiêu đề cột hiển thị
                    btnCol.Text = "Xử lý";                    // Text của nút (áp dụng cho tất cả hàng)
                    btnCol.UseColumnTextForButtonValue = true;
                    Dgv_Details_RM.Columns.Add(btnCol);
                }
            }
        }
        // Xuất ra file excel
        private void Btn_Excel_Click(object sender, EventArgs e)
        {
            if (Dgv_Details_RM.DataSource != null)
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
        private async void Data_Details_RM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var col = Dgv_Details_RM.Columns[e.ColumnIndex];
            if (col == null) return;

            // Xử lý sự kiện làm thẻ Eink
            if (col.Name == "Action")
            {
                var row_tt = Dgv_Details_RM.Rows[e.RowIndex];

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
                    //Data_Details_Load(r, c);
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
                    if (!check_add_eink)
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
                    Data_Search_Overview = Data_Overview.Where(x => x.MATERIAL_CODE == tt_ItemCode).ToList();
                    if (!check_add_eink)
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
                    if(!check_add_eink)
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
                

                check_search = true; // Chuyển b =1 để biết rằng nó đã chuyển sang trạng thái tìm kiếm
                if (Dgv_Details_RM.Tag.ToString() == "RM_Overview")
                {
                    Dgv_Details_RM.DataSource = Data_Search_Overview;
                }
                else if (Dgv_Details_RM.Tag.ToString() == "RM_Detail")
                {
                    if(!check_add_eink)
                    {
                        Dgv_Details_RM.DataSource = Data_Search_Detail;
                    }
                    else
                    {
                        Dgv_Details_RM.DataSource = Data_Search_Eink;
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
            if (Dgv_Details_RM.Tag.ToString() == "RM_Overview")
            {
                Dgv_Details_RM.DataSource = Data_Overview;
                check_search = false;
            }
            else if (Dgv_Details_RM.Tag.ToString() == "RM_Detail")
            {
                if(!check_add_eink)
                {
                    Dgv_Details_RM.DataSource = Data_Detail;
                }
                else
                {
                    Dgv_Details_RM.DataSource = Data_Eink;
                }
                
                check_search = false;
            }
        }
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (Dgv_Details_RM.DataSource == null)
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
                if(Dgv_Details_RM.DataSource == null)
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
