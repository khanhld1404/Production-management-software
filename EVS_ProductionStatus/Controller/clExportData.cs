using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVS_ProductionStatus.Controller
{
    class clExportData
    {
        public void LoadKitting(DataGridView gr, DateTime _from, DateTime _to, string _masp, string _lot, string _manv, string _wo, string _loaisp)
        {
            try
            {
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    var qr = db.pro_10_KittingTime(_from, _to, _masp, _lot, _manv, _wo, _loaisp).ToList();

                    typeof(DataGridView).InvokeMember(
                                                    "DoubleBuffered",
                                                    BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                                                    null,
                                                    gr,
                                                    new object[] { true });

                    gr.Invoke(new Action(() =>
                    {
                        gr.AutoGenerateColumns = false;
                        gr.DataSource = qr;
                        gr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                    }));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public void LoadKhau(DataGridView gr, DateTime _from, DateTime _to, string _masp, string _lot, string _manv, string _wo, string _loaisp)
        {
            try
            {
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    var qr = db.pro_08_KhauTime(_from, _to, _masp, _lot, _manv, _wo, _loaisp).ToList();

                    typeof(DataGridView).InvokeMember(
                                                    "DoubleBuffered",
                                                    BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                                                    null,
                                                    gr,
                                                    new object[] { true });

                    gr.Invoke(new Action(() =>
                    {
                        //gr.AutoGenerateColumns = false;
                        gr.DataSource = qr;
                        //gr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                    }));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void LoadQC(DataGridView gr, DateTime _from, DateTime _to, string _masp, string _lot, string _manv, string _wo, string _loaisp)
        {
            try
            {
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    var qr = db.pro_09_QCTime(_from, _to, _masp, _lot, _manv, _wo, _loaisp).ToList();

                    typeof(DataGridView).InvokeMember(
                                                    "DoubleBuffered",
                                                    BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                                                    null,
                                                    gr,
                                                    new object[] { true });

                    gr.Invoke(new Action(() =>
                    {
                        //gr.AutoGenerateColumns = false;
                        gr.DataSource = qr;
                        gr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                    }));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void LoadDongGoi(DataGridView gr, DateTime _from, DateTime _to, string _masp, string _lot, string _manv, string _wo, string _loaisp)
        {
            try
            {
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    var qr = db.pro_11_DongGoiTime(_from, _to, _masp, _lot, _manv, _wo, _loaisp).ToList();

                    typeof(DataGridView).InvokeMember(
                                                    "DoubleBuffered",
                                                    BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                                                    null,
                                                    gr,
                                                    new object[] { true });

                    gr.Invoke(new Action(() =>
                    {
                        gr.AutoGenerateColumns = false;
                        gr.DataSource = qr;
                        gr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                    }));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ExportToExcel(DataGridView gr)
        {
            try
            {
                if (gr.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.FileName = DateTime.Now.ToString("yyMMddHHmmss") + "_DataExport";
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

                            for (int row = 0; row < gr.Rows.Count; row++)
                            {
                                int excelcol = 1;
                                for (int col = 0; col < gr.Columns.Count; col++)
                                {
                                    if (gr.Columns[col].Visible == true)
                                    {
                                        if (row == 0)
                                        {
                                            ws.Cells[1, excelcol].Value = gr.Columns[col].HeaderText;
                                        }
                                        ws.Cells[row + 2, excelcol].Value = gr.Rows[row].Cells[col].Value;
                                        excelcol++;

                                        //Các cột tên Start / End được hiểu là cột thời gian thao tác >> thay đổi định dạng
                                        if (gr.Columns[col].Name.Contains("Bắt_đầu") || gr.Columns[col].Name.Contains("Bắt đầu") ||
                                            gr.Columns[col].Name.Contains("Kết_thúc") || gr.Columns[col].Name.Contains("Kết thúc") ||
                                            gr.Columns[col].Name.Contains("Thời_gian") || gr.Columns[col].Name.Contains("Thời gian"))
                                        {
                                            ws.Column(col+1).Style.Numberformat.Format = "dd/mm/yyyy hh:mm";
                                        }
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




        public void loadcbLoai(ComboBox cb)
        {
            try
            {
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    var qr = (from s in db.v_DSLoaiSP select s).ToList();
                    qr.Insert(0, new v_DSLoaiSP { loaisp = "" });
                    cb.DataSource = qr;
                    cb.DisplayMember = "LoaiSP";
                    cb.ValueMember = "LoaiSP";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }

    class LoaiSP
    {
        string maloai { get; set; }
        string tenloai { get; set; }
    }
}
