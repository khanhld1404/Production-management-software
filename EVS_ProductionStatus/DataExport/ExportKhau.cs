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
    public partial class ExportKhau : Form
    {
        clExportData cl = new clExportData();
        DateTime _from, _to;
        string _masp, _lot, _manv, _wo, _loaisp;
        public ExportKhau()
        {
            InitializeComponent();
        }

        private void ExportKhau_Load(object sender, EventArgs e)
        {
            cl.loadcbLoai(cbLoaiSP);
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    using (Entities db = new Entities())
        //    {
        //        var qr = (from s in db.tblQCs
        //                  select s).ToList();
        //        foreach (var tmp in qr)
        //        {
        //            if (isExistDetail(tmp.WOID))
        //            {
        //                //Update
        //                var up = (from s in db.tblQCDetails
        //                          where s.WOID == tmp.WOID
        //                          select s).FirstOrDefault();
        //                if (up.Start2 == null)
        //                {
        //                    up.Start2 = tmp.QCTime_Start;
        //                    up.End2 = tmp.QCTime_End;
        //                    up.User2 = tmp.UserQC;
        //                    goto savepoint;
        //                }
        //                if (up.Start3 == null)
        //                {
        //                    up.Start3 = tmp.QCTime_Start;
        //                    up.End3 = tmp.QCTime_End;
        //                    up.User3 = tmp.UserQC;
        //                    goto savepoint;
        //                }
        //                if (up.Start4 == null)
        //                {
        //                    up.Start4 = tmp.QCTime_Start;
        //                    up.End4 = tmp.QCTime_End;
        //                    up.User4 = tmp.UserQC;
        //                    goto savepoint;
        //                }
        //                if (up.Start5 == null)
        //                {
        //                    up.Start5 = tmp.QCTime_Start;
        //                    up.End5 = tmp.QCTime_End;
        //                    up.User5 = tmp.UserQC;
        //                    goto savepoint;
        //                }
        //                if (up.Start6 == null)
        //                {
        //                    up.Start6 = tmp.QCTime_Start;
        //                    up.End6 = tmp.QCTime_End;
        //                    up.User6 = tmp.UserQC;
        //                    goto savepoint;
        //                }
        //                if (up.Start7 == null)
        //                {
        //                    up.Start7 = tmp.QCTime_Start;
        //                    up.End7 = tmp.QCTime_End;
        //                    up.User7 = tmp.UserQC;
        //                    goto savepoint;
        //                }

        //            savepoint: { }

        //                db.SaveChanges();
        //            }
        //            else
        //            {
        //                //Insert
        //                tblKhauInDetail tb = new tblKhauInDetail();
        //                tb.workorder = tmp.workorder;
        //                tb.WOID = tmp.WOID;
        //                tb.Start1 = tmp.QCTime_Start;
        //                tb.End1 = tmp.QCTime_End;
        //                tb.User1 = tmp.UserQC;
        //                db.tblKhauInDetails.Add(tb);
        //                db.SaveChanges();

        //            }

        //        }

        //        MessageBox.Show("thanh cong");
        //    }
        //}

        //private bool isExistDetail(string _woid)
        //{
        //    bool kq = false;
        //    using (Entities db = new Entities())
        //    {
        //        var qr = (from s in db.tblQCDetails
        //                  where s.WOID == _woid
        //                  select s).FirstOrDefault();
        //        if (qr != null)
        //            kq = true;
        //    }
        //    return kq;
        //}

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
                cl.LoadKhau(grThongtin, _from, _to, _masp, _lot, _manv, _wo, _loaisp);
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
