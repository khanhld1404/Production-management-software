using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EVS_ProductionStatus.Controller;

namespace EVS_ProductionStatus
{
    public partial class ExportDongGoi : Form
    {
        clExportData cl = new clExportData();
        DateTime _from, _to;
        string _masp, _lot, _manv, _wo, _loaisp;

        public ExportDongGoi()
        {
            InitializeComponent();
        }

        private void ExportDongGoi_Load(object sender, EventArgs e)
        {
            cl.loadcbLoai(cbLoaiSP);
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            _from = dtFrom.Value;
            _to = dtTo.Value;
            _masp = txtItem.Text;
            _lot = txtLot.Text;
            _manv = txtNguoiTT.Text;
            _wo = txtWO.Text;
            _loaisp = cbLoaiSP.Text;
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
                cl.LoadDongGoi(grThongtin, _from, _to, _masp, _lot, _manv, _wo, _loaisp);
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
