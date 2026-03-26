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

namespace EVS_ProductionStatus
{
    public partial class OperatorStatus : Form
    {
        bool isLoaded = false;
        public OperatorStatus()
        {
            InitializeComponent();
        }

        private void OperatorStatus_Load(object sender, EventArgs e)
        {
            loadcbcongdoan();
            isLoaded = true;
        }

        //Load các công đoạn
        private void loadcbcongdoan()
        {
            try
            {
                using (Entities db = new Entities(clConnection.connectEntity))
                {
                    var qr = (from s in db.tblViTriNguoiTTs       
                              orderby s.CongDoan
                              select s.CongDoan.ToUpper()).Distinct().ToList();
                    qr.Insert(0, "");
                    cbCongDoan.DataSource = qr;
                    cbCongDoan.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Cập nhật dư liệu, chia thành các ô
        private void loaddata(string _congdoan)
        {
            try
            {
                if (!string.IsNullOrEmpty(_congdoan))
                {
                    grThongtin.Rows.Clear();
                    using (Entities db = new Entities(clConnection.connectEntity))
                    {
                        var qr = (from s in db.tblViTriNguoiTTs
                                  where s.CongDoan == _congdoan
                                  orderby s.Nhom, s.ViTri
                                  select s).ToList();
                        var qr_max = qr.Max(s => s.ViTri);
                        int sodong = Convert.ToInt32(Math.Ceiling((decimal)qr_max / 30));
                        if (sodong <= 20)
                            sodong = 20;
                        for (int i = 0; i < sodong; i++)
                        {
                            grThongtin.Rows.Add();
                        }

                        foreach (var tmp in qr)
                        {
                            int col = (tmp.ViTri - 1) % 30;
                            int row = Convert.ToInt32((tmp.ViTri - 1) / 30);                            
                            grThongtin.Rows[row].Cells[col].Value = tmp.ViTri.ToString();
                            if (tmp.UserID != null)
                            {
                                grThongtin.Rows[row].Cells[col].Style.BackColor = Color.Yellow;
                                if (isDangKhau(tmp.ViTri, _congdoan))
                                {
                                    grThongtin.Rows[row].Cells[col].Style.BackColor = Color.LawnGreen;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Xác định mỗi vị trí có đang khâu không
        private bool isDangKhau(int _vitri, string _cd)
        {
            bool kq = false;
            using (Entities db = new Entities(clConnection.connectEntity))
            {
                string desc_string = "";
                if (_cd != "ANA")
                {
                    switch (_cd)
                    {
                        case "RELAY":
                            desc_string = "Stent";
                            break;
                        case "TREO":
                            desc_string = "Treo";
                            break;
                        case "THORA":
                            desc_string = "Gen";
                            break;
                    }

                    var qr = (from s in db.tblViTriNguoiTTs
                              join khau in db.tblKhauIns on s.UserID equals khau.UserIn
                              join ip in db.tblInputs on khau.WOID equals ip.WOID
                              where s.ViTri == _vitri && ip.desc2.StartsWith(desc_string)
                              && khau.InTime_Start != null && khau.InTime_End == null
                              //orderby khau.id descending
                              select khau).FirstOrDefault();
                    if (qr != null)
                    {
                        kq = true;
                    }
                }

                else
                {
                    var qr = (from s in db.tblViTriNguoiTTs
                              join khau in db.tblKhauIns on s.UserID equals khau.UserIn
                              join ip in db.tblInputs on khau.WOID equals ip.WOID
                              where s.ViTri == _vitri && !ip.desc2.StartsWith("Gen") && !ip.desc2.StartsWith("Treo")
                              && !ip.desc2.StartsWith("Stent")
                              && khau.InTime_Start != null && khau.InTime_End == null
                              //orderby khau.id descending
                              select khau).FirstOrDefault();
                    if (qr != null)
                    {
                        kq = true;
                        //if (qr.InTime_Start != null && qr.InTime_End == null)
                        //{
                        //    kq = true;
                        //}
                    }
                }
                
            }
            return kq;
        }

        //private int LaySoNguoiTrongNhom(string _nhom, string _congdoan)
        //{
        //    int kq = 0;
        //    using (Entities db = new Entities())
        //    {
        //        int qr = (from s in db.tblViTriNguoiTTs
        //                  where s.CongDoan == _congdoan && s.Nhom == _nhom
        //                  select s).Count();
        //        kq = qr;
        //    }
        //    return kq;
        //}

        //Cập nhật lại file excel
        private void btnImport_Click(object sender, EventArgs e)
    {
        try
        {
            var rs = MessageBox.Show(
                "Khi import sẽ xóa hết người dùng hiện tại để nhập mới, có tiếp tục không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (rs != DialogResult.Yes) return;

            openFileDialog1.Filter = "Excel Workbook (*.xlsx;*.xlsm)|*.xlsx;*.xlsm";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            var fileInfo = new FileInfo(Path.GetFullPath(openFileDialog1.FileName));

                // BẮT BUỘC với EPPlus 5+ (đặt 1 lần ở Program.cs càng tốt)
                OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                using (var p = new ExcelPackage(fileInfo))
            {
                if (p.Workbook.Worksheets.Count == 0)
                {
                    MessageBox.Show("File Excel không chứa worksheet nào. Vui lòng kiểm tra lại file.");
                    return;
                }

                // Lấy sheet có dữ liệu đầu tiên; nếu tất cả trống, lấy sheet đầu
                var ws = p.Workbook.Worksheets
                            .FirstOrDefault(w => w.Dimension != null)
                         ?? p.Workbook.Worksheets.First();

                if (ws.Dimension == null || ws.Dimension.End.Row < 2)
                {
                    MessageBox.Show("Sheet được chọn không có dữ liệu (hoặc thiếu dòng dữ liệu).");
                    return;
                }

                int rowCount = ws.Dimension.End.Row;

                using (var db = new Entities(clConnection.connectEntity))
                {
                    db.pro_06_TruncateViTriNguoiTT();

                    // Đọc từ dòng 2 (bỏ header)
                    for (int i = 2; i <= rowCount; i++)
                    {
                        // Dùng .Text để tránh null (cell trống trả về "")
                        var c1 = ws.Cells[i, 1].Text?.Trim(); // Vị trí
                        var c2 = ws.Cells[i, 2].Text?.Trim(); // Công đoạn
                        var c3 = ws.Cells[i, 3].Text?.Trim(); // Nhóm
                        var c4 = ws.Cells[i, 4].Text?.Trim(); // UserID

                        // Bỏ qua dòng hoàn toàn trống
                        if (string.IsNullOrWhiteSpace(c1) &&
                            string.IsNullOrWhiteSpace(c2) &&
                            string.IsNullOrWhiteSpace(c3) &&
                            string.IsNullOrWhiteSpace(c4))
                        {
                            continue;
                        }

                        // Bắt buộc có cột 1 & 2
                        if (string.IsNullOrWhiteSpace(c1) || string.IsNullOrWhiteSpace(c2))
                        {
                            MessageBox.Show($"Lỗi: dòng {i} thiếu cột bắt buộc (Vị trí hoặc Công đoạn).");
                            return;
                        }

                        if (!int.TryParse(c1, out int viTri))
                        {
                            MessageBox.Show($"Lỗi: 'Vị trí' ở dòng {i} không phải số hợp lệ.");
                            return;
                        }

                        var congDoan = c2.ToUpperInvariant();
                        var allowed = new[] { "RELAY", "TREO", "ANA", "THORA" };
                        if (!allowed.Contains(congDoan))
                        {
                            MessageBox.Show(
                                $"Lỗi: mã công đoạn ở dòng {i} không hợp lệ ({congDoan}). " +
                                $"Danh sách cho phép: {string.Join(", ", allowed)}");
                            return;
                        }

                        var rec = new tblViTriNguoiTT
                        {
                            ViTri = viTri,
                            CongDoan = congDoan,
                            Nhom = c3 ?? string.Empty,
                            UserID = string.IsNullOrWhiteSpace(c4) ? null : c4
                        };

                        db.tblViTriNguoiTTs.Add(rec);
                    }

                    db.SaveChanges();
                }
            }

            MessageBox.Show("Import dữ liệu thành công");
            loadcbcongdoan();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
    }

    //Vẽ lại lưới
    private void cbCongDoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                loaddata(cbCongDoan.Text);
            }
        }

        //lưới ở trạng thái xem, không giữ vùng chọn
        private void grThongtin_SelectionChanged(object sender, EventArgs e)
        {
            grThongtin.ClearSelection();
        }

        // Mở một form mới hiển thị chi tiết thông tin hơn
        private void grThongtin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grThongtin.CurrentCell.Value != null)
                {
                    OperatorStatusDetail f = new OperatorStatusDetail(Convert.ToInt32(grThongtin.CurrentCell.Value), cbCongDoan.Text);
                    f.StartPosition = FormStartPosition.Manual;
                    int x = grThongtin.PointToScreen(grThongtin.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location).X;
                    int y = grThongtin.PointToScreen(grThongtin.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location).Y;
                    if (x > 1000)
                    {
                        x = 1000;
                    }
                    if (y > 250)
                    {
                        y = 250;
                    }
                    f.Location = new Point(x, y);
                    f.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
