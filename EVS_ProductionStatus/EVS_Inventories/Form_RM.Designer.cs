using System.Windows.Forms;

namespace EVS_Management
{
    partial class Form_RM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dgv_Main_RM = new System.Windows.Forms.DataGridView();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Blocked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restricted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lab_Main_RM = new System.Windows.Forms.Label();
            this.Btn_Total = new System.Windows.Forms.Button();
            this.Btn_Details = new System.Windows.Forms.Button();
            this.Btn_Excel = new System.Windows.Forms.Button();
            this.Dgv_Details_RM = new System.Windows.Forms.DataGridView();
            this.Lab_Details_RM = new System.Windows.Forms.Label();
            this.label_suggest = new System.Windows.Forms.Label();
            this.txt_Search_ItemCode = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.txt_Search_Lotno = new System.Windows.Forms.TextBox();
            this.location_box = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Main_RM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Details_RM)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Main_RM
            // 
            this.Dgv_Main_RM.AllowUserToAddRows = false;
            this.Dgv_Main_RM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Main_RM.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(7, 10, 0, 10);
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Main_RM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.Dgv_Main_RM.ColumnHeadersHeight = 48;
            this.Dgv_Main_RM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TT,
            this.Blocked,
            this.UU,
            this.QI,
            this.Restricted,
            this.Total});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Main_RM.DefaultCellStyle = dataGridViewCellStyle18;
            this.Dgv_Main_RM.EnableHeadersVisualStyles = false;
            this.Dgv_Main_RM.Location = new System.Drawing.Point(38, 63);
            this.Dgv_Main_RM.Name = "Dgv_Main_RM";
            this.Dgv_Main_RM.ReadOnly = true;
            this.Dgv_Main_RM.RowHeadersVisible = false;
            this.Dgv_Main_RM.RowTemplate.Height = 30;
            this.Dgv_Main_RM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Dgv_Main_RM.Size = new System.Drawing.Size(1064, 164);
            this.Dgv_Main_RM.TabIndex = 0;
            this.Dgv_Main_RM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_Main_RM_CellClick);
            // 
            // TT
            // 
            this.TT.HeaderText = "Trạng Thái";
            this.TT.Name = "TT";
            this.TT.ReadOnly = true;
            // 
            // Blocked
            // 
            this.Blocked.HeaderText = "Blocked";
            this.Blocked.Name = "Blocked";
            this.Blocked.ReadOnly = true;
            // 
            // UU
            // 
            this.UU.HeaderText = "UU";
            this.UU.Name = "UU";
            this.UU.ReadOnly = true;
            // 
            // QI
            // 
            this.QI.HeaderText = "QI";
            this.QI.Name = "QI";
            this.QI.ReadOnly = true;
            // 
            // Restricted
            // 
            this.Restricted.HeaderText = "Restricted";
            this.Restricted.Name = "Restricted";
            this.Restricted.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Tổng Tồn";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Lab_Main_RM
            // 
            this.Lab_Main_RM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_Main_RM.AutoSize = true;
            this.Lab_Main_RM.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Lab_Main_RM.Location = new System.Drawing.Point(480, 23);
            this.Lab_Main_RM.Name = "Lab_Main_RM";
            this.Lab_Main_RM.Size = new System.Drawing.Size(130, 22);
            this.Lab_Main_RM.TabIndex = 2;
            this.Lab_Main_RM.Text = "Tồn Kho RM ";
            // 
            // Btn_Total
            // 
            this.Btn_Total.BackColor = System.Drawing.Color.Gray;
            this.Btn_Total.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Total.ForeColor = System.Drawing.Color.White;
            this.Btn_Total.Location = new System.Drawing.Point(38, 347);
            this.Btn_Total.Name = "Btn_Total";
            this.Btn_Total.Size = new System.Drawing.Size(150, 57);
            this.Btn_Total.TabIndex = 6;
            this.Btn_Total.Text = "Tổng quan từng sản phẩm";
            this.Btn_Total.UseVisualStyleBackColor = false;
            this.Btn_Total.Click += new System.EventHandler(this.Btn_Total_Click);
            // 
            // Btn_Details
            // 
            this.Btn_Details.BackColor = System.Drawing.Color.Orange;
            this.Btn_Details.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Details.ForeColor = System.Drawing.Color.White;
            this.Btn_Details.Location = new System.Drawing.Point(209, 347);
            this.Btn_Details.Name = "Btn_Details";
            this.Btn_Details.Size = new System.Drawing.Size(120, 57);
            this.Btn_Details.TabIndex = 7;
            this.Btn_Details.Text = "Chi tiết từng sản phẩm";
            this.Btn_Details.UseVisualStyleBackColor = false;
            this.Btn_Details.Click += new System.EventHandler(this.Btn_Details_Click);
            // 
            // Btn_Excel
            // 
            this.Btn_Excel.BackColor = System.Drawing.Color.Green;
            this.Btn_Excel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Excel.ForeColor = System.Drawing.Color.White;
            this.Btn_Excel.Location = new System.Drawing.Point(353, 347);
            this.Btn_Excel.Name = "Btn_Excel";
            this.Btn_Excel.Size = new System.Drawing.Size(113, 57);
            this.Btn_Excel.TabIndex = 8;
            this.Btn_Excel.Text = "Xuất Excel";
            this.Btn_Excel.UseVisualStyleBackColor = false;
            this.Btn_Excel.Click += new System.EventHandler(this.Btn_Excel_Click);
            // 
            // Dgv_Details_RM
            // 
            this.Dgv_Details_RM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Details_RM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Details_RM.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Details_RM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.Dgv_Details_RM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Details_RM.DefaultCellStyle = dataGridViewCellStyle20;
            this.Dgv_Details_RM.EnableHeadersVisualStyles = false;
            this.Dgv_Details_RM.Location = new System.Drawing.Point(38, 432);
            this.Dgv_Details_RM.Name = "Dgv_Details_RM";
            this.Dgv_Details_RM.ReadOnly = true;
            this.Dgv_Details_RM.RowHeadersVisible = false;
            this.Dgv_Details_RM.RowTemplate.Height = 30;
            this.Dgv_Details_RM.Size = new System.Drawing.Size(1160, 424);
            this.Dgv_Details_RM.TabIndex = 5;
            this.Dgv_Details_RM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_Details_RM_CellClick);
            // 
            // Lab_Details_RM
            // 
            this.Lab_Details_RM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_Details_RM.AutoSize = true;
            this.Lab_Details_RM.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Lab_Details_RM.Location = new System.Drawing.Point(469, 241);
            this.Lab_Details_RM.Name = "Lab_Details_RM";
            this.Lab_Details_RM.Size = new System.Drawing.Size(141, 22);
            this.Lab_Details_RM.TabIndex = 4;
            this.Lab_Details_RM.Text = "Thông Tin RM";
            // 
            // label_suggest
            // 
            this.label_suggest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_suggest.AutoSize = true;
            this.label_suggest.Location = new System.Drawing.Point(610, 347);
            this.label_suggest.Name = "label_suggest";
            this.label_suggest.Size = new System.Drawing.Size(0, 13);
            this.label_suggest.TabIndex = 9;
            // 
            // txt_Search_ItemCode
            // 
            this.txt_Search_ItemCode.Font = new System.Drawing.Font("Arial", 15F);
            this.txt_Search_ItemCode.Location = new System.Drawing.Point(38, 284);
            this.txt_Search_ItemCode.Name = "txt_Search_ItemCode";
            this.txt_Search_ItemCode.Size = new System.Drawing.Size(373, 30);
            this.txt_Search_ItemCode.TabIndex = 11;
            this.txt_Search_ItemCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyDown);
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Search.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Search.ForeColor = System.Drawing.Color.White;
            this.Btn_Search.Location = new System.Drawing.Point(992, 281);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(110, 40);
            this.Btn_Search.TabIndex = 8;
            this.Btn_Search.Text = "Tìm Kiếm";
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // txt_Search_Lotno
            // 
            this.txt_Search_Lotno.Font = new System.Drawing.Font("Arial", 15F);
            this.txt_Search_Lotno.Location = new System.Drawing.Point(433, 284);
            this.txt_Search_Lotno.Name = "txt_Search_Lotno";
            this.txt_Search_Lotno.Size = new System.Drawing.Size(373, 30);
            this.txt_Search_Lotno.TabIndex = 12;
            this.txt_Search_Lotno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyDown);
            // 
            // location_box
            // 
            this.location_box.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_box.FormattingEnabled = true;
            this.location_box.Location = new System.Drawing.Point(826, 284);
            this.location_box.Name = "location_box";
            this.location_box.Size = new System.Drawing.Size(140, 31);
            this.location_box.TabIndex = 16;
            this.location_box.Tag = "";
            // 
            // Form_RM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.location_box);
            this.Controls.Add(this.txt_Search_Lotno);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.txt_Search_ItemCode);
            this.Controls.Add(this.label_suggest);
            this.Controls.Add(this.Lab_Details_RM);
            this.Controls.Add(this.Dgv_Details_RM);
            this.Controls.Add(this.Btn_Excel);
            this.Controls.Add(this.Btn_Details);
            this.Controls.Add(this.Btn_Total);
            this.Controls.Add(this.Lab_Main_RM);
            this.Controls.Add(this.Dgv_Main_RM);
            this.Name = "Form_RM";
            this.Size = new System.Drawing.Size(1235, 901);
            this.Load += new System.EventHandler(this.Form_RM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Main_RM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Details_RM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Main_RM;
        private Label Lab_Main_RM;
        private Button Btn_Total;
        private Button Btn_Details;
        private Button Btn_Excel;
        private DataGridView Dgv_Details_RM;
        private Label Lab_Details_RM;
        private Label label_suggest;
        private TextBox txt_Search_ItemCode;
        private Button Btn_Search;
        private TextBox txt_Search_Lotno;
        private DataGridViewTextBoxColumn TT;
        private DataGridViewTextBoxColumn Blocked;
        private DataGridViewTextBoxColumn UU;
        private DataGridViewTextBoxColumn QI;
        private DataGridViewTextBoxColumn Restricted;
        private DataGridViewTextBoxColumn Total;
        private ComboBox location_box;
    }
}