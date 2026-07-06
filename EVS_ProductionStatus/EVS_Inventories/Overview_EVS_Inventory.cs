

using EVS_ProductionStatus.Data_EVS;
using EVS_ProductionStatus.EVS_Inventories.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVS_ProductionStatus.EVS_Inventories
{
    public partial class Overview_EVS_Inventory : Form
    {
        public Overview_EVS_Inventory()
        {
            InitializeComponent();
        }

        private LoadingOverlay _overlay;

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

        // Location của từng trạng thái
        List<string> Trong_SX = new List<string> { "3008", "3009", "3010", "3108", "3109", "3110", "9999" };
        List<string> Ngoai_SX = new List<string> { "1001", "1002", "2001", "2002", "4004" };
        List<string> Khong_SX = new List<string> { "5001", "5002", "5003", "5004", "5005" };

        // Thông tin trạng thái
        string Blocked_Status = "Blocked", UU_Status = "Unrestricted", QI_Status = "In Qual.Insp", Res_Status = "Restricted-Use";

        // Thông tin dùng để xác định xem sản phẩm là HFG,RM hay WIP
        string HFG = "F04", RM = "R06", WIP = "S06";

        // Thông tin của các Datagrid
        // Lấy giá trị tồn kho theo từng trạng thái
        public double Get_Value(List<EVS_Inventory_Total> list,List<string> location, string status, string sp)
        {
            double kq = list
                 .Where(x => location.Contains(x.Storage_Location) && x.Stock_Type == status && x.MRP_Controller == sp)
                 .Sum(x => x.SL);
            return kq;
        }
        // Lấy giá trị tổng tồn kho
        public double Get_Total(List<EVS_Inventory_Total> list,List<string> location,string sp)
        {
            double kq = list
                 .Where(x => location.Contains(x.Storage_Location) && x.MRP_Controller == sp)
                 .Sum(x => x.SL);
            return kq;
        }

        private void Main_EVS_Inventory_Load(object sender, EventArgs e)
        {

            ShowOverlay();
            try
            {
                // Load và xử lý dữ liệu
                Get_EVS_Inventory_Infor.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Get_EVS_Inventory_Infor_DoWork(object sender, DoWorkEventArgs e)
        {
            using(Manage_evsEntities mb = new Manage_evsEntities(clConnection.connectEntity2))
            {
                var invantory_data = mb.EVS_Inventory.AsEnumerable()
                    .GroupBy(x => new
                    {
                        x.Storage_Location,
                        x.Stock_Type,
                        x.MRP_Controller
                    })
                    .Select(g => new EVS_Inventory_Total
                    {
                        Storage_Location = g.Key.Storage_Location,
                        Stock_Type = g.Key.Stock_Type,
                        MRP_Controller = g.Key.MRP_Controller,
                        SL = g.Sum(x => double.TryParse(x.Inventory_Qty, out double v) ? v : 0)
                    })
                    .ToList();


                var groups = new[]
                {
                new { Name = "EVS", Locations = Trong_SX },
                new { Name = "NSX", Locations = Ngoai_SX },
                new { Name = "KSX", Locations = Khong_SX }
            };
                List<InventoryResult> result =
                    new List<InventoryResult>();

                foreach (var group in groups)
                {
                    InventoryResult row = new InventoryResult();

                    row.GridName = group.Name;

                    row.Blocked_HFG = Get_Value(invantory_data, group.Locations, Blocked_Status, HFG);
                    row.UU_HFG = Get_Value(invantory_data, group.Locations, UU_Status, HFG);
                    row.QI_HFG = Get_Value(invantory_data, group.Locations, QI_Status, HFG);
                    row.Res_HFG = Get_Value(invantory_data, group.Locations, Res_Status, HFG);
                    row.Total_HFG = Get_Total(invantory_data, group.Locations, HFG);

                    row.Blocked_RM = Get_Value(invantory_data, group.Locations, Blocked_Status, RM);
                    row.UU_RM = Get_Value(invantory_data, group.Locations, UU_Status, RM);
                    row.QI_RM = Get_Value(invantory_data, group.Locations, QI_Status, RM);
                    row.Res_RM = Get_Value(invantory_data, group.Locations, Res_Status, RM);
                    row.Total_RM = Get_Total(invantory_data, group.Locations, RM);

                    row.Blocked_WIP = Get_Value(invantory_data, group.Locations, Blocked_Status, WIP);
                    row.UU_WIP = Get_Value(invantory_data, group.Locations, UU_Status, WIP);
                    row.QI_WIP = Get_Value(invantory_data, group.Locations, QI_Status, WIP);
                    row.Res_WIP = Get_Value(invantory_data, group.Locations, Res_Status, WIP);
                    row.Total_WIP = Get_Total(invantory_data, group.Locations, WIP);

                    result.Add(row);
                }

                e.Result = result;
            }
        }
        private void Get_EVS_Inventory_Infor_RunWorkerCompleted(
            object sender,
            RunWorkerCompletedEventArgs e)
        {
            HideOverlay();
                var result =
                    (List<InventoryResult>)e.Result;
            // Clear dữ liệu

            Main_EVS.Rows.Clear();
            Main_NSX.Rows.Clear();
            Main_KSX.Rows.Clear();


            foreach (var item in result)
                {
                    DataGridView grid = null;

                    switch (item.GridName)
                    {
                        case "EVS":
                            grid = Main_EVS;
                            break;

                        case "NSX":
                            grid = Main_NSX;
                            break;

                        case "KSX":
                            grid = Main_KSX;
                            break;
                    }

                    grid.Rows.Add(
                        "Thành Phẩm(HFG)",
                        item.Blocked_HFG,
                        item.UU_HFG,
                        item.QI_HFG,
                        item.Res_HFG,
                        item.Total_HFG);

                    grid.Rows.Add(
                        "Bán Thành Phẩm(WIP)",
                        item.Blocked_WIP,
                        item.UU_WIP,
                        item.QI_WIP,
                        item.Res_WIP,
                        item.Total_WIP);

                grid.Rows.Add(
                        "Nguyên Vật Liệu(RM)",
                        item.Blocked_RM,
                        item.UU_RM,
                        item.QI_RM,
                        item.Res_RM,
                        item.Total_RM);
                // Tính chiều cao dựa trên số dòng + header (Giúp cho bảng hiện thị không bị thừa và cũng không bị thiếu)
                grid.Height = grid.ColumnHeadersHeight +
                                       grid.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + 2;
            }
        }
    }
}
