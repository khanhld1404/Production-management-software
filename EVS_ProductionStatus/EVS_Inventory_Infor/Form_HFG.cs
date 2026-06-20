
using EVS_ProductionStatus;
using EVS_ProductionStatus.Class;
using EVS_ProductionStatus.Data_EVS;
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
using System.Windows.Media.Imaging;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

// Dùng UserControl để giúp không tạo ra một form hay một tab mới
namespace EVS_ProductionStatus
{
    public partial class Form_HFG : UserControl
    {
        public Form_HFG()
        {
            InitializeComponent();
        }

        // Đường dẫn kết nối đến cơ sở dữ  liệu
        Manage_evsEntities mb = new Manage_evsEntities(clConnection.connectEntity2);

        List<string> Trong_SX = new List<string>{"9999", "3010", "3008", "3009", "2001", "2101"};
        List<string> Ngoai_SX = new List<string> { "1001", "2001", "4004", "1002", "2002" };
        List<string> Khong_SX = new List<string> { "5001", "5002", "5003", "5004", "5005" };

        // Các biến để lưu dữ liệu cho EVS
        double Blocked_EVS, UU_EVS, QI_EVS, Res_EVS, Total_EVS;
        // Các biến để lưu dữ liệu cho ngoài sản xuất
        double Blocked_NSX, UU_NSX, QI_NSX, Res_NSX, Total_NSX;
        // Các biến để lưu dữ liệu cho máy không sử dụng sản xuất
        double Blocked_KSD, UU_KSD, QI_KSD, Res_KSD, Total_KSD;
        // Thông tin trạng thái
        string Blocked_Status = "Blocked",UU_Status = "Unrestricted", QI_Status = "In Qual.Insp", Res_Status = "Restricted-Use";
        // Lấy giá trị tồn kho theo từng trạng thái
        public double Get_Value(List<string> location, string status)
        {
            double kq = mb.EVS_Inventory.AsEnumerable()
                 .Where(x => location.Contains(x.Storage_Location) && x.Stock_Type == status && x.MRP_Controller == "F04")
                 .Sum(x => Double.Parse(x.Inventory_Qty));
            return kq;
        }
        // Lấy giá trị tổng tồn kho
        public double Get_Total(List<string> location)
        {
            double kq = mb.EVS_Inventory.AsEnumerable()
                 .Where(x => location.Contains(x.Storage_Location) && x.MRP_Controller == "F04")
                 .Sum(x => Double.Parse(x.Inventory_Qty));
            return kq;
        }

        // Thiết lập dữ liệu cho bảng tổng quan
        private void Load_Data()
        {
            // Thiết lập comment cho ô tìm kiếm
            Placeholder.SetupPlaceholder(txt_Search_ItemNumber, "ItemNumber");
            Placeholder.SetupPlaceholder(txt_Search_ID, "ID");
            txt_Search_ItemNumber.AutoSize = false;
            txt_Search_ID.AutoSize = false;

            // Tính toán những con ở trong EVS

            Blocked_EVS = Get_Value(Trong_SX,Blocked_Status);
            UU_EVS = Get_Value(Trong_SX,UU_Status);
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
            Dgv_Main_HFG.Rows.Add("Trong EVS", Blocked_EVS, UU_EVS, QI_EVS, Res_EVS, Total_EVS);
            Dgv_Main_HFG.Rows.Add("Ngoài sản xuất", Blocked_NSX, UU_NSX, QI_NSX, Res_NSX, Total_NSX);
            Dgv_Main_HFG.Rows.Add("Không sản xuất", Blocked_KSD, UU_KSD, QI_KSD, Res_KSD, Total_KSD);

            // Tính chiều cao dựa trên số dòng + header (Giúp cho bảng hiện thị không bị thừa và cũng không bị thiếu)
            Dgv_Main_HFG.Height = Dgv_Main_HFG.ColumnHeadersHeight +
                                   Dgv_Main_HFG.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + 2;
        }
        //Thiết lập dữ liệu cho bảng chi tiết
        public void Load_Data_Detail(List<string> list, string status)
        {
            List<EVS_ProductionStatus.Data_EVS.EVS_Inventory> Data_Root; 
            // Dữ liệu gốc đầu vào
            if(status != "Total")
            {
                Data_Root = mb.EVS_Inventory
                .Where(x => x.Stock_Type == status && x.MRP_Controller == "F04")
                .ToList();
            }
            else
            {
                Data_Root = mb.EVS_Inventory
                            .Where(x => x.MRP_Controller == "F04")
                            .ToList();
            }
            Data_Overview = Data_Root.AsEnumerable()
                    .Where(x => list.Contains(x.Storage_Location))
                    .GroupBy(s => s.Registered__Material ?? s.Material_Number)
                    .Select(g => new HFG_Overview
                    {
                        MATERIAL_CODE = g.Key,
                        Tổng_Số_Lượng = g.Sum(x => Double.Parse(x.Inventory_Qty))
                    }
                    ).ToList();
            Data_Detail = Data_Root.AsEnumerable()
                            .Where(x => list.Contains(x.Storage_Location))
                            .GroupBy(s => new {
                                MATERIAL_CODE = s.Registered__Material ?? s.Material_Number,
                                BATCH_NUMBER = s.Vendor_Batch_Number ?? s.Batch_Number
                            }
                            )
                            .Select(g => new HFG_Detail
                            {
                                MATERIAL_CODE = g.Key.MATERIAL_CODE,
                                BATCH_NUMBER = g.Key.BATCH_NUMBER,
                                Số_Lượng = g.Sum(x => Double.Parse(x.Inventory_Qty))
                            }
                            ).ToList();
        }

