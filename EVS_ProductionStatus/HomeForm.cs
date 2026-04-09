using EVS_ProductionStatus.Class;
using Main_Project_Trainee;
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

        private void btnTrangthaiSX_Treo_Click(object sender, EventArgs e)
        {
            ProductionStatus f = new ProductionStatus("TREO");
            f.Show();
        }

        private void btnTrangthaiSX_AnaThora_Click(object sender, EventArgs e)
        {
            ProductionStatus f = new ProductionStatus("THORA");
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

        public static void ShowUserControlAsForm(UserControl uc, string title)
        {
            Form frm = new Form();
            frm.Text = title;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Size = uc.Size; // hoặc frm.AutoSize = true;
            frm.Controls.Add(uc);
            frm.WindowState = FormWindowState.Maximized;
            uc.Dock = DockStyle.Fill; // Cho vừa form

            frm.Show(); // hoặc frm.Show();
        }

        private void btn_HFG_Click(object sender, EventArgs e)
        {
            ShowUserControlAsForm(new Form_HFG(),"HFG");
        }

        private void btn_RM_WIP_Click(object sender, EventArgs e)
        {
            ShowUserControlAsForm(new Form_RM_WIP(), "RM_WIP");
        }

        // Thực hiện việc cập nhật dữ liệu trước khi vào chương trình chính
        private void HomeForm_Load(object sender, EventArgs e)
        {
            Reload_Inventory_Infor.UpdateInventory();
        }
    }
}
