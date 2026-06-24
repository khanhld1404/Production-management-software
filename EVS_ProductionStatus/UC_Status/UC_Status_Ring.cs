using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EVS_Management.Data_EVS;

namespace EVS_Management
{
    public partial class UC_Status_Ring : UserControl
    {
        public delegate void del_UCClick();
        public event del_UCClick event_UCClick;

        string product_type_code;
        string WOPlanCode = "", WOKittingCode = "", WOKhauInCode = "", WOKhauOutCode = "", WOPlanCode_Next = "", WOQCCode = "", WODGCode = "";

        public UC_Status_Ring(string _type)
        {
            InitializeComponent();
            product_type_code = _type;
        }

        public UC_Status_Ring()
        {
            InitializeComponent();
        }

        public void loaddata()
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string desc_string = "";
                switch (product_type_code)
                {
                    case "Ring":
                        desc_string = "S";
                        WOPlanCode = "WO_KH_R";
                        WOKittingCode = "KITTING_KH_R";
                        WOKhauInCode = "IN_KH_R";
                        WOKhauOutCode = "OUT_KH_R";
                        WOPlanCode_Next = "WO_KH_NEXT_R";
                        WOQCCode = "QC_KH_R";
                        WODGCode = "DG_KH_R";
                        break;
                }

                string cur_wo_string, next_wo_string;
                int thismonth, thisyear, nextmonth, nextyear;
                thismonth = DateTime.Now.Month;
                thisyear = DateTime.Now.Year;
                nextmonth = (DateTime.Now.AddMonths(1)).Month;
                nextyear = (DateTime.Now.AddMonths(1)).Year;

                cur_wo_string = thisyear.ToString().Substring(2) + thismonth.ToString("00");
                next_wo_string = nextyear.ToString().Substring(2) + nextmonth.ToString("00");


