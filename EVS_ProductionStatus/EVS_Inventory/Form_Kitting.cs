
using EVS_ProductionStatus.Class;
using EVS_ProductionStatus.Data;
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

        Manage_evsEntities mb = new Manage_evsEntities(clConnection.connectString2);
        string tt_Itemtype;
        public Form_Kitting(string tt)
        {
            InitializeComponent();
            tt_Itemtype = tt;
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


        private List<Kitting_Type> new_evs_manage;
        public static DataTable dt;

        //Hàm Hiển thị gợi ý Kitting theo loại sản phẩm
        private void Data_Item_Type(DataTable dt_raw)
        {
            Lab_TT_Kitting.Text = "Thông Tin Kitting NVL (" + tt_Itemtype + ")";
            new_evs_manage = mb.EVS_Manage
                             .Select(x => new Kitting_Type
                             {
                                 Item_Number = x.Item_Number,
                                 Item_Type = x.Item_Type
                             })
                             .ToList();
            var summary = (from tt1 in dt_raw.AsEnumerable()
                               join tt2 in new_evs_manage
                                   on tt1.Field<string>("wo_item") equals tt2.Item_Number
                               where tt2.Item_Type.Trim().ToUpper() == tt_Itemtype
                               select new
                               {
                                   Nhóm_Kitting = tt1.Field<long>("Nhóm_Kitting"),
                                   Id = tt1.Field<long>("id"),
                                   Wo_Item = tt1.Field<string>("Wo_Item"),
                                   Số_Lượng_Trong_Nhóm = tt1.Field<int>("Số_Lượng_Trong_Nhóm")
                               })
                            .ToList();
            // Đưa đếm nhóm số hạng bắt  đầu đếm từ 1
            int current_Rank = 0;
            long? previousRank = null;
            var result = summary.Select(
                        x =>
                        {
                            if (previousRank != x.Nhóm_Kitting)
                            {
                                current_Rank += 1;
                                previousRank = x.Nhóm_Kitting;
                            }
                            return new
                            {
                                Nhóm_Kitting = current_Rank,
                                Id = x.Id,
                                Wo_Item = x.Wo_Item,
                                Số_Lượng_Trong_Nhóm = x.Số_Lượng_Trong_Nhóm
                            };
                        }
                        ).ToList();
            dt = Other_function.ToDataTable(result);
            Data_Kitting_NVL.DataSource = dt;
        }

        //Hàm hiển thị dữ liệu khi vào 
        private async Task Load_DataAsync()
        {
            ShowOverlay();
            try
            {
                var data = await Task.Run(() =>
                {
                    using (SqlConnection conn = new SqlConnection(clConnection.connectString))
                    using (SqlCommand cmd = new SqlCommand("GetInformation", conn))
                    using (SqlDataAdapter dap = new SqlDataAdapter(cmd))
                    {
                        cmd.CommandTimeout = 150;
                        var tmp = new DataTable();
                        dap.Fill(tmp);
                        return tmp;
                    }
                });
                Data_Item_Type(data);
                Txt_NVL.AutoSize = false;
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

        private void Btn_Rewatch_Click(object sender, EventArgs e)
        {
            Rewatch();
        }
        private void Txt_NVL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(Txt_NVL.Text))
                {
                    e.SuppressKeyPress = true; Rewatch();
                }
                else
                {
                    e.SuppressKeyPress = true; DoSearch();
                }
            }

        }

        private void DoSearch()
        {
            try
            {
                //Lấy dữ liệu nhập
                string value = Txt_NVL.Text;

                Match wo = Regex.Match(value, @"^[^%]*");
                int work_order = Convert.ToInt32(wo.Value);


                Match tt = Regex.Match(value, @"(?<=%)[^%]*(?=%)");
                string k_tt = tt.Value;
                int id_item = Convert.ToInt32(k_tt.Substring(0, 8));

                string wo_item = k_tt.Substring(8);

                Match dr = Regex.Match(value, @"^(?:[^%]*%){2}(?<after>.*)$");
                string draw_rev = dr.Groups["after"].Value;

                // Tìm nhóm_Kitting Sản phẩm
                Data_Kitting_NVL.DataSource = null;
                Data_Kitting_NVL.Refresh();
                var dv = new DataView(dt)
                {
                    RowFilter = $"Id = {id_item}"
                };
                DataTable dtselect = dv.ToTable(true, "Nhóm_Kitting");

                var sel = dtselect.AsEnumerable()
                          .Select(x => x.Field<int>("Nhóm_Kitting"))
                          .Select(n => $"Nhóm_Kitting = {n}");
                string filterIn = string.Join(" ", sel);

                var dt_need = new DataView(dt)
                {
                    RowFilter = string.IsNullOrEmpty(filterIn) ? "1=0" : $"({filterIn})"
                };

                Data_Kitting_NVL.DataSource = dt_need;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã vạch không hợp lệ!");
            }
        }

        private void Rewatch()
        {
            Data_Kitting_NVL.DataSource = null;
            Data_Kitting_NVL.Refresh();
            Data_Kitting_NVL.DataSource = dt;
        }

        //Cập nhật lại dữ liệu
        private async void Btn_Refresh_Click(object sender, EventArgs e)
        {
            bool check_connect;
            using (var loading = new Form
            {
                Text = "Đang tải dữ liệu...",
                StartPosition = FormStartPosition.CenterScreen,
                ControlBox = false,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                ClientSize = new Size(320, 100),
                TopMost = true
            })
            {
                var lbl = new Label
                {
                    Text = $"Đang cập nhật lại dữ liệu\nVui lòng chờ…",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 10, System.Drawing.FontStyle.Regular)
                };
                loading.Controls.Add(lbl);   // show modeless để không block await
                loading.Refresh();

                try
                {
                    // Load dữ liệu ở chế độ async (không đơ UI)
                    picLoading.Invoke(new Action(() => picLoading.Visible = true));
                    var Reload_Function = new Reload_Inventory_Infor();
                    check_connect = await Reload_Function.CallInventoryApiAsync("http://10.239.2.10:5555/api/inventory");
                    picLoading.Invoke(new Action(() => picLoading.Visible = false));
                    if (!check_connect)
                    {
                        return;
                    }
                    loading.Show();
                    var data = await Task.Run(() =>
                    {
                        using (SqlConnection conn = new SqlConnection(clConnection.connectString))
                        using (SqlCommand cmd = new SqlCommand("GetInformation", conn))
                        using (SqlDataAdapter dap = new SqlDataAdapter(cmd))
                        {
                            cmd.CommandTimeout = 150;
                            var tmp = new DataTable();
                            dap.Fill(tmp);
                            return tmp;
                        }
                    });
                    Data_Item_Type(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                    loading.Close();
                }
            }
        }
    }
}

