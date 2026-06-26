using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EVS_ProductionStatus.Class;

namespace EVS_ProductionStatus
{
    public partial class ExportBox : Form
    {
        clExportData cl = new clExportData();
        DateTime _from, _to;
        string _nv1, _nv2;

        public ExportBox()
        {
            InitializeComponent();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            _from = dtFrom.Value;
            _to = dtTo.Value;
            _nv2 = txt_nv2.Text.Trim();
            _nv1 = txt_nv1.Text.Trim();
            if (backgroundWorker1.IsBusy)
            {
                MessageBox.Show("Đang tìm kiếm dữ liệu, vui lòng đợi đến khi hoàn thành!");
            }
            else
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                picLoading.Invoke(new Action(() => picLoading.Visible = true));
                cl.LoadBox(grThongtin, _from, _to, _nv1, _nv2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            picLoading.Invoke(new Action(() => picLoading.Visible = false));
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                cl.ExportToExcel(grThongtin);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
