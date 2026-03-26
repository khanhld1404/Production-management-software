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
    public partial class View_MasterBanVe : Form
    {
        Controller.clMaBanVe cl = new Controller.clMaBanVe();
        public View_MasterBanVe()
        {
            InitializeComponent();
        }

        private void View_MasterBanVe_Load(object sender, EventArgs e)
        {
            cl.loaddata(grThongtin);
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            txtFileURL.Text = cl.selectfile(openFileDialog1);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            cl.importdata(txtFileURL.Text);
            cl.loaddata(grThongtin);
        }
    }
}
