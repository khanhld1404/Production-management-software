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
    public partial class Check_Account : Form
    {
        // Biến dùng để biết có kiểm tra xem tài khoản có phải là admin hay không hay chỉ cần kiểm tra tài khoản thôi
        bool check_admin = false;
        public Check_Account(bool _check_admin)
        {
            InitializeComponent();
            check_admin = _check_admin;
        }

        private void Check_Admin_Account_Load(object sender, EventArgs e)
        {
            txt_account.Focus();
        }
        // Hàm dùng để kiểm tra xem mã nhân viên có đúng là tài khoản admin hay ko
        private void check_admin_account()
        {
            string tt = txt_account.Text.Trim().ToString();
            if(tt == "")
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
                        if (user.admin_role == "true")
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Nhân viên không phải là admin");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên không tồn tại!");
                    }
                }
            }
        }
        // Kiểm tra xem tài khoản có tồn tại không
        private void check_regular_account()
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
                               .Any(x => x.userid == tt);
                    if (user)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên không tồn tại!");
                    }
                }
            }
        }
        private void btn_check_account_Click(object sender, EventArgs e)
        {
            if(check_admin)
            {
                check_admin_account();
            }
            else
            {
                check_regular_account();
            }
        }

        private void txt_account_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (check_admin)
                {
                    check_admin_account();
                }
                else
                {
                    check_regular_account();
                }
            }
        }
    }
}
