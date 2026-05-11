using EVS_ProductionStatus.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EVS_ProductionStatus.Data;
namespace EVS_ProductionStatus
{
    public partial class NhapKhauIn : Form
    {
        string wo = "", woid = "", wo_part = "";
        //Kiểm tra mã vòng
        bool check_ring;
        public NhapKhauIn(bool _check_ring)
        {
            InitializeComponent();
            check_ring = _check_ring;
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
                    woid = lst[1].Substring(0, 10);
                    wo_part = lst[2];
                    //Kiểm tra điều kiện chuỗi nhập vào nếu WO và WOID khác 8 ký tự thì báo lỗi
                    if (wo.Length != 8 || woid.Length != 10)
                    {
                        lbError.Invoke(new Action(() => lbError.Text = "Lỗi. Mã vạch không phù hợp!"));
                        lbError.Invoke(new Action(() => lbError.Visible = true));
                        return;
                    }

                    lbScanned.Text = "";
                    inputdata(woid,wo,wo_part);
                    txtBarcode.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void inputdata(string _woid, string _wo, string _wopart)
        {
            try
            {
                pnData.Visible = false;
                lbError.Visible = false;
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    
                    //1. Tìm chỉ thị trong bảng Nhập khâu đã start chưa end
                    //Nếu có thì cập nhật thời gian end
                    var qr_khau = (from s in db.tblKhauIns
                                   where s.WOID == _woid && s.workorder == _wo  && s.InTime_End == null
                                   orderby s.id descending
                                   select s).FirstOrDefault();
                    if (qr_khau != null)
                    {
                        qr_khau.InTime_End = DateTime.Now;
                        db.SaveChanges();

                        //3. Load thông tin trạng thái hiện tại và danh sách của WO đã quét
                        loadControls(_woid,_wo,_wopart);
                        loadGridView(_woid, _wo);
                    }
                    else
                    //2. Nếu k có thì tìm trong bảng tblInput những chỉ thị đã kitting end mà chưa khâu out
                    //Nếu có thì thêm vào bảng nhập khâu, nếu không có báo lỗi
                    {
                        // Kiểm tra theo thiết bị
                        if (!check_ring)
                        {
                            var qr_input = (from s in db.tblInputs
                                            where s.WOID == _woid && s.workorder == _wo && s.itemnumber == _wopart && s.KittingTime_End != null && s.OutTime == null
                                            select s).FirstOrDefault();
                            if (qr_input == null)
                            {
                                lbError.Text = "Lỗi. Số chỉ thị đã quét không thể bắt đầu khâu in!";
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
                        else //theo mã vòng
                        {
                            using (Manage_evsEntities wodb = new Manage_evsEntities(clConnection.connectString2))
                            {
                                var qr_input = (from s in wodb.tblInput_Ring
                                                where s.WOID == _woid && s.workorder == _wo && s.itemnumber == _wopart && s.KittingTime_End != null && s.OutTime == null
                                                select s).FirstOrDefault();
                                if (qr_input == null)
                                {
                                    lbError.Text = "Lỗi. Số chỉ thị đã quét không thể bắt đầu khâu in!";
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

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void loadControls(string _woid,string _wo,string _item)
        {
            try
            {
                pnData.Visible = false;
                // theo thiết bị
                if (!check_ring)
                {
                    using (Entities db = new Entities(clConnection.connectEntity))
                    {
                        var qr_input = (from s in db.tblInputs
                                        where s.WOID == _woid && s.workorder == _wo && s.itemnumber == _item
                                        select s).FirstOrDefault();

                        if (qr_input != null)
                        {
                            lbWO.Invoke(new Action(() => lbWO.Text = qr_input.workorder));
                            lbItem.Invoke(new Action(() => lbItem.Text = qr_input.itemnumber));
                            lbLot.Invoke(new Action(() => lbLot.Text = qr_input.lot));
                            lbQty.Invoke(new Action(() => lbQty.Text = qr_input.qty.ToString()));
                            lbID.Invoke(new Action(() => lbID.Text = qr_input.WOID.ToString()));
                        }

                        var _tb = (from s in db.tblKhauIns
                                       //where s.workorder == _wo
                                   where s.WOID == _woid && s.workorder == _wo
                                   orderby s.id descending
                                   select s).FirstOrDefault();
                        if (_tb != null)
                        {
                            //Cập nhật luôn tên người thao tác nếu có
                            lbTenNguoiTT.Text = getUserName(_tb.UserIn);
                            pnData.Invoke(new Action(() => pnData.Visible = true));

                            if (_tb.InTime_End != null)
                            {
                                lbCongdoan.Text = "KHÂU IN _ END";
                                pnCongDoan.BackColor = Color.Aquamarine;
                            }
                            else
                            {
                                lbCongdoan.Text = "KHÂU IN _ START";
                                pnCongDoan.BackColor = Color.LawnGreen;
                            }
                        }
                    }
                }
                else // theo mã vòng 
                {
                    using (Entities db = new Entities(clConnection.connectEntity))
                    {
                        using(Manage_evsEntities wodb = new Manage_evsEntities(clConnection.connectString2))
                        {
                            var qr_input = (from s in wodb.tblInput_Ring
                                            where s.WOID == _woid && s.workorder == _wo && s.itemnumber == _item
                                            select s).FirstOrDefault();

                            if (qr_input != null)
                            {
                                lbWO.Invoke(new Action(() => lbWO.Text = qr_input.workorder));
                                lbItem.Invoke(new Action(() => lbItem.Text = qr_input.itemnumber));
                                lbLot.Invoke(new Action(() => lbLot.Text = qr_input.lot));
                                lbQty.Invoke(new Action(() => lbQty.Text = qr_input.qty.ToString()));
                                lbID.Invoke(new Action(() => lbID.Text = qr_input.WOID.ToString()));
                            }

                            var _tb = (from s in db.tblKhauIns
                                           //where s.workorder == _wo
                                       where s.WOID == _woid && s.workorder == _wo
                                       orderby s.id descending
                                       select s).FirstOrDefault();
                            if (_tb != null)
                            {
                                //Cập nhật luôn tên người thao tác nếu có
                                lbTenNguoiTT.Text = getUserName(_tb.UserIn);
                                pnData.Invoke(new Action(() => pnData.Visible = true));

                                if (_tb.InTime_End != null)
                                {
                                    lbCongdoan.Text = "KHÂU IN _ END";
                                    pnCongDoan.BackColor = Color.Aquamarine;
                                }
                                else
                                {
                                    lbCongdoan.Text = "KHÂU IN _ START";
                                    pnCongDoan.BackColor = Color.LawnGreen;
                                }
                            }
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
                    using(Manage_evsEntities wodb = new Manage_evsEntities(clConnection.connectString2))
                    {
                        var qr = (from s in db.tblKhauIns
                                      //where s.workorder == lbWO.Text
                                  where s.WOID == lbID.Text && s.workorder == lbWO.Text
                                  orderby s.id descending
                                  select s).ToList();
                        if (qr[0].InTime_End != null)
                        {
                            qr[0].InTime_End = null;
                        }
                        else
                        {
                            db.tblKhauIns.Remove(qr[0]);
                            //Theo thiết bị
                            if (!check_ring)
                            {
                                var qr_input = (from s in db.tblInputs
                                                    //where s.workorder == lbWO.Text
                                                where s.WOID == lbID.Text && s.workorder == lbWO.Text && s.itemnumber == lbItem.Text
                                                select s).FirstOrDefault();
                                //Nếu là dòng cuối thì xóa ngày Khâu in ở tblInput
                                if (qr.Count == 1 && qr_input != null)
                                {
                                    qr_input.InTime_Start = null;
                                    qr_input.UserIn = null;
                                }
                            }
                            else // theo mã vòng
                            {
                                var qr_input = (from s in wodb.tblInput_Ring
                                                    //where s.workorder == lbWO.Text
                                                where s.WOID == lbID.Text && s.workorder == lbWO.Text && s.itemnumber == lbItem.Text
                                                select s).FirstOrDefault();
                                //Nếu là dòng cuối thì xóa ngày Khâu in ở tblInput
                                if (qr.Count == 1 && qr_input != null)
                                {
                                    qr_input.InTime_Start = null;
                                    qr_input.UserIn = null;
                                }
                            }
                        }

                        wodb.SaveChanges();
                        db.SaveChanges();
                        //Load lại list và control
                        loadControls(lbID.Text, lbWO.Text, lbItem.Text);
                        loadGridView(lbID.Text, lbWO.Text);
                    }
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
                        using (Manage_evsEntities wodb = new Manage_evsEntities(clConnection.connectString2))
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

                                //Theo thiết bị
                                if (!check_ring)
                                {
                                    var qr_input = (from s in db.tblInputs
                                                        //where s.workorder == wo && s.KittingTime_End != null && s.InTime_Start == null
                                                    where s.WOID == woid && s.workorder == wo && s.itemnumber == wo_part && s.KittingTime_End != null && s.InTime_Start == null
                                                    select s).FirstOrDefault();

                                    if (qr_input != null)
                                    {
                                        qr_input.InTime_Start = KhauInTime;
                                        qr_input.UserIn = txtUsername.Text;
                                    }
                                }
                                else // theo mã vòng
                                {
                                    var qr_input = (from s in wodb.tblInput_Ring
                                                        //where s.workorder == wo && s.KittingTime_End != null && s.InTime_Start == null
                                                    where s.WOID == woid && s.workorder == wo && s.itemnumber == wo_part && s.KittingTime_End != null && s.InTime_Start == null
                                                    select s).FirstOrDefault();

                                    if (qr_input != null)
                                    {
                                        qr_input.InTime_Start = KhauInTime;
                                        qr_input.UserIn = txtUsername.Text;
                                    }

                                }
                                tblKhauIn tb = new tblKhauIn();
                                tb.WOID = woid;
                                tb.workorder = wo;
                                tb.InTime_Start = KhauInTime;
                                tb.UserIn = txtUsername.Text;
                                db.tblKhauIns.Add(tb);
                                db.SaveChanges();
                                wodb.SaveChanges();
                                loadControls(woid, wo, wo_part);
                                loadGridView(woid, wo);
                            }
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

        private void loadGridView(string _woid, string _wo)
        {
            try
            {
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    var qr = (from s in db.tblKhauIns
                              join u in db.tblUsers on s.UserIn equals u.userid into tmpU
                              from u1 in tmpU.DefaultIfEmpty()
                              where s.WOID == _woid && s.workorder == _wo
                              orderby s.id
                              select new {
                                  s.WOID,
                                  s.workorder,
                                  s.InTime_Start,
                                  s.InTime_End,
                                  s.UserIn,
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
