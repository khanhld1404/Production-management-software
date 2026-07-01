using EVS_ProductionStatus.Class;
using EVS_ProductionStatus.Data_EVS;
using EVS_ProductionStatus.EVS_Inventories.Class;
using EVS_ProductionStatus.EVS_Inventories.Model;
using EVS_ProductionStatus.EVS_Inventories.Model.EVS;
using EVS_ProductionStatus.EVS_Inventories.Model.NSX_KSX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVS_ProductionStatus.EVS_Inventories
{
    public partial class EVS_Alowcate : Form
    {

        // Lấy danh sách các location sử dụng để tính toán
        List<string> list = new List<string>();

        // Dữ liệu gốc dùng để tính toán dữ liệu
        List<EVS_Inventory> data_root;
        // Dữ liệu load được
        List<Model.EVS.EVS_Inventory_Alowcate> data_load;

        // Dữ liệu tìm kiếm được
        List<Model.EVS.EVS_Inventory_Alowcate> data_search;
        public EVS_Alowcate(List<string> _list, string _tt)
        {
            InitializeComponent();
            list = _list;
            Lab_Infor_Total.Text = "Thông Tin Tồn Alowcate " + _tt;
        }

        // Lấy số lượng tồn alowcate (Chỉ tính trạng thái UU)
        public double Get_Alowcate(List<MB25> data, string material,string batch)
        {
            var result = data
                        .Where(x => x.Material == material && x.Batch == batch)
                        .Select(x => (double?)x.Total)
                        .FirstOrDefault() ?? 0;

            return result;
        }

        private void Data_Load()
        {
            using (Manage_evsEntities mb = new Manage_evsEntities(clConnection.connectEntity2))
            {
                // data dùng để tính allowcate
                var MB25_Data = mb.MB25.ToList();

                data_root = mb.EVS_Inventory
                           .Where(x => list.Contains(x.Storage_Location) && x.Stock_Type == "Unrestricted")
                           .ToList();
                data_load = data_root
                           .GroupBy(x => new
                           {
                               MATERIAL_NUMBER = x.Registered__Material ?? x.Material_Number,
                               BATCH_NUMBER = x.Vendor_Batch_Number ?? x.Batch_Number
                           })
                           .Select(g => new EVS_Inventory_Alowcate
                           {
                               Item = g.Key.MATERIAL_NUMBER,
                               Lot = g.Key.BATCH_NUMBER,
                               Ton = Math.Round(g.Sum(x => (double.TryParse(x.Inventory_Qty, out double v) ? v : 0)), 1),
                               Alowcate = Get_Alowcate(MB25_Data, g.Key.MATERIAL_NUMBER,g.Key.BATCH_NUMBER),
                               KD = Math.Round(g.Sum(x => (double.TryParse(x.Inventory_Qty, out double v) ? v : 0)), 1) - Get_Alowcate(MB25_Data, g.Key.MATERIAL_NUMBER,g.Key.BATCH_NUMBER)
                           }).ToList();

                EVS_Alowcate_Data.DataSource = data_load;
            }
        }
        private void EVS_Alowcate_Load(object sender, EventArgs e)
        {
            // Thêm màn load khi tính toán dữ liệu để hiện thị trong bảng detail
            using (var loading = new Form
            {
                Text = "Xử lý dữ liệu...",
                StartPosition = FormStartPosition.CenterScreen,
                ControlBox = false,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                ClientSize = new Size(320, 100),
                TopMost = true
            })
            {
                var lbl = new Label
                {
                    Text = $"Đang xử lý dữ liệu\nVui lòng chờ…",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,

                    Font = new Font("Arial", 10, FontStyle.Regular)
                };
                loading.Controls.Add(lbl);
                loading.Show();       // show modeless để không block await
                loading.Refresh();

                try
                {
                    // Thiết lập location 
                    location_box.Items.Add("All Location");
                    // Thêm lựa chọn vào combobox
                    foreach (string item in list)
                    {
                        location_box.Items.Add(item);
                    }
                    location_box.SelectedIndex = 0;
                    // Thiết lập comment cho ô tìm kiếm
                    Placeholder.SetupPlaceholder(txt_Search_Material, "Item");
                    Placeholder.SetupPlaceholder(txt_Batch_Number, "Lot");
                    // Tính toán và lọc dữ liệu
                    Data_Load();
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
            }
        }

        private void Search(List<Model.EVS.EVS_Inventory_Alowcate> data, string tt_Material_Code,string tt_Batch_Number)
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
                }
            }
            else
            {
                data_search = data;
            }
            EVS_Alowcate_Data.DataSource = data_search;
        }
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            //Lấy thông tin trong ô tìm kiếm
            string tt_Material_Code = Placeholder.GetRealText(txt_Search_Material);
            string tt_Batch_Number = Placeholder.GetRealText(txt_Batch_Number);
            string location = location_box.Text.Trim();
            try
            {
                if (location == "" || location == "All Location")
                {
                    Search(data_load, tt_Material_Code,tt_Batch_Number);
                }
                else
                {
                    using (Manage_evsEntities mb = new Manage_evsEntities(clConnection.connectEntity2))
                    {
                        // data dùng để tính allowcate
                        var MB25_Data = mb.MB25.ToList();

                        List<EVS_Inventory_Alowcate> Data_Search_Location = data_root
                               .Where(x => x.Storage_Location == location)
                               .GroupBy(x => new
                               {
                                   MATERIAL_NUMBER = x.Registered__Material ?? x.Material_Number,
                                   BATCH_NUMBER = x.Vendor_Batch_Number ?? x.Batch_Number
                               })
                               .Select(g => new EVS_Inventory_Alowcate
                               {
                                   Item = g.Key.MATERIAL_NUMBER,
                                   Lot = g.Key.BATCH_NUMBER,
                                   Ton = Math.Round(g.Sum(s => double.TryParse(s.Inventory_Qty, out double v) ? v : 0), 1),
                                   Alowcate = Get_Alowcate(MB25_Data, g.Key.MATERIAL_NUMBER, g.Key.BATCH_NUMBER),
                                   KD = Math.Round(g.Sum(s => double.TryParse(s.Inventory_Qty, out double v) ? v : 0) - Get_Alowcate(MB25_Data, g.Key.MATERIAL_NUMBER, g.Key.BATCH_NUMBER), 1)
                               }).ToList();
                        Search(Data_Search_Location, tt_Material_Code,tt_Batch_Number);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Excel_Click(object sender, EventArgs e)
        {
            Excel_Only_Sheet.ExportToExcel(EVS_Alowcate_Data);
        }

        private void EVS_Alowcate_Data_SelectionChanged(object sender, EventArgs e)
        {
            double ton = 0;
            double alowcate = 0;
            double kd = 0;
            foreach (DataGridViewCell cell in EVS_Alowcate_Data.SelectedCells)
            {
                if (cell.Value == null) continue;

                if (!double.TryParse(cell.Value.ToString(), out double value))
                    continue;

                // Cột tồn
                if (cell.ColumnIndex == 2)
                {
                    ton += value;
                }

                // Cột alowcate
                if (cell.ColumnIndex == 3)
                {
                    alowcate += value;
                }

                // Cột khả dụng
                if (cell.ColumnIndex == 4)
                {
                    kd += value;
                }
            }

            lab_Ton.Text = $"Tổng Tồn: {ton:N1}";
            lab_Alowcate.Text = $"Tổng Alowcate: {alowcate:N1}";
            lab_KD.Text = $"Tổng Khả Dụng: {kd:N1}";
        }
    }
}
