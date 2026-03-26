using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVS_ProductionStatus.Settings
{
    public partial class InputPacking : Form
    {
        public InputPacking()
        {
            InitializeComponent();
        }

        private void InputPacking_Load(object sender, EventArgs e)
        {
            txtBarcode.Select();
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string woid = "";
                    lbThoiGian.Text = "-";
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

                    lbError.Visible = false;
                    grBatDau.Rows.Clear();
                    grKetThuc.Rows.Clear();
                    DateTime currentTime = DateTime.Now;

                    using (Entities db = new Entities(clConnection.connectEntity))
                    {
                        var qr_wo = (from s in db.tblInputs
                                     where s.WOID == woid
                                     select s).FirstOrDefault();

                        if (qr_wo == null)
                        {
                            lbError.Text = "Lỗi. Số chỉ thị không phù hợp!";
                            lbError.Visible = true;
                            return;
                        }

                        //Tìm chỉ thị chờ bắt đầu đóng gói ở bảng tblInput là chỉ thị đã kết thúc QC
                        var qr_dg = (from s in db.tblInputs
                                     where s.WOID == woid && s.QCTime_End != null && s.DongGoi_Start == null
                                     select s).FirstOrDefault();
                        if (qr_dg == null)
                        {
                            lbError.Text = "Lỗi. Số chỉ thị không phù hợp để đóng gói!";
                            lbError.Visible = true;

                        }
                        else
                        {
                            //Thiet lap thoi gian cho nguoi dung quan sat
                            lbThoiGian.Text = currentTime.ToString("dd/MM/yyyy HH:mm:ss");

                            //
                            qr_dg.DongGoi_Start = currentTime;

                            // 1.HIỂN THỊ CHỈ THỊ SẼ START LÊN GRIDVIEW
                            //Them vao ds se start dong goi
                            grBatDau.Rows.Add(qr_wo.WOID, qr_wo.workorder, qr_wo.itemnumber, qr_wo.lot,
                                qr_wo.desc1, qr_wo.desc2, qr_wo.qty);

                            //Lay loai san pham
                            var qr_loaisp = (from s in db.v_06_LoaiSP
                                             where s.itemnumber == qr_wo.itemnumber
                                             select s.LoaiSP).FirstOrDefault();

                            var qr_kt = (from s in db.tblInputs
                                         join l in db.v_06_LoaiSP on s.itemnumber equals l.itemnumber
                                         where l.LoaiSP == qr_loaisp && s.DongGoi_Start != null && s.DongGoi_End == null
                                         select s).ToList();
                            if (qr_kt.Count > 0)
                            {
                                foreach (var tmp in qr_kt)
                                {
                                    tmp.DongGoi_End = currentTime;
                                    grKetThuc.Rows.Add(tmp.WOID, tmp.workorder, tmp.itemnumber, tmp.lot,
                                tmp.desc1, tmp.desc2, tmp.qty);
                                }

                                
                            }
                            db.SaveChanges();                       
                        
                        }
                        
                        txtBarcode.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (grBatDau.Rows.Count == 0)
                {
                    lbError.Text = "Lỗi. Không có dữ liệu cần xóa!";
                    lbError.Visible = true;
                }
                else
                {
                    var check = MessageBox.Show("Bạn chắn chắn muốn hủy dữ liệu vừa quét?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (check == DialogResult.Yes)
                    {
                        lbError.Visible = false;
                        string _woid = grBatDau.Rows[0].Cells[0].Value.ToString();
                        using (Entities db = new Entities(clConnection.connectEntity))
                        {                            
                            var qr_input = (from s in db.tblInputs
                                            where s.WOID == _woid
                                            select s).FirstOrDefault();
                            if (qr_input != null)
                            {
                                qr_input.DongGoi_Start = null;
                                qr_input.DongGoi_End = null;
                                qr_input.DongGoiGroup = null;
                                qr_input.UserDongGoi = null;

                            }

                            string _woidKT;
                            foreach (DataGridViewRow r in grKetThuc.Rows)
                            {
                                _woidKT = r.Cells[0].Value.ToString();
                                var qr_kt = (from s in db.tblInputs
                                             where s.WOID == _woidKT
                                             select s).FirstOrDefault();
                                if (qr_kt != null)
                                {
                                    qr_kt.DongGoi_End = null;
                                    qr_kt.UserDongGoi = null;
                                }
                            }
                            db.SaveChanges();
                            grBatDau.Rows.Clear();
                            grKetThuc.Rows.Clear();
                        }
                    }
                }
                lbThoiGian.Text = "-";
                txtBarcode.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnKetThucPacking_Click(object sender, EventArgs e)
        {
            KetThucPacking f = new KetThucPacking();
            f.ShowDialog();
            txtBarcode.Select();
        }
    }
}
