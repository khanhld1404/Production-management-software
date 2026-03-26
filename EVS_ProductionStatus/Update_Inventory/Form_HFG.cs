
using EVS_ProductionStatus;
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
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Dùng UserControl để giúp không tạo ra một form hay một tab mới
namespace Main_Project_Trainee
{
    public partial class Form_HFG : UserControl
    {
        public Form_HFG()
        {
            InitializeComponent();
        }
        string entityConnString = clConnection.connectString2;
        private void Load_Data()
        {
            // Thiết lập comment cho ô tìm kiếm
            Placeholder.SetupPlaceholder(txt_Search_ItemNumber, "ItemNumber");
            Placeholder.SetupPlaceholder(txt_Search_ID, "ID");
            txt_Search_ItemNumber.AutoSize = false;
            txt_Search_ID.AutoSize = false;
            //Đường dẫn kết nối
            Manage_evsEntities mb = new Manage_evsEntities(entityConnString);

            var summary2 = (from em in mb.EVS_Manage
                            join in_e in mb.NewInventory_EVS
                            // Xét on trên nhiều điều kiện chứ không dùng trong where vì nếu dùng trong where sẽ không lấy được các dòng không đủ dữ liệu 
                            on new { Item_Number = em.Item_Number, Part = "HFG", Loc = "04020" }
                            equals new { Item_Number = in_e.Itemcode, Part = in_e.part_type, Loc = in_e.loc }
                            into group_check
                            // Giúp hiện ra cả những thông tin không khớp với cái on bên trên, ở đó các giá trị thiếu sẽ là null (Ở đây nếu thiếu thì Qty = null)
                            from in_e in group_check.DefaultIfEmpty() 
                            group new { em, in_e } by em.Item_Type into g
                            select new
                            {
                                ItemType = g.Key,
                                //Nếu thiếu sẽ ra kết quả bằng 0 vì nếu không thuộc trạng thái sẽ bằng 0
                                Total = g.Sum(x => (x.in_e.status.ToUpper() == "HOLD" || x.in_e.status.ToUpper() == "UNDER QA") ? x.in_e.Qty : 0),
                                Hold = g.Sum(x => x.in_e.status.ToUpper() == "HOLD" ? x.in_e.Qty : 0),
                                Under_QA = g.Sum(x => x.in_e.status.ToUpper() == "UNDER QA" ? x.in_e.Qty : 0)
                            }).ToList();
            Dgv_Main_HFG.DataSource = summary2;
            // Tính chiều cao dựa trên số dòng + header (Giúp cho bảng hiện thị không bị thừa và cũng không bị thiếu)
            Dgv_Main_HFG.Height = Dgv_Main_HFG.ColumnHeadersHeight +
                                   Dgv_Main_HFG.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + 2;
        }
        // Khai báo biến toàn cục
        private List<HFG_Overview> Data_Overview;
        private List<HFG_Detail> Data_Detail;

        private List<HFG_Overview> Data_Search_OverView;
        private List<HFG_Detail> Data_Search_Detail;
        int b = 0; // Xác định việc tìm kiếm, nếu b =0 là không tìm kiếm, còn b = 1 là có tìm kiếm
        private void Form_HFG_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
        private void Data_Details_HFG_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                b = 0;
                Manage_evsEntities mb = new Manage_evsEntities(entityConnString);
                string Item_type = Dgv_Main_HFG.Rows[e.RowIndex].Cells["ItemType"].Value.ToString();
                string sum_type = Dgv_Main_HFG.Columns[e.ColumnIndex].Name;

