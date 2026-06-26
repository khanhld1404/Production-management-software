using EVS_ProductionStatus.Data_EVS;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EVS_ProductionStatus.Class
{
    class clMaBanVe
    {

        public void loaddata(DataGridView gr)
        {
            try
            {
                using (DB_Entities db = new DB_Entities(clConnection.connectEntity))
                {
                    var qr = (from s in db.tblBanVes
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
                        
                        using (DB_Entities db = new DB_Entities(clConnection.connectEntity))
                        {
                            db.pro_04_TruncateBanVe();

                            for (int i = 2; i <= rowCount; i++)
                            {
                                tblBanVe tb = new tblBanVe();
                                tb.itemnumber = ws.Cells[i, 1].Value.ToString();
                                tb.mabanve = ws.Cells[i, 2].Value.ToString();
                                db.tblBanVes.Add(tb);
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
