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
    public partial class InputForm : Form
    {
        string code;
        public InputForm(string _code)
        {
            InitializeComponent();
            code = _code;
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    var qr_woplan = (from s in db.tblContents
                                     where s.code == code
                                     select s.content).FirstOrDefault();
                    txtWOKH.Text = qr_woplan;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            savedata();
        }

        private void savedata()
        {
            try
            {
                //Chỉ lưu số nguyên, tránh nhập sai định dạng
                int kq = Convert.ToInt32(txtWOKH.Text);
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    var qr_woplan = (from s in db.tblContents
                                     where s.code == code
                                     select s).FirstOrDefault();
                    qr_woplan.content = kq.ToString();
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtWOKH_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    savedata();
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