        // Khai báo biến toàn cục
        private List<HFG_Overview> Data_Overview;
        private List<HFG_Detail> Data_Detail;

        private List<HFG_Overview> Data_Search_OverView;
        private List<HFG_Detail> Data_Search_Detail;
        bool check_search = false; // Xác định việc tìm kiếm, nếu false là không tìm kiếm, còn true là có tìm kiếm (Nhằm xác định dữ liệu trong bảng chi tiết)
        private void Form_HFG_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void Data_Details_HFG_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                check_search = false;

                string Tinh_Trang = Dgv_Main_HFG.Rows[e.RowIndex].Cells["TC"].Value.ToString();
                string sum_type = Dgv_Main_HFG.Columns[e.ColumnIndex].Name;

                // Chỉnh lại thông tin status đối với từng cột trạng thái được bấm
                if(sum_type == "QI")
                {
                    sum_type = "In Qual.Insp";
                }
                if(sum_type == "Restricted")
                {
                    sum_type = "Restricted-Use";
                }
                // Lọc dữ liệu theo trạng thái và tình trạng
                if(Tinh_Trang == "Trong EVS")
                {
                    Load_Data_Detail(Trong_SX, sum_type);
                }
                else if(Tinh_Trang == "Ngoài sản xuất")
                {
                    Load_Data_Detail(Ngoai_SX, sum_type);
                }
                else
                {
                    Load_Data_Detail(Khong_SX, sum_type);
                }

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
            if (!check_search) 
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
            if (!check_search)
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

        //private async void Btn_Refresh_Click(object sender, EventArgs e)
        //{
        //    picLoading.Invoke(new Action(() => picLoading.Visible = true));
        //    var Reload_Function = new Reload_Inventory_Infor();
        //    bool check_connect = await Reload_Function.CallInventoryApiAsync("http://10.239.2.10:5555/api/inventory");
        //    picLoading.Invoke(new Action(() => picLoading.Visible = false));
        //    if (check_connect)
        //    {
        //        Load_Data();
        //        Dgv_Details_HFG.DataSource = null;
        //        Dgv_Details_HFG.Refresh();
        //    }
        //}


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
                    Data_Search_Detail = Data_Detail.Where(x => x.MATERIAL_CODE.Contains(tt_ItemNumber) && x.BATCH_NUMBER.Contains(tt_ID)).ToList();
                    Data_Search_OverView = Data_Overview.Where(x => x.MATERIAL_CODE.Contains(tt_ItemNumber)).ToList();

                    bool check_ID = Data_Detail.Any(x => x.BATCH_NUMBER.Contains(tt_ID));

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
                    Data_Search_Detail = Data_Detail.Where(x => x.MATERIAL_CODE.Contains(tt_ItemNumber)).ToList();
                    Data_Search_OverView = Data_Overview.Where(x => x.MATERIAL_CODE.Contains(tt_ItemNumber)).ToList();

                    //Kiểm tra thông tin tìm kiếm ItemNumber
                    if(!Data_Search_OverView.Any())
                    {
                        MessageBox.Show("ItemNumber không chính xác!");
                    }
                }
                //Chỉ nhập ID
                else if (tt_ItemNumber == "" && tt_ID != "")
                {
                    Data_Search_Detail = Data_Detail.Where(x => x.BATCH_NUMBER.Contains(tt_ID)).ToList();
                    var Item_code_return = Data_Detail.Where(x => x.BATCH_NUMBER.Contains(tt_ID))
                                                        .Select(x => x.MATERIAL_CODE)
                                                        .Distinct()
                                                        .ToList();
                    Data_Search_OverView = (from s in Data_Overview
                               join code in Item_code_return
                                   on s.MATERIAL_CODE equals code
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
                check_search = true;
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
                check_search = false;
            }
            else if (Dgv_Details_HFG.Tag.ToString() == "HFG_Detail")
            {
                Dgv_Details_HFG.DataSource = Data_Detail;
                check_search = false;
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
