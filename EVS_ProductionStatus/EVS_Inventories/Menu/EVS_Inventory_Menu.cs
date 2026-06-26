
using System;
using System.Windows.Forms;
using EVS_ProductionStatus.EVS_Inventories.Class;
namespace EVS_ProductionStatus.EVS_Inventories
{
    public partial class EVS_Inventory_Menu : Form
    {
        public EVS_Inventory_Menu()
        {
            InitializeComponent();
        }
        private void btn_HFG_Inventory_Click(object sender, EventArgs e)
        {
            Other_function.ShowUserControlAsForm(new Form_HFG(), "HFG");
        }

        private void btn_RM_Inventory_Click(object sender, EventArgs e)
        {
            Other_function.ShowUserControlAsForm(new Form_RM(), "RM");
        }

        private void btn_WIP_Inventory_Click(object sender, EventArgs e)
        {
            Other_function.ShowUserControlAsForm(new Form_WIP(), "WIP");
        }
    }
}
