using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVS_ProductionStatus
{
    public partial class QuanLyNguoiThaoTac : Form
    {
        public QuanLyNguoiThaoTac()
        {
            InitializeComponent();
        }

        private void QuanLyNguoiThaoTac_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void loaddata()
        {
            try
            {
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    var qr = (from s in db.tblUsers
                              orderby s.userid
                              select s).ToList();
                    grThongtin.AutoGenerateColumns = false;
                    grThongtin.DataSource = qr;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void loaddata(string _timkiem)
        {
            using (Entities db = new Entities(clConnection.connectEntity))
            {
                var qr = (from s in db.tblUsers
                          where s.userid.Contains(_timkiem) || s.name.Contains(_timkiem)
                          orderby s.userid
                          select s).ToList();
                grThongtin.AutoGenerateColumns = false;
                grThongtin.DataSource = qr;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtUserID.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }

                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    if (isExistUserID(txtUserID.Text))
                        MessageBox.Show("Mã người thao tác đã tồn tại");
                    else
                    {
                        tblUser tb = new tblUser();
                        tb.userid = txtUserID.Text;
                        tb.name = txtName.Text;
                        db.tblUsers.Add(tb);
                        db.SaveChanges();
                        MessageBox.Show("Thêm thành công");
                        loaddata();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            loaddata(txtTimKiem.Text);
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
                        string _uid = grThongtin.Rows[e.RowIndex].Cells["userid"].Value.ToString();
                        using (Entities db = new Entities(clConnection.connectEntity))
                        {
                            var qr = (from s in db.tblUsers
                                      where s.userid == _uid
                                      select s).FirstOrDefault();
                            if (qr != null)
                            {
                                db.tblUsers.Remove(qr);
                                db.SaveChanges();
                                loaddata();
                            }

                        }
                    }
                }
            }
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    loaddata(txtTimKiem.Text);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                var rs = MessageBox.Show("Khi import sẽ xóa hết người dùng hiện tại để nhập mới, có tiếp tục không?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (rs == DialogResult.Yes)
                {
                    openFileDialog1.Filter = "Excel File (*.xlsx)|*.xlsx";
                    openFileDialog1.RestoreDirectory = true;

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo fileInfo = new FileInfo(Path.GetFullPath(openFileDialog1.FileName));
                        using (ExcelPackage p = new ExcelPackage(fileInfo))
                        {
                            var ws = p.Workbook.Worksheets[1];
                            int rowCount = ws.Dimension.End.Row;     //get row count

                            using (Entities db = new Entities(clConnection.connectEntity))
                            {
                                db.pro_05_TruncateUser();
                                for (int i = 2; i <= rowCount; i++)
                                {
                                    //Nếu có ô trống, thì báo lỗi và dừng luôn
                                    if (ws.Cells[i, 1].Value == null ||
                                        ws.Cells[i, 2].Value == null)
                                    {
                                        MessageBox.Show("Lỗi. Dữ liệu có ô trống, vui lòng kiểm tra lại file");
                                        return;
                                    }
                                    tblUser tb = new tblUser();
                                    tb.userid = ws.Cells[i, 1].Value.ToString();
                                    tb.name = ws.Cells[i, 2].Value.ToString();
                                    db.tblUsers.Add(tb);

                                }
                                db.tblUsers.Add(new tblUser() { userid = "admin", name = "Quản lý hệ thống" });
                                db.SaveChanges();
                            }
                        }
                        MessageBox.Show("Import dữ liệu thành công");
                        loaddata();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool isExistUserID(string _userid)
        {
            bool kq = false;
            using (Entities db = new Entities(clConnection.connectEntity))
            {
                var qr = (from s in db.tblUsers
                          where s.userid == _userid
                          select s).FirstOrDefault();
                if (qr != null)
                    kq = true;
            }

            return kq;
        }
    }
}
