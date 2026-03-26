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
    public partial class ThietLapFile : Form
    {
        public ThietLapFile()
        {
            InitializeComponent();
        }

        private void ThietLapFile_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void loaddata()
        {
            try
            {
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    var qr = (from s in db.tblURLs
                              where s.Code == "FILE_URL"
                              select s).FirstOrDefault();
                    if (qr != null)
                    {
                        txtURL.Text = qr.URL;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtURL.Text = openFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtURL.Text))
                {
                    MessageBox.Show("Chưa chọn file");
                    
                }
                else
                {
                    using (Entities db = new Entities(clConnection.connectEntity))
                    {
                        var qr = (from s in db.tblURLs
                                  where s.Code == "FILE_URL"
                                  select s).FirstOrDefault();
                        if (qr != null)
                        {
                            qr.URL = txtURL.Text;
                        }
                        else
                        {
                            tblURL tb = new tblURL();
                            tb.Code = "FILE_URL";
                            tb.URL = txtURL.Text;
                            db.tblURLs.Add(tb);
                        }
                        db.SaveChanges();
                        MessageBox.Show("Lưu thành công");
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