                using (DB_Entities db = new DB_Entities(clConnection.connectEntity))
                {
                    using (Manage_evsEntities wodb = new Manage_evsEntities(clConnection.connectEntity2))
                    {
                        var find_status = new List<string> { "TECO - Technically completed", "REL - Released" };

                        var qr_root = wodb.tblWOes
                                     .Where(s => find_status.Contains(s.STATUS)
                                     && s.PROD_LINE == "EVS"
                                     && s.MES_PART.Contains("EV036"))
                                     .AsEnumerable();
                        int qr_total = 0, qr_total_next = 0;

                        qr_total = qr_root
                            .Where(s => s.WORK_ORDER_ID.Substring(1).StartsWith(cur_wo_string))
                            .Select(s => s.WORK_ORDER_ID + s.WORK_ORDER + s.WO_PART)
                            .Distinct()
                            .Count();
                        qr_total_next = qr_root
                            .Where(s => s.WORK_ORDER_ID.Substring(1).StartsWith(next_wo_string))
                            .Select(s => s.WORK_ORDER_ID + s.WORK_ORDER + s.WO_PART)
                            .Distinct()
                            .Count();

                        //Nếu có 2 tháng gần nhau thì hiển thị phân chia thành 2 tháng Panel
                        if (qr_total_next > 0)
                        {
                            pnWOKH.Invoke(new Action(() => pnWOKH.Visible = true));
                            pnTongWO.Invoke(new Action(() => pnTongWO.Visible = true));
                            pnHoanThanh.Invoke(new Action(() => pnHoanThanh.Visible = true));
                            pnChuaHT.Invoke(new Action(() => pnChuaHT.Visible = true));
                        }
                        else
                        {
                            pnWOKH.Invoke(new Action(() => pnWOKH.Visible = false));
                            pnTongWO.Invoke(new Action(() => pnTongWO.Visible = false));
                            pnHoanThanh.Invoke(new Action(() => pnHoanThanh.Visible = false));
                            pnChuaHT.Invoke(new Action(() => pnChuaHT.Visible = false));
                        }

                        //Lấy số lượng WO hoàn thành của 2 tháng
                        var qr_root_complete = wodb.tblWOes
                                              .Where(s => s.STATUS == "TECO - Technically completed"
                                              && s.PROD_LINE == "EVS"
                                              && s.MES_PART.Contains("EV036"))
                                              .AsEnumerable()
                                              .Where(s => Decimal.TryParse(s.COMPLETE_QTY, out decimal qty) && qty > 0);
                        var qr_complete = qr_root_complete
                                .Where(s => s.WORK_ORDER_ID.Substring(1).StartsWith(cur_wo_string))
                                .Select(s => s.WORK_ORDER_ID + s.WORK_ORDER + s.WO_PART)
                                .Distinct()
                                .Count();
                        var qr_complete_next = qr_root_complete
                                .Where(s => s.WORK_ORDER_ID.Substring(1).StartsWith(next_wo_string))
                                .Select(s => s.WORK_ORDER_ID + s.WORK_ORDER + s.WO_PART)
                                .Distinct()
                                .Count();

                        //Lấy số WO chưa hoàn thành của 2 tháng
                        int chuaHT = qr_total - qr_complete;
                        int chuaHT_next = qr_total_next - qr_complete_next;

                        //Gán số lượng vào các label để hiển thị và hiển thị giá trị tháng năm
                        lbTongWO.Invoke(new Action(() => lbTongWO.Text = qr_total.ToString()));
                        lbTongWO_Cur.Invoke(new Action(() => lbTongWO_Cur.Text = qr_total.ToString()));
                        lbTongWO_Next.Invoke(new Action(() => lbTongWO_Next.Text = qr_total_next.ToString()));

                        lbHoanThanh.Invoke(new Action(() => lbHoanThanh.Text = qr_complete.ToString()));
                        lbHoanThanh_Cur.Invoke(new Action(() => lbHoanThanh_Cur.Text = qr_complete.ToString()));
                        lbHoanThanh_Next.Invoke(new Action(() => lbHoanThanh_Next.Text = qr_complete_next.ToString()));

                        lbChuaHT.Invoke(new Action(() => lbChuaHT.Text = chuaHT.ToString()));
                        lbChuaHT_Cur.Invoke(new Action(() => lbChuaHT_Cur.Text = chuaHT.ToString()));
                        lbChuaHT_Next.Invoke(new Action(() => lbChuaHT_Next.Text = chuaHT_next.ToString()));

                        lbWOKHMonth_Cur.Invoke(new Action(() => lbWOKHMonth_Cur.Text = string.Format("{0:00}-{1}", thismonth, thisyear)));
                        lbTongWOMonth_Cur.Invoke(new Action(() => lbTongWOMonth_Cur.Text = string.Format("{0:00}-{1}", thismonth, thisyear)));
                        lbChuaHTMonth_Cur.Invoke(new Action(() => lbChuaHTMonth_Cur.Text = string.Format("{0:00}-{1}", thismonth, thisyear)));
                        lbHoanThanhMonth_Cur.Invoke(new Action(() => lbHoanThanhMonth_Cur.Text = string.Format("{0:00}-{1}", thismonth, thisyear)));

                        lbWOKHMonth_Next.Invoke(new Action(() => lbWOKHMonth_Next.Text = string.Format("{0:00}-{1}", nextmonth, nextyear)));
                        lbTongWOMonth_Next.Invoke(new Action(() => lbTongWOMonth_Next.Text = string.Format("{0:00}-{1}", nextmonth, nextyear)));
                        lbChuaHTMonth_Next.Invoke(new Action(() => lbChuaHTMonth_Next.Text = string.Format("{0:00}-{1}", nextmonth, nextyear)));
                        lbHoanThanhMonth_Next.Invoke(new Action(() => lbHoanThanhMonth_Next.Text = string.Format("{0:00}-{1}", nextmonth, nextyear)));

                        var qr_TotalKitting = db.tblInput_Ring
                                              .Where(x => x.KittingTime_End != null && x.WOID.Substring(1).StartsWith(cur_wo_string))
                                              .Count();

                        var qr_TotalKitting_next = db.tblInput_Ring
                                              .Where(x => x.KittingTime_End != null && x.WOID.Substring(1).StartsWith(next_wo_string))
                                              .Count();

                        var qr_TodayKitting = db.tblInput_Ring
                                              .Where(x => x.KittingTime_End != null && x.KittingTime_End >= DateTime.Today)
                                              .Count();

                        var qr_TotalQC = db.tblInput_Ring
                                              .Where(x => x.QCTime_Start != null && x.WOID.Substring(1).StartsWith(cur_wo_string))
                                              .Count();

                        var qr_TotalQC_next = db.tblInput_Ring
                                              .Where(x => x.QCTime_Start != null && x.WOID.Substring(1).StartsWith(next_wo_string))
                                              .Count();

                        DateTime time_end = DateTime.Today.AddDays(1);

                        var qr_TodayQC = db.tblInput_Ring
                                              .Where(x => x.QCTime_Start != null 
                                              && x.QCTime_End >= DateTime.Today && x.QCTime_End < time_end)
                                              .Count();
                        //
                        //Nếu có số tháng tiếp thì lấy k thì lấy tháng hiện tại
                        if (Convert.ToInt32(qr_TotalKitting_next) != 0)
                        {
                            lbKittingTotal.Invoke(new Action(() => lbKittingTotal.Text = qr_TotalKitting_next.ToString() == "" ? "0" : qr_TotalKitting_next.ToString()));
                            lbMonthKitting.Invoke(new Action(() => lbMonthKitting.Text = lbWOKHMonth_Next.Text));
                        }
                        else
                        {
                            lbKittingTotal.Invoke(new Action(() => lbKittingTotal.Text = qr_TotalKitting.ToString() == "" ? "0" : qr_TotalKitting.ToString()));
                            lbMonthKitting.Invoke(new Action(() => lbMonthKitting.Text = lbWOKHMonth_Cur.Text));
                        }

                        //Nếu có số tháng tiếp thì lấy k thì lấy tháng hiện tại
                        if (Convert.ToInt32(qr_TotalQC_next) != 0)
                        {
                            lbQCTotal.Invoke(new Action(() => lbQCTotal.Text = qr_TotalQC_next.ToString() == "" ? "0" : qr_TotalQC_next.ToString()));
                            lbMonthQC.Invoke(new Action(() => lbMonthQC.Text = lbWOKHMonth_Next.Text));
                        }
                        else
                        {
                            lbQCTotal.Invoke(new Action(() => lbQCTotal.Text = qr_TotalQC.ToString() == "" ? "0" : qr_TotalQC.ToString()));
                            lbMonthQC.Invoke(new Action(() => lbMonthQC.Text = lbWOKHMonth_Cur.Text));
                        }


                        lbKittingToday.Invoke(new Action(() => lbKittingToday.Text = qr_TodayKitting.ToString() == "" ? "0" : qr_TodayKitting.ToString()));
                        lbQCToday.Invoke(new Action(() => lbQCToday.Text = qr_TodayQC.ToString() == "" ? "0" : qr_TodayQC.ToString()));

                        int chuasx;
                        //Nếu có tháng mới thì cập nhật theo tháng mới
                        if (qr_total_next > 0)
                        {
                            chuasx = qr_total_next - qr_TotalKitting_next;
                        }
                        else
                        {
                            chuasx = qr_total - qr_TotalKitting;
                        }

                        lbNotyetTotal.Invoke(new Action(() => lbNotyetTotal.Text = chuasx.ToString()));
                        


                        var qr_woplan = (from s in db.tblContents
                                         where s.code == WOPlanCode
                                         select s.content).FirstOrDefault();
                        lbWOKH.Invoke(new Action(() => lbWOKH.Text = qr_woplan));
                        lbWOKH_Cur.Invoke(new Action(() => lbWOKH_Cur.Text = qr_woplan));

                        var qr_woplan_next = (from s in db.tblContents
                                              where s.code == WOPlanCode_Next
                                              select s.content).FirstOrDefault();
                        lbWOKH_Next.Invoke(new Action(() => lbWOKH_Next.Text = qr_woplan_next));

                        var qr_wokitting = (from s in db.tblContents
                                            where s.code == WOKittingCode
                                            select s.content).FirstOrDefault();
                        lbWOKitting.Invoke(new Action(() => lbWOKitting.Text = qr_wokitting));


                        var qr_woqc = (from s in db.tblContents
                                       where s.code == WOQCCode
                                       select s.content).FirstOrDefault();
                        lbWOQC.Invoke(new Action(() => lbWOQC.Text = qr_woqc));


                        lbChenhLechKitting.Invoke(new Action(() => lbChenhLechKitting.Text = (Convert.ToInt32(lbKittingToday.Text) - Convert.ToInt32(lbWOKitting.Text)).ToString()));
                        lbChenhLechQC.Invoke(new Action(() => lbChenhLechQC.Text = (Convert.ToInt32(lbQCToday.Text) - Convert.ToInt32(lbWOQC.Text)).ToString()));
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Thiết lập lại số lượng kế hoạch WO
        private void lbWOKH_Click(object sender, EventArgs e)
        {
            InputForm f = new InputForm(WOPlanCode);
            if (f.ShowDialog() == DialogResult.OK)
            {
                loaddata();
            }
        }

        private void UC_Status_Click(object sender, EventArgs e)
        {
            event_UCClick();
        }

        private void lbWOKH_Next_Click(object sender, EventArgs e)
        {
            InputForm f = new InputForm(WOPlanCode_Next);
            if (f.ShowDialog() == DialogResult.OK)
            {
                loaddata();
            }
        }

        private void lbWOKitting_Click(object sender, EventArgs e)
        {
            InputForm f = new InputForm(WOKittingCode);
            if (f.ShowDialog() == DialogResult.OK)
            {
                loaddata();
            }
        }


        private void lbWOQC_Click(object sender, EventArgs e)
        {
            InputForm f = new InputForm(WOQCCode);
            if (f.ShowDialog() == DialogResult.OK)
            {
                loaddata();
            }
        }

    }
}
