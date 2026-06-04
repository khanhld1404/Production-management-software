
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EVS_ProductionStatus.Update_Inventory;
namespace EVS_ProductionStatus
{
    public partial class EVS_Inventory : Form
    {
        public EVS_Inventory()
        {
            InitializeComponent();
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
        private void btn_HFG_Inventory_Click(object sender, EventArgs e)
        {
            ShowUserControlAsForm(new Form_HFG(), "HFG");
        }

        private void btn_RM_Inventory_Click(object sender, EventArgs e)
        {
            ShowUserControlAsForm(new Form_RM(), "RM");
        }

        private void btn_WIP_Inventory_Click(object sender, EventArgs e)
        {

        }
    }
}
