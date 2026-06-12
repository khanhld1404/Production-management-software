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
using EVS_ProductionStatus.Controller;
namespace EVS_ProductionStatus
{
    public partial class Box_Status : Form
    {
        // Đường dẫn cơ sở dữ liệu
        DB_Entities db = new DB_Entities(clConnection.connectEntity);
        // Mã nhân viên đầu
        string emp_1 = "";
        // Mã nhân viên thứ hai
        string emp_2 = "";
        // Kiểm tra xem đã quét đủ 2 nhân viên chưa
        bool check_nv = false;
        // Giá trị mã thùng nhập vào hiện tại
        string present_box = "";
        // Dữ liệu bảng
        private void Data_Box()
        {
           string box_infor = lab_Box.Text.ToString();
            // Thêm số thứ tự vào bảng dữ liệu
            int current_Rank = 0;
            int? previousRank = null;

            var data_box_rank = db.Packing_List
                .Where(x => x.MaPL == box_infor)
                .OrderBy(x => x.id)
                .AsEnumerable()
                .Select(x =>
                {
                    if (previousRank != x.id)
                    {
                        current_Rank += 1;
                        previousRank = x.id;
                    }
                    return new
                    {
                        STT = current_Rank,
                        WO = x.WO_No,
                        ID = x.ID_No,
                        Item = x.Item_No,
                        Result = x.Result
                    };
                });
            var data_box = data_box_rank.OrderBy(x => x.Result).ToList();
            Box_Data.Rows.Clear();
            foreach (var tt in data_box)
            {
                int row_index = Box_Data.Rows.Add(tt.STT,tt.WO, tt.ID, tt.Item, tt.Result);
                if (tt.Result == "OK")
                {
                    Box_Data.Rows[row_index].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }

            // Thêm thông tin số lượng trong bảng
            Box_count_infor();
        }

        // Các dữ liệu tổng của thùng
        private void Box_count_infor()
        {
            // Dữ liệu bảng
            string box = lab_Box.Text.ToString();

            var tt_box = db.Packing_List
                        .Where(x => x.MaPL == box);
            // Tổng số lượng có trong thùng
            int total_box = tt_box.Count();
            lab_total_box.Text = total_box.ToString();

            // Tổng số lượng OK
            int total_box_ok = tt_box
                .Where(x => x.Result == "OK")
                .Count();
            lab_total_ok.Text = total_box_ok.ToString();

            // Tổng số lượng NG
            int total_box_ng = tt_box
                .Where(x => x.Result == "NG")
                .Count();
            lab_total_ng.Text = total_box_ng.ToString();
        }

        public Box_Status() 
        {
            InitializeComponent();
            txt_Box_Number.Focus();
        }

        private void txt_Box_Number_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                // Giá trị mã thùng nhập vào

                string tt_box = txt_Box_Number.Text.Trim().ToString();

                var box_status = db.Packing_List
                                 .FirstOrDefault(x => x.MaPL == tt_box);
               if(box_status != null)
                {
                    // Kiểm tra xem có còn tồn tại NG không
                    bool check_ng_box = db.Packing_List
                                        .Where(x => x.MaPL == present_box)
                                        .Any(x => x.Result == "NG");
                    if (present_box != "" && tt_box != present_box && check_ng_box)
                    {
                        DialogResult result = MessageBox.Show("Thùng " + present_box + " đang đóng dở. Xác nhận chuyển sang đóng thùng khác?", "Xác nhận thoát đóng thùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result != DialogResult.Yes)
                        {
                            return;
                        }
                    }
                    present_box = tt_box;

                    txt_Box_Number.Text = "";
                    lab_box_error.Text = "";

                    lab_Box.Text = tt_box.ToString();
                    if(check_nv == false)
                    {
                        arrow1.Visible = true;
                        lab_emp1.Visible = true;
                        txt_emp_1.Visible = true;
                        txt_emp_1.Focus();
                    }
                    else
                    {
                        txt_wo_scan.Focus();
                    }
                    Data_Box();

                }
                else
                {
                    lab_box_error.Text = "Mã thùng không tồn tại!";
                    return;
                }
            }
        }