                Data_Overview = (from em in mb.EVS_Manage
                            join in_e in mb.NewInventory_EVS
                            on em.Item_Number equals in_e.Itemcode
                            where in_e.part_type == "HFG" &&
                                  (
                                  (sum_type == "Total" && (in_e.status.ToUpper() == "HOLD" || in_e.status.ToUpper() == "UNDER QA")) ||
                                  (sum_type == "Hold" && in_e.status.ToUpper() == "HOLD") ||
                                  (sum_type == "Under_QA" && in_e.status.ToUpper() == "UNDER QA")
                                  ) &&
                                  in_e.loc == "04020"
                                  &&
                                  em.Item_Type == Item_type
                            group new { em, in_e } by em.Item_Number into g
                            orderby g.Key
                            select new HFG_Overview
                            {
                                ItemNumber = g.Key,
                                Total = g.Sum(x => x.in_e.Qty ?? 0),
                            }).ToList();
                Data_Detail = (from em in mb.EVS_Manage
                            join in_e in mb.NewInventory_EVS
                            on em.Item_Number equals in_e.Itemcode
                            where in_e.part_type == "HFG" &&
                                  (
                                  (sum_type == "Total" && (in_e.status.ToUpper() == "HOLD" || in_e.status.ToUpper() == "UNDER QA")) ||
                                  (sum_type == "Hold" && in_e.status.ToUpper() == "HOLD") ||
                                  (sum_type == "Under_QA" && in_e.status.ToUpper() == "UNDER QA")
                                  ) &&
                                  in_e.loc == "04020"
                                  &&
                                  em.Item_Type == Item_type
                            group new { em, in_e } by new { em.Item_Number, in_e.LotNo } into g
                            orderby g.Key
                            select new HFG_Detail
                            {
                                ItemNumber = g.Key.Item_Number,
                                ID = g.Key.LotNo,
                                Số_Lượng = g.Sum(x => x.in_e.Qty ?? 0),
                            }).ToList();
                //Xác định bảng nào sẽ được hiển thị 
                if (Dgv_Details_HFG.DataSource == null || Dgv_Details_HFG.Tag.ToString() == "HFG_Overview")
                {
                    Lab_Detail_HFG.Text = "Thông Tin HFG (Tổng Quan)";
                    Dgv_Details_HFG.DataSource = null;
                    Dgv_Details_HFG.Refresh();
                    Dgv_Details_HFG.DataSource = Data_Overview;
                    Dgv_Details_HFG.Tag = "HFG_Overview";
                }
                else if (Dgv_Details_HFG.Tag.ToString() == "HFG_Detail")
                {
                    Dgv_Details_HFG.DataSource = null;
                    Dgv_Details_HFG.Refresh();
                    Dgv_Details_HFG.DataSource = Data_Detail;
                    Dgv_Details_HFG.Tag = "HFG_Detail";
                }

            }
        }

        //Nút bấm xem tổng quan
        private void Btn_Total_Click(object sender, EventArgs e)
        {
            if (Dgv_Details_HFG.DataSource == null)
            {
                MessageBox.Show("Chưa có dữ liệu. Mời bạn nhấn bên trên");
                return;
            }
            Lab_Detail_HFG.Text = "Thông Tin HFG (Tổng Quan)";
            Dgv_Details_HFG.DataSource = null;
            Dgv_Details_HFG.Refresh();
            if (b != 1) 
            {
                Dgv_Details_HFG.DataSource = Data_Overview;
            }
            else //Nếu b = 1 thì nó sẽ là kết quả tìm kiếm
            {
                Dgv_Details_HFG.DataSource = Data_Search_OverView;
            }
            Dgv_Details_HFG.Tag = "HFG_Overview";
        }

        //Nút bấm xem chi tiết
        private void Btn_Details_Click(object sender, EventArgs e)
        {
            if (Dgv_Details_HFG.DataSource == null)
            {
                MessageBox.Show("Chưa có dữ liệu. Mời bạn nhấn bên trên");
                return;
            }
            Lab_Detail_HFG.Text = "Thông Tin HFG (Chi Tiết)";
            Dgv_Details_HFG.DataSource = null;
            Dgv_Details_HFG.Refresh();
            if (b != 1)
            {
                Dgv_Details_HFG.DataSource = Data_Detail;
            }
            else
            {
                Dgv_Details_HFG.DataSource = Data_Search_Detail;
            }
            Dgv_Details_HFG.Tag = "HFG_Detail";
        }
        // Xuất ra file excel
        private void Btn_Excel_Click(object sender, EventArgs e)
        {

            if (Dgv_Details_HFG.DataSource != null)
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

        private async void Btn_Refresh_Click(object sender, EventArgs e)
        {
            picLoading.Invoke(new Action(() => picLoading.Visible = true));
            var Reload_Function = new Reload_Inventory_Infor();
            bool check_connect = await Reload_Function.CallInventoryApiAsync("http://10.239.2.10:5555/api/inventory");
            picLoading.Invoke(new Action(() => picLoading.Visible = false));
            if (check_connect)
            {
                Load_Data();
                Dgv_Details_HFG.DataSource = null;
                Dgv_Details_HFG.Refresh();
            }
        }
        private void Search()
        {
            //Lấy thông tin trong ô tìm kiếm
            string tt_ItemNumber = Placeholder.GetRealText(txt_Search_ItemNumber);
            string tt_ID = Placeholder.GetRealText(txt_Search_ID);
            try
            {
                // Nếu nhập đủ thông tin tìm kiếm
                if(tt_ItemNumber != "" && tt_ID != "")
                {
                    Data_Search_Detail = Data_Detail.Where(x => x.ItemNumber == tt_ItemNumber && x.ID == tt_ID).ToList();
                    Data_Search_OverView = Data_Overview.Where(x => x.ItemNumber == tt_ItemNumber).ToList();

                    bool check_ID = Data_Detail.Any(x => x.ID == tt_ID);

                    //Kiểm tra thông tin tìm kiếm có chính xác không
                    if(!Data_Search_OverView.Any() && !check_ID)
                    {
                        MessageBox.Show("Cả ItemNumber và ID đều không chính xác!");
                    }else if(!Data_Search_OverView.Any())
                    {
                        MessageBox.Show("ItemNumber không chính xác!");
                    }else if(!check_ID)
                    {
                        MessageBox.Show("ID không chính xác!");
                    }

                }
                //Chỉ nhập ItemNumber
                else if(tt_ItemNumber != "" && tt_ID == "")
                {
                    Data_Search_Detail = Data_Detail.Where(x => x.ItemNumber == tt_ItemNumber).ToList();
                    Data_Search_OverView = Data_Overview.Where(x => x.ItemNumber == tt_ItemNumber).ToList();

                    //Kiểm tra thông tin tìm kiếm ItemNumber
                    if(!Data_Search_OverView.Any())
                    {
                        MessageBox.Show("ItemNumber không chính xác!");
                    }
                }
                //Chỉ nhập ID
                else if (tt_ItemNumber == "" && tt_ID != "")
                {
                    Data_Search_Detail = Data_Detail.Where(x => x.ID == tt_ID).ToList();
                    var Item_code_return = Data_Detail.Where(x => x.ID == tt_ID)
                                                        .Select(x => x.ItemNumber)
                                                        .Distinct()
                                                        .ToList();
                    Data_Search_OverView = (from s in Data_Overview
                               join code in Item_code_return
                                   on s.ItemNumber equals code
                               select s)
                               .ToList();

                    //Kiểm tra thông tin tìm kiếm ID
                    if (!Data_Search_Detail.Any())
                    {
                        MessageBox.Show("ID không chính xác!");
                    }
                }
                else
                {
                    MessageBox.Show("Mời bạn nhập một trong hai ô để bắt đầu tìm kiếm!");
                    return;
                }
                b = 1;
                if (Dgv_Details_HFG.Tag.ToString() == "HFG_Overview")
                {
                    Dgv_Details_HFG.DataSource = Data_Search_OverView;
                }
                else if (Dgv_Details_HFG.Tag.ToString() == "HFG_Detail")
                {
                    Dgv_Details_HFG.DataSource = Data_Search_Detail;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Rewatch()
        {
            if (Dgv_Details_HFG.Tag.ToString() == "HFG_Overview")
            {
                Dgv_Details_HFG.DataSource = Data_Overview;
                b = 0;
            }
            else if (Dgv_Details_HFG.Tag.ToString() == "HFG_Detail")
            {
                Dgv_Details_HFG.DataSource = Data_Detail;
                b = 0;
            }
        }
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (Dgv_Details_HFG.DataSource == null)
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
                if (Dgv_Details_HFG.DataSource == null)
                {
                    MessageBox.Show("Chưa có dữ liệu trong bảng, mời bạn nhấn bên trên");
                    return;
                }
                // Cần phải sử dụng PlaceHolder vì comment ở đây là text, nên để xác định được ô tìm kiếm có trống không ta cần phải không tính đến comment
                if (Placeholder.GetRealText(txt_Search_ItemNumber) == "" && Placeholder.GetRealText(txt_Search_ID) == "")
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
