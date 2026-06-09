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
        // Thực hiện việc đọc lại dữ liệu bảng 
        private void Data_Box()
        {
           string box_infor = lab_Box.Text.ToString();
           var  data_box = db.Packing_List
               .Where(x => x.MaPL == box_infor)
               .OrderByDescending(x => x.Result)
               .Select(x => new 
               {
                   wo = x.WO_No,
                   ID = x.ID_No,
                   Item = x.Item_No,
                   Result = x.Result
               }).ToList();
            Box_Data.Rows.Clear();
            foreach (var tt in data_box)
            {
                int row_index = Box_Data.Rows.Add(tt.wo, tt.ID, tt.Item, tt.Result);
                if (tt.Result == "OK")
                {
                    Box_Data.Rows[row_index].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
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
                string box_infor = txt_Box_Number.Text.ToString();
                var box_status = db.Packing_List
                                 .FirstOrDefault(x => x.MaPL == box_infor);
               if(box_infor != null)
                {
                    lab_box_error.Text = "";
                    lab_Box.Text = box_infor.ToString();
                    Data_Box();
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
                emp_1 = txt_emp_1.Text.ToString();
                bool emp_exist = db.tblUsers
                                .Any(x => x.userid == emp_1);
                if(emp_exist)
                {
                    lab_nv1_error.Text = "";
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
                emp_2 = txt_emp_2.Text.ToString();
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
                string barcode = txt_wo_scan.Text.ToString();
                // Lấy work_order_id
                string woid = barcode.Substring(4, 10);
                // Lấy Item_code
                string item = barcode.Substring(19);
                MessageBox.Show(woid + " " + item);
                // Dữ liệu bảng
                string box = lab_Box.Text.ToString();
                // Kiểm tra woid và item có tồn tại không
                var kq = db.Packing_List
                               .FirstOrDefault(x => x.MaPL == box && x.ID_No == woid && x.Item_No == item);
                if (kq != null)
                {
                    kq.Result = "OK";
                    db.Packing_List.Add(kq);
                    db.SaveChanges();
                }
                else
                {
                    lab_code_error.Text = "Mã code không thỏa mãn";
                    return;
                }
                // Đưa ra thành màu xanh
                Data_Box();
            }
        }
    }
}
