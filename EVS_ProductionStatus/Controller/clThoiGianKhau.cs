using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVS_ProductionStatus.Controller
{
    class clThoiGianKhau
    {
        public void loaddata(DataGridView gr)
        {
            try
            {
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    var qr = (from s in db.tblThoiGianKhaus
                              select s).ToList();

                    gr.AutoGenerateColumns = false;
                    gr.DataSource = qr;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void importdata(string _url)
        {
            try
            {
                if (!string.IsNullOrEmpty(_url))
                {
                    FileInfo fileInfo = new FileInfo(Path.GetFullPath(_url));
                    using (ExcelPackage p = new ExcelPackage(fileInfo))
                    {
                        var ws = p.Workbook.Worksheets[1];
                        int rowCount = ws.Dimension.End.Row;     //get row count                      

                        using (Entities db = new Entities(clConnection.connectEntity))
                        {
                            for (int i = 2; i <= rowCount; i++)
                            {
                                string _item = ws.Cells[i, 1].Value.ToString();
                                var qr = (from s in db.tblThoiGianKhaus
                                          where s.itemnumber == _item
                                          select s).FirstOrDefault();

                                if (qr != null)
                                {
                                    qr.sophut = Convert.ToInt32(ws.Cells[i, 2].Value ?? 0);
                                }
                                else
                                {
                                    tblThoiGianKhau tb = new tblThoiGianKhau();
                                    tb.itemnumber = ws.Cells[i, 1].Value.ToString();
                                    tb.sophut = Convert.ToInt32(ws.Cells[i, 2].Value ?? 0);
                                    db.tblThoiGianKhaus.Add(tb);
                                }
                            }
                            db.SaveChanges();
                        }
                    }
                    MessageBox.Show("Nhập dữ liệu thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void deleteItem(string _item)
        {
            try
            {
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    var qr = (from s in db.tblThoiGianKhaus
                              where s.itemnumber == _item
                              select s).FirstOrDefault();

                    if (qr != null)
                    {
                        db.tblThoiGianKhaus.Remove(qr);

                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public string selectfile(OpenFileDialog openFileDialog)
        {
            string kq = "";
            openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                kq = openFileDialog.FileName;
            }


            return kq;
        }
    }
}
