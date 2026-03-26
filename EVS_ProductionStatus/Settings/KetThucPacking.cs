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
    public partial class KetThucPacking : Form
    {        
        public KetThucPacking()
        {
            InitializeComponent();
        }


        private void KetThucPacking_Load(object sender, EventArgs e)
        {
            txtUsername.Select();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lbMSG.Visible = false;
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            try
            {
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    //Kiểm tra thông tin người thao tác có tồn tại không
                    var qr_user = (from s in db.tblUsers
                                   where s.userid == txtUsername.Text
                                   select s).FirstOrDefault();
                    if (qr_user == null)
                    {
                        MessageBox.Show("Người thao tác không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        //Cap nhat toan bo workorder da end ma chua co ma nhan vien
                        var qr_userdonggoi = (from s in db.tblInputs
                                              join v in db.v_06_LoaiSP on s.itemnumber equals v.itemnumber
                                              where s.DongGoi_End != null && s.UserDongGoi == null
                                              && v.LoaiSP == cbLoaiSP.Text
                                              select s).ToList();

                        foreach (var tmp in qr_userdonggoi)
                        {
                            tmp.UserDongGoi = txtUsername.Text;
                        }

                        db.SaveChanges();
                        lbMSG.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
