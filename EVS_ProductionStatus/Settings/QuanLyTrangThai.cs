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
    public partial class QuanLyTrangThai : Form
    {
        public QuanLyTrangThai()
        {
            InitializeComponent();
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string woid = "";
                    List<string> lst = new List<string>();
                    txtBarcode.Invoke(new Action(() => lst = txtBarcode.Text.Split('%').ToList()));
                    string wo = lst[0];
                    woid = lst[1].Substring(0, 8);
                    //Kiểm tra điều kiện chuỗi nhập vào nếu WO và WOID khác 8 ký tự thì báo lỗi
                    if (wo.Length != 8 || woid.Length != 8)
                    {
                        lbError.Invoke(new Action(() => lbError.Text = "Lỗi. Mã vạch không phù hợp!"));
                        lbError.Invoke(new Action(() => lbError.Visible = true));
                        return;
                    }
                    loaddata(woid);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void loaddata(string _woid)
        {
            try
            {
                pnData.Visible = false;
                lbError.Visible = false;
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    //Đầu tiên tìm trong dữ liệu Input nếu có thì cập nhật vào
                    var qr_input = (from s in db.tblInputs
                                    where s.WOID == _woid
                                    select s).FirstOrDefault();
                    if (qr_input != null)
                    {
                        loadControls(qr_input);
                    }

                    else
                    {
                        lbError.Text = "Lỗi. Số chỉ thị không tồn tại!";
                        lbError.Visible = true;
                    }
                    txtBarcode.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void loadControls(tblInput _tb)
        {
            try
            {
                lbWO.Invoke(new Action(() => lbWO.Text = _tb.workorder));
                lbItem.Invoke(new Action(() => lbItem.Text = _tb.itemnumber));
                lbLot.Invoke(new Action(() => lbLot.Text = _tb.lot));
                lbQty.Invoke(new Action(() => lbQty.Text = _tb.qty.ToString()));
                lbID.Invoke(new Action(() => lbID.Text = _tb.WOID.ToString()));

                //Cập nhật luôn tên người thao tác nếu có
                lbTenNguoiTT.Invoke(new Action(() => lbTenNguoiTT.Visible = false));
                lbNguoiTT.Invoke(new Action(() => lbNguoiTT.Visible = false));

                pnData.Invoke(new Action(() => pnData.Visible = true));

                if (_tb.DongGoi_End != null)
                {
                    lbCongdoan.Invoke(new Action(() => lbCongdoan.Text = "ĐÓNG GÓI _ END"));
                    pnCongDoan.Invoke(new Action(() => pnCongDoan.BackColor = Color.Gold));
                    if (getUserName(_tb.UserDongGoi) != "")
                    {
                        lbTenNguoiTT.Invoke(new Action(() => lbTenNguoiTT.Text = getUserName(_tb.UserDongGoi)));
                        lbTenNguoiTT.Invoke(new Action(() => lbTenNguoiTT.Visible = true));
                        lbNguoiTT.Invoke(new Action(() => lbNguoiTT.Visible = true));
                    }
                    return;
                }

                if (_tb.DongGoi_Start != null)
                {
                    lbCongdoan.Invoke(new Action(() => lbCongdoan.Text = "ĐÓNG GÓI _ START"));
                    pnCongDoan.Invoke(new Action(() => pnCongDoan.BackColor = Color.DarkKhaki));
                    if (getUserName(_tb.UserDongGoi) != "")
                    {
                        lbTenNguoiTT.Invoke(new Action(() => lbTenNguoiTT.Text = getUserName(_tb.UserDongGoi)));
                        lbTenNguoiTT.Invoke(new Action(() => lbTenNguoiTT.Visible = true));
                        lbNguoiTT.Invoke(new Action(() => lbNguoiTT.Visible = true));
                    }
                    return;
                }

                if (_tb.QCTime_End != null)
                {
                    lbCongdoan.Invoke(new Action(() => lbCongdoan.Text = "QC _ END"));
                    pnCongDoan.Invoke(new Action(() => pnCongDoan.BackColor = Color.Tomato));
                    if (getUserName(_tb.UserQC) != "")
                    {
                        lbTenNguoiTT.Invoke(new Action(() => lbTenNguoiTT.Text = getUserName(_tb.UserQC)));
                        lbTenNguoiTT.Invoke(new Action(() => lbTenNguoiTT.Visible = true));
                        lbNguoiTT.Invoke(new Action(() => lbNguoiTT.Visible = true));
                    }
                    return;
                }

                if (_tb.QCTime_Start != null)
                {
                    lbCongdoan.Invoke(new Action(() => lbCongdoan.Text = "QC _ START"));
                    pnCongDoan.Invoke(new Action(() => pnCongDoan.BackColor = Color.Wheat));
                    if (getUserName(_tb.UserQC) != "")
                    {
                        lbTenNguoiTT.Invoke(new Action(() => lbTenNguoiTT.Text = getUserName(_tb.UserQC)));
                        lbTenNguoiTT.Invoke(new Action(() => lbTenNguoiTT.Visible = true));
                        lbNguoiTT.Invoke(new Action(() => lbNguoiTT.Visible = true));
                    }
                    return;
                }

                if (_tb.OutTime != null)
                {
                    lbCongdoan.Invoke(new Action(() => lbCongdoan.Text = "KHÂU _ OUT"));
                    pnCongDoan.Invoke(new Action(() => pnCongDoan.BackColor = Color.Aquamarine));
                    if (getUserName(_tb.UserIn) != "")
                    {
                        lbTenNguoiTT.Invoke(new Action(() => lbTenNguoiTT.Text = getUserName(_tb.UserIn)));
                        lbTenNguoiTT.Invoke(new Action(() => lbTenNguoiTT.Visible = true));
                        lbNguoiTT.Invoke(new Action(() => lbNguoiTT.Visible = true));
                    }
                    return;
                }

                if (_tb.InTime_Start != null)
                {
                    lbCongdoan.Invoke(new Action(() => lbCongdoan.Text = "KHÂU _ IN"));
                    pnCongDoan.Invoke(new Action(() => pnCongDoan.BackColor = Color.LawnGreen));
                    if (getUserName(_tb.UserIn) != "")
                    {
                        lbTenNguoiTT.Invoke(new Action(() => lbTenNguoiTT.Text = getUserName(_tb.UserIn)));
                        lbTenNguoiTT.Invoke(new Action(() => lbTenNguoiTT.Visible = true));
                        lbNguoiTT.Invoke(new Action(() => lbNguoiTT.Visible = true));
                    }
                    return;
                }

                if (_tb.KittingTime_End != null)
                {
                    lbCongdoan.Invoke(new Action(() => lbCongdoan.Text = "KITTING _ END"));
                    pnCongDoan.Invoke(new Action(() => pnCongDoan.BackColor = Color.Olive));
                    if (getUserName(_tb.UserKitting) != "")
                    {
                        lbTenNguoiTT.Invoke(new Action(() => lbTenNguoiTT.Text = getUserName(_tb.UserKitting)));
                        lbTenNguoiTT.Invoke(new Action(() => lbTenNguoiTT.Visible = true));
                        lbNguoiTT.Invoke(new Action(() => lbNguoiTT.Visible = true));
                    }
                    return;
                }

                lbCongdoan.Invoke(new Action(() => lbCongdoan.Text = "KITTING _ START"));
                pnCongDoan.Invoke(new Action(() => pnCongDoan.BackColor = Color.Yellow));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private string getUserName(string _uid)
        {
            string kq = "";
            using (Entities db = new Entities(clConnection.connectEntity))
            {
                var qr_user = (from s in db.tblUsers
                               where s.userid == _uid
                               select s).FirstOrDefault();
                if (qr_user != null)
                    kq = qr_user.name;
            }
            return kq;
        }

        private void lnkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var rs = MessageBox.Show("Bạn có chắc xóa dữ liệu quét gần nhất", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                //Bỏ thời gian trong tblInput
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    var qr = (from s in db.tblInputs
                              //where s.workorder == lbWO.Text
                              where s.WOID == lbID.Text
                              select s).FirstOrDefault();

                    //Lấy dữ liệu khâu in ở bảng tblKhauIn để cập nhật
                    var qr_khauin = (from s in db.tblKhauIns
                                         //where s.workorder == lbWO.Text
                                     where s.WOID == lbID.Text
                                     orderby s.id descending
                                     select s).ToList();

                    //Lấy dữ liệu QC ở bảng tblQC để cập nhật
                    var qr_qc = (from s in db.tblQCs
                                     //where s.workorder == lbWO.Text
                                 where s.WOID == lbID.Text
                                 orderby s.id descending
                                 select s).ToList();


                    if (qr.DongGoi_End != null)
                    {
                        qr.DongGoi_End = null;
                        qr.UserDongGoi = null;
                        goto save_point;
                    }
                    if (qr.DongGoi_Start != null)
                    {
                        qr.DongGoi_Start = null;
                        qr.DongGoiGroup = null;
                        goto save_point;
                    }

                    if (qr.QCTime_End != null)
                    {
                        qr.QCTime_End = null;
                        if (qr_qc.Count > 0)
                        {
                            qr_qc[0].QCTime_End = null;
                        }
                        goto save_point;
                    }
                    if (qr.QCTime_Start != null)
                    {
                        qr.QCTime_Start = null;
                        qr.UserQC = null;
                        //Xoa khau in start o bang tblKhau                        
                        if (qr_qc.Count > 0)
                        {
                            db.tblQCs.RemoveRange(qr_qc);
                        }
                        goto save_point;
                    }
                    if (qr.OutTime != null)
                    {
                        qr.OutTime = null;
                        //Xoa khau in end o bang tblKhau                        
                        if (qr_khauin.Count > 0)
                        {
                            qr_khauin[0].InTime_End = null;
                        }

                        goto save_point;
                    }
                    if (qr.InTime_Start != null)
                    {
                        qr.InTime_Start = null;
                        qr.UserIn = null;
                        //Xoa khau in start o bang tblKhau                        
                        if (qr_khauin.Count > 0)
                        {
                            db.tblKhauIns.RemoveRange(qr_khauin);
                        }
                        goto save_point;
                    }
                    if (qr.KittingTime_End != null)
                    {
                        qr.KittingTime_End = null;
                        qr.UserKitting = null;
                    }
                    //Mới đến kitting start thì xóa dữ liệu luôn
                    else
                    {
                        db.tblInputs.Remove(qr);
                    }

                    //Điểm nhảy đến thực hiện lưu dữ liệu
                    save_point:

                    db.SaveChanges();
                    //Load lại list và control

                    var qr1 = (from s in db.tblInputs
                               //where s.workorder == lbWO.Text
                               where s.WOID == lbID.Text
                               select s).FirstOrDefault();
                    if (qr1 == null)
                    {
                        pnData.Visible = false;
                    }
                    else
                    {
                        loaddata(lbID.Text);
                    }
                }
            }
            //Chọn lại ô quét mã vạch
            txtBarcode.Select();
        }
    }

}
