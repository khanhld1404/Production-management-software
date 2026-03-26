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
    public partial class NhapQCDoDang : Form
    {
        string wo = "", woid = "";
        public NhapQCDoDang()
        {
            InitializeComponent();
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    pnNhanVien.Visible = false;
                    List<string> lst = new List<string>();
                    txtBarcode.Invoke(new Action(() => lst = txtBarcode.Text.Split('%').ToList()));
                    wo = lst[0];
                    woid = lst[1].Substring(0, 8);

                    //Kiểm tra điều kiện chuỗi nhập vào nếu WO và WOID khác 8 ký tự thì báo lỗi
                    if (wo.Length != 8 || woid.Length != 8)
                    {
                        lbError.Invoke(new Action(() => lbError.Text = "Lỗi. Mã vạch không phù hợp!"));
                        lbError.Invoke(new Action(() => lbError.Visible = true));
                        return;
                    }

                    lbScanned.Text = "";
                    inputdata(woid);
                    txtBarcode.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void inputdata(string _woid)
        {
            try
            {
                pnData.Visible = false;
                lbError.Visible = false;
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    //1. Tìm chỉ thị trong bảng QC đã start chưa end
                    //Nếu có thì cập nhật thời gian end
                    var qr_khau = (from s in db.tblQCs
                                   where s.WOID == _woid && s.QCTime_End == null
                                   orderby s.id descending
                                   select s).FirstOrDefault();
                    if (qr_khau != null)
                    {
                        qr_khau.QCTime_End = DateTime.Now;
                        db.SaveChanges();

                        //3. Load thông tin trạng thái hiện tại và danh sách của WO đã quét
                        loadControls(_woid);
                        loadGridView(_woid);
                    }
                    else
                    //2. Nếu k có thì tìm trong bảng tblInput những chỉ thị đã khâu out mà chưa QC end
                    //Nếu có thì thêm vào bảng nhập khâu, nếu không có báo lỗi
                    {
                        var qr_input = (from s in db.tblInputs
                                        where s.WOID == _woid && s.OutTime != null && s.QCTime_End == null
                                        select s).FirstOrDefault();
                        if (qr_input == null)
                        {
                            lbError.Text = "Lỗi. Số chỉ thị đã quét không thể bắt đầu QC!";
                            lbError.Visible = true;
                            return;
                        }
                        else
                        {
                            //Muốn bắt đầu phải quét mã nhân viên đã
                            pnNhanVien.Visible = true;
                            txtUsername.Select();
                            //Xử lý tiếp tại sự kiện txtUsername_KeyDown
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void loadControls(string _woid)
        {
            try
            {
                pnData.Visible = false;
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    var qr_input = (from s in db.tblInputs
                                    where s.WOID == _woid
                                    select s).FirstOrDefault();

                    if (qr_input != null)
                    {
                        lbWO.Invoke(new Action(() => lbWO.Text = qr_input.workorder));
                        lbItem.Invoke(new Action(() => lbItem.Text = qr_input.itemnumber));
                        lbLot.Invoke(new Action(() => lbLot.Text = qr_input.lot));
                        lbQty.Invoke(new Action(() => lbQty.Text = qr_input.qty.ToString()));
                        lbID.Invoke(new Action(() => lbID.Text = qr_input.WOID.ToString()));
                    }

                    var _tb = (from s in db.tblQCs
                               where s.WOID == _woid
                               orderby s.id descending
                               select s).FirstOrDefault();
                    if (_tb != null)
                    {
                        //Cập nhật luôn tên người thao tác nếu có
                        lbTenNguoiTT.Text = getUserName(_tb.UserQC);
                        pnData.Invoke(new Action(() => pnData.Visible = true));

                        if (_tb.QCTime_End != null)
                        {
                            lbCongdoan.Text = "QC _ END";
                            pnCongDoan.BackColor = Color.Tomato;
                        }
                        else
                        {
                            lbCongdoan.Text = "QC _ START";
                            pnCongDoan.BackColor = Color.Wheat;
                        }
                    }
                }
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
                    var qr = (from s in db.tblQCs
                              where s.WOID == lbID.Text
                              orderby s.id descending
                              select s).ToList();
                    if (qr[0].QCTime_End != null)
                    {
                        qr[0].QCTime_End = null;
                    }
                    else
                    {
                        db.tblQCs.Remove(qr[0]);                        

                        var qr_input = (from s in db.tblInputs
                                        where s.WOID == lbID.Text
                                        select s).FirstOrDefault();

                        if (qr.Count == 1 && qr_input != null)
                        {
                            qr_input.QCTime_Start = null;
                            qr_input.UserQC = null;
                        }
                    }

                    db.SaveChanges();
                    //Load lại list và control
                    loadControls(lbID.Text);
                    loadGridView(lbID.Text);

                }
            }
            //Chọn lại ô quét mã vạch
            txtBarcode.Select();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    lbError.Visible = false;
                    lbScanned.Text = txtUsername.Text;
                    using (Entities db = new Entities(clConnection.connectEntity))
                    {
                        //Kiểm tra thông tin người thao tác có tồn tại không
                        var qr_user = (from s in db.tblUsers
                                       where s.userid == txtUsername.Text
                                       select s).FirstOrDefault();
                        if (qr_user == null)
                        {
                            lbError.Text = "Lỗi. Người thao tác không tồn tại";
                            lbError.Visible = true;
                            txtUsername.Text = "";
                            return;
                        }
                        else
                        {
                            //Nếu tblInput chưa nhập thì cần thêm cả thời gian khâu in vào tblInput
                            DateTime KhauInTime = DateTime.Now;

                            var qr_input = (from s in db.tblInputs
                                            where s.WOID == woid && s.OutTime != null && s.QCTime_Start == null
                                            select s).FirstOrDefault();

                            if (qr_input != null)
                            {
                                qr_input.QCTime_Start = KhauInTime;
                                qr_input.UserQC = txtUsername.Text;
                            }

                            tblQC tb = new tblQC();
                            tb.WOID = woid;
                            tb.workorder = wo;
                            tb.QCTime_Start = KhauInTime;
                            tb.UserQC = txtUsername.Text;
                            db.tblQCs.Add(tb);
                            db.SaveChanges();

                            loadControls(woid);
                            loadGridView(woid);
                        }
                    }

                    txtUsername.Text = "";
                    pnNhanVien.Visible = false;
                    txtBarcode.Select();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void loadGridView(string _woid)
        {
            try
            {
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    var qr = (from s in db.tblQCs
                              join u in db.tblUsers on s.UserQC equals u.userid into tmpU
                              from u1 in tmpU.DefaultIfEmpty()
                              where s.WOID == _woid
                              orderby s.id
                              select new
                              {
                                  s.WOID,
                                  s.workorder,
                                  s.QCTime_Start,
                                  s.QCTime_End,
                                  s.UserQC,
                                  u1.name
                              }).ToList();

                    grThongtin.AutoGenerateColumns = false;
                    grThongtin.DataSource = qr;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Hủy quét mã người dùng
        private void lnkCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                txtUsername.Text = "";
                pnNhanVien.Visible = false;
                txtBarcode.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
