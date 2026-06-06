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
    public partial class Box_Status : Form
    {
        public Box_Status()
        {
            InitializeComponent();
            txt_Box_Number.Focus();
        }

        private void txt_Box_Number_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
               
                arrow1.Visible = true;
                lab_emp1.Visible = true;
                txt_emp_1.Visible = true;
                txt_emp_1.Focus();
            }
        }

        private void txt_emp_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                arrow2.Visible = true;
                lab_emp2.Visible = true;
                txt_emp_2.Visible = true;
                txt_emp_2.Focus();
            }
        }

        private void txt_emp_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_wo_scan.Enabled = true;
                txt_wo_scan.Focus();
            }
        }

        private void txt_wo_scan_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
