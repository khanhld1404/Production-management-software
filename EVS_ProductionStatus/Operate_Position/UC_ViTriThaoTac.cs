using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVS_ProductionStatus
{
    public partial class UC_ViTriThaoTac : UserControl
    {
        int vitri;
        public UC_ViTriThaoTac(int _vitri)
        {
            InitializeComponent();
            vitri = _vitri;
        }

        private void UC_ViTriThaoTac_Load(object sender, EventArgs e)
        {
            ;lbVitri.Text = vitri.ToString();
        }
    }
}