        private void txt_emp_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Lấy mã nhân viên đầu tiên
                emp_1 = txt_emp_1.Text.Trim().ToString();
                bool emp_exist = db.tblUsers
                                .Any(x => x.userid == emp_1);
                if(emp_exist)
                {
                    lab_nv1_error.Text = "";
                    txt_emp_1.Enabled = false;
                    arrow2.Visible = true;
                    lab_emp2.Visible = true;
                    txt_emp_2.Visible = true;
                    txt_emp_2.Focus();
                }
                else
                {
                    lab_nv1_error.Text = "Mã nhân viên không tồn tại!";
                    return;
                }
            }
        }

        private void txt_emp_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Lấy mã nhân viên thứ hai
                emp_2 = txt_emp_2.Text.Trim().ToString();
                if(emp_2 == emp_1)
                {
                    lab_nv2_error.Text = "Cần mã nhân viên thứ hai!";
                    return;
                }
                bool emp_exist = db.tblUsers
                                .Any(x => x.userid == emp_2);
                if (emp_exist)
                {
                    check_nv = true;
                    txt_emp_2.Enabled = false;
                    lab_nv2_error.Text = "";
                    txt_wo_scan.Enabled = true;
                    txt_wo_scan.Focus();

                    // Đóng chỗ nhập nhân viên 1
                    arrow1.Visible = false;
                    lab_emp1.Visible = false;
                    txt_emp_1.Visible = false;

                    // Đóng chỗ nhập nhân viên 2
                    arrow2.Visible = false;
                    lab_emp2.Visible = false;
                    txt_emp_2.Visible = false;
                }
                else
                {
                    lab_nv2_error.Text = "Mã nhân viên không tồn tại!";
                }
            }
        }

        private void txt_wo_scan_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                // Dữ liệu tên bảng
                string tt_box = lab_Box.Text.ToString();

                string barcode = txt_wo_scan.Text.Trim().ToString();

                // Lấy work_order_id
                int firstClose = barcode.IndexOf(')');
                int secondOpen = barcode.IndexOf('(', firstClose + 1);

                string woid = barcode.Substring(firstClose + 1, secondOpen - firstClose - 1);
                // Lấy Item_code
                int secondClose = barcode.IndexOf(')', secondOpen + 1);

                string item = barcode.Substring(secondClose + 1);

                // Kiểm tra woid và item có tồn tại không
                var kq = db.Packing_List
                               .FirstOrDefault(x => x.MaPL == tt_box && x.ID_No == woid && x.Item_No == item);

                if (kq != null)
                {

                    // Xử lý với những ng
                    if (kq.Result == "NG")
                    {
                        // Số thư tự nhỏ nhất cần quét (Do quét thùng lấy lần lượt trong thùng)
                        var NG_min_index = db.Packing_List
                                       .Where(x => x.MaPL == tt_box && x.Result == "NG")
                                       .OrderBy(x => x.id)
                                       .FirstOrDefault();

                        // Kiểm tra xem nó có đúng thứ tự hay không
                        if (NG_min_index.ID_No == woid && NG_min_index.Item_No == item)
                        {
                            // Quét thành công thì xóa dữ liệu chỗ quét mã và focus vào chỗ quét lần nữa
                            txt_wo_scan.Text = string.Empty;
                            txt_wo_scan.Focus();

                            // Kiểm tra xem dữ liệu có cái nào là ok không
                            bool check_ok_box = db.Packing_List
                                                .Where(x => x.MaPL == tt_box)
                                                .Any(x => x.Result == "OK");
                            // Bắt đầu tính thời gian từ lần quét thành công đầu tiên trong thùng
                            if (!check_ok_box)
                            {
                                var first_time_box = db.Packing_Time
                                                     .Where(x => x.MaThung == tt_box)
                                                     .FirstOrDefault();
                                first_time_box.TimeStart = DateTime.Now;
                                db.SaveChanges();
                            }

                            kq.Result = "OK";
                            db.SaveChanges();
                        }
                        else
                        {
                            // Quét thành công thì xóa dữ liệu chỗ quét mã và focus vào chỗ quét lần nữa
                            txt_wo_scan.Text = string.Empty;
                            txt_wo_scan.Focus();

                            MessageBox.Show(
                                "Mã quét nằm sai thứ tự quét!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                            return;
                        }
                    }
                    else
                    {
                        // Quét thành công thì xóa dữ liệu chỗ quét mã và focus vào chỗ quét lần nữa
                        txt_wo_scan.Text = string.Empty;
                        txt_wo_scan.Focus();

                        MessageBox.Show(
                            "Mã code đã được quét!",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        return;
                    }
                }
                else
                {
                    // Quét thành công thì xóa dữ liệu chỗ quét mã và focus vào chỗ quét lần nữa
                    txt_wo_scan.Text = string.Empty;
                    txt_wo_scan.Focus();

                    MessageBox.Show(
                        "Mã code không thỏa mãn!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
                // Kiểm tra xem dữ liệu có còn ng không
                // Kiểm tra xem có còn tồn tại NG không
                bool check_ng_box = db.Packing_List
                                    .Where(x => x.MaPL == tt_box)
                                    .Any(x => x.Result == "NG");
                if (!check_ng_box)
                {
                    var last_time_box = db.Packing_Time
                                        .Where(x => x.MaThung == tt_box)
                                        .FirstOrDefault();
                    last_time_box.TimeEnd = DateTime.Now;
                    db.SaveChanges();
                    MessageBox.Show("Đã thực hiện xong thùng: " + tt_box);
                }
                // Đưa ra dữ liệu box mới
                Data_Box();
            }
        }

        private void Box_Status_Load(object sender, EventArgs e)
        {

        }

        private void Box_Status_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                // Kiểm tra xem có còn tồn tại NG không
                bool check_ng_box = db.Packing_List
                                    .Where(x => x.MaPL == present_box)
                                    .Any(x => x.Result == "NG");
                if (present_box != "" && check_ng_box)
                {
                    DialogResult result = MessageBox.Show("Thùng " + present_box + " đang đóng dở dang. Bạn có thực sự muốn thoát?", "Xác nhận thoát đóng thùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }
    }
}
