using EVS_ProductionStatus.Class;
using EVS_ProductionStatus.Update_Inventory.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVS_ProductionStatus
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void itemThietLapFile_Click(object sender, EventArgs e)
        {
            ThietLapFile f = new ThietLapFile();
            f.ShowDialog();
        }

        private void btnTrangthaiSX_Click(object sender, EventArgs e)
        {
            ProductionStatus f = new ProductionStatus("RELAY");
            f.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportHome f = new ExportHome();
            f.Show();
        }

        private void itemTrangThaiWO_Click(object sender, EventArgs e)
        {
            QuanLyTrangThai f = new QuanLyTrangThai();
            f.Show();
        }

        private void itemThoiGianNghi_Click(object sender, EventArgs e)
        {
            QuanLyThoiGianNghi f = new QuanLyThoiGianNghi();
            f.Show();
        }

        private void itemNguoiThaoTac_Click(object sender, EventArgs e)
        {
            QuanLyNguoiThaoTac f = new QuanLyNguoiThaoTac();
            f.Show();
        }

        private void btnTrangthaiSXOther_Click(object sender, EventArgs e)
        {
            //ProductionStatusOther f = new ProductionStatusOther();
            ProductionStatus f = new ProductionStatus("THORA", "TREO", "RELAY");
            f.Show();
        }

        private void itemWOBaoLuu_Click(object sender, EventArgs e)
        {
            QuanLyWOBaoLuu f = new QuanLyWOBaoLuu();
            f.Show();
        }

        private void itemMaBanVe_Click(object sender, EventArgs e)
        {
            View_MasterBanVe f = new View_MasterBanVe();
            f.Show();
        }

        private void btnOperatorStatus_Click(object sender, EventArgs e)
        {
            OperatorStatus f = new OperatorStatus();
            f.Show();
        }

        private void itemWOChamDG_Click(object sender, EventArgs e)
        {
            Settings.WOChamDongGoi f = new Settings.WOChamDongGoi();
            f.Show();
        }

        private void toolPacking_Click(object sender, EventArgs e)
        {
            Settings.InputPacking f = new Settings.InputPacking();
            f.Show();
        }

        private void toolTrangThaiSP_Click(object sender, EventArgs e)
        {
            Settings.TrangThaiSP f = new Settings.TrangThaiSP();
            f.Show();
        }

        private void itemThoiGianKhau_Click(object sender, EventArgs e)
        {
            Settings.masterThoiGianKhau f = new Settings.masterThoiGianKhau();
            f.Show();
        }

        // Thực hiện việc cập nhật dữ liệu trước khi vào chương trình chính
        private void HomeForm_Load(object sender, EventArgs e)
        {
            //Reload_Inventory_Infor.UpdateInventory();
            Other_function.Call_Procedure(clConnection.connectString3,"update_tblWO");
        }

        private void btn_Ring_Click(object sender, EventArgs e)
        {
            ProductionStatus f = new ProductionStatus();
            f.Show();
        }

        private void btn_Inventory_Click(object sender, EventArgs e)
        {
            EVS_Inventory_Menu f = new EVS_Inventory_Menu();
            f.Show();
        }

        private void btn_Box_Click(object sender, EventArgs e)
        {
            Box_Status f = new Box_Status();
            f.Show();
        }

        private void btn_Status_Details_Production_Click(object sender, EventArgs e)
        {
            Status_Details_Menu f = new Status_Details_Menu();
            f.Show();
        }

        private void btn_Kitting_Click(object sender, EventArgs e)
        {
            Other_function.ShowUserControlAsForm(new Form_Kitting(), "Gợi ý Kitting");
        }
    }
}