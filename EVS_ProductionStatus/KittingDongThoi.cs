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
using EVS_ProductionStatus.Data;

namespace EVS_ProductionStatus
{
    public partial class KittingDongThoi : Form
    {
        string wo = "", woid = "", wo_part = "", dr = "", drNorm = "";
        BindingList<clKittingDongThoi> lstKitting;
        public KittingDongThoi()
        {
            InitializeComponent();
        }

        private void KittingDongThoi_Load(object sender, EventArgs e)
        {
            lstKitting = new BindingList<clKittingDongThoi>();
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
                    wo_part = lst[2];
                    dr = lst[3];
                    if (!string.IsNullOrEmpty(dr) && dr.Length == 1 && char.IsDigit(dr[0]))
                    {
                        drNorm = "0" + dr;
                    }
                    else if (dr.Length == 2 && char.IsDigit(dr[0]))
                    {
                        drNorm = dr.TrimStart('0');
                    }

                    //Kiểm tra điều kiện chuỗi nhập vào nếu WO và WOID khác 8 ký tự thì báo lỗi
                    if (wo.Length != 8 || woid.Length != 10)
                    {
                        lbError.Invoke(new Action(() => lbError.Text = "Lỗi. Mã vạch không phù hợp!"));
                        lbError.Invoke(new Action(() => lbError.Visible = true));
                        return;
                    }

                    pnNhanVien.Visible = false;
                    lbError.Visible = false;
                    lbScanned.Text = "";
                    txtBarcode.Text = "";

                    using (Entities db = new Entities(clConnection.connectEntity))
                    {
                        //Đầu tiên tìm trong dữ liệu Input nếu có nghĩa là đã kitting >> báo lỗi
                        var qr_input = (from s in db.tblInputs
                                            //where s.workorder == wo
                                        where s.WOID == woid && s.workorder == wo && s.itemnumber == wo_part
                                        select s).FirstOrDefault();
                        if (qr_input != null)
                        {
                            lbError.Text = "Lỗi. Chỉ thị đã kitting trước đó!";
                            lbError.Visible = true;
                            return;
                        }
                        //Nếu không có thì tìm trong bảng workorder
                        else
                        {
                            using (Manage_evsEntities wodb = new Manage_evsEntities(clConnection.connectString2))
                            {


                                var qr = (from s in wodb.tblWOes
                                              //where s.workorder == wo
                                          where s.WORK_ORDER_ID == woid && s.WORK_ORDER == wo && s.WO_PART == wo_part && (s.DRAWING_REV == dr || s.DRAWING_REV == drNorm)
                                          select s).FirstOrDefault();
                                if (qr == null)
                                {
                                    lbError.Text = "Lỗi. Số chỉ thị không tồn tại!";
                                    lbError.Visible = true;
                                    return;
                                }
                                else
                                {
                                    var item_existed = (from s in lstKitting
                                                            //where s.workorder == wo
                                                        where s.WOID == woid && s.workorder == wo && s.itemnumber == wo_part
                                                        select s).FirstOrDefault();

                                    if (item_existed != null)
                                    {
                                        lbError.Text = "Lỗi. Chỉ thị bị trùng";
                                        lbError.Visible = true;
                                        txtMaBanVe.Text = "";
                                        return;
                                    }
                                    else
                                    {
                                        string product_type_desc_string = qr.WORK_ORDER_ID.Substring(0, 1);

                                        //Tạm thời bỏ quét mã bản vẽ TREO >> mở lại treo
                                        if (product_type_desc_string == "T" || product_type_desc_string == "R")
                                        //if (product_type_desc_string == "Sten")
                                        {
                                            pnNhanVien.Visible = true;
                                            txtMaBanVe.Select();
                                            return;
                                        }
                                        else
                                        {
                                            int s = int.Parse(qr.ORDER_QTY.Split('.')[0]);
                                            lstKitting.Add(new clKittingDongThoi()
                                            {
                                                workorder = qr.WORK_ORDER,
                                                itemnumber = qr.WO_PART,
                                                lot = qr.LOT_SERIAL,
                                                qty = s,
                                                desc1 = qr.DESCRIPTION_FOR_WO_COMPONENT_VN,
                                                desc2 = qr.DESCRIPTION_FOR_WO_COMPONENT_EN,
                                                WOID = qr.WORK_ORDER_ID
                                            });
                                            grThongtin.AutoGenerateColumns = false;
                                            grThongtin.DataSource = lstKitting;
                                            txtBarcode.Select();
                                        }

                                    }
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


        private void txtMaBanVe_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    lbError.Visible = false;
                    lbScanned.Text = txtMaBanVe.Text;
                    using (Entities db = new Entities(clConnection.connectEntity))
                    {
                        using(Manage_evsEntities wodb = new Manage_evsEntities(clConnection.connectString2))
                        {
                            //Lấy thông tin sản phẩm theo workorder
                            var qr_dr = (from s in wodb.tblWOes
                                             //where s.workorder == wo
                                         where s.WORK_ORDER_ID == woid && s.WORK_ORDER == wo && s.WO_PART == wo_part && (s.DRAWING_REV == dr || s.DRAWING_REV == drNorm)
                                         select s).FirstOrDefault();

                            //Kiểm tra mã bản vẽ nhập vào so với mã sản phẩm
                            var qr_banve = (from s in db.tblBanVes
                                            where s.itemnumber == qr_dr.WO_PART
                                            select s).FirstOrDefault();
                            if (qr_banve == null)
                            {
                                lbError.Text = "Lỗi. Sản phẩm chưa thiết lập mã bản vẽ";
                                lbError.Visible = true;
                                txtMaBanVe.Text = "";
                                return;
                            }

                            if (txtMaBanVe.Text != qr_banve.mabanve)
                            {
                                lbError.Text = "Lỗi. Mã bản vẽ không phù hợp";
                                lbError.Visible = true;
                                txtMaBanVe.Text = "";
                                return;
                            }
                            else
                            {
                                var item_existed = (from s in lstKitting
                                                        //where s.workorder == wo
                                                    where s.WOID == woid && s.workorder == wo && s.itemnumber == wo_part
                                                    select s).FirstOrDefault();

                                if (item_existed != null)
                                {
                                    lbError.Text = "Lỗi. Chỉ thị đã thêm trước đó";
                                    lbError.Visible = true;
                                    txtMaBanVe.Text = "";
                                    return;
                                }
                                else
                                {
                                    int s = int.Parse(qr_dr.ORDER_QTY.Split('.')[0]);
                                    lstKitting.Add(new clKittingDongThoi() { workorder = qr_dr.WORK_ORDER, itemnumber = qr_dr.WO_PART, lot = qr_dr.LOT_SERIAL,
                                    qty = s, desc1 = qr_dr.DESCRIPTION_FOR_WO_COMPONENT_VN, desc2 = qr_dr.DESCRIPTION_FOR_WO_COMPONENT_EN, WOID = qr_dr.WORK_ORDER_ID});
                                    grThongtin.AutoGenerateColumns = false;
                                    grThongtin.DataSource = lstKitting;
                                    txtMaBanVe.Text = "";
                                }                            
                            }
                        }
                    }
                    pnNhanVien.Visible = false;
                    txtBarcode.Select();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //Lưu dữ liệu
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    string kittingGroup = DateTime.Now.ToString("yyMMddHHmmssff");
                    DateTime kittingTime = DateTime.Now;
                    foreach (var qr_dr in lstKitting)
                    {
                        if (isExistWO(qr_dr.WOID,qr_dr.workorder,qr_dr.itemnumber))
                        {
                            MessageBox.Show("Chỉ thị đã được kitting trước đó", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        tblInput tb = new tblInput();
                        tb.WOID = qr_dr.WOID;
                        tb.workorder = qr_dr.workorder;
                        tb.itemnumber = qr_dr.itemnumber;
                        tb.lot = qr_dr.lot;
                        tb.qty = qr_dr.qty;
                        tb.KittingTime_Start = kittingTime;
                        tb.desc1 = qr_dr.desc1;
                        tb.desc2 = qr_dr.desc2;
                        tb.KittingGroup = kittingGroup;
                        db.tblInputs.Add(tb);
                    }
                    db.SaveChanges();
                }

                lstKitting.Clear();
                txtBarcode.Select();
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
                txtMaBanVe.Text = "";
                pnNhanVien.Visible = false;
                txtBarcode.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

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
                        string selectedWO = grThongtin.Rows[e.RowIndex].Cells["workorder"].Value.ToString();
                        string selectedIN = grThongtin.Rows[e.RowIndex].Cells["itemnumber"].Value.ToString();
                        var qr = (from s in lstKitting
                                  //where s.workorder == selectedwo
                                  where s.WOID == selectedID && s.workorder == selectedWO && s.itemnumber == selectedIN
                                  select s).FirstOrDefault();
                        lstKitting.Remove(qr);
                    }
                    txtBarcode.Select();
                }
            }
        }

        private bool isExistWO(string _ID, string _WO, string _itemnumber)
        {
            bool kq = false;
            using (Entities db = new Entities(clConnection.connectEntity))
            {
                var qr = (from s in db.tblInputs
                              //where s.workorder == _wo
                          where s.WOID == _ID && s.workorder == _WO && s.itemnumber == _itemnumber
                          select s).FirstOrDefault();
                if (qr != null)
                    kq = true;
            }
            return kq;
        }
    }
}
