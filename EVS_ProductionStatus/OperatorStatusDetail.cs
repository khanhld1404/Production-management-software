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
    public partial class OperatorStatusDetail : Form
    {
        int Vitri;
        string CD;
        public OperatorStatusDetail()
        {
            InitializeComponent();
        }

        public OperatorStatusDetail(int _vitri, string _cd)
        {
            InitializeComponent();
            Vitri = _vitri;
            CD = _cd;
        }

        private void OperatorStatusDetail_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void loaddata()
        {
            using (Entities db = new Entities(clConnection.connectEntity))
            {
                string desc_string = "";
                if (CD != "ANA")
                {
                    switch (CD)
                    {
                        case "RELAY":
                            desc_string = "Stent";
                            break;
                        case "TREO":
                            desc_string = "Treo";
                            break;
                        case "THORA":
                            desc_string = "Gen";
                            break;
                        default:
                            MessageBox.Show("Chủng loại không phù hợp");
                            this.Close();
                            return;
                    }

                    var qr = (from s in db.tblViTriNguoiTTs
                              join u in db.tblUsers on s.UserID equals u.userid into tmpU
                              from u1 in tmpU.DefaultIfEmpty()
                              join khau in db.tblKhauIns on s.UserID equals khau.UserIn into tmpK
                              from khau1 in tmpK.DefaultIfEmpty()
                              join ip in db.tblInputs on khau1.WOID equals ip.WOID into tmpI
                              from ip1 in tmpI.DefaultIfEmpty()
                              where s.ViTri == Vitri && (ip1.desc2.StartsWith(desc_string) || ip1.desc2 == null)
                              && khau1.InTime_Start != null && khau1.InTime_End == null
                              orderby khau1.id descending
                              select new
                              {
                                  s.Nhom,
                                  s.UserID,
                                  u1.name,
                                  ip1.itemnumber,
                                  ip1.lot,
                                  khau1.InTime_Start,
                                  khau1.InTime_End
                              }).FirstOrDefault();

                    //Neu dang khau
                    if (qr != null)
                    {
                        lbMaNguoiTT.Text = qr.UserID;
                        lbTenNguoiTT.Text = qr.name;
                        lbNhom.Text = qr.Nhom;
                        lbMaSP.Text = qr.itemnumber;
                        lbLot.Text = qr.lot;
                        lbStartTime.Text = qr.InTime_Start.ToString();
                        lbEndTime.Text = qr.InTime_End.ToString();
                    }
                    else
                    {
                        //Neu da hoan thanh hoac chua co du lieu
                        var qr_HT = (from s in db.tblViTriNguoiTTs
                                  join u in db.tblUsers on s.UserID equals u.userid into tmpU
                                  from u1 in tmpU.DefaultIfEmpty()
                                  join khau in db.tblKhauIns on s.UserID equals khau.UserIn into tmpK
                                  from khau1 in tmpK.DefaultIfEmpty()
                                  join ip in db.tblInputs on khau1.WOID equals ip.WOID into tmpI
                                  from ip1 in tmpI.DefaultIfEmpty()
                                  where s.ViTri == Vitri && (ip1.desc2.StartsWith(desc_string) || ip1.desc2 == null)
                                  
                                  orderby khau1.id descending
                                  select new
                                  {
                                      s.Nhom,
                                      s.UserID,
                                      u1.name,
                                      ip1.itemnumber,
                                      ip1.lot,
                                      khau1.InTime_Start,
                                      khau1.InTime_End
                                  }).FirstOrDefault();
                        if (qr_HT != null)
                        {
                            lbMaNguoiTT.Text = qr_HT.UserID;
                            lbTenNguoiTT.Text = qr_HT.name;
                            lbNhom.Text = qr_HT.Nhom;
                            lbMaSP.Text = qr_HT.itemnumber;
                            lbLot.Text = qr_HT.lot;
                            lbStartTime.Text = qr_HT.InTime_Start.ToString();
                            lbEndTime.Text = qr_HT.InTime_End.ToString();
                        }
                    }
                }
                else
                {
                    var qr = (from s in db.tblViTriNguoiTTs
                              join u in db.tblUsers on s.UserID equals u.userid into tmpU
                              from u1 in tmpU.DefaultIfEmpty()
                              join khau in db.tblKhauIns on s.UserID equals khau.UserIn into tmpK
                              from khau1 in tmpK.DefaultIfEmpty()
                              join ip in db.tblInputs on khau1.WOID equals ip.WOID into tmpI
                              from ip1 in tmpI.DefaultIfEmpty()
                              where s.ViTri == Vitri && (!ip1.desc2.StartsWith("Gen") && !ip1.desc2.StartsWith("Treo")
                              && !ip1.desc2.StartsWith("Stent") || ip1.desc2 == null)
                              && khau1.InTime_Start != null && khau1.InTime_End == null
                              orderby khau1.id descending
                              select new
                              {
                                  s.Nhom,
                                  s.UserID,
                                  u1.name,
                                  ip1.itemnumber,
                                  ip1.lot,
                                  khau1.InTime_Start,
                                  khau1.InTime_End
                              }).FirstOrDefault();

                    if (qr != null)
                    {
                        lbMaNguoiTT.Text = qr.UserID;
                        lbTenNguoiTT.Text = qr.name;
                        lbNhom.Text = qr.Nhom;
                        lbMaSP.Text = qr.itemnumber;
                        lbLot.Text = qr.lot;
                        lbStartTime.Text = qr.InTime_Start.ToString();
                        lbEndTime.Text = qr.InTime_End.ToString();
                    }
                    else
                    {
                        var qr_HT = (from s in db.tblViTriNguoiTTs
                                  join u in db.tblUsers on s.UserID equals u.userid into tmpU
                                  from u1 in tmpU.DefaultIfEmpty()
                                  join khau in db.tblKhauIns on s.UserID equals khau.UserIn into tmpK
                                  from khau1 in tmpK.DefaultIfEmpty()
                                  join ip in db.tblInputs on khau1.WOID equals ip.WOID into tmpI
                                  from ip1 in tmpI.DefaultIfEmpty()
                                  where s.ViTri == Vitri && (!ip1.desc2.StartsWith("Gen") && !ip1.desc2.StartsWith("Treo")
                                  && !ip1.desc2.StartsWith("Stent") || ip1.desc2 == null)
                                  orderby khau1.id descending
                                  select new
                                  {
                                      s.Nhom,
                                      s.UserID,
                                      u1.name,
                                      ip1.itemnumber,
                                      ip1.lot,
                                      khau1.InTime_Start,
                                      khau1.InTime_End
                                  }).FirstOrDefault();

                        if (qr_HT != null)
                        {
                            lbMaNguoiTT.Text = qr_HT.UserID;
                            lbTenNguoiTT.Text = qr_HT.name;
                            lbNhom.Text = qr_HT.Nhom;
                            lbMaSP.Text = qr_HT.itemnumber;
                            lbLot.Text = qr_HT.lot;
                            lbStartTime.Text = qr_HT.InTime_Start.ToString();
                            lbEndTime.Text = qr_HT.InTime_End.ToString();
                        }
                    }
                }

                
            }
        }
    }
}
