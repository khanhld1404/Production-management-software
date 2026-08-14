using EVS_ProductionStatus.Class;
using EVS_ProductionStatus.Data_EVS;
using EVS_ProductionStatus.EVS_Inventories.Class;
using EVS_ProductionStatus.EVS_Inventories.Model;
using EVS_ProductionStatus.EVS_Inventories.Model.EVS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace EVS_ProductionStatus.EVS_Inventories
{
    public partial class EVS_Alowcate : Form
    {

        // Lấy danh sách các location sử dụng để tính toán  
        List<string> Trong_SX = new List<string> { "3008", "3009", "3010", "3108", "3109", "3110", "9999" };

        // Dữ liệu gốc dùng để tính toán dữ liệu
        List<EVS_Inventory> data_root;
        // Dữ liệu load được
        List<Model.EVS.EVS_Inventory_Alowcate> data_load;

        // Dữ liệu tìm kiếm được
        List<Model.EVS.EVS_Inventory_Alowcate> data_search;

        //Thông tin để xác định HFG,RM và WIP
        List<string> status_list;

        public EVS_Alowcate(List<string> _status_list)
        {
            InitializeComponent();
            Lab_Infor_Total.Text = "Thông Tin Tồn Alowcate Trong Sản Xuất (EVS)";
            status_list = _status_list;
        }

        // Xây dựng đường dẫn truyền dữ liệu để cập nhật thông tin lưu trữ trên thẻ eink kịp thời

        // Xây dựng và  gọi api để load và  cập nhật dữ liệu lên thẻ eink
        //Đường dẫn
        private static readonly HttpClient http = new HttpClient
        {
            //Địa chỉ dùng để cho local
            //https://localhost:7188/
            // Địa chỉ dùng cho việc kết nối mạng
            //http://172.31.9.31/test_api/

            BaseAddress = new Uri("http://172.31.9.31/test_api/"),
            Timeout = TimeSpan.FromSeconds(100)
        };

        // Gọi API để cập nhật dữ liệu trong bảng product
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
        private async Task Set_Eink(List<Model.EVS.EVS_Inventory_Alowcate> data)
        {
            // Kiểm tra xem có con nào có nhiều trạng thái. Nếu có một trạng thái là connect thì cho tất cả giá trị là connect

            using (Manage_evsEntities db = new Manage_evsEntities(clConnection.connectEntity2))
            {
                var groups = db.EVS_Inventory
                    .GroupBy(x => new
                    {
                        x.Material_Number,
                        Batch = x.Batch_Number,
                        x.Storage_Location
                    })
                    .ToList();

                foreach (var group in groups)
                {
                    // Có ít nhất 1 record là Connect
                    bool hasConnect = group.Any(x => x.Connect_Status == "Connect");

                    if (hasConnect)
                    {
                        foreach (var item in group)
                        {
                            item.Connect_Status = "Connect";
                        }
                    }
                }
                db.SaveChanges();
            }


            var ListProduct = data
                .Select(item => new Product_Eink
                {
                    ItemCode = item.Item,
                    LotNo = item.Lot,
                    Location = item.Location,
                    R_float1 = item.Total,
                    R_float2 = item.Alowcate,
                    R_float3 = item.KD
                })
                .ToList();
            await PostDataAsync("api/product/Stock/", ListProduct);
        }

        // Lấy số lượng tồn alowcate (Chỉ tính trạng thái UU)
        public double Get_Alowcate(List<MB25> data, string material,string batch,string location)
        {
            var result = data
                        .Where(x => x.Material == material && x.Batch == batch && x.Location == location)
                        .Select(x => (double?)x.Total)
                        .FirstOrDefault() ?? 0;

            return result;
        }

        // Thực hiện tạo một hàm loading để xử lý dữ liệu ở trong bảng
        private Form loading_data;
        // Thực hiện tạo một hàm loading để tính toán số lượng có trong bảng
        private Form loading_quantity;

        private void Data_Load()
        {
            // Thêm màn load khi tính toán và xử lý dữ liệu

            // Tạo một loading
            loading_data = new Form
            {
                Text = "Xử lý dữ liệu...",
                StartPosition = FormStartPosition.CenterScreen,
                ControlBox = false,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                ClientSize = new Size(320, 100),
                TopMost = true
            };
            var lbl = new Label
            {
                Text = $"Đang xử lý dữ liệu\nVui lòng chờ…",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,

                Font = new Font("Arial", 10, FontStyle.Regular)
            };
            loading_data.Controls.Add(lbl);
            loading_data.Show();
            loading_data.Refresh();

            try
            {
                // Tính toán và lọc dữ liệu
                EVS_BackGround.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi xử lý dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }  
        private void EVS_Alowcate_Load(object sender, EventArgs e)
        {
              // Thiết lập location 
            location_box.Items.Add("All Location");
            // Thêm lựa chọn vào combobox location
            foreach (string item in Trong_SX)
            {
                location_box.Items.Add(item);
            }
            location_box.SelectedIndex = 0;
            // Thiết lập comment cho ô tìm kiếm
            Placeholder.SetupPlaceholder(txt_Search_Material, "Item");
            Placeholder.SetupPlaceholder(txt_Batch_Number, "Lot");
            Placeholder.SetupPlaceholder(txt_search_mac_eink, "Mac Eink");

            // Thêm một cột action vào 
            var btnCol = new DataGridViewButtonColumn();
            btnCol.Name = "Action";                  // Tên nội bộ cột
            btnCol.HeaderText = "Thao tác";          // Tiêu đề cột hiển thị                  
            btnCol.UseColumnTextForButtonValue = false;
            EVS_Alowcate_Data.Columns.Add(btnCol);

            Data_Load();
        }

        // Lọc dựa trên mã lot, mã item 
        private void Search_1(List<Model.EVS.EVS_Inventory_Alowcate> data, string tt_Material_Code,string tt_Batch_Number)
        {
            if (tt_Material_Code != "" && tt_Batch_Number != "")
            {
                //Kiểm tra thông tin tìm kiếm có chính xác không
                bool check_tk = data.Any(x => x.Item == tt_Material_Code && x.Lot == tt_Batch_Number);
                if (check_tk)
                {
                    data_search = data.Where(x => x.Item == tt_Material_Code && x.Lot == tt_Batch_Number).ToList();
                }
                else
                {
                    MessageBox.Show("Thông tin tìm kiếm không chính xác");
                    return;
                }

            }
            else if (tt_Material_Code != "" && tt_Batch_Number == "")
            {
                //Kiểm tra thông tin tìm kiếm có chính xác không
                bool check_tk = data.Any(x => x.Item == tt_Material_Code);
                if (check_tk)
                {
                    data_search = data.Where(x => x.Item == tt_Material_Code ).ToList();
                }
                else
                {
                    MessageBox.Show("Thông tin tìm kiếm không chính xác");
                    return;
                }
            }
            else if (tt_Material_Code == "" && tt_Batch_Number != "")
            {
                //Kiểm tra thông tin tìm kiếm có chính xác không
                bool check_tk = data.Any(x =>  x.Lot == tt_Batch_Number);
                if (check_tk)
                {
                    data_search = data.Where(x => x.Lot == tt_Batch_Number).ToList();
                }
                else
                {
                    MessageBox.Show("Thông tin tìm kiếm không chính xác");
                    return ;
                }
            }
            else
            {
                data_search = data;
            }
            EVS_Alowcate_Data.Rows.Clear();
            foreach (var tt in data_search)
            {
                int row_index = EVS_Alowcate_Data.Rows.Add(tt.Location, tt.Item,tt.ItemNCC, tt.Lot, tt.Total, tt.UU, tt.Restricted, tt.Blocked, tt.Alowcate, tt.KD);
                if (tt.Connect == "Connect")
                {
                    EVS_Alowcate_Data.Rows[row_index].DefaultCellStyle.BackColor = Color.LightGreen;
                    EVS_Alowcate_Data.Rows[row_index].Cells["Action"].Value = "Đã Kết Nối";
                }
                else
                {
                    EVS_Alowcate_Data.Rows[row_index].Cells["Action"].Value = "Kết Nối Eink";
                }
            }
        }

        // Lọc dựa trên mã mac của thẻ Eink và location
        private void Search_2()
        {
            //Lấy thông tin trong ô tìm kiếm
            string tt_Material_Code = Placeholder.GetRealText(txt_Search_Material);
            string tt_Batch_Number = Placeholder.GetRealText(txt_Batch_Number);
            string mac = Placeholder.GetRealText(txt_search_mac_eink);
            string location = location_box.Text.Trim();
            try
            {
                List<EVS_Inventory_Alowcate> Data_Search_Location = new List<EVS_Inventory_Alowcate> { };

                if (mac == "")
                {
                    if (location == "" || location == "All Location")
                    {
                        Data_Search_Location = data_load;
                    }
                    else
                    {
                        Data_Search_Location = data_load
                                            .Where(x => x.Location == location)
                                            .ToList();
                    }
                }
                else
                {
                    if (location == "" || location == "All Location")
                    {
                        Data_Search_Location = data_load.Where(x => x.Eink_Mac == mac).ToList();
                    }
                    else
                    {
                        Data_Search_Location = data_load
                                            .Where(x => x.Location == location && x.Eink_Mac == mac)
                                            .ToList();
                    }
                }
                Search_1(Data_Search_Location, tt_Material_Code, tt_Batch_Number);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            Search_2();
        }

        private void Btn_Excel_Click(object sender, EventArgs e)
        {
            Excel_Only_Sheet.ExportToExcel(EVS_Alowcate_Data);
        }

        private void EVS_Alowcate_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // Lấy giá  trị status dựa vào các giá trị trên
            using (Manage_evsEntities db = new Manage_evsEntities(clConnection.connectEntity2))
            {


                var col = EVS_Alowcate_Data.Columns[e.ColumnIndex];
                if (col == null) return;

                // Xử lý sự kiện làm thẻ Eink
                if (col.Name == "Action")
                {
                    var row_tt = EVS_Alowcate_Data.Rows[e.RowIndex];

                    double GetDouble(string colName)
                    {
                        var val = row_tt.Cells[colName].Value?.ToString();
                        return double.TryParse(val, out var v) ? v : 0d;
                    }
                    // Tính toán giá trị để nhập vào
                    string item_value = row_tt.Cells["Item"].Value?.ToString();
                    string lot_value = row_tt.Cells["Lot"].Value?.ToString();
                    string location_value = row_tt.Cells["Location"].Value?.ToString();
                    string stocktype = db.EVS_Inventory
                                       .Where(x => x.Material_Number == item_value && x.Batch_Number == lot_value && x.Storage_Location == location_value)
                                       .Select(x => x.Stock_Type)
                                       .FirstOrDefault();
                    var dto = new Product_Eink
                    {
                        ItemCode = item_value,
                        LotNo = lot_value,
                        Location = location_value,
                        R_float1 = GetDouble("Ton"),
                        R_float2 = GetDouble("Alowcate"),
                        R_float3 = GetDouble("KD")
                    };
                    // Lấy thông tin kiểm tra xem sản phẩm đã được connect đến thẻ eink chưa
                    string tt_connect = data_load
                                     .Where(x => x.Item == item_value && x.Lot == lot_value && x.Location == location_value)
                                     .Select(x => x.Connect).FirstOrDefault();

                    //MessageBox.Show(Item_code + " " + Lot_No + " " + Qty + " " + Qty_Allowcate);

                    Eink_NVL f_Elink = new Eink_NVL(dto, tt_connect);
                    if (f_Elink.ShowDialog() == DialogResult.OK)
                    {
                        EVS_BackGround.RunWorkerAsync();
                    }
                }
            }
        }

        private void EVS_BackGround_DoWork(object sender, DoWorkEventArgs e)
        {
            using (Manage_evsEntities mb = new Manage_evsEntities(clConnection.connectEntity2))
            {
                // Nhiều con sau khi kết nối có sinh ra thêm những con khác cùng lot,item (do sản phảm có thể bị chặn hoặc chuyển vào kho)
                // Ta cần đối với những con có connect kiểm ra xem có con nào chưa kết nối mà trùng location,item, lot  ko
                // Thì cho nó kết nối



                // data dùng để tính allowcate
                var MB25_Data = mb.MB25.ToList();
                // Chỉ tính alowcate của RM và WIP
                data_root = mb.EVS_Inventory
                           .Where(x => Trong_SX.Contains(x.Storage_Location)  && status_list.Contains(x.MRP_Controller))
                           .ToList();

                data_load = data_root
                           .GroupBy(x => new
                           {
                               Location = x.Storage_Location,
                               MATERIAL_NUMBER = x.Material_Number,
                               RegistedMaterial = x.Registered__Material,
                               BATCH_NUMBER = x.Batch_Number,
                               Connect = x.Connect_Status,
                               Mac = x.Eink_Mac
                               //Status = x.Stock_Type
                           })
                           .Select(g => 
                           {
                               var uu = Math.Round(
                                g.Sum(x => x.Stock_Type == "Unrestricted"
                                 ? (double.TryParse(x.Inventory_Qty, out double v) ? v : 0)
                                 : 0), 2);
                               var alowcate = Get_Alowcate(MB25_Data, g.Key.MATERIAL_NUMBER, g.Key.BATCH_NUMBER, g.Key.Location);
                               return new EVS_Inventory_Alowcate
                               {
                                   Location = g.Key.Location,

                                   Item = g.Key.MATERIAL_NUMBER,

                                   ItemNCC = g.Key.RegistedMaterial,

                                   Lot = g.Key.BATCH_NUMBER,

                                   UU = uu,

                                   Restricted = Math.Round(
                                        g.Sum(x => x.Stock_Type == "Restricted-Use"
                                            ? (double.TryParse(x.Inventory_Qty, out double v) ? v : 0)
                                            : 0), 2),

                                   Blocked = Math.Round(
                                        g.Sum(x => x.Stock_Type == "Blocked"
                                            ? (double.TryParse(x.Inventory_Qty, out double v) ? v : 0)
                                            : 0), 2),

                                   Total = Math.Round(
                                        g.Sum(x => double.TryParse(x.Inventory_Qty, out double v) ? v : 0)
                                            , 2),

                                   Alowcate = alowcate,

                                   KD = Math.Round(uu - alowcate,2),

                                   Connect = g.Key.Connect,
                                   Eink_Mac = g.Key.Mac
                                   //StockType = g.Key.Status
                               };
                           })
                           .OrderBy(x => x.Connect)
                           .ToList();
                // Truyền dữ liệu cập nhật lên
                Set_Eink(data_load);
            }
        }

        private void EVS_BackGround_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            EVS_Alowcate_Data.Rows.Clear();
            foreach (var tt in data_load)
            {
                int row_index = EVS_Alowcate_Data.Rows.Add(tt.Location, tt.Item,tt.ItemNCC, tt.Lot, tt.Total, tt.UU,tt.Restricted,tt.Blocked, tt.Alowcate, tt.KD);
                if (tt.Connect == "Connect")
                {
                    EVS_Alowcate_Data.Rows[row_index].DefaultCellStyle.BackColor = Color.LightGreen;
                    EVS_Alowcate_Data.Rows[row_index].Cells["Action"].Value = "Đã Kết Nối";
                }
                else
                {
                    EVS_Alowcate_Data.Rows[row_index].Cells["Action"].Value = "Kết Nối Eink";
                }
            }

            loading_data.Close();
        }

        private void EVS_Alowcate_Data_SelectionChanged(object sender, EventArgs e)
        {

            double ton = 0;
            foreach (DataGridViewCell cell in EVS_Alowcate_Data.SelectedCells)
            {
                if (cell.Value == null) continue;

                if (!double.TryParse(cell.Value.ToString(), out double value))
                    continue;
                if (cell.ColumnIndex >= 3 && cell.ColumnIndex <= 8)
                {
                    ton += value;
                }
            }
            lab_Ton.Text = $"Tổng Tồn: {ton:N1}";

        }
        private void EVS_Alowcate_Data_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.ColumnIndex >= 3 && e.ColumnIndex <= 8)
            {
                // Mở form load thông tin
                // Tạo một loading
                loading_quantity = new Form
                {
                    Text = "Xử lý thông tin...",
                    StartPosition = FormStartPosition.CenterScreen,
                    ControlBox = false,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    ClientSize = new Size(320, 100),
                    TopMost = true
                };
                var lbl = new Label
                {
                    Text = $"Đang thực hiện tính toán \nVui lòng chờ…",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,

                    Font = new Font("Arial", 10, FontStyle.Regular)
                };
                loading_quantity.Controls.Add(lbl);
                loading_quantity.Show();
                loading_quantity.Refresh();

                EVS_Alowcate_Data.ClearSelection();

                foreach (DataGridViewRow row in EVS_Alowcate_Data.Rows)
                {
                    row.Cells[e.ColumnIndex].Selected = true;
                }


                // Đóng lại màn hình load dữ liệu
                loading_quantity.Close();
            }

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            EVS_Alowcate_Data.Rows.Clear();
            foreach (var tt in data_load)
            {
                int row_index = EVS_Alowcate_Data.Rows.Add(tt.Location, tt.Item,tt.ItemNCC, tt.Lot, tt.Total, tt.UU, tt.Restricted, tt.Blocked, tt.Alowcate, tt.KD);
                if (tt.Connect == "Connect")
                {
                    EVS_Alowcate_Data.Rows[row_index].DefaultCellStyle.BackColor = Color.LightGreen;
                    EVS_Alowcate_Data.Rows[row_index].Cells["Action"].Value = "Đã Kết Nối";
                }
                else
                {
                    EVS_Alowcate_Data.Rows[row_index].Cells["Action"].Value = "Kết Nối Eink";
                }
            }
        }

        private void txt_search_mac_eink_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Search_2(); 
            }
        }
    }
}
