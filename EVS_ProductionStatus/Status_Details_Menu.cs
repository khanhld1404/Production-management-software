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
    public partial class Status_Details_Menu : Form
    {
        public Status_Details_Menu()
        {
            InitializeComponent();
        }

        private void btn_Thora_Status_Click(object sender, EventArgs e)
        {
            ProductionStatus f = new ProductionStatus("THORA");
            f.Show();
        }

        private void btn_Treo_Status_Click(object sender, EventArgs e)
        {
            ProductionStatus f = new ProductionStatus("TREO");
            f.Show();
        }

        private void btn_Relay_Status_Click(object sender, EventArgs e)
        {
            ProductionStatus f = new ProductionStatus("RELAY");
            f.Show();
        }
    }
}
