using System.Windows.Forms;

namespace EVS_Management
{
    partial class Form_HFG
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dgv_Main_HFG = new System.Windows.Forms.DataGridView();
            this.Lab_Main_HFG = new System.Windows.Forms.Label();
            this.Lab_Detail_HFG = new System.Windows.Forms.Label();
            this.Dgv_Details_HFG = new System.Windows.Forms.DataGridView();
            this.Btn_Total = new System.Windows.Forms.Button();
            this.Btn_Details = new System.Windows.Forms.Button();
            this.Btn_Excel = new System.Windows.Forms.Button();
            this.txt_Search_Material_Code = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.txt_Search_Batch_Number = new System.Windows.Forms.TextBox();
            this.location_box = new System.Windows.Forms.ComboBox();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Blocked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unrestricted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restricted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Main_HFG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Details_HFG)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Main_HFG
            // 
            this.Dgv_Main_HFG.AllowUserToAddRows = false;
            this.Dgv_Main_HFG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Main_HFG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Main_HFG.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(7, 12, 0, 12);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Main_HFG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Main_HFG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Main_HFG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TT,
            this.Blocked,
            this.Unrestricted,
            this.QI,
            this.Restricted,
            this.Total});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Main_HFG.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Main_HFG.EnableHeadersVisualStyles = false;
            this.Dgv_Main_HFG.Location = new System.Drawing.Point(38, 64);
            this.Dgv_Main_HFG.Name = "Dgv_Main_HFG";
            this.Dgv_Main_HFG.ReadOnly = true;
            this.Dgv_Main_HFG.RowHeadersVisible = false;
            this.Dgv_Main_HFG.RowTemplate.Height = 30;
            this.Dgv_Main_HFG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Dgv_Main_HFG.Size = new System.Drawing.Size(1057, 177);
            this.Dgv_Main_HFG.TabIndex = 0;
            this.Dgv_Main_HFG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_Details_HFG_Click);
            // 
            // Lab_Main_HFG
            // 
            this.Lab_Main_HFG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_Main_HFG.AutoSize = true;
            this.Lab_Main_HFG.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Lab_Main_HFG.Location = new System.Drawing.Point(479, 23);
            this.Lab_Main_HFG.Name = "Lab_Main_HFG";
            this.Lab_Main_HFG.Size = new System.Drawing.Size(135, 22);
            this.Lab_Main_HFG.TabIndex = 2;
            this.Lab_Main_HFG.Text = "Tồn Kho HFG";
            // 
            // Lab_Detail_HFG
            // 
            this.Lab_Detail_HFG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_Detail_HFG.AutoSize = true;
            this.Lab_Detail_HFG.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Lab_Detail_HFG.Location = new System.Drawing.Point(479, 244);
            this.Lab_Detail_HFG.Name = "Lab_Detail_HFG";
            this.Lab_Detail_HFG.Size = new System.Drawing.Size(151, 22);
            this.Lab_Detail_HFG.TabIndex = 4;
            this.Lab_Detail_HFG.Text = "Thông Tin HFG";
            // 
            // Dgv_Details_HFG
            // 
            this.Dgv_Details_HFG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Details_HFG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Details_HFG.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Details_HFG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Details_HFG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Details_HFG.DefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_Details_HFG.EnableHeadersVisualStyles = false;
            this.Dgv_Details_HFG.Location = new System.Drawing.Point(38, 428);
            this.Dgv_Details_HFG.Name = "Dgv_Details_HFG";
            this.Dgv_Details_HFG.ReadOnly = true;
            this.Dgv_Details_HFG.RowHeadersVisible = false;
            this.Dgv_Details_HFG.RowTemplate.Height = 30;
            this.Dgv_Details_HFG.Size = new System.Drawing.Size(1121, 453);
            this.Dgv_Details_HFG.TabIndex = 5;
            // 
            // Btn_Total
            // 
            this.Btn_Total.BackColor = System.Drawing.Color.Gray;
            this.Btn_Total.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Total.ForeColor = System.Drawing.Color.White;
            this.Btn_Total.Location = new System.Drawing.Point(38, 346);
            this.Btn_Total.Name = "Btn_Total";
            this.Btn_Total.Size = new System.Drawing.Size(153, 57);
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
            this.Btn_Details.Location = new System.Drawing.Point(216, 346);
            this.Btn_Details.Name = "Btn_Details";
            this.Btn_Details.Size = new System.Drawing.Size(130, 57);
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
            this.Btn_Excel.Location = new System.Drawing.Point(382, 346);
            this.Btn_Excel.Name = "Btn_Excel";
            this.Btn_Excel.Size = new System.Drawing.Size(113, 57);
            this.Btn_Excel.TabIndex = 8;
            this.Btn_Excel.Text = "Xuất Excel";
            this.Btn_Excel.UseVisualStyleBackColor = false;
            this.Btn_Excel.Click += new System.EventHandler(this.Btn_Excel_Click);
            // 
            // txt_Search_Material_Code
            // 
            this.txt_Search_Material_Code.Font = new System.Drawing.Font("Arial", 15F);
            this.txt_Search_Material_Code.Location = new System.Drawing.Point(38, 287);
            this.txt_Search_Material_Code.Name = "txt_Search_Material_Code";
            this.txt_Search_Material_Code.Size = new System.Drawing.Size(383, 31);
            this.txt_Search_Material_Code.TabIndex = 12;
            this.txt_Search_Material_Code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyDown);
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Search.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Search.ForeColor = System.Drawing.Color.White;
            this.Btn_Search.Location = new System.Drawing.Point(991, 279);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(104, 40);
            this.Btn_Search.TabIndex = 13;
            this.Btn_Search.Text = "Tìm Kiếm";
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // txt_Search_Batch_Number
            // 
            this.txt_Search_Batch_Number.Font = new System.Drawing.Font("Arial", 15F);
            this.txt_Search_Batch_Number.Location = new System.Drawing.Point(446, 288);
            this.txt_Search_Batch_Number.Name = "txt_Search_Batch_Number";
            this.txt_Search_Batch_Number.Size = new System.Drawing.Size(383, 30);
            this.txt_Search_Batch_Number.TabIndex = 14;
            this.txt_Search_Batch_Number.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyDown);
            // 
            // location_box
            // 
            this.location_box.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_box.FormattingEnabled = true;
            this.location_box.Location = new System.Drawing.Point(845, 287);
            this.location_box.Name = "location_box";
            this.location_box.Size = new System.Drawing.Size(140, 31);
            this.location_box.TabIndex = 15;
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
            // Unrestricted
            // 
            this.Unrestricted.HeaderText = "UU";
            this.Unrestricted.Name = "Unrestricted";
            this.Unrestricted.ReadOnly = true;
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
            // Form_HFG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.location_box);
            this.Controls.Add(this.txt_Search_Batch_Number);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.txt_Search_Material_Code);
            this.Controls.Add(this.Btn_Excel);
            this.Controls.Add(this.Btn_Details);
            this.Controls.Add(this.Btn_Total);
            this.Controls.Add(this.Dgv_Details_HFG);
            this.Controls.Add(this.Lab_Detail_HFG);
            this.Controls.Add(this.Lab_Main_HFG);
            this.Controls.Add(this.Dgv_Main_HFG);
            this.Name = "Form_HFG";
            this.Size = new System.Drawing.Size(1225, 896);
            this.Load += new System.EventHandler(this.Form_HFG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Main_HFG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Details_HFG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Main_HFG;
        private Label Lab_Main_HFG;
        private Label Lab_Detail_HFG;
        private DataGridView Dgv_Details_HFG;
        private Button Btn_Total;
        private Button Btn_Details;
        private Button Btn_Excel;
        private TextBox txt_Search_Material_Code;
        private Button Btn_Search;
        private TextBox txt_Search_Batch_Number;
        private ComboBox location_box;
        private DataGridViewTextBoxColumn TT;
        private DataGridViewTextBoxColumn Blocked;
        private DataGridViewTextBoxColumn Unrestricted;
        private DataGridViewTextBoxColumn QI;
        private DataGridViewTextBoxColumn Restricted;
        private DataGridViewTextBoxColumn Total;
    }
}
