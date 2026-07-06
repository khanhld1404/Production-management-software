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

        // Thiết lập màu sắc tên cột được chọn
        private void SetActiveButton(ToolStripButton active)
        {
            foreach (ToolStripButton button in Menu_EVS_Total_Detail.Items)
            {
                button.BackColor = SystemColors.GradientInactiveCaption;
                button.ForeColor = SystemColors.ControlText;
            }
            active.BackColor = SystemColors.Highlight;
            active.ForeColor = SystemColors.Control;
        }

        private void TSX_Click(object sender, EventArgs e)
        {
            SetActiveButton(TSX);
            OpenForm(new EVS_Alowcate());
        }
        private void NSX_Click(object sender, EventArgs e)
        {
            SetActiveButton(NSX);
            OpenForm(new NSX_KSX_Alowcate(Ngoai_SX, "Ngoài Sản Xuất") );
        }

        private void Main_EVS_Alowcate_Load(object sender, EventArgs e)
        {
            SetActiveButton(TSX);
            OpenForm(new EVS_Alowcate() );
        }
    }
}
