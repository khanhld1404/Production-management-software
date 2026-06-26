using EVS_ProductionStatus.EVS_Inventories.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVS_ProductionStatus.EVS_Inventories.Menu
{
    public partial class EVS_Kitting_Menu : Form
    {
        public EVS_Kitting_Menu()
        {
            InitializeComponent();
        }

        private void btn_3008_Click(object sender, EventArgs e)
        {
            Other_function.ShowUserControlAsForm(new Form_Kitting("3008"), "Gợi ý Kitting của location 3008");
        }

        private void btn_3009_Click(object sender, EventArgs e)
        {
            Other_function.ShowUserControlAsForm(new Form_Kitting("3009"), "Gợi ý Kitting của location 3009");
        }

        private void btn_3010_Click(object sender, EventArgs e)
        {
            Other_function.ShowUserControlAsForm(new Form_Kitting("3010"), "Gợi ý Kitting của location 3010");
        }
    }
}
