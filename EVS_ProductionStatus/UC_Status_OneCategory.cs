using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVS_ProductionStatus
{
    public partial class UC_Status_OneCategory : UserControl
    {
        public delegate void del_UCClick();
        public event del_UCClick event_UCClick;

        string product_type_code;
        string WOPlanCode = "", WOKittingCode = "", WOKhauInCode = "", WOKhauOutCode = "", WOPlanCode_Next = "", WOQCCode = "", WODGCode = "";

        public UC_Status_OneCategory(string _type)
        {
            InitializeComponent();
            product_type_code = _type;
        }

        public UC_Status_OneCategory()
        {
            InitializeComponent();
        }

        public void loaddata()
        {
            if (product_type_code == "ANA")
            {
                backgroundWorker2.RunWorkerAsync();
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
                string desc_string = "";
                switch (product_type_code)
                {
                    case "THORA":
                        desc_string = "Gen";
                        WOPlanCode = "WO_KH_THORA";
                        WOKittingCode = "KITTING_KH_THORA";
                        WOKhauInCode = "IN_KH_THORA";
                        WOKhauOutCode = "OUT_KH_THORA";
                        WOPlanCode_Next = "WO_KH_NEXT_THORA";
                        WOQCCode = "QC_KH_THORA";
                        WODGCode = "DG_KH_THORA";
                        break;
                    case "TREO":
                        desc_string = "Treo";
                        WOPlanCode = "WO_KH_TREO";
                        WOKittingCode = "KITTING_KH_TREO";
                        WOKhauInCode = "IN_KH_TREO";
                        WOKhauOutCode = "OUT_KH_TREO";
                        WOPlanCode_Next = "WO_KH_NEXT_TREO";
                        WOQCCode = "QC_KH_TREO";
                        WODGCode = "DG_KH_TREO";
                        break;
                    case "RELAY":
                        desc_string = "Stent";
                        WOPlanCode = "WO_KH";
                        WOKittingCode = "KITTING_KH";
                        WOKhauInCode = "IN_KH";
                        WOKhauOutCode = "OUT_KH";
                        WOPlanCode_Next = "WO_KH_NEXT";
                        WOQCCode = "QC_KH";
                        WODGCode = "DG_KH";
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


                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    var qr_total = (from s in db.tblWOes
                                    where s.workorder.StartsWith(cur_wo_string) && s.desc2.StartsWith(desc_string)
                                    select s).Count();

                    var qr_total_next = (from s in db.tblWOes
                                         where s.workorder.StartsWith(next_wo_string) && s.desc2.StartsWith(desc_string)
                                         select s).Count();

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
                    var qr_complete = (from s in db.tblWOes
                                       where s.wostatus == "C" && s.workorder.StartsWith(cur_wo_string) && s.desc2.StartsWith(desc_string)
                                       select s).Count();
                    var qr_complete_next = (from s in db.tblWOes
                                            where s.wostatus == "C" && s.workorder.StartsWith(next_wo_string) && s.desc2.StartsWith(desc_string)
                                            select s).Count();

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


                    var qr_TotalKitting = (from tmp in db.tblInputs
                                           where tmp.KittingTime_End != null && tmp.workorder.StartsWith(cur_wo_string) && tmp.desc2.StartsWith(desc_string)
                                           select tmp.qty).Sum();

                    var qr_TotalKitting_next = (from tmp in db.tblInputs
                                                where tmp.KittingTime_End != null && tmp.workorder.StartsWith(next_wo_string) && tmp.desc2.StartsWith(desc_string)
                                                select tmp.qty).Sum();

                    var qr_TodayKitting = (from tmp in db.tblInputs
                                           where tmp.KittingTime_End != null && tmp.KittingTime_End >= DateTime.Today && tmp.desc2.StartsWith(desc_string)
                                           select tmp.qty).Sum();

                    var qr_TotalIn = (from tmp in db.tblInputs
                                      where tmp.InTime_Start != null && tmp.workorder.StartsWith(cur_wo_string) && tmp.desc2.StartsWith(desc_string)
                                      select tmp.qty).Sum();

                    var qr_TotalIn_next = (from tmp in db.tblInputs
                                           where tmp.InTime_Start != null && tmp.workorder.StartsWith(next_wo_string) && tmp.desc2.StartsWith(desc_string)
                                           select tmp.qty).Sum();

                    var qr_TodayIn = (from tmp in db.tblInputs
                                      where tmp.InTime_Start != null && tmp.InTime_Start >= DateTime.Today && tmp.desc2.StartsWith(desc_string)
                                      select tmp.qty).Sum();

                    var qr_TotalOut = (from tmp in db.tblInputs
                                       where tmp.OutTime != null && tmp.workorder.StartsWith(cur_wo_string) && tmp.desc2.StartsWith(desc_string)
                                       select tmp.qty).Sum();

                    var qr_TotalOut_next = (from tmp in db.tblInputs
                                            where tmp.OutTime != null && tmp.workorder.StartsWith(next_wo_string) && tmp.desc2.StartsWith(desc_string)
                                            select tmp.qty).Sum();

                    var qr_TodayOut = (from tmp in db.tblInputs
                                       where tmp.OutTime != null && tmp.OutTime >= DateTime.Today && tmp.desc2.StartsWith(desc_string)
                                       select tmp.qty).Sum();

                    var qr_TotalQC = (from tmp in db.tblInputs
                                      where tmp.QCTime_Start != null && tmp.workorder.StartsWith(cur_wo_string) && tmp.desc2.StartsWith(desc_string)
                                      select tmp.qty).Sum();

                    var qr_TotalQC_next = (from tmp in db.tblInputs
                                           where tmp.QCTime_Start != null && tmp.workorder.StartsWith(next_wo_string) && tmp.desc2.StartsWith(desc_string)
                                           select tmp.qty).Sum();

                    //var qr_TodayQC = (from tmp in db.tblInputs
                    //                  where tmp.QCTime_Start != null && tmp.QCTime_Start >= DateTime.Today && tmp.desc2.StartsWith(desc_string)
                    //                  select tmp.qty).Sum();
                    DateTime time_end = DateTime.Today.AddDays(1);
                    var qr_TodayQC = (from tmp in db.tblInputs
                                      where tmp.QCTime_Start != null && 
                                      (tmp.QCTime_End >= DateTime.Today && tmp.QCTime_End < time_end)
                                      && tmp.desc2.StartsWith(desc_string)
                                      select tmp.qty).Sum();

                    var qr_TotalDG = (from tmp in db.tblInputs
                                      where tmp.DongGoi_Start != null && tmp.workorder.StartsWith(cur_wo_string) && tmp.desc2.StartsWith(desc_string)
                                      select tmp.qty).Sum();

                    var qr_TotalDG_next = (from tmp in db.tblInputs
                                           where tmp.DongGoi_Start != null && tmp.workorder.StartsWith(next_wo_string) && tmp.desc2.StartsWith(desc_string)
                                           select tmp.qty).Sum();

                    //var qr_TodayDG = (from tmp in db.tblInputs
                    //                  where tmp.DongGoi_Start != null && tmp.DongGoi_Start >= DateTime.Today && tmp.desc2.StartsWith(desc_string)
                    //                  select tmp.qty).Sum();
                    var qr_TodayDG = (from tmp in db.tblInputs
                                      where tmp.DongGoi_Start != null && 
                                      ( tmp.DongGoi_End >= DateTime.Today && tmp.DongGoi_End< time_end) && 
                                        tmp.desc2.StartsWith(desc_string)
                                      select tmp.qty).Sum();

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
                    if (Convert.ToInt32(qr_TotalIn_next) != 0)
                    {
                        lbInTotal.Invoke(new Action(() => lbInTotal.Text = qr_TotalIn_next.ToString() == "" ? "0" : qr_TotalIn_next.ToString()));
                        lbMonthIn.Invoke(new Action(() => lbMonthIn.Text = lbWOKHMonth_Next.Text));
                    }
                    else
                    {
                        lbInTotal.Invoke(new Action(() => lbInTotal.Text = qr_TotalIn.ToString() == "" ? "0" : qr_TotalIn.ToString()));
                        lbMonthIn.Invoke(new Action(() => lbMonthIn.Text = lbWOKHMonth_Cur.Text));
                    }

                    //Nếu có số tháng tiếp thì lấy k thì lấy tháng hiện tại
                    if (Convert.ToInt32(qr_TotalOut_next) != 0)
                    {
                        lbOutTotal.Invoke(new Action(() => lbOutTotal.Text = qr_TotalOut_next.ToString() == "" ? "0" : qr_TotalOut_next.ToString()));
                        lbMonthOut.Invoke(new Action(() => lbMonthOut.Text = lbWOKHMonth_Next.Text));
                    }
                    else
                    {
                        lbOutTotal.Invoke(new Action(() => lbOutTotal.Text = qr_TotalOut.ToString() == "" ? "0" : qr_TotalOut.ToString()));
                        lbMonthOut.Invoke(new Action(() => lbMonthOut.Text = lbWOKHMonth_Cur.Text));
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

                    if (Convert.ToInt32(qr_TotalDG_next) != 0)
                    {
                        lbDGTotal.Invoke(new Action(() => lbDGTotal.Text = qr_TotalDG_next.ToString() == "" ? "0" : qr_TotalDG_next.ToString()));
                        lbMonthDG.Invoke(new Action(() => lbMonthDG.Text = lbWOKHMonth_Next.Text));
                    }
                    else
                    {
                        lbDGTotal.Invoke(new Action(() => lbDGTotal.Text = qr_TotalDG.ToString() == "" ? "0" : qr_TotalDG.ToString()));
                        lbMonthDG.Invoke(new Action(() => lbMonthDG.Text = lbWOKHMonth_Cur.Text));
                    }

                    lbKittingToday.Invoke(new Action(() => lbKittingToday.Text = qr_TodayKitting.ToString() == "" ? "0" : qr_TodayKitting.ToString()));
                    lbInToday.Invoke(new Action(() => lbInToday.Text = qr_TodayIn.ToString() == "" ? "0" : qr_TodayIn.ToString()));
                    lbOutToday.Invoke(new Action(() => lbOutToday.Text = qr_TodayOut.ToString() == "" ? "0" : qr_TodayOut.ToString()));
                    lbQCToday.Invoke(new Action(() => lbQCToday.Text = qr_TodayQC.ToString() == "" ? "0" : qr_TodayQC.ToString()));
                    lbDGToday.Invoke(new Action(() => lbDGToday.Text = qr_TodayDG.ToString() == "" ? "0" : qr_TodayDG.ToString()));


                    int chuasx;
                    //Nếu có tháng mới thì cập nhật theo tháng mới
                    if (qr_total_next > 0)
                    {
                        chuasx = qr_total_next - (qr_TotalKitting_next ?? 0);
                    }
                    else
                    {
                        chuasx = qr_total - (qr_TotalKitting ?? 0);
                    }

                    lbNotyetTotal.Invoke(new Action(() => lbNotyetTotal.Text = chuasx.ToString()));

                    int tonkitting = (qr_TotalKitting ?? 0) + (qr_TotalKitting_next ?? 0) - (qr_TotalIn ?? 0) - (qr_TotalIn_next ?? 0);
                    lbTonKitting.Invoke(new Action(() => lbTonKitting.Text = tonkitting.ToString()));

                    int sodangkhau = (qr_TotalIn ?? 0) + (qr_TotalIn_next ?? 0) - (qr_TotalOut ?? 0) - (qr_TotalOut_next ?? 0);
                    lbSoDangKhau.Invoke(new Action(() => lbSoDangKhau.Text = sodangkhau.ToString()));

                    //2023-07: thêm số tồn khâu
                    int tonkhau = (qr_TotalOut ?? 0) + (qr_TotalOut_next ?? 0) - (qr_TotalQC ?? 0) - (qr_TotalQC_next ?? 0);
                    lbTonKhau.Invoke(new Action(() => lbTonKhau.Text = tonkhau.ToString()));

                    //Số chưa đóng gói = số WO đã chuyển thành C - số đã kết thúc do người dùng quét    
                    //Cập nhật thành: Số chưa đg = số wo thành C của tháng này + tháng sau - (số đã kết thúc DG tháng này + tháng sau)
                    int chuaDG = qr_complete_next + qr_complete - Convert.ToInt32(qr_TotalDG_next) - Convert.ToInt32(qr_TotalDG);
                    lbChuaDG.Invoke(new Action(() => lbChuaDG.Text = chuaDG.ToString()));

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

                    var qr_wokhauin = (from s in db.tblContents
                                       where s.code == WOKhauInCode
                                       select s.content).FirstOrDefault();
                    lbWOKhauIn.Invoke(new Action(() => lbWOKhauIn.Text = qr_wokhauin));

                    var qr_wokhauout = (from s in db.tblContents
                                        where s.code == WOKhauOutCode
                                        select s.content).FirstOrDefault();
                    lbWOKhauOut.Invoke(new Action(() => lbWOKhauOut.Text = qr_wokhauout));

                    var qr_woqc = (from s in db.tblContents
                                   where s.code == WOQCCode
                                   select s.content).FirstOrDefault();
                    lbWOQC.Invoke(new Action(() => lbWOQC.Text = qr_woqc));

                    var qr_wodg = (from s in db.tblContents
                                   where s.code == WODGCode
                                   select s.content).FirstOrDefault();
                    lbWODG.Invoke(new Action(() => lbWODG.Text = qr_wodg));

                    lbChenhLechKitting.Invoke(new Action(() => lbChenhLechKitting.Text = (Convert.ToInt32(lbKittingToday.Text) - Convert.ToInt32(lbWOKitting.Text)).ToString()));
                    lbChenhLechKhauIn.Invoke(new Action(() => lbChenhLechKhauIn.Text = (Convert.ToInt32(lbInToday.Text) - Convert.ToInt32(lbWOKhauIn.Text)).ToString()));
                    lbChenhLechKhauOut.Invoke(new Action(() => lbChenhLechKhauOut.Text = (Convert.ToInt32(lbOutToday.Text) - Convert.ToInt32(lbWOKhauOut.Text)).ToString()));
                    lbChenhLechQC.Invoke(new Action(() => lbChenhLechQC.Text = (Convert.ToInt32(lbQCToday.Text) - Convert.ToInt32(lbWOQC.Text)).ToString()));
                    lbChenhLechDG.Invoke(new Action(() => lbChenhLechDG.Text = (Convert.ToInt32(lbDGToday.Text) - Convert.ToInt32(lbWODG.Text)).ToString()));


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                WOPlanCode = "WO_KH_ANA";
                WOKittingCode = "KITTING_KH_ANA";
                WOKhauInCode = "IN_KH_ANA";
                WOKhauOutCode = "OUT_KH_ANA";
                WOPlanCode_Next = "WO_KH_NEXT_ANA";
                WOQCCode = "QC_KH_ANA";
                WODGCode = "DG_KH_ANA";

                string cur_wo_string, next_wo_string;
                int thismonth, thisyear, nextmonth, nextyear;
                thismonth = DateTime.Now.Month;
                thisyear = DateTime.Now.Year;
                nextmonth = (DateTime.Now.AddMonths(1)).Month;
                nextyear = (DateTime.Now.AddMonths(1)).Year;

                cur_wo_string = thisyear.ToString().Substring(2) + thismonth.ToString("00");
                next_wo_string = nextyear.ToString().Substring(2) + nextmonth.ToString("00");


                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    var qr_total = (from s in db.tblWOes
                                    where s.workorder.StartsWith(cur_wo_string) && !s.desc2.StartsWith("Gen")
                                     && !s.desc2.StartsWith("Treo") && !s.desc2.StartsWith("Stent")
                                    select s).Count();

                    var qr_total_next = (from s in db.tblWOes
                                         where s.workorder.StartsWith(next_wo_string) && !s.desc2.StartsWith("Gen")
                                     && !s.desc2.StartsWith("Treo") && !s.desc2.StartsWith("Stent")
                                         select s).Count();

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
                    var qr_complete = (from s in db.tblWOes
                                       where s.wostatus == "C" && s.workorder.StartsWith(cur_wo_string) && !s.desc2.StartsWith("Gen")
                                     && !s.desc2.StartsWith("Treo") && !s.desc2.StartsWith("Stent")
                                       select s).Count();
                    var qr_complete_next = (from s in db.tblWOes
                                            where s.wostatus == "C" && s.workorder.StartsWith(next_wo_string) && !s.desc2.StartsWith("Gen")
                                     && !s.desc2.StartsWith("Treo") && !s.desc2.StartsWith("Stent")
                                            select s).Count();

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


                    var qr_TotalKitting = (from tmp in db.tblInputs
                                           where tmp.KittingTime_End != null && tmp.workorder.StartsWith(cur_wo_string) && !tmp.desc2.StartsWith("Gen")
                                     && !tmp.desc2.StartsWith("Treo") && !tmp.desc2.StartsWith("Stent")
                                           select tmp.qty).Sum();

                    var qr_TotalKitting_next = (from tmp in db.tblInputs
                                                where tmp.KittingTime_End != null && tmp.workorder.StartsWith(next_wo_string) && !tmp.desc2.StartsWith("Gen")
                                     && !tmp.desc2.StartsWith("Treo") && !tmp.desc2.StartsWith("Stent")
                                                select tmp.qty).Sum();

                    var qr_TodayKitting = (from tmp in db.tblInputs
                                           where tmp.KittingTime_End != null && tmp.KittingTime_End >= DateTime.Today && !tmp.desc2.StartsWith("Gen")
                                     && !tmp.desc2.StartsWith("Treo") && !tmp.desc2.StartsWith("Stent")
                                           select tmp.qty).Sum();

                    var qr_TotalIn = (from tmp in db.tblInputs
                                      where tmp.InTime_Start != null && tmp.workorder.StartsWith(cur_wo_string) && !tmp.desc2.StartsWith("Gen")
                                     && !tmp.desc2.StartsWith("Treo") && !tmp.desc2.StartsWith("Stent")
                                      select tmp.qty).Sum();

                    var qr_TotalIn_next = (from tmp in db.tblInputs
                                           where tmp.InTime_Start != null && tmp.workorder.StartsWith(next_wo_string) && !tmp.desc2.StartsWith("Gen")
                                     && !tmp.desc2.StartsWith("Treo") && !tmp.desc2.StartsWith("Stent")
                                           select tmp.qty).Sum();

                    var qr_TodayIn = (from tmp in db.tblInputs
                                      where tmp.InTime_Start != null && tmp.InTime_Start >= DateTime.Today && !tmp.desc2.StartsWith("Gen")
                                     && !tmp.desc2.StartsWith("Treo") && !tmp.desc2.StartsWith("Stent")
                                      select tmp.qty).Sum();

                    var qr_TotalOut = (from tmp in db.tblInputs
                                       where tmp.OutTime != null && tmp.workorder.StartsWith(cur_wo_string) && !tmp.desc2.StartsWith("Gen")
                                     && !tmp.desc2.StartsWith("Treo") && !tmp.desc2.StartsWith("Stent")
                                       select tmp.qty).Sum();

                    var qr_TotalOut_next = (from tmp in db.tblInputs
                                            where tmp.OutTime != null && tmp.workorder.StartsWith(next_wo_string) && !tmp.desc2.StartsWith("Gen")
                                     && !tmp.desc2.StartsWith("Treo") && !tmp.desc2.StartsWith("Stent")
                                            select tmp.qty).Sum();

                    var qr_TodayOut = (from tmp in db.tblInputs
                                       where tmp.OutTime != null && tmp.OutTime >= DateTime.Today && !tmp.desc2.StartsWith("Gen")
                                     && !tmp.desc2.StartsWith("Treo") && !tmp.desc2.StartsWith("Stent")
                                       select tmp.qty).Sum();

                    var qr_TotalQC = (from tmp in db.tblInputs
                                      where tmp.QCTime_Start != null && tmp.workorder.StartsWith(cur_wo_string) && !tmp.desc2.StartsWith("Gen")
                                     && !tmp.desc2.StartsWith("Treo") && !tmp.desc2.StartsWith("Stent")
                                      select tmp.qty).Sum();

                    var qr_TotalQC_next = (from tmp in db.tblInputs
                                           where tmp.QCTime_Start != null && tmp.workorder.StartsWith(next_wo_string) && !tmp.desc2.StartsWith("Gen")
                                     && !tmp.desc2.StartsWith("Treo") && !tmp.desc2.StartsWith("Stent")
                                           select tmp.qty).Sum();

                    var qr_TodayQC = (from tmp in db.tblInputs
                                      where tmp.QCTime_Start != null && tmp.QCTime_Start >= DateTime.Today && !tmp.desc2.StartsWith("Gen")
                                     && !tmp.desc2.StartsWith("Treo") && !tmp.desc2.StartsWith("Stent")
                                      select tmp.qty).Sum();

                    var qr_TotalDG = (from tmp in db.tblInputs
                                      where tmp.DongGoi_Start != null && tmp.workorder.StartsWith(cur_wo_string) && !tmp.desc2.StartsWith("Gen")
                                     && !tmp.desc2.StartsWith("Treo") && !tmp.desc2.StartsWith("Stent")
                                      select tmp.qty).Sum();

                    var qr_TotalDG_next = (from tmp in db.tblInputs
                                           where tmp.DongGoi_Start != null && tmp.workorder.StartsWith(next_wo_string) && !tmp.desc2.StartsWith("Gen")
                                        && !tmp.desc2.StartsWith("Treo") && !tmp.desc2.StartsWith("Stent")
                                           select tmp.qty).Sum();

                    var qr_TodayDG = (from tmp in db.tblInputs
                                      where tmp.DongGoi_Start != null && tmp.DongGoi_Start >= DateTime.Today && !tmp.desc2.StartsWith("Gen")
                                     && !tmp.desc2.StartsWith("Treo") && !tmp.desc2.StartsWith("Stent")
                                      select tmp.qty).Sum();

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
                    if (Convert.ToInt32(qr_TotalIn_next) != 0)
                    {
                        lbInTotal.Invoke(new Action(() => lbInTotal.Text = qr_TotalIn_next.ToString() == "" ? "0" : qr_TotalIn_next.ToString()));
                        lbMonthIn.Invoke(new Action(() => lbMonthIn.Text = lbWOKHMonth_Next.Text));
                    }
                    else
                    {
                        lbInTotal.Invoke(new Action(() => lbInTotal.Text = qr_TotalIn.ToString() == "" ? "0" : qr_TotalIn.ToString()));
                        lbMonthIn.Invoke(new Action(() => lbMonthIn.Text = lbWOKHMonth_Cur.Text));
                    }

                    //Nếu có số tháng tiếp thì lấy k thì lấy tháng hiện tại
                    if (Convert.ToInt32(qr_TotalOut_next) != 0)
                    {
                        lbOutTotal.Invoke(new Action(() => lbOutTotal.Text = qr_TotalOut_next.ToString() == "" ? "0" : qr_TotalOut_next.ToString()));
                        lbMonthOut.Invoke(new Action(() => lbMonthOut.Text = lbWOKHMonth_Next.Text));
                    }
                    else
                    {
                        lbOutTotal.Invoke(new Action(() => lbOutTotal.Text = qr_TotalOut.ToString() == "" ? "0" : qr_TotalOut.ToString()));
                        lbMonthOut.Invoke(new Action(() => lbMonthOut.Text = lbWOKHMonth_Cur.Text));
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

                    if (Convert.ToInt32(qr_TotalDG_next) != 0)
                    {
                        lbDGTotal.Invoke(new Action(() => lbDGTotal.Text = qr_TotalDG_next.ToString() == "" ? "0" : qr_TotalDG_next.ToString()));
                        lbMonthDG.Invoke(new Action(() => lbMonthDG.Text = lbWOKHMonth_Next.Text));
                    }
                    else
                    {
                        lbDGTotal.Invoke(new Action(() => lbDGTotal.Text = qr_TotalDG.ToString() == "" ? "0" : qr_TotalDG.ToString()));
                        lbMonthDG.Invoke(new Action(() => lbMonthDG.Text = lbWOKHMonth_Cur.Text));
                    }

                    lbKittingToday.Invoke(new Action(() => lbKittingToday.Text = qr_TodayKitting.ToString() == "" ? "0" : qr_TodayKitting.ToString()));
                    lbInToday.Invoke(new Action(() => lbInToday.Text = qr_TodayIn.ToString() == "" ? "0" : qr_TodayIn.ToString()));
                    lbOutToday.Invoke(new Action(() => lbOutToday.Text = qr_TodayOut.ToString() == "" ? "0" : qr_TodayOut.ToString()));
                    lbQCToday.Invoke(new Action(() => lbQCToday.Text = qr_TodayQC.ToString() == "" ? "0" : qr_TodayQC.ToString()));
                    lbDGToday.Invoke(new Action(() => lbDGToday.Text = qr_TodayDG.ToString() == "" ? "0" : qr_TodayDG.ToString()));


                    int chuasx;
                    //Nếu có tháng mới thì cập nhật theo tháng mới
                    if (qr_total_next > 0)
                    {
                        chuasx = qr_total_next - (qr_TotalKitting_next ?? 0);
                    }
                    else
                    {
                        chuasx = qr_total - (qr_TotalKitting ?? 0);
                    }

                    lbNotyetTotal.Invoke(new Action(() => lbNotyetTotal.Text = chuasx.ToString()));

                    int tonkitting = (qr_TotalKitting ?? 0) + (qr_TotalKitting_next ?? 0) - (qr_TotalIn ?? 0) - (qr_TotalIn_next ?? 0);
                    lbTonKitting.Invoke(new Action(() => lbTonKitting.Text = tonkitting.ToString()));

                    int sodangkhau = (qr_TotalIn ?? 0) + (qr_TotalIn_next ?? 0) - (qr_TotalOut ?? 0) - (qr_TotalOut_next ?? 0);
                    lbSoDangKhau.Invoke(new Action(() => lbSoDangKhau.Text = sodangkhau.ToString()));

                    //2023-07: thêm số tồn khâu
                    int tonkhau = (qr_TotalOut ?? 0) + (qr_TotalOut_next ?? 0) - (qr_TotalQC ?? 0) - (qr_TotalQC_next ?? 0);
                    lbTonKhau.Invoke(new Action(() => lbTonKhau.Text = tonkhau.ToString()));

                    //Số chưa đóng gói = số WO đã chuyển thành C - số đã kết thúc do người dùng quét
                    //Cập nhật thành: Số chưa đg = số wo thành C của tháng này + tháng sau - (số đã kết thúc DG tháng này + tháng sau)
                    int chuaDG = qr_complete_next + qr_complete - Convert.ToInt32(qr_TotalDG_next) - Convert.ToInt32(qr_TotalDG);
                    lbChuaDG.Invoke(new Action(() => lbChuaDG.Text = chuaDG.ToString()));

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

                    var qr_wokhauin = (from s in db.tblContents
                                       where s.code == WOKhauInCode
                                       select s.content).FirstOrDefault();
                    lbWOKhauIn.Invoke(new Action(() => lbWOKhauIn.Text = qr_wokhauin));

                    var qr_wokhauout = (from s in db.tblContents
                                        where s.code == WOKhauOutCode
                                        select s.content).FirstOrDefault();
                    lbWOKhauOut.Invoke(new Action(() => lbWOKhauOut.Text = qr_wokhauout));

                    var qr_woqc = (from s in db.tblContents
                                   where s.code == WOQCCode
                                   select s.content).FirstOrDefault();
                    lbWOQC.Invoke(new Action(() => lbWOQC.Text = qr_woqc));

                    var qr_wodg = (from s in db.tblContents
                                   where s.code == WODGCode
                                   select s.content).FirstOrDefault();
                    lbWODG.Invoke(new Action(() => lbWODG.Text = qr_wodg));

                    lbChenhLechKitting.Invoke(new Action(() => lbChenhLechKitting.Text = (Convert.ToInt32(lbKittingToday.Text) - Convert.ToInt32(lbWOKitting.Text)).ToString()));
                    lbChenhLechKhauIn.Invoke(new Action(() => lbChenhLechKhauIn.Text = (Convert.ToInt32(lbInToday.Text) - Convert.ToInt32(lbWOKhauIn.Text)).ToString()));
                    lbChenhLechKhauOut.Invoke(new Action(() => lbChenhLechKhauOut.Text = (Convert.ToInt32(lbOutToday.Text) - Convert.ToInt32(lbWOKhauOut.Text)).ToString()));
                    lbChenhLechQC.Invoke(new Action(() => lbChenhLechQC.Text = (Convert.ToInt32(lbQCToday.Text) - Convert.ToInt32(lbWOQC.Text)).ToString()));
                    lbChenhLechDG.Invoke(new Action(() => lbChenhLechDG.Text = (Convert.ToInt32(lbDGToday.Text) - Convert.ToInt32(lbWODG.Text)).ToString()));


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

        private void lbWOKhauIn_Click(object sender, EventArgs e)
        {
            InputForm f = new InputForm(WOKhauInCode);
            if (f.ShowDialog() == DialogResult.OK)
            {
                loaddata();
            }
        }

        private void lbWOKhauOut_Click(object sender, EventArgs e)
        {
            InputForm f = new InputForm(WOKhauOutCode);
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

        private void lbWODG_Click(object sender, EventArgs e)
        {
            InputForm f = new InputForm(WODGCode);
            if (f.ShowDialog() == DialogResult.OK)
            {
                loaddata();
            }
        }

    }
}
