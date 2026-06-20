
using EVS_ProductionStatus.Class;
using EVS_ProductionStatus.Data_EVS;
using EVS_ProductionStatus.EVS_Inventory.Model;
using EVS_ProductionStatus.Update_Inventory.Class;
using EVS_ProductionStatus.Update_Inventory.Model;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static OfficeOpenXml.ExcelErrorValue;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EVS_ProductionStatus
{
    public partial class Form_Kitting : UserControl
    {
        private LoadingOverlay _overlay;

        // Đường dẫn kết nối dữ liệu
        Manage_evsEntities wodb = new Manage_evsEntities(clConnection.connectEntity2);

        public Form_Kitting()
        {
            InitializeComponent();
            //tt_Itemtype = tt;
        }


        private void ShowOverlay(string message = "Đang tải dữ liệu ...")
        {
            if (_overlay != null) return;

            this.SuspendLayout();

            _overlay = new LoadingOverlay { Message = message };
            _overlay.UseWaitCursor = true;      // đổi cursor dạng chờ
            this.UseWaitCursor = true;          // áp dụng cho toàn UserControl

            this.Controls.Add(_overlay);
            _overlay.BringToFront();            // đảm bảo ở trên cùng
            _overlay.Visible = true;

            // Tuỳ chọn: vô hiệu hoá các control nền
            foreach (Control c in this.Controls)
                if (c != _overlay) c.Enabled = false;

            this.ResumeLayout();
        }

        private void HideOverlay()
        {
            if (_overlay == null) return;

            this.SuspendLayout();

            foreach (Control c in this.Controls)
                if (c != _overlay) c.Enabled = true;

            this.Controls.Remove(_overlay);
            _overlay.Dispose();
            _overlay = null;

            this.UseWaitCursor = false;

            this.ResumeLayout();
        }

        // Chèn dữ liệu vào bảng
        private void Data_Insert(List<Kitting_Data> kitting_data)
        {
            // Làm mới datagridview
            Data_Kitting_NVL.Rows.Clear();
            foreach (var item in kitting_data)
            {
                Data_Kitting_NVL.Rows.Add(item.Nhóm_Kitting,item.Item_Wo,item.ID_Wo,item.Số_Lượng);
            }
        }
        private void Data_kitting()
        {
            var kitting_infor = wodb.Kitting_Infor
                                .Select(
                                    x => new Kitting_Data
                                    {
                                        Nhóm_Kitting = x.Nhom_Kitting,
                                        Item_Wo = x.woid,
                                        ID_Wo = x.id,
                                        Số_Lượng = x.quantity
                                    }
                                 )
                                .Distinct()
                                .OrderBy(x => x.Nhóm_Kitting)
                                .ThenBy(x => x.Item_Wo)
                                .ToList();
            Data_Insert(kitting_infor);
        }
        //Hàm hiển thị dữ liệu khi vào 
        private async Task Load_DataAsync()
        {
            ShowOverlay();
            try
            {
                Data_kitting();
                Txt_NVL.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                HideOverlay();
            }
        }

        //Sự kiện khi load dữ liệu của  form/usercontrol
        private void Form_Kitting_Load(object sender, EventArgs e)
        {
            // đẩy sang “nhịp sau” để overlay vẽ trước
            this.BeginInvoke(new Action(async () => await Load_DataAsync()));

        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            DoSearch();
        }
        private void Btn_Excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel Files|*.xlsx|All Files|*.*";
            saveFileDialog1.Title = "Chọn nơi lưu file Excel";
            saveFileDialog1.DefaultExt = "xlsx";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
               Excel_Only_Sheet.ExportToExcel(Data_Kitting_NVL, saveFileDialog1.FileName);
               MessageBox.Show("Xuất Excel thành công!");
            }
        }
        private void Txt_NVL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(Txt_NVL.Text))
                {
                    e.SuppressKeyPress = true; DoSearch();
                }
            }

        }

        private void DoSearch()
        {
            try
            {
                // Lấy location lựa chọn
                string location = CB_Location.Text.Trim();

                //Lấy dữ liệu nhập
                string value = Txt_NVL.Text.Trim();

                // Tìm nhóm_Kitting Sản phẩm

                // Biến chứa các nhóm Kitting cần  tìm
                List<long> list_group_kitting = new List<long>();
                // Biến chứa dữ liệu kitting tìm được
                List<Kitting_Data> dt_kitting;
                // Tìm Nhóm Kitting
                if (string.IsNullOrWhiteSpace(value))
                {
                    if (string.IsNullOrWhiteSpace(location) || location == "All Location")
                    {
                        Data_kitting();
                        // Do con này thực hiện luôn trong Data_kitting() rồi nên ko cần thực hiện cái bên dưới nữa
                        return;
                    }
                    else
                    {
                        dt_kitting = wodb.Kitting_Infor
                                        .Where(x => x.locate_kitting == location)
                                        .Select(
                                            x => new Kitting_Data
                                            {
                                                Nhóm_Kitting = x.Nhom_Kitting,
                                                Item_Wo = x.woid,
                                                ID_Wo = x.id,
                                                Số_Lượng = x.quantity
                                            }
                                         )
                                        .Distinct()
                                        .OrderBy(x => x.Nhóm_Kitting)
                                        .ThenBy(x => x.Item_Wo)
                                        .ToList();
                    }
                }
                else
                {
                    // Phân tích dữ liệu nhập
                    string[] parts = value.Split('%');

                    //Kiểm tra mã nhập vào
                    if (parts.Length < 4)
                    {
                        MessageBox.Show("Định dạng phải là: WO%WOID%ITEM%DRAW_REV");
                        return;
                    }

                    string WO = parts[0];
                    string WOID = parts[1];
                    string ITEM = parts[2];
                    string DRAW_REV = parts[3];

                    if (string.IsNullOrWhiteSpace(location) || location == "All Location")
                    {
                        list_group_kitting = wodb.Kitting_Infor
                                            .Where(x => x.wo == WO && x.woid == WOID && x.id == ITEM && x.draw_rev == DRAW_REV)
                                            .Select(x => x.Nhom_Kitting)
                                            .ToList();
                    }
                    else
                    {
                        list_group_kitting = wodb.Kitting_Infor
                                            .Where(x => x.wo == WO && x.woid == WOID && x.id == ITEM && x.draw_rev == DRAW_REV && x.locate_kitting == location)
                                            .Select(x => x.Nhom_Kitting)
                                            .ToList();
                    }
                    dt_kitting = wodb.Kitting_Infor
                                     .Where(x => list_group_kitting.Contains(x.Nhom_Kitting))
                                    .Select(
                                        x => new Kitting_Data
                                        {
                                            Nhóm_Kitting = x.Nhom_Kitting,
                                            Item_Wo = x.woid,
                                            ID_Wo = x.id,
                                            Số_Lượng = x.quantity
                                        }
                                     )
                                    .Distinct()
                                    .OrderBy(x => x.Nhóm_Kitting)
                                    .ThenBy(x => x.Item_Wo)
                                    .ToList();
                }
                // Thực hiện việc truyền dữ liệu vào bảng
                Data_Insert(dt_kitting);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã vạch không hợp lệ!");
            }
        }
    }
}

