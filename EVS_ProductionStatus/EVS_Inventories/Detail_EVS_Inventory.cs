using EVS_ProductionStatus.Class;
using EVS_ProductionStatus.Data_EVS;
using EVS_ProductionStatus.EVS_Inventories.Class;
using EVS_ProductionStatus.EVS_Inventories.Model;
using System;
using System.Collections;
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
    public partial class Detail_EVS_Inventory : Form
    {

        // Nhận dữ liệu được lấy về
        List<Inventories_Total> DataDetail;

        // Dữ liệu tìm kiếm tìm được
        List<Inventories_Total> DataSearch;

        // Location của từng trạng thái
        List<string> list;
        // Thông tin thể loại được hiện ở trên text
        string tt;

        //Thông tin để xác định HFG,RM và WIP
        List<string> status_list;

        public Detail_EVS_Inventory(List<string> _list, string _tt, List<string> _status_list)
        {
            InitializeComponent();
            list = _list;
            tt = _tt;
            status_list = _status_list;
        }

        // Thực hiện việc tính toán 
        public void Data_Load(List<string> inventory_location)
        {
            // Xóa các location cũ
            location_box.Items.Clear();
            // Thiết lập location 
            location_box.Items.Add("All Location");
            // Thêm lựa chọn vào combobox
            foreach (string item in inventory_location)
            {
                location_box.Items.Add(item);
            }
            location_box.SelectedIndex = 0;

            using (Manage_evsEntities mb = new Manage_evsEntities(clConnection.connectEntity2))
            {

                DataDetail = mb.EVS_Inventory.AsEnumerable()
                    .Where(x => inventory_location.Contains(x.Storage_Location) && status_list.Contains(x.MRP_Controller))
                    .GroupBy(x => new
                    {
                        MATERIAL_NUMBER = x.Registered__Material ?? x.Material_Number,
                        BATCH_NUMBER = x.Vendor_Batch_Number ?? x.Batch_Number,
                        LOCATION = x.Storage_Location
                    })
                    .OrderBy(g => g.Key.MATERIAL_NUMBER)
                    .Select(g => new Inventories_Total
                    {
                        Location = g.Key.LOCATION,
                        Item = g.Key.MATERIAL_NUMBER,
                        Lot = g.Key.BATCH_NUMBER,
                        Total = Math.Round(
                            g.Sum(x => double.TryParse(x.Inventory_Qty, out double v) ? v : 0)
                                , 2),
                        UU =Math.Round(
                            g.Sum(x => x.Stock_Type == "Unrestricted"
                                ? (double.TryParse(x.Inventory_Qty, out double v) ? v : 0)
                                : 0), 2),
                        
                        Restricted = Math.Round(
                            g.Sum(x => x.Stock_Type == "Restricted-Use"
                                ? (double.TryParse(x.Inventory_Qty, out double v) ? v : 0)
                                : 0), 2),

                        Blocked = Math.Round(
                            g.Sum(x => x.Stock_Type == "Blocked"
                                ? (double.TryParse(x.Inventory_Qty, out double v) ? v : 0)
                                : 0), 2),
                        QI = Math.Round(
                            g.Sum(x => x.Stock_Type == "In Qual.Insp"
                                ? (double.TryParse(x.Inventory_Qty, out double v) ? v : 0)
                                : 0), 2)
                    })
                    .ToList();

                Total_EVS_Data.DataSource = DataDetail;
            }
        }

        private void Total_EVS_Inventory_Load(object sender, EventArgs e)
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
                    // Thực hiện việc xử lý dữ liệu trong sản xuất (EVS) là mặc định
                    // Thiết lập comment cho ô tìm kiếm
                    Placeholder.SetupPlaceholder(txt_Search_Material, "Item");
                    Placeholder.SetupPlaceholder(txt_Search_Batch, "Lot");

                    // Tính toán và lọc dữ liệu
                    Lab_Infor_Total.Text = "Thông Tin Tồn " + tt;
                    Data_Load(list);
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

        private void Btn_Excel_Click(object sender, EventArgs e)
        {
            Excel_Only_Sheet.ExportToExcel(Total_EVS_Data);
        }

        //Tìm kiếm
        private void Search(List<Inventories_Total> data, string Item, string lot)
        {
            if (Item != "" && lot != "")
            {
                //Kiểm tra thông tin tìm kiếm có chính xác không
                bool check_tt = data.Any(x => x.Item == Item && x.Lot == lot);
                if (check_tt)
                {
                    DataSearch = data.Where(x => x.Item == Item && x.Lot == lot).ToList();
                }
                else
                {
                    MessageBox.Show("Thông tin tìm kiếm đang không chính xác");
                }

            }
            else if (Item != "" && lot == "")
            {
                //Kiểm tra thông tin tìm kiếm có chính xác không
                bool check_tt = data.Any(x => x.Item == Item);
                if (check_tt)
                {
                    DataSearch = data.Where(x => x.Item == Item).ToList();
                }
                else
                {
                    MessageBox.Show("Thông tin tìm kiếm đang không chính xác");
                }

            }
            else if (Item == "" && lot != "")
            {
                //Kiểm tra thông tin tìm kiếm có chính xác không
                bool check_tt = data.Any(x => x.Lot == lot);
                if (check_tt)
                {
                    DataSearch = data.Where(x => x.Item == lot).ToList();
                }
                else
                {
                    MessageBox.Show("Thông tin tìm kiếm đang không chính xác");
                }

            }
            else
            {
                DataSearch = data;
            }
            Total_EVS_Data.DataSource = DataSearch;
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            //Lấy thông tin trong ô tìm kiếm
            string tt_Material_Code = Placeholder.GetRealText(txt_Search_Material);
            string tt_Batch_Number = Placeholder.GetRealText(txt_Search_Batch);
            string location = location_box.Text.Trim();
            try
            {
                if (location == "" || location == "All Location")
                {
                    Search(DataDetail,tt_Material_Code,tt_Batch_Number);
                }
                else
                {
                    List<Inventories_Total> Data_Search_Location = DataDetail.Where(x => x.Location == location).ToList();
                    Search(Data_Search_Location, tt_Material_Code, tt_Batch_Number);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
