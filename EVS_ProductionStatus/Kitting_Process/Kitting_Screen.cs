using EVS_ProductionStatus.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVS_ProductionStatus.Kitting_Process
{
    public partial class Kitting_Screen : Form
    {
        public Kitting_Screen()
        {
            InitializeComponent();
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode  == Keys.Enter)
            {
                // Kiểm tra xem đã nhập tài khoản, mã nhân viên hay chưa
                Check_Account f = new Check_Account(false);
                if(f.ShowDialog() == DialogResult.OK )
                {

                }
            }
        }
    }
}
