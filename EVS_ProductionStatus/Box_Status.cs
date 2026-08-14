
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EVS_ProductionStatus.Class;
using EVS_ProductionStatus;
using EVS_ProductionStatus.Data_EVS;
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

        // Hàm kiểm tra xem còn trạng thái ok trong một box cụ thể ko
        public bool Check_OK(string tt_box)
        {
            return db.Packing_List
                     .Any(x => x.Result == "OK" && x.MaPL == tt_box);
        }

        // Hàm kiểm tra xem còn trạng thái ok trong một box cụ thể ko
        public bool Check_NG(string tt_box)
        {
            return db.Packing_List
                     .Any(x => x.Result == "NG" && x.MaPL == tt_box);
        }

        // Dữ liệu bảng
        private void Data_Box()
        {
           string box_infor = Box_Overview.Rows[0].Cells[1].Value.ToString();

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
            var data_box = data_box_rank.OrderByDescending(x => x.Result).ToList();
            Box_Data.Rows.Clear();
            foreach (var tt in data_box)
            {
                int row_index = Box_Data.Rows.Add(tt.STT,tt.WO, tt.ID, tt.Item, tt.Result);
                if (tt.Result == "OK")
                {
                    Box_Data.Rows[row_index].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
            int stt = data_box
                    .Where(x => x.Result == "NG")
                    .Select(x => x.STT).FirstOrDefault();
            if(stt != 0)
            {
                Box_Data.FirstDisplayedScrollingRowIndex = stt - 1;
            }
            // Thêm thông tin số lượng trong bảng
            Box_count_infor();
        }

        // Các dữ liệu tổng của thùng
        private void Box_count_infor()
        {
            // Dữ liệu bảng
            string box = Box_Overview.Rows[0].Cells[1].Value.ToString();

            var tt_box = db.Packing_List
                        .Where(x => x.MaPL == box);
            // Tổng số lượng có trong thùng
            int total_box = tt_box.Count();
            Box_Overview.Rows[3].Cells[1].Value = total_box.ToString();

            // Tổng số lượng OK
            int total_box_ok = tt_box
                .Where(x => x.Result == "OK")
                .Count();
            Box_Overview.Rows[4].Cells[1].Value = total_box_ok.ToString();

            // Tổng số lượng NG
            int total_box_ng = tt_box
                .Where(x => x.Result == "NG")
                .Count();
            Box_Overview.Rows[5].Cells[1].Value = total_box_ng.ToString();
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

                // Kiểm tra xem thùng mới đã hoàn thành hay chưa
                bool check_box_complete = db.Packing_Time
                                          .Any(x => x.MaThung == tt_box && x.TimeEnd != null);
                if (check_box_complete)
                {
                    DialogResult result = MessageBox.Show("Thùng " + tt_box + " đã được đóng hết. Bạn có muốn xem lại thông tin thùng ko?", "Xác nhận đóng thùng!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(result == DialogResult.No)
                    {
                        txt_Box_Number.Text = string.Empty;
                        txt_Box_Number.Focus();
                        return;
                    }
                }
                var box_status = db.Packing_List
                                 .FirstOrDefault(x => x.MaPL == tt_box);
               if(box_status != null)
                {
                    // Kiểm tra xem có còn tồn tại NG không

                    if (present_box != "" && tt_box != present_box && Check_NG(present_box))
                    {
                        DialogResult result = MessageBox.Show("Thùng " + present_box + " đang đóng dở. Xác nhận chuyển sang đóng thùng khác? (Lưu ý: Thông tin đóng thùng sẽ được làm mới và bạn phải nhập lại từ đầu!)", "Xác nhận thoát đóng thùng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result != DialogResult.Yes)
                        {
                            return;
                        }
                    }
                    // Kiểm tra xem thùng cũ đã đóng xong chưa ( Phân biệt nó với viêc chưa đóng xong)
                    bool check_complete_box = db.Packing_Time
                                            .Any(x => x.TimeEnd != null && x.MaThung == present_box);
                    if (!check_complete_box)
                    {
                        // Nếu chuyển sang đóng thùng khác thì xóa thông tin ok của thùng cũ đi
                        var ok_box_present = db.Packing_List
                            .Where(x => x.MaPL == present_box && x.Result == "OK");
                        foreach (var box in ok_box_present)
                        {
                            box.Result = "NG";
                        }
                        db.SaveChanges();
                    }

                    // Lấy tt box hiện tại
                    present_box = tt_box;

                    txt_Box_Number.Text = "";
                    lab_box_error.Text = "";

                    // Truyền dữ liệu mã thùng vào

                    Box_Overview.Rows[0].Cells[1].Value = tt_box.ToString();


                    if(check_nv == false)
                    {
                        arrow1.Visible = true;
                        lab_emp1.Visible = true;
                        txt_emp_1.Visible = true;
                        txt_emp_1.Focus();
                    }
                    else
                    {
                        txt_wo_scan.Enabled = true;
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
                                .Any(x => x.userid == emp_1 && x.active == "true");
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
                                .Any(x => x.userid == emp_2 && x.active == "true");
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

                    // Hiển thị nút dừng khẩn cấp ra


                    // Truyền dữ liệu nhân viên quét vào
                    Box_Overview.Rows[1].Cells[1].Value = emp_1.ToString();
                    Box_Overview.Rows[2].Cells[1].Value = emp_2.ToString();
                }
                else
                {
                    lab_nv2_error.Text = "Mã nhân viên không tồn tại!";
                }
            }
        }

        // Load lại scan barcode
        private void ResetScan()
        {

            txt_wo_scan.Text = string.Empty;
            txt_wo_scan.Focus();

        }
        private void txt_wo_scan_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                
                // Dữ liệu tên bảng
                string tt_box = Box_Overview.Rows[0].Cells[1].Value.ToString();

                string barcode = txt_wo_scan.Text.Trim().ToString();

                // Lọc dữ liệu ra
                int firstClose = barcode.IndexOf(')');
                int secondOpen = barcode.IndexOf('(', firstClose + 1);
                int secondClose = barcode.IndexOf(')', secondOpen + 1);

                // Kiểm tra đoạn mã nhập vào có hợp lệ hay không
                if (firstClose == -1 || secondOpen == -1 || secondClose == -1 || secondOpen <= firstClose)
                {
                    MessageBox.Show("Mã quét không đúng định dạng!");
                    ResetScan();
                    return;
                }

                // Lấy work_order_id

                string woid = barcode.Substring(firstClose + 1, secondOpen - firstClose - 1);
                // Lấy Item_code

                string item = barcode.Substring(secondClose + 1);


                // Kiểm tra woid và item có tồn tại không
                var kq = db.Packing_List
                               .FirstOrDefault(x => x.MaPL == tt_box && x.ID_No == woid && x.Item_No == item);

                if (kq != null)
                {

                    // Xử lý với những ng
                    if (kq.Result == "NG")
                    {

                        // Số thư tự nhỏ nhất cần quét (Do quét thùng lấy lần lượt trong thùng). Ở đây chắc chắn sẽ có ng vì mã quét vào của thùng là một ng
                        var NG_min_index = db.Packing_List
                                       .Where(x => x.MaPL == tt_box && x.Result == "NG")
                                       .OrderBy(x => x.id)
                                       .FirstOrDefault();

                        // Kiểm tra xem nó có đúng thứ tự hay không
                        if (NG_min_index.ID_No == woid && NG_min_index.Item_No == item)
                        {

                            // Bắt đầu tính thời gian từ lần quét thành công đầu tiên trong thùng
                            if (!Check_OK(tt_box))
                            {
                                var first_time_box = db.Packing_Time
                                                     .Where(x => x.MaThung == tt_box)
                                                     .FirstOrDefault();
                                first_time_box.TimeStart = DateTime.Now;
                                first_time_box.Emp_1 = emp_1;
                                first_time_box.Emp_2 = emp_2;
                            }

                            kq.Result = "OK";
                            kq.Scan_Time = DateTime.Now;
                            db.SaveChanges();

                            // Quét thành công thì xóa dữ liệu chỗ quét mã và focus vào chỗ quét lần nữa
                            ResetScan();
                        }
                        else
                        {

                            MessageBox.Show(
                                "Mã quét nằm sai thứ tự quét!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );

                            // Quét thành công thì xóa dữ liệu chỗ quét mã và focus vào chỗ quét lần nữa
                            ResetScan();

                            return;
                        }
                    }
                    else
                    {

                        MessageBox.Show(
                            "Mã code đã được quét!",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );

                        // Quét thành công thì xóa dữ liệu chỗ quét mã và focus vào chỗ quét lần nữa
                        ResetScan();

                        return;
                    }
                }
                else
                {

                    MessageBox.Show(
                        "Mã code không thỏa mãn!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    // Quét thành công thì xóa dữ liệu chỗ quét mã và focus vào chỗ quét lần nữa
                    ResetScan();

                    return;
                }

                // Kiểm tra xem có còn tồn tại NG không
                if (!Check_NG(tt_box))
                {
                    var last_time_box = db.Packing_Time
                                        .Where(x => x.MaThung == tt_box)
                                        .FirstOrDefault();
                    last_time_box.TimeEnd = DateTime.Now;
                    db.SaveChanges();
                    MessageBox.Show("Đã thực hiện xong thùng: " + tt_box + " .Hãy bắt đầu quét một mã thùng khác!");
                    txt_Box_Number.Focus();

                }
                // Đưa ra dữ liệu box mới
                Data_Box();
            }
        }

        // Hiển thị giao diện ban đầu
        private void Box_Status_Load(object sender, EventArgs e)
        {
            txt_Box_Number.Focus();

            Box_Overview.Rows.Add("Mã Thùng", "");
            Box_Overview.Rows.Add("Mã NV 1", "");
            Box_Overview.Rows.Add("Mã NV 2", "");
            Box_Overview.Rows.Add("Tổng số lượng", "");
            Box_Overview.Rows.Add("Số lượng OK", "");
            Box_Overview.Rows.Add("Số lượng NG", "");


            // Tính chiều cao dựa trên số dòng + header (Giúp cho bảng hiện thị không bị thừa và cũng không bị thiếu)
            Box_Overview.Height = Box_Overview.ColumnHeadersHeight +
                                   Box_Overview.Rows.GetRowsHeight(DataGridViewElementStates.Visible) - 20;
        }

        private void Box_Status_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                if (present_box != "" && Check_NG(present_box))
                {
                    DialogResult result = MessageBox.Show("Thùng " + present_box + " đang đóng dở dang. Bạn có thực sự muốn thoát? (Lưu ý: Thông tin đóng thùng sẽ được làm mới và bạn phải nhập lại từ đầu!)", "Xác nhận thoát đóng thùng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        // Nếu đóng màn hình thì xóa thông tin ok của thùng cũ đi
                        var ok_box_present = db.Packing_List
                            .Where(x => x.MaPL == present_box && x.Result == "OK");

                        foreach (var box in ok_box_present)
                        {
                            box.Result = "NG";
                        }
                        db.SaveChanges();
                    }
                }
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if(Box_Data.Rows.Count == 0)
            {
                MessageBox.Show("Mời bạn nhập số Thùng!");
                return;
            }
            if(emp_1 == ""  || emp_2 == "")
            {
                MessageBox.Show("Mời bạn nhập mã nhân viên!");
                return;
            }

            // Xử lý việc dừng đóng thùng nhưng vẫn lưu ý dữ liệu
            // xóa thông tin có trong biến mã thùng
            DialogResult result = MessageBox.Show("Bạn có muốn dừng việc đóng thùng " + present_box + " . Thông tin đóng thùng của bạn sẽ không bị mất đi!", "Xác nhận dừng đóng thùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                // Xóa các dữ liệu hiện và ghi ra trên màn hình
                present_box = "";
                txt_Box_Number.Clear();
                Box_Data.Rows.Clear();
                txt_wo_scan.Enabled = false;

                // Thiết lập lại dữ liệu các tiêu đề ở bảng overview
                Box_Overview.Rows[0].Cells[1].Value = null;
                Box_Overview.Rows[3].Cells[1].Value = null;
                Box_Overview.Rows[4].Cells[1].Value = null;
                Box_Overview.Rows[5].Cells[1].Value = null;

                txt_Box_Number.Focus();
            }
            else
            {
                return;
            }
        }

        private void Btn_Excel_Click(object sender, EventArgs e)
        {
            if(Box_Data.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu nào của thùng được ghi nhận!");
            }
            else
            {
                Excel_Only_Sheet.ExportToExcel(Box_Data);
            }
        }
    }
}
