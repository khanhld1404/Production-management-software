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

namespace EVS_ProductionStatus.Settings
{
    public partial class WOChamDongGoi : Form
    {
        public WOChamDongGoi()
        {
            InitializeComponent();
        }

        private void WOChamDongGoi_Load(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            loaddata(txtTimKiem.Text);
        }

        private void btnHuyTimKiem_Click(object sender, EventArgs e)
        {
            loaddata("");
        }

        private void loaddata(string _key)
        {
            try
            {
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    var qr = db.pro_12_WOChuaDG(_key).ToList();

                    grThongtin.Invoke(new Action(() => grThongtin.AutoGenerateColumns = false));
                    grThongtin.Invoke(new Action(() => grThongtin.DataSource = qr));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (grThongtin.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    saveFileDialog1.FileName = DateTime.Now.ToString("yyMMddHHmmss") + "_WOChuaDG";
                    saveFileDialog1.DefaultExt = "xlsx";
                    saveFileDialog1.Filter = "Excel file |*.xlsx";
                    saveFileDialog1.FilterIndex = 1;

                    var result = saveFileDialog1.ShowDialog();
                    FileInfo fileInfo = new FileInfo(Path.GetFullPath(saveFileDialog1.FileName));
                    if (result == DialogResult.OK)
                    {
                        if (File.Exists(Path.GetFullPath(saveFileDialog1.FileName)))
                        {
                            File.Delete(Path.GetFullPath(saveFileDialog1.FileName));
                        }

                        using (ExcelPackage p = new ExcelPackage(fileInfo))
                        {
                            var ws = p.Workbook.Worksheets.Add("Data");

                            for (int row = 0; row < grThongtin.Rows.Count; row++)
                            {
                                int excelcol = 1;
                                for (int col = 0; col < grThongtin.Columns.Count; col++)
                                {
                                    if (grThongtin.Columns[col].Visible == true)
                                    {
                                        if (row == 0)
                                        {
                                            ws.Cells[1, excelcol].Value = grThongtin.Columns[col].HeaderText;
                                        }
                                        ws.Cells[row + 2, excelcol].Value = grThongtin.Rows[row].Cells[col].Value;
                                        excelcol++;
                                    }
                                }
                            }

                            ws.Cells[ws.Dimension.Address].AutoFitColumns();
                            p.Save();
                            MessageBox.Show("Xuất file thành công");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loaddata(txtTimKiem.Text);
            }
        }
    }
}
