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
    public partial class DongGoiDongThoi : Form
    {
        string wo, woid;
        BindingList<clDongGoiDongThoi> lstDG;
        public DongGoiDongThoi()
        {
            InitializeComponent();
        }

        private void DongGoiDongThoi_Load(object sender, EventArgs e)
        {
            lstDG = new BindingList<clDongGoiDongThoi>();
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    //Bóc tách số workorder
                    List<string> lst = new List<string>();
                    txtBarcode.Invoke(new Action(() => lst = txtBarcode.Text.Split('%').ToList()));
                    wo = lst[0];
                    woid = lst[1].Substring(0, 10);

                    //Kiểm tra điều kiện chuỗi nhập vào nếu WO và WOID khác 8 ký tự thì báo lỗi
                    if (wo.Length != 8 || woid.Length != 10)
                    {
                        lbError.Invoke(new Action(() => lbError.Text = "Lỗi. Mã vạch không phù hợp!"));
                        lbError.Invoke(new Action(() => lbError.Visible = true));
                        return;
                    }
                    
                    lbError.Visible = false;
                    txtBarcode.Text = "";

                    using (Entities db = new Entities(clConnection.connectEntity))
                    {
                        //Đầu tiên tìm trong dữ liệu Input
                        var qr_input = (from s in db.tblInputs
                                            //where s.workorder == wo
                                        where s.WOID == woid
                                        select s).FirstOrDefault();
                        if (qr_input != null)
                        {
                            if (qr_input.DongGoi_Start != null || qr_input.QCTime_End == null)
                            {
                                lbError.Text = "Lỗi. Chỉ thị không thể đóng gói, kiểm tra trạng thái hiện tại!";
                                lbError.Visible = true;                                
                            }
                            else
                            {
                                var item_existed = (from s in lstDG
                                                        //where s.workorder == wo
                                                    where s.WOID == woid
                                                    select s).FirstOrDefault();

                                if (item_existed != null)
                                {
                                    lbError.Text = "Lỗi. Chỉ thị bị trùng";
                                    lbError.Visible = true;
                                    txtBarcode.Text = "";
                                }
                                else
                                {
                                    //pnNhanVien.Visible = true;
                                    //txtMaBanVe.Select();
                                    //230814 Thay đổi không quét mã nhân viên khi bắt đầu

                                    lstDG.Add(new clDongGoiDongThoi()
                                    {
                                        workorder = qr_input.workorder,
                                        itemnumber = qr_input.itemnumber,
                                        lot = qr_input.lot,
                                        qty = qr_input.qty,
                                        desc1 = qr_input.desc1,
                                        desc2 = qr_input.desc2,
                                        WOID = qr_input.WOID                                        
                                    });
                                    grThongtin.AutoGenerateColumns = false;
                                    grThongtin.DataSource = lstDG;
                                }
                            }
                        }
                        else
                        {
                            lbError.Text = "Lỗi. Chỉ thị không thể đóng gói, kiểm tra trạng thái hiện tại!";
                            lbError.Visible = true;                     
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //230814 Thay đổi không quét mã nhân viên khi bắt đầu
        private void txtMaBanVe_KeyDown(object sender, KeyEventArgs e)
        {
            //try
            //{
            //    if (e.KeyCode == Keys.Enter)
            //    {
            //        lbError.Visible = false;
            //        lbScanned.Text = txtMaBanVe.Text;

            //        using (Entities db = new Entities())
            //        {
            //            //Kiểm tra thông tin người thao tác có tồn tại không
            //            var qr_user = (from s in db.tblUsers
            //                           where s.userid == txtMaBanVe.Text
            //                           select s).FirstOrDefault();
            //            if (qr_user == null)
            //            {
            //                lbError.Text = "Lỗi. Người thao tác không tồn tại";
            //                lbError.Visible = true;
            //                txtMaBanVe.Text = "";
            //                return;
            //            }

            //            //Lấy thông tin sản phẩm theo workorder
            //            var qr_dr = (from s in db.tblWOes
            //                             //where s.workorder == wo
            //                         where s.WOID == woid
            //                         select s).FirstOrDefault();


            //            lstDG.Add(new clDongGoiDongThoi()
            //            {
            //                workorder = qr_dr.workorder,
            //                itemnumber = qr_dr.itemnumber,
            //                lot = qr_dr.lot,
            //                qty = qr_dr.qty,
            //                desc1 = qr_dr.desc1,
            //                desc2 = qr_dr.desc2,
            //                WOID = qr_dr.WOID,
            //                userID = txtMaBanVe.Text
            //            });
            //            grThongtin.AutoGenerateColumns = false;
            //            grThongtin.DataSource = lstDG;
            //            txtMaBanVe.Text = "";

            //        }
            //        pnNhanVien.Visible = false;
            //        txtBarcode.Select();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //Lưu dữ liệu
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    string DGGroup = DateTime.Now.ToString("yyMMddHHmmssff");
                    DateTime DGTime = DateTime.Now;
                    foreach (var qr_dr in lstDG)
                    {
                        if (isExistWO(qr_dr.WOID))
                        {
                            MessageBox.Show("Chỉ thị đã được đóng gói trước đó", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtBarcode.Text = "";
                            return;
                        }

                        var qr = (from s in db.tblInputs
                                  where s.WOID == qr_dr.WOID
                                  select s).FirstOrDefault();
                        qr.DongGoi_Start = DGTime;
                        qr.DongGoiGroup = DGGroup;
                        //qr.UserDongGoi = qr_dr.userID;
                    }
                    db.SaveChanges();
                }

                lstDG.Clear();
                txtBarcode.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Hủy quét mã người dùng
        //private void lnkCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    try
        //    {
        //        txtMaBanVe.Text = "";
        //        pnNhanVien.Visible = false;
        //        txtBarcode.Select();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}

        private void grThongtin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == grThongtin.Columns["xoa"].Index)
                {
                    var rs = MessageBox.Show("Xác nhận xóa dữ liệu hàng đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        //string selectedwo = grThongtin.Rows[e.RowIndex].Cells["workorder"].Value.ToString();
                        string selectedID = grThongtin.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                        var qr = (from s in lstDG
                                      //where s.workorder == selectedwo
                                  where s.WOID == selectedID
                                  select s).FirstOrDefault();
                        lstDG.Remove(qr);
                    }
                    txtBarcode.Select();
                }
            }
        }

        private bool isExistWO(string _ID)
        {
            bool kq = false;
            using (Entities db = new Entities(clConnection.connectEntity))
            {
                var qr = (from s in db.tblInputs
                              //where s.workorder == _wo
                          where s.WOID == _ID && s.DongGoi_Start != null
                          select s).FirstOrDefault();
                if (qr != null)
                    kq = true;
            }
            return kq;
        }
    }
}
