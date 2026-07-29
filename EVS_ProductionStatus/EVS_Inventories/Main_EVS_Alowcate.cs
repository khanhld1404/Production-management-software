using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVS_ProductionStatus.EVS_Inventories.Model
{
    public partial class Main_EVS_Alowcate : Form
    {
        public Main_EVS_Alowcate()
        {
            InitializeComponent();
        }

        // Xử lý việc gọi một form trong panel
        private void OpenForm(Form frm)
        {
            Infor_Panel.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            Infor_Panel.Controls.Add(frm);
            frm.Show();
        }

        //Thông tin Location
        List<string> Ngoai_SX = new List<string> { "1001", "1002", "2001", "2002", "4004" };
        List<string> Khong_SX = new List<string> { "5001", "5002", "5003", "5004", "5005" };
        List<string> Trong_SX = new List<string> { "3008", "3009", "3010", "3108", "3109", "3110", "9999" };

        // Thiết lập màu sắc tên cột được chọn
        private void SetActiveItem(ToolStripItem active)
        {
            foreach (ToolStripItem item in Menu_EVS_Total_Detail.Items)
            {
                if (item is ToolStripButton ||
                    item is ToolStripDropDownButton)
                {
                    item.BackColor = SystemColors.GradientInactiveCaption;
                    item.ForeColor = SystemColors.ControlText;
                }
            }

            active.BackColor = SystemColors.Highlight;
            active.ForeColor = SystemColors.Control;
        }
        // Cách xác định HFG,RM và WIP
        List<string> HFG = new List<string>() { "F04" };
        List<string> RM_WIP = new List<string>() { "R06","S06" };
        List<string> All_Status = new List<string>() { "F04","R06","S06"};
        private void NSX_Click(object sender, EventArgs e)
        {
            SetActiveItem(NSX);
            OpenForm(new Detail_EVS_Inventory(Ngoai_SX, "Ngoài Sản Xuất",All_Status));
        }

        private void Main_EVS_Alowcate_Load(object sender, EventArgs e)
        {
            SetActiveItem(TSX);
            TSX.Text = TSX_RM_WIP.Text;
            OpenForm(new EVS_Alowcate(RM_WIP));
        }

        private void KSX_Click(object sender, EventArgs e)
        {
            SetActiveItem(KSX);
            OpenForm(new Detail_EVS_Inventory(Khong_SX, "Không Sản Xuất",All_Status));
        }

        private void TSX_DropDownItemClicked(
            object sender,
            ToolStripItemClickedEventArgs e)
        {
            TSX.Text = e.ClickedItem.Text;

            switch (e.ClickedItem.Name)
            {
                case "TSX_RM_WIP":
                    SetActiveItem(TSX);
                    OpenForm(new EVS_Alowcate(RM_WIP));
                    break;

                case "TSX_HFG":
                    SetActiveItem(TSX);
                    OpenForm(new Detail_EVS_Inventory(Trong_SX,"Trong Sản Xuất (HFG)",HFG));
                    break;
            }
        }
    }
}
