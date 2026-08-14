
using EVS_ProductionStatus.Data_EVS;
using EVS_ProductionStatus.Settings;
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
                using (DB_Entities db = new DB_Entities(clConnection.connectEntity))
                {
                    var qr = (from s in db.tblUsers
                              orderby s.userid
                              select s).ToList();
                    grThongtin.Rows.Clear();
                    foreach (var item in qr)
                    {
                        int row_index = grThongtin.Rows.Add(item.userid, item.name);
                        if (item.active == "true")
                        {
                            grThongtin.Rows[row_index].Cells["active"].Value = "Hoạt Động";
                            grThongtin.Rows[row_index].Cells["action"].Value = "Khóa tài khoản";
                        }
                        else
                        {
                            grThongtin.Rows[row_index].DefaultCellStyle.BackColor = Color.PaleVioletRed;
                            grThongtin.Rows[row_index].Cells["active"].Value = "Khóa";
                            grThongtin.Rows[row_index].Cells["action"].Value = "Mở Tài Khoản";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void loaddata(string _timkiem)
        {
            using (DB_Entities db = new DB_Entities(clConnection.connectEntity))
            {
                var qr = (from s in db.tblUsers
                          where s.userid.Contains(_timkiem) || s.name.Contains(_timkiem)
                          orderby s.userid
                          select s).ToList();

                grThongtin.Rows.Clear();
                foreach (var item in qr)
                {
                    int row_index = grThongtin.Rows.Add(item.userid, item.name);
                    if (item.active == "true")
                    {
                        grThongtin.Rows[row_index].Cells["active"].Value = "Hoạt Động";
                        grThongtin.Rows[row_index].Cells["action"].Value = "Khóa tài khoản";
                    }
                    else
                    {
                        grThongtin.Rows[row_index].DefaultCellStyle.BackColor = Color.PaleVioletRed;
                        grThongtin.Rows[row_index].Cells["active"].Value = "Khóa";
                        grThongtin.Rows[row_index].Cells["action"].Value = "Mở Tài Khoản";
                    }
                }
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
                if (e.ColumnIndex == grThongtin.Columns["action"].Index)
                {
                    string _uid = grThongtin.Rows[e.RowIndex].Cells["userid"].Value.ToString();
                    Check_Account f = new Check_Account(true);
                    if(f.ShowDialog() == DialogResult.OK)
                    {
                        using (DB_Entities db = new DB_Entities(clConnection.connectEntity))
                        {
                            var user = db.tblUsers.FirstOrDefault(x => x.userid == _uid);
                            // kiểm tra xem tài khoản đang mở hay đóng
                            if (user.active == "true")
                            {
                                var rs = MessageBox.Show("Xác nhận khóa tài khoản?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (rs == DialogResult.Yes)
                                {
                                    if (user != null)
                                    {
                                        user.active = "false";
                                        db.SaveChanges();
                                        loaddata();
                                    }
                                }
                            }
                            else
                            {
                                var rs = MessageBox.Show("Xác nhận mở tài khoản?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (rs == DialogResult.Yes)
                                {
                                    if (user != null)
                                    {
                                        user.active = "true";
                                        db.SaveChanges();
                                        loaddata();
                                    }
                                }
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

        private void btn_add_admin_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có phải là tài khoản admin hay không
            Check_Account f = new Check_Account(true);
            if(f.ShowDialog() == DialogResult.OK)
            {
                Add_Admin_Account add_admin_form = new Add_Admin_Account();
                add_admin_form.Show();
            }
        }
    }
}
