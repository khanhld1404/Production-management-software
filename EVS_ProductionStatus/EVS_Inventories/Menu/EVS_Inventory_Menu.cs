
using EVS_ProductionStatus.EVS_Inventories.Class;
using EVS_ProductionStatus.EVS_Inventories.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace EVS_ProductionStatus.EVS_Inventories
{
    public partial class EVS_Inventory_Menu : Form
    {
        public EVS_Inventory_Menu()
        {
            InitializeComponent();
        }

        private void btn_Total_Click(object sender, EventArgs e)
        {
            Overview_EVS_Inventory f = new Overview_EVS_Inventory();
            f.Show();
        }

        private void btn_Detail_Click(object sender, EventArgs e)
        {
            Main_EVS_Alowcate f = new Main_EVS_Alowcate();
            f.Show();
        }
    }
}
