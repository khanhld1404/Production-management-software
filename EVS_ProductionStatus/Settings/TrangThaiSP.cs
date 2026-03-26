using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVS_ProductionStatus.Settings
{
    public partial class TrangThaiSP : Form
    {
        int thismonth, thisyear, nextmonth, nextyear;
        int sx1, sx2, sx3, sx4, ht1;
        bool isLoaded = false;
        public TrangThaiSP()
        {
            InitializeComponent();
        }

        private void TrangThaiSP_Load(object sender, EventArgs e)
        {
            thismonth = DateTime.Now.Month;
            thisyear = DateTime.Now.Year;
            nextmonth = (DateTime.Now.AddMonths(1)).Month;
            nextyear = (DateTime.Now.AddMonths(1)).Year;
            addContent();
            loadPercent();
            isLoaded = true;
        }

        private void loadPercent()
        {
            try
            {
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    var qrSX1 = (from s in db.tblContents
                              where s.code == "TT_SX_1"
                              select s.content).FirstOrDefault();
                    var qrSX2 = (from s in db.tblContents
                                 where s.code == "TT_SX_2"
                                 select s.content).FirstOrDefault();
                    var qrSX3 = (from s in db.tblContents
                                 where s.code == "TT_SX_3"
                                 select s.content).FirstOrDefault();
                    var qrSX4 = (from s in db.tblContents
                                 where s.code == "TT_SX_4"
                                 select s.content).FirstOrDefault();
                    var qrHT1 = (from s in db.tblContents
                                 where s.code == "TT_HT_1"
                                 select s.content).FirstOrDefault();
                    
                    sx1 = Convert.ToInt32(qrSX1);
                    sx2 = Convert.ToInt32(qrSX2);
                    sx3 = Convert.ToInt32(qrSX3);
                    sx4 = Convert.ToInt32(qrSX4);
                    ht1 = Convert.ToInt32(qrHT1);

                    txtSX1.Text = sx1.ToString();
                    txtSX2.Text = sx2.ToString();
                    txtSX3.Text = sx3.ToString();
                    txtSX4.Text = sx4.ToString();
                    txtHT1.Text = ht1.ToString();

                    lbSX1.Text = string.Format("< {0}%", sx1);
                    lbSX2.Text = string.Format("-{0}%", sx2 - 1);
                    lbSX3.Text = string.Format("-{0}%", sx3 - 1);
                    lbSX4.Text = string.Format("-{0}%", sx4);
                    lbHT1.Text = string.Format("> {0}%", ht1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (isLoaded)
                {
                    lbSX1.Text = string.Format("< {0}%", Convert.ToInt32(txtSX1.Text));
                    lbSX2.Text = string.Format("-{0}%", Convert.ToInt32(txtSX2.Text) - 1);
                    lbSX3.Text = string.Format("-{0}%", Convert.ToInt32(txtSX3.Text) - 1);
                    lbSX4.Text = string.Format("-{0}%", Convert.ToInt32(txtSX4.Text));
                    lbHT1.Text = string.Format("> {0}%", Convert.ToInt32(txtHT1.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu đã nhập không phù hợp, kiểm tra lại \n" + ex.ToString());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    sx1 = Convert.ToInt32(txtSX1.Text);
                    sx2 = Convert.ToInt32(txtSX2.Text);
                    sx3 = Convert.ToInt32(txtSX3.Text);
                    sx4 = Convert.ToInt32(txtSX4.Text);
                    ht1 = Convert.ToInt32(txtHT1.Text);

                    var qrSX1 = (from s in db.tblContents
                                 where s.code == "TT_SX_1"
                                 select s).FirstOrDefault();
                    qrSX1.content = sx1.ToString();

                    var qrSX2 = (from s in db.tblContents
                                 where s.code == "TT_SX_2"
                                 select s).FirstOrDefault();
                    qrSX2.content = sx2.ToString();

                    var qrSX3 = (from s in db.tblContents
                                 where s.code == "TT_SX_3"
                                 select s).FirstOrDefault();
                    qrSX3.content = sx3.ToString();

                    var qrSX4 = (from s in db.tblContents
                                 where s.code == "TT_SX_4"
                                 select s).FirstOrDefault();
                    qrSX4.content = sx4.ToString();

                    var qrHT1 = (from s in db.tblContents
                                 where s.code == "TT_HT_1"
                                 select s).FirstOrDefault();
                    qrHT1.content = ht1.ToString();

                    //lbSX1.Text = string.Format("< {0}%", sx1);
                    //lbSX2.Text = string.Format("-{0}%", sx2 - 1);
                    //lbSX3.Text = string.Format("-{0}%", sx3 - 1);
                    //lbSX4.Text = string.Format("-{0}%", sx4);
                    //lbHT1.Text = string.Format("> {0}%", ht1);

                    db.SaveChanges();
                    MessageBox.Show("Lưu thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void addContent()
        {
            grContent.Rows.Clear();
            grContent.Rows.Add("Tổng số WO đã phát");
            grContent.Rows.Add("Số WO đã hoàn thành");
            grContent.Rows.Add("Số WO đang thao tác");
            grContent.Rows.Add("Số WO tồn");
            grContent.Rows.Add("Tỷ lệ hoàn thành");

            string strThisMonth = thismonth.ToString("00") + "-" + thisyear.ToString("0000");
            string strNextMonth = nextmonth.ToString("00") + "-" + nextyear.ToString("0000");
            grTotal.Columns["totalKitting"].HeaderText = strThisMonth;
            grTotal.Columns["totalKhau"].HeaderText = strThisMonth;
            grTotal.Columns["totalQC"].HeaderText = strThisMonth;
            //grTotal.Columns["totalDongGoi"].HeaderText = strThisMonth;

            grTotal.Columns["totalKittingNext"].HeaderText = strNextMonth;
            grTotal.Columns["totalKhauNext"].HeaderText = strNextMonth;
            grTotal.Columns["totalQCNext"].HeaderText = strNextMonth;
            //grTotal.Columns["totalDongGoiNext"].HeaderText = strNextMonth;

            grTotal.Columns["totalKittingNext"].Visible = false;
            grTotal.Columns["totalKhauNext"].Visible = false;
            grTotal.Columns["totalQCNext"].Visible = false;
            //grTotal.Columns["totalDongGoiNext"].Visible = false;

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                picLoading.Invoke(new Action(() => picLoading.Visible = true));
                string loaisp = "";
                cbLoaiSP.Invoke(new Action(() => loaisp = cbLoaiSP.Text));
                loaddata(loaisp);
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


        private void btnHienThi_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void loaddata(string _loaisp)
        {
            try
            {
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    var qr = db.pro_14_TrangThaiSP(_loaisp).ToList();
                    grThongtin.Invoke(new Action(() => grThongtin.AutoGenerateColumns = false));
                    grThongtin.Invoke(new Action(() => grThongtin.DataSource = qr));
                    formatGridView();

                    //Lấy thông tin tổng hợp WO
                    string cur_wo_string, next_wo_string;

                    cur_wo_string = thisyear.ToString().Substring(2) + thismonth.ToString("00");
                    next_wo_string = nextyear.ToString().Substring(2) + nextmonth.ToString("00");

                    var qr_total = (from s in db.tblWOes
                                    join l in db.v_06_LoaiSP on s.itemnumber equals l.itemnumber
                                    where s.workorder.StartsWith(cur_wo_string) && l.LoaiSP == _loaisp
                                    select s).Count();

                    var qr_total_next = (from s in db.tblWOes
                                         join l in db.v_06_LoaiSP on s.itemnumber equals l.itemnumber
                                         where s.workorder.StartsWith(next_wo_string) && l.LoaiSP == _loaisp
                                         select s).Count();


                    //Bỏ đóng gói
                    ////Dong goi
                    //var dg_ht = (from s in db.tblInputs
                    //             join l in db.v_06_LoaiSP on s.itemnumber equals l.itemnumber
                    //             where s.workorder.StartsWith(cur_wo_string) && l.LoaiSP == _loaisp && s.DongGoi_End != null
                    //             select s).Count();

                    //var dg_ht_next = (from s in db.tblInputs
                    //                  join l in db.v_06_LoaiSP on s.itemnumber equals l.itemnumber
                    //                  where s.workorder.StartsWith(next_wo_string) && l.LoaiSP == _loaisp && s.DongGoi_End != null
                    //                  select s).Count();

                    //var dg_sx = (from s in db.tblInputs
                    //             join l in db.v_06_LoaiSP on s.itemnumber equals l.itemnumber
                    //             where s.workorder.StartsWith(cur_wo_string) && l.LoaiSP == _loaisp
                    //             && s.DongGoi_End == null && s.DongGoi_Start != null
                    //             select s).Count();

                    //var dg_sx_next = (from s in db.tblInputs
                    //                  join l in db.v_06_LoaiSP on s.itemnumber equals l.itemnumber
                    //                  where s.workorder.StartsWith(next_wo_string) && l.LoaiSP == _loaisp
                    //                  && s.DongGoi_End == null && s.DongGoi_Start != null
                    //                  select s).Count();


                    //QC
                    var qc_ht = (from s in db.tblInputs
                                 join l in db.v_06_LoaiSP on s.itemnumber equals l.itemnumber
                                 where s.workorder.StartsWith(cur_wo_string) && l.LoaiSP == _loaisp && s.QCTime_End != null
                                 select s).Count();

                    var qc_ht_next = (from s in db.tblInputs
                                      join l in db.v_06_LoaiSP on s.itemnumber equals l.itemnumber
                                      where s.workorder.StartsWith(next_wo_string) && l.LoaiSP == _loaisp && s.QCTime_End != null
                                      select s).Count();

                    var qc_sx = (from s in db.tblInputs
                                 join l in db.v_06_LoaiSP on s.itemnumber equals l.itemnumber
                                 where s.workorder.StartsWith(cur_wo_string) && l.LoaiSP == _loaisp
                                 && s.QCTime_End == null && s.QCTime_Start != null
                                 select s).Count();

                    var qc_sx_next = (from s in db.tblInputs
                                      join l in db.v_06_LoaiSP on s.itemnumber equals l.itemnumber
                                      where s.workorder.StartsWith(next_wo_string) && l.LoaiSP == _loaisp
                                      && s.QCTime_End == null && s.QCTime_Start != null
                                      select s).Count();


                    //khau
                    var khau_ht = (from s in db.tblInputs
                                   join l in db.v_06_LoaiSP on s.itemnumber equals l.itemnumber
                                   where s.workorder.StartsWith(cur_wo_string) && l.LoaiSP == _loaisp && s.OutTime != null
                                   select s).Count();

                    var khau_ht_next = (from s in db.tblInputs
                                        join l in db.v_06_LoaiSP on s.itemnumber equals l.itemnumber
                                        where s.workorder.StartsWith(next_wo_string) && l.LoaiSP == _loaisp && s.OutTime != null
                                        select s).Count();

                    var khau_sx = (from s in db.tblInputs
                                   join l in db.v_06_LoaiSP on s.itemnumber equals l.itemnumber
                                   where s.workorder.StartsWith(cur_wo_string) && l.LoaiSP == _loaisp
                                   && s.OutTime == null && s.InTime_Start != null
                                   select s).Count();

                    var khau_sx_next = (from s in db.tblInputs
                                        join l in db.v_06_LoaiSP on s.itemnumber equals l.itemnumber
                                        where s.workorder.StartsWith(next_wo_string) && l.LoaiSP == _loaisp
                                        && s.OutTime == null && s.InTime_Start != null
                                        select s).Count();


                    //kitting
                    var kitting_ht = (from s in db.tblInputs
                                      join l in db.v_06_LoaiSP on s.itemnumber equals l.itemnumber
                                      where s.workorder.StartsWith(cur_wo_string) && l.LoaiSP == _loaisp && s.KittingTime_End != null
                                      select s).Count();

                    var kitting_ht_next = (from s in db.tblInputs
                                           join l in db.v_06_LoaiSP on s.itemnumber equals l.itemnumber
                                           where s.workorder.StartsWith(next_wo_string) && l.LoaiSP == _loaisp && s.KittingTime_End != null
                                           select s).Count();

                    var kitting_sx = (from s in db.tblInputs
                                      join l in db.v_06_LoaiSP on s.itemnumber equals l.itemnumber
                                      where s.workorder.StartsWith(cur_wo_string) && l.LoaiSP == _loaisp
                                      && s.KittingTime_End == null && s.KittingTime_Start != null
                                      select s).Count();

                    var kitting_sx_next = (from s in db.tblInputs
                                           join l in db.v_06_LoaiSP on s.itemnumber equals l.itemnumber
                                           where s.workorder.StartsWith(next_wo_string) && l.LoaiSP == _loaisp
                                           && s.KittingTime_End == null && s.KittingTime_Start != null
                                           select s).Count();

                    grTotal.Invoke(new Action(() =>
                    {
                        grTotal.Rows.Clear();
                        grTotal.Rows.Add(qr_total, qr_total_next, qr_total, qr_total_next, qr_total, qr_total_next, qr_total, qr_total_next);
                        grTotal.Rows.Add(kitting_ht, kitting_ht_next, khau_ht, khau_ht_next, qc_ht, qc_ht_next);
                        grTotal.Rows.Add(kitting_sx, kitting_sx_next, khau_sx, khau_sx_next, qc_sx, qc_sx_next);
                        grTotal.Rows.Add(qr_total - kitting_ht - kitting_sx, qr_total_next - kitting_ht_next - kitting_sx_next,
                            qr_total - khau_ht - khau_sx, qr_total_next - khau_ht_next - khau_sx_next,
                            qr_total - qc_ht - qc_sx, qr_total_next - qc_ht_next - qc_sx_next);
                        grTotal.Rows.Add(((double)kitting_ht / (qr_total == 0 ? 1 : qr_total)).ToString("0.## %"), ((double)kitting_ht_next / (qr_total_next == 0 ? 1 : qr_total_next)).ToString("0.## %"),
                            ((double)khau_ht / (qr_total == 0 ? 1 : qr_total)).ToString("0.## %"), ((double)khau_ht_next / (qr_total_next == 0 ? 1 : qr_total_next)).ToString("0.## %"),
                            ((double)qc_ht / (qr_total == 0 ? 1 : qr_total)).ToString("0.## %"), ((double)qc_ht_next / (qr_total_next == 0 ? 1 : qr_total_next)).ToString("0.## %"));

                        if (qr_total_next > 0)
                        {
                            grTotal.Columns["totalKittingNext"].Visible = true;
                            grTotal.Columns["totalKhauNext"].Visible = true;
                            grTotal.Columns["totalQCNext"].Visible = true;
                            //grTotal.Columns["totalDongGoiNext"].Visible = true;
                        }
                        else
                        {
                            grTotal.Columns["totalKittingNext"].Visible = false;
                            grTotal.Columns["totalKhauNext"].Visible = false;
                            grTotal.Columns["totalQCNext"].Visible = false;
                            //grTotal.Columns["totalDongGoiNext"].Visible = false;
                        }
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void formatGridView()
        {
            try
            {
                string khau_value, qc_value, kitting_value, trangthai;                
                grThongtin.Invoke(new Action(() =>
                {
                    foreach (DataGridViewRow r in grThongtin.Rows)
                    {
                        trangthai = r.Cells["TrangThai"].Value == null ? "" : r.Cells["TrangThai"].Value.ToString();
                        khau_value = r.Cells["KhauTime"].Value == null ? "" : r.Cells["KhauTime"].Value.ToString();
                        //dg_value = r.Cells["DGTime"].Value == null ? "" : r.Cells["DGTime"].Value.ToString();
                        qc_value = r.Cells["QCTime"].Value == null ? "" : r.Cells["QCTime"].Value.ToString();
                        kitting_value = r.Cells["KittingTime"].Value == null ? "" : r.Cells["KittingTime"].Value.ToString();

                        //if (dg_value != "")
                        //{
                        //    r.Cells["DGTime"].Style.BackColor = Color.Yellow;
                        //    r.Cells["QCTime"].Style.BackColor = Color.Green;
                        //    if (khau_value.Contains("%"))
                        //    {
                        //        int val = Convert.ToInt32(khau_value.Substring(0, khau_value.Length - 2));
                        //        if (val <= 100)
                        //            r.Cells["KhauTime"].Style.BackColor = Color.LimeGreen;
                        //        else
                        //            r.Cells["KhauTime"].Style.BackColor = Color.Pink;

                        //    }
                        //    else
                        //    {
                        //        r.Cells["KhauTime"].Style.BackColor = Color.Green;
                        //    }
                        //    r.Cells["KittingTime"].Style.BackColor = Color.Green;
                        //    continue;
                        //}
                        if (trangthai == "1.QC")
                        {
                            r.Cells["QCTime"].Style.BackColor = Color.Yellow;
                            if (khau_value.Contains("%"))
                            {
                                int val = Convert.ToInt32(khau_value.Substring(0, khau_value.Length - 2));
                                if (val <= ht1)
                                    r.Cells["KhauTime"].Style.BackColor = Color.LimeGreen;
                                else
                                    r.Cells["KhauTime"].Style.BackColor = Color.Pink;

                            }
                            else
                            {
                                r.Cells["KhauTime"].Style.BackColor = Color.Green;
                            }
                            r.Cells["KittingTime"].Style.BackColor = Color.Green;
                            r.Cells["StartKhau"].Style.BackColor = r.Cells["KhauTime"].Style.BackColor;
                            continue;
                        }

                        if (trangthai == "2.KhauOut")
                        {
                            if (khau_value.Contains("%"))
                            {
                                int val = Convert.ToInt32(khau_value.Substring(0, khau_value.Length - 2));
                                if (val <= ht1)
                                    r.Cells["KhauTime"].Style.BackColor = Color.LimeGreen;
                                else
                                    r.Cells["KhauTime"].Style.BackColor = Color.Pink;

                            }
                            r.Cells["KittingTime"].Style.BackColor = Color.Green;
                            r.Cells["StartKhau"].Style.BackColor = r.Cells["KhauTime"].Style.BackColor;
                        }

                        if (trangthai == "3.Khau")
                        {
                            if (khau_value.Contains("%"))
                            {
                                int val = Convert.ToInt32(khau_value.Substring(0, khau_value.Length - 2));
                                if (val < sx1)
                                {
                                    r.Cells["KhauTime"].Style.BackColor = Color.Moccasin;
                                    goto jump_point;
                                }
                                if (val < sx2)
                                {
                                    r.Cells["KhauTime"].Style.BackColor = Color.Olive;
                                    goto jump_point;
                                }
                                if (val < sx3)
                                {
                                    r.Cells["KhauTime"].Style.BackColor = Color.Aquamarine;
                                    goto jump_point;
                                }
                                if (val <= sx4)
                                {
                                    r.Cells["KhauTime"].Style.BackColor = Color.LightSeaGreen;
                                    goto jump_point;
                                }
                                else
                                    r.Cells["KhauTime"].Style.BackColor = Color.Thistle;

                            }
                            else
                            {
                                r.Cells["KhauTime"].Style.BackColor = Color.Yellow;
                            }
                        jump_point:
                            r.Cells["KittingTime"].Style.BackColor = Color.Green;
                            r.Cells["StartKhau"].Style.BackColor = r.Cells["KhauTime"].Style.BackColor;
                            continue;
                        }

                        if (trangthai == "4.KittingEnd")
                        {
                            r.Cells["KittingTime"].Style.BackColor = Color.Green;
                            continue;
                        }

                        if (trangthai == "5.KittingStart")
                        {
                            r.Cells["KittingTime"].Style.BackColor = Color.Yellow;
                            continue;
                        }
                    }
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (grThongtin.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.FileName = DateTime.Now.ToString("yyMMddHHmmss") + "_DataExport";
                    saveFileDialog1.DefaultExt = "xlsx";
                    saveFileDialog1.Filter = "Excel file |*.xlsx";
                    saveFileDialog1.FilterIndex = 1;

                    var result = saveFileDialog1.ShowDialog();
                    FileInfo fileInfo = new FileInfo(Path.GetFullPath(saveFileDialog1.FileName));
                    if (result == DialogResult.OK)
                    {
                        if (File.Exists(Path.GetFullPath(saveFileDialog1.FileName)))
                        {
                            File.Delete(Path.GetFullPath(saveFileDialog1.FileName));
                        }

                        using (ExcelPackage p = new ExcelPackage(fileInfo))
                        {
                            var ws = p.Workbook.Worksheets.Add("Data");

                            for (int row = 0; row < grThongtin.Rows.Count; row++)
                            {
                                int excelcol = 1;
                                for (int col = 0; col < grThongtin.Columns.Count; col++)
                                {
                                    if (grThongtin.Columns[col].Visible == true)
                                    {
                                        if (row == 0)
                                        {
                                            ws.Cells[1, excelcol].Value = grThongtin.Columns[col].HeaderText;
                                        }
                                        ws.Cells[row + 2, excelcol].Value = grThongtin.Rows[row].Cells[col].Value;
                                        excelcol++;

                                        //Các cột tên Start / End được hiểu là cột thời gian thao tác >> thay đổi định dạng
                                        if (grThongtin.Columns[col].Name.Contains("Kitting") || grThongtin.Columns[col].Name.Contains("QC") ||
                                            grThongtin.Columns[col].Name.Contains("Bắt đầu khâu"))
                                        {
                                            ws.Column(col + 1).Style.Numberformat.Format = "dd/mm/yyyy hh:mm";
                                        }
                                    }
                                }
                            }

                            ws.Cells[ws.Dimension.Address].AutoFitColumns();

                            p.Save();
                            MessageBox.Show("Xuất file thành công");
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
