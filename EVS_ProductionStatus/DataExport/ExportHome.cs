
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVS_Management
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

        private void btnExportQCRing_Click(object sender, EventArgs e)
        {
            ExportQCRing f = new ExportQCRing();
            f.Show();
        }

        private void btnExportRing_Click(object sender, EventArgs e)
        {
            ExportRing f = new ExportRing();
            f.Show();
        }

        private void btn_Box_Click(object sender, EventArgs e)
        {
            ExportBox f = new ExportBox();
            f.Show();
        }
    }
}
