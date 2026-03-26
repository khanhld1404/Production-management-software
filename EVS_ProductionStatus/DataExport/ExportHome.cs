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
    public partial class ExportHome : Form
    {
        public ExportHome()
        {
            InitializeComponent();
        }

        private void btnExportKhau_Click(object sender, EventArgs e)
        {
            ExportKhau f = new ExportKhau();
            f.Show();
        }

        private void btnExportQC_Click(object sender, EventArgs e)
        {
            ExportQC f = new ExportQC();
            f.Show();
        }

        private void btnExportKitting_Click(object sender, EventArgs e)
        {
            ExportKitting f = new ExportKitting();
            f.Show();
        }

        private void btnExportDG_Click(object sender, EventArgs e)
        {
            ExportDongGoi f = new ExportDongGoi();
            f.Show();
        }
       
    }
}
