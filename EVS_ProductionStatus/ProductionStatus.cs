using EVS_ProductionStatus.Data;
using EVS_ProductionStatus.Update_Inventory.Class;
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
    public partial class ProductionStatus : Form
    {
        clMethod cl = new clMethod();
        tblInput current_data = new tblInput();
        string wo = "", woid = "",wo_part = "",dr = "",drNorm = "";
        string type1, type2, type3;
        UC_Status_OneCategory uc;
        UC_Status uc4_1, uc4_2, uc4_3;
        bool isEmployeeScan;
        int NumberOfUC;
        string product_type_desc_string = "";

        public ProductionStatus(string _type1)
        {
            InitializeComponent();
            type1 = _type1;
            NumberOfUC = 1;
            lbType.Text = _type1;
        }

        public ProductionStatus(string _type1, string _type2, string _type3)
        {
            InitializeComponent();
            type1 = _type1;
            type2 = _type2;
            type3 = _type3;
            NumberOfUC = 3;
            lbType.Text = _type1 + "_" + _type2 + "_" + _type3 + "_";
        }


        private void ProductionStatus_Load(object sender, EventArgs e)
        {
            addUC();
            uc_loaddata();
            timer1.Start();
        }

        private void addUC()
        {
            switch (NumberOfUC)
            {
                case 1:
                    uc = new UC_Status_OneCategory(type1);
                    uc.Location = new Point(43, 43);
                    uc.event_UCClick += UC_Clicked;
                    this.Controls.Add(uc);
                    break;
                case 3:
                    uc4_1 = new UC_Status(type1);
                    uc4_1.Location = new Point(7, 43);
                    uc4_1.event_UCClick += UC_Clicked;
                    this.Controls.Add(uc4_1);

                    uc4_2 = new UC_Status(type2);
                    uc4_2.Location = new Point(325, 43);
                    uc4_2.event_UCClick += UC_Clicked;
                    this.Controls.Add(uc4_2);

                    uc4_3 = new UC_Status(type3);
                    uc4_3.Location = new Point(644, 43);
                    uc4_3.event_UCClick += UC_Clicked;
                    this.Controls.Add(uc4_3);
                    break;
            }

        }

        private void UC_Clicked()
        {
            if (txtUsername.Visible == true)
                txtUsername.Select();
            else
                txtBarcode.Select();
        }


        //Load lại trạng thái sản xuất định kỳ
        private void timer1_Tick(object sender, EventArgs e)
        {
            uc_loaddata();
        }

        private void uc_loaddata()
        {
            switch (NumberOfUC)
            {
                case 1:
                    uc.loaddata();
                    break;
                case 3:
                    uc4_1.loaddata();
                    uc4_2.loaddata();
                    uc4_3.loaddata();
                    btn_Kitting.Hide();
                    break;
            }

        }


        #region Đồng bộ từ excel
        //Bấm nút đồng bộ, load dữ liệu từ excel sau đó cập nhật trạng thái sx hiện tại
        private void btnDongBoDL_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
            else
                MessageBox.Show("Đang load dữ liệu, vui lòng chờ kết thúc trước khi thao tác tiếp");
        }

        //Bắt đầu đồng bộ từ excel
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            picLoading.Invoke(new Action(() => picLoading.Visible = true));
            cl.DongBoDL();
        }

        //Kết thúc đồng bộ excel
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            picLoading.Invoke(new Action(() => picLoading.Visible = false));
            //Sau khi đồng bộ xong thì load lại dữ liệu
            uc_loaddata();
            txtBarcode.Invoke(new Action(() => txtBarcode.Select()));
        }

        #endregion

        #region Nhập dữ liệu
        //Quét mã chỉ thị, kiểm tra chỉ thị có tồn tại hay đã hoàn thành không, sau đó hiển thị công đoạn hiện tại, cập nhật trạng thái
        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    backgroundWorker3.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Xử lý khi quét mã chỉ thị
        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //Bóc tách số workorder >> so ID
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
                else if(dr.Length == 2 && char.IsDigit(dr[0]))
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

                //Ẩn các control chưa được phép hiện, để reset từ đầu mỗi lần quét
                pnData.Invoke(new Action(() => pnData.Visible = false));
                lbError.Invoke(new Action(() => lbError.Visible = false));
                pnNhanVien.Invoke(new Action(() => pnNhanVien.Visible = false));
                lbNguoiTT.Invoke(new Action(() => lbNguoiTT.Visible = false));
                lbTenNguoiTT.Invoke(new Action(() => lbTenNguoiTT.Visible = false));
                lbScanned.Invoke(new Action(() => lbScanned.Text = ""));


                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    //Đầu tiên tìm trong dữ liệu Input nếu có thì cập nhật vào
                    var qr_input = (from s in db.tblInputs
                                        //where s.workorder == wo
                                    where s.WOID == woid && s.workorder == wo && s.itemnumber == wo_part
                                    select s).FirstOrDefault();

                    if (qr_input != null)
                    {
                        //Nếu quét đến công đoạn cuối rồi thì không quét nữa
                        if (qr_input.DongGoi_End != null)
                        {
                            lbError.Invoke(new Action(() => lbError.Text = "Lỗi. Chỉ thị sản xuất đã hoàn thành!"));
                            lbError.Invoke(new Action(() => lbError.Visible = true));
                            return;
                        }
                        else
                        {
                            current_data = qr_input;
                            //Hiển thị cửa sổ nhập mã nhân viên với các bước:
                            //1.Kitting end
                            //2.Khâu in
                            //3.QC in
                            //4. Đóng gói in >> 230814 thay đổi thành Đóng gói out
                            if ((qr_input.DongGoi_End == null && qr_input.DongGoi_Start != null))
                            {
                                pnNhanVien.Invoke(new Action(() => pnNhanVien.Visible = true));
                                lbBarcode2.Invoke(new Action(() => lbBarcode2.Text = "Quét mã nhân viên"));
                                isEmployeeScan = true;
                                txtUsername.Invoke(new Action(() => txtUsername.Select()));
                                return;

                            }

                            if (qr_input.KittingTime_End == null || qr_input.InTime_Start == null ||
                                (qr_input.QCTime_Start == null && qr_input.OutTime != null))
                            {
                                pnNhanVien.Invoke(new Action(() => pnNhanVien.Visible = true));
                                lbBarcode2.Invoke(new Action(() => lbBarcode2.Text = "Quét mã nhân viên"));
                                isEmployeeScan = true;
                                txtUsername.Invoke(new Action(() => txtUsername.Select()));
                                return;

                                //Xử lý tiếp ở sự kiện txtUsername keydown


                            }
                            //Thêm thời gian trường hợp khâu out, qc end mà k cần quét mã nhân viên: Thêm ĐG (start)
                            else
                            {
                                if (qr_input.OutTime == null)
                                {
                                    DateTime KhauEnd = DateTime.Now;
                                    qr_input.OutTime = KhauEnd;

                                    //Thêm thời gian khâu in end bằng thời gian khâu out
                                    var qr_khauin = (from s in db.tblKhauIns
                                                         //where s.workorder == wo
                                                     where s.WOID == woid && s.workorder == wo
                                                     orderby s.id descending
                                                     select s).FirstOrDefault();
                                    if (qr_khauin != null)
                                    {
                                        qr_khauin.InTime_End = KhauEnd;
                                    }

                                    db.SaveChanges();
                                }
                                else
                                {
                                    if (qr_input.QCTime_End == null)
                                    {
                                        DateTime QCEndTime = DateTime.Now;
                                        qr_input.QCTime_End = QCEndTime;

                                        //Thêm thời gian khâu in end bằng thời gian khâu out
                                        var qr_qc = (from s in db.tblQCs
                                                         //where s.workorder == wo
                                                     where s.WOID == woid && s.workorder == wo
                                                     orderby s.id descending
                                                     select s).FirstOrDefault();
                                        if (qr_qc != null)
                                        {
                                            qr_qc.QCTime_End = QCEndTime;
                                        }

                                        db.SaveChanges();
                                    }
                                    else
                                    {
                                        if (qr_input.DongGoi_Start == null)
                                        {
                                            //DateTime dg = DateTime.Now;
                                            ////Kiểm tra xem có DG đồng thời không
                                            //if (qr_input.DongGoiGroup != null)
                                            //{
                                            //    var qrDG = (from s in db.tblInputs
                                            //                     where s.DongGoiGroup == qr_input.DongGoiGroup
                                            //                     select s).ToList();
                                            //    foreach (var tmp in qrDG)
                                            //    {
                                            //        tmp.DongGoi_End = dg;
                                            //    }
                                            //}
                                            //else
                                            //{
                                            //    qr_input.DongGoi_End = dg;
                                            //}
                                            //db.SaveChanges();
                                            DateTime DGStart = DateTime.Now;
                                            qr_input.DongGoi_Start = DGStart;
                                            db.SaveChanges();
                                        }
                                    }
                                }
                            }
                        }
                    }

                    //Nếu không có chỉ thị đã nhập trong tblInput thì tìm trong bảng WO
                    else
                    {
                        using (Manage_evsEntities wodb = new Manage_evsEntities(clConnection.connectString2))
                        {
                            var qr = (from s in wodb.tblWOes
                                          //where s.workorder == wo
                                      where s.WORK_ORDER_ID == woid && s.WORK_ORDER == wo && s.WO_PART == wo_part && (s.DRAWING_REV == dr || s.DRAWING_REV == drNorm)
                                      select s).FirstOrDefault();
                            
                            //Nếu bảng WO không có thì báo lỗi
                            if (qr == null)
                            {
                                lbError.Invoke(new Action(() => lbError.Text = "Lỗi. Số chỉ thị không tồn tại!"));
                                lbError.Invoke(new Action(() => lbError.Visible = true));
                                return;
                            }
                            //Nếu bảng WO có thì thêm mới vào bảng Input >> có thì quét mã bản vẽ  
                            //Quét bản vẽ với chủng loại TREO vs RELAY
                            else
                            {
                                product_type_desc_string = qr.WORK_ORDER_ID.Substring(0, 1);

                                //Tạm thời bỏ quét mã bản vẽ TREO >> mở lại quét mã bản vẽ treo
                                if (product_type_desc_string == "T" || product_type_desc_string == "R")
                                //if (product_type_desc_string == "Sten")
                                {
                                    pnNhanVien.Invoke(new Action(() => pnNhanVien.Visible = true));
                                    lbBarcode2.Invoke(new Action(() => lbBarcode2.Text = "Quét mã bản vẽ"));
                                    isEmployeeScan = false;
                                    txtUsername.Invoke(new Action(() => txtUsername.Select()));

                                    //Xử lý tiếp ở sự kiện txtUsername keydown

                                    return;
                                }
                                else
                                {
                                    tblInput tb = new tblInput();
                                    tb.WOID = qr.WORK_ORDER_ID;
                                    tb.workorder = qr.WORK_ORDER;
                                    tb.itemnumber = qr.WO_PART;
                                    tb.lot = qr.LOT_SERIAL;
                                    string s = qr.ORDER_QTY.Split('.')[0];
                                    MessageBox.Show(s);
                                    if (int.TryParse(s,out int value))
                                    {
                                        tb.qty = value;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Dữ liệu có vấn đề");
                                        return;
                                    }
                                    tb.KittingTime_Start = DateTime.Now;
                                    tb.desc1 = qr.DESCRIPTION_FOR_WO_COMPONENT_VN;
                                    tb.desc2 = qr.DESCRIPTION_FOR_WO_COMPONENT_EN;
                                    db.tblInputs.Add(tb);
                                    db.SaveChanges();
                                    current_data = tb;
                                }
                            }
                        }
                    }
                }

                //Hiển thị dữ liệu với công đoạn kitting và khâu out, khâu in sẽ hiển thị riêng sau khi quét mã nv
                loadControls(current_data);
                //Load lại dữ liệu
                uc_loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        //Kết thúc xử lý quét mã chỉ thị
        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            txtBarcode.Invoke(new Action(() => txtBarcode.Text = ""));
        }


        //Hiển thị thông tin công đoạn hiện tại vào control
        private void loadControls(tblInput _tb)
        {
            try
            {
                lbWO.Invoke(new Action(() => lbWO.Text = _tb.workorder));
                lbID.Invoke(new Action(() => lbID.Text = _tb.WOID));
                lbItem.Invoke(new Action(() => lbItem.Text = _tb.itemnumber));
                lbLot.Invoke(new Action(() => lbLot.Text = _tb.lot));
                lbQty.Invoke(new Action(() => lbQty.Text = _tb.qty.ToString()));

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

        //Gợi ý Kitting
        private void btn_Kitting_Click(object sender, EventArgs e)
        {
            switch (NumberOfUC)
            {
                case 1:
                    Other_function.ShowUserControlAsForm(new Form_Kitting(type1), "Gợi ý Kitting");
                    break;
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

        //Bấm nút xóa lần quét gần nhất
        private void lnkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var rs = MessageBox.Show("Bạn có chắc xóa dữ liệu quét công đoạn hiện tại?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                //Bỏ thời gian trong tblInput
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    var qr = (from s in db.tblInputs
                                  //where s.workorder == lbWO.Text
                              where s.WOID == woid && s.workorder == wo && s.itemnumber == wo_part
                              select s).FirstOrDefault();

                    //Lấy dữ liệu khâu in ở bảng tblKhauIn để cập nhật
                    var qr_khauin = (from s in db.tblKhauIns
                                         //where s.workorder == lbWO.Text
                                     where s.WOID == lbID.Text && s.workorder == lbWO.Text
                                     orderby s.id descending
                                     select s).ToList();

                    //Lấy dữ liệu QC ở bảng tblQC để cập nhật
                    var qr_qc = (from s in db.tblQCs
                                     //where s.workorder == lbWO.Text
                                 where s.WOID == lbID.Text && s.workorder == lbWO.Text
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
                               where s.WOID == lbID.Text && s.workorder == lbWO.Text && s.itemnumber == lbItem.Text
                               select s).FirstOrDefault();
                    if (qr1 == null)
                    {
                        pnData.Visible = false;
                    }
                    else
                    {
                        loadControls(qr1);
                    }
                }
                uc_loaddata();
            }
            //Chọn lại ô quét mã vạch
            txtBarcode.Select();
        }

        //Quét mã người dùng
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
                        //Quét mã người dùng
                        if (isEmployeeScan)
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
                                //Đầu tiên tìm trong dữ liệu Input nếu có thì cập nhật vào
                                var qr_input = (from s in db.tblInputs
                                                    //where s.workorder == wo
                                                where s.WOID == woid && s.workorder == wo && s.itemnumber == wo_part
                                                select s).FirstOrDefault();
                                // Sử dụng else if thay vì chỉ if để ngăn chặn trường hợp chạy cả hai if
                                if (qr_input.KittingTime_End == null)
                                {
                                    DateTime kittingEnd = DateTime.Now;
                                    //Kiểm tra xem có kitting đồng thời không
                                    if (qr_input.KittingGroup != null)
                                    {
                                        var qrKitting = (from s in db.tblInputs
                                                         where s.KittingGroup == qr_input.KittingGroup
                                                         select s).ToList();
                                        foreach (var tmp in qrKitting)
                                        {
                                            tmp.KittingTime_End = kittingEnd;
                                            tmp.UserKitting = txtUsername.Text;
                                        }
                                    }
                                    else
                                    {
                                        qr_input.KittingTime_End = kittingEnd;
                                        qr_input.UserKitting = txtUsername.Text;
                                    }

                                    goto user_save_point;
                                }


                                //Sau khi khâu thì lưu lại
                                else if (qr_input.InTime_Start == null)
                                {
                                    DateTime KhauInTime = DateTime.Now;
                                    qr_input.UserIn = txtUsername.Text;
                                    qr_input.InTime_Start = KhauInTime;
                                    //Thêm vào bảng tblKhauIn
                                    tblKhauIn tb = new tblKhauIn();
                                    tb.WOID = woid;
                                    tb.workorder = wo;
                                    tb.InTime_Start = KhauInTime;
                                    tb.UserIn = txtUsername.Text;
                                    db.tblKhauIns.Add(tb);

                                    goto user_save_point;
                                }
                                //Sau khi qc thì lưu lại
                                else if (qr_input.QCTime_Start == null)
                                {
                                    DateTime QCTime = DateTime.Now;
                                    qr_input.UserQC = txtUsername.Text;
                                    qr_input.QCTime_Start = QCTime;
                                    //Thêm vào bảng tblQC
                                    tblQC tb = new tblQC();
                                    tb.WOID = woid;
                                    tb.workorder = wo;
                                    tb.QCTime_Start = QCTime;
                                    tb.UserQC = txtUsername.Text;
                                    db.tblQCs.Add(tb);

                                    goto user_save_point;
                                }
                                //230814 Chuyen tu dong goi start > dong goi end
                                else if (qr_input.DongGoi_End == null)
                                {
                                    DateTime dgTime = DateTime.Now;
                                    //Neu k dong goi dong thoi thi ket thuc id nao cap nhat id day
                                    if (qr_input.DongGoiGroup == null)
                                    {
                                        qr_input.UserDongGoi = txtUsername.Text;
                                        qr_input.DongGoi_End = dgTime;
                                    }
                                    else
                                    {
                                        var qrDG = (from s in db.tblInputs
                                                    where s.DongGoiGroup == qr_input.DongGoiGroup
                                                    select s).ToList();
                                        foreach (var tmp in qrDG)
                                        {
                                            tmp.UserDongGoi = txtUsername.Text;
                                            tmp.DongGoi_End = dgTime;
                                        }
                                    }


                                    goto user_save_point;
                                }

                            user_save_point:

                                db.SaveChanges();
                                //Them UC vao flowlayout
                                loadControls(qr_input);
                                //Load lại dữ liệu
                                uc_loaddata();
                            }
                        }
                        //Quét mã bản vẽ Kitting start
                        else
                        {
                            using (Manage_evsEntities wodb = new Manage_evsEntities(clConnection.connectString2))
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
                                    txtUsername.Text = "";
                                    return;
                                }

                                if (txtUsername.Text != qr_banve.mabanve)
                                {
                                    lbError.Text = "Lỗi. Mã bản vẽ không phù hợp";
                                    lbError.Visible = true;
                                    txtUsername.Text = "";
                                    return;
                                }
                                else
                                {
                                    tblInput tb = new tblInput();
                                    tb.WOID = qr_dr.WORK_ORDER_ID;
                                    tb.workorder = qr_dr.WORK_ORDER;
                                    tb.itemnumber = qr_dr.WO_PART;
                                    tb.lot = qr_dr.LOT_SERIAL;
                                    string s = qr_dr.ORDER_QTY.Split('.')[0];
                                    if (int.TryParse(s, out int value))
                                    {
                                        tb.qty = value;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Dữ liệu có vấn đề");
                                        return;
                                    }
                                    tb.KittingTime_Start = DateTime.Now;
                                    tb.desc1 = qr_dr.DESCRIPTION_FOR_WO_COMPONENT_VN;
                                    tb.desc2 = qr_dr.DESCRIPTION_FOR_WO_COMPONENT_EN;

                                    db.tblInputs.Add(tb);
                                    db.SaveChanges();

                                    //Them UC vao flowlayout
                                    loadControls(tb);
                                    //Load lại dữ liệu
                                    uc_loaddata();
                                }
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

        //Hủy quét mã người dùng
        private void lnkCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                txtUsername.Text = "";
                pnNhanVien.Visible = false;
                txtBarcode.Text = "";
                txtBarcode.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnNhapKhau_Click(object sender, EventArgs e)
        {
            NhapKhauIn f = new NhapKhauIn();
            if (f.ShowDialog() == DialogResult.Cancel)
            {
                txtBarcode.Select();
            }
        }

        private void btnQCDoDang_Click(object sender, EventArgs e)
        {
            NhapQCDoDang f = new NhapQCDoDang();
            if (f.ShowDialog() == DialogResult.Cancel)
            {
                txtBarcode.Select();
            }
        }

        private void btnKittingDongThoi_Click(object sender, EventArgs e)
        {
            KittingDongThoi f = new KittingDongThoi();
            if (f.ShowDialog() == DialogResult.Cancel)
            {
                txtBarcode.Select();
            }
        }


        private void btnDongGoiDongThoi_Click(object sender, EventArgs e)
        {
            DongGoiDongThoi f = new DongGoiDongThoi();
            if (f.ShowDialog() == DialogResult.Cancel)
            {
                txtBarcode.Select();
            }
        }

        #endregion


    }
}
