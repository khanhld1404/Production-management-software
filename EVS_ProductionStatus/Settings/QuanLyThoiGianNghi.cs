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
    public partial class QuanLyThoiGianNghi : Form
    {
        bool isLoaded = false;
        public QuanLyThoiGianNghi()
        {
            InitializeComponent();
        }

        private void QuanLyThoiGianNghi_Load(object sender, EventArgs e)
        {
            isLoaded = true;
        }

        private void loaddata(string _cd)
        {
            try
            {
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    var qr = (from s in db.tblThoiGianNghis
                              where s.CongDoan == _cd
                              orderby s.BreakStartHour, s.BreakStartMin
                              select new
                              {
                                  s.id,
                                  s.CongDoan,
                                  BreakStart = s.BreakStartHour + ":" + s.BreakStartMin,
                                  BreakEnd = s.BreakEndHour + ":" + s.BreakEndMin
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cbCongDoan.Text.Trim()))
                {
                    MessageBox.Show("Hãy chọn công đoạn cần thêm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtStartHour.Text.Length > 2 || txtStartMin.Text.Length > 2 ||
                        txtEndHour.Text.Length > 2 || txtEndMin.Text.Length > 2 ||
                        txtStartHour.Text.Length < 1 || txtStartMin.Text.Length < 1 ||
                        txtEndHour.Text.Length < 1 || txtEndMin.Text.Length < 1 ||
                        Convert.ToInt32(txtStartHour.Text) > 23 || Convert.ToInt32(txtEndHour.Text) > 23 ||
                        Convert.ToInt32(txtStartMin.Text) > 59 || Convert.ToInt32(txtEndMin.Text) > 59)
                    {
                        MessageBox.Show("Lỗi. Xem lại dữ liệu đã nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string startHour, startMin, endHour, endMin;
                    startHour = txtStartHour.Text.Length == 1 ? "0" + txtStartHour.Text : txtStartHour.Text;
                    startMin = txtStartMin.Text.Length == 1 ? "0" + txtStartMin.Text : txtStartMin.Text;
                    endHour = txtEndHour.Text.Length == 1 ? "0" + txtEndHour.Text : txtEndHour.Text;
                    endMin = txtEndMin.Text.Length == 1 ? "0" + txtEndMin.Text : txtEndMin.Text;

                    if (Convert.ToInt32(startHour + startMin) > Convert.ToInt32(endHour + endMin))
                    {
                        MessageBox.Show("Lỗi. Thời gian bắt đầu cần nhỏ hơn thời gian kết thúc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    using (Entities db = new Entities(clConnection.connectEntity))
                    {                     
                        var qr = db.pro_07_TimeOverlapRows(startHour, startMin, endHour, endMin, cbCongDoan.Text).FirstOrDefault();

                        if (qr > 0)
                        {
                            MessageBox.Show("Khoảng thời gian bị trùng, kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            tblThoiGianNghi tb = new tblThoiGianNghi();
                            tb.CongDoan = cbCongDoan.Text;
                            tb.BreakStartHour = startHour;
                            tb.BreakStartMin = startMin;
                            tb.BreakEndHour = endHour;
                            tb.BreakEndMin = endMin;
                            db.tblThoiGianNghis.Add(tb);
                            db.SaveChanges();
                            loaddata(cbCongDoan.Text);
                        }
                    }
                }
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
                        int tmpID = Convert.ToInt32(grThongtin.Rows[e.RowIndex].Cells["id"].Value);
                        using (Entities db = new Entities(clConnection.connectEntity))
                        {
                            var qr = (from s in db.tblThoiGianNghis
                                      where s.id == tmpID
                                      select s).FirstOrDefault();
                            if (qr != null)
                            {
                                db.tblThoiGianNghis.Remove(qr);
                                db.SaveChanges();
                                loaddata(cbCongDoan.Text);
                            }

                        }
                    }
                }
            }
        }

        private void cbCongDoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                loaddata(cbCongDoan.Text);
            }
        }

    }
}
