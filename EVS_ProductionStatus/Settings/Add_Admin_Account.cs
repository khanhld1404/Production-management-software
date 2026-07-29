using EVS_ProductionStatus.Data_EVS;
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
    public partial class Add_Admin_Account : Form
    {
        public Add_Admin_Account()
        {
            InitializeComponent();
        }

        private void Check_Admin_Account_Load(object sender, EventArgs e)
        {
            txt_account.Focus();
        }
        // Hàm dùng để kiểm tra xem mã nhân viên có đúng là tài khoản admin hay ko
        private void check_account()
        {
            string tt = txt_account.Text.Trim().ToString();
            if (tt == "")
            {
                MessageBox.Show("Mời bạn nhập mã nhân viên!");
            }
            else
            {
                using (DB_Entities db = new DB_Entities(clConnection.connectEntity))
                {
                    var user = db.tblUser_EVS
                               .Where(x => x.userid == tt)
                               .FirstOrDefault();
                    if (user != null)
                    {
                        user.admin_role = "true";
                        db.SaveChanges();
                        ToastForm.Show("Thông báo", $"Mã nhân viên {user.userid} đã được thêm quyền admin thành công!");
                        txt_account.Text = "";
                        txt_account.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên không tồn tại!");
                    }
                }
            }
        }
        private void btn_add_account_Click(object sender, EventArgs e)
        {
            check_account();
        }

        private void txt_account_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
