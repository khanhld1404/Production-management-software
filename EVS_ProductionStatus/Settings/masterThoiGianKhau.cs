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
    public partial class masterThoiGianKhau : Form
    {
        Controller.clThoiGianKhau cl = new Controller.clThoiGianKhau();
        public masterThoiGianKhau()
        {
            InitializeComponent();
        }

        private void masterThoiGianKhau_Load(object sender, EventArgs e)
        {
            cl.loaddata(grThongtin);
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            txtFileURL.Text = cl.selectfile(openFileDialog1);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            cl.importdata(txtFileURL.Text);
            cl.loaddata(grThongtin);
        }

        private void grThongtin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == grThongtin.Columns["Xoa"].Index)
                {
                    var rs = MessageBox.Show("Xác nhận xóa dữ liệu hàng đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        cl.deleteItem(grThongtin.Rows[e.RowIndex].Cells["itemnumber"].Value.ToString());
                        cl.loaddata(grThongtin);
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
