using System.Windows.Forms;

namespace Main_Project_Trainee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dgv_Main_HFG = new System.Windows.Forms.DataGridView();
            this.Lab_Main_HFG = new System.Windows.Forms.Label();
            this.Lab_Detail_HFG = new System.Windows.Forms.Label();
            this.Dgv_Details_HFG = new System.Windows.Forms.DataGridView();
            this.Btn_Total = new System.Windows.Forms.Button();
            this.Btn_Details = new System.Windows.Forms.Button();
            this.Btn_Excel = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.txt_Search_ItemNumber = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.txt_Search_ID = new System.Windows.Forms.TextBox();
            this.picLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Main_HFG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Details_HFG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Main_HFG
            // 
            this.Dgv_Main_HFG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Main_HFG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Main_HFG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_Main_HFG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Main_HFG.DefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_Main_HFG.EnableHeadersVisualStyles = false;
            this.Dgv_Main_HFG.Location = new System.Drawing.Point(38, 64);
            this.Dgv_Main_HFG.Name = "Dgv_Main_HFG";
            this.Dgv_Main_HFG.ReadOnly = true;
            this.Dgv_Main_HFG.RowHeadersVisible = false;
            this.Dgv_Main_HFG.RowTemplate.Height = 30;
            this.Dgv_Main_HFG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Dgv_Main_HFG.Size = new System.Drawing.Size(789, 177);
            this.Dgv_Main_HFG.TabIndex = 0;
            this.Dgv_Main_HFG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_Details_HFG_Click);
            // 
            // Lab_Main_HFG
            // 
            this.Lab_Main_HFG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_Main_HFG.AutoSize = true;
            this.Lab_Main_HFG.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Lab_Main_HFG.Location = new System.Drawing.Point(342, 30);
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
            this.Lab_Detail_HFG.Location = new System.Drawing.Point(528, 259);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Details_HFG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Dgv_Details_HFG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Details_HFG.DefaultCellStyle = dataGridViewCellStyle8;
            this.Dgv_Details_HFG.EnableHeadersVisualStyles = false;
            this.Dgv_Details_HFG.Location = new System.Drawing.Point(38, 444);
            this.Dgv_Details_HFG.Name = "Dgv_Details_HFG";
            this.Dgv_Details_HFG.ReadOnly = true;
            this.Dgv_Details_HFG.RowHeadersVisible = false;
            this.Dgv_Details_HFG.RowTemplate.Height = 30;
            this.Dgv_Details_HFG.Size = new System.Drawing.Size(1121, 400);
            this.Dgv_Details_HFG.TabIndex = 5;
            // 
            // Btn_Total
            // 
            this.Btn_Total.BackColor = System.Drawing.Color.Gray;
            this.Btn_Total.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Total.ForeColor = System.Drawing.Color.White;
            this.Btn_Total.Location = new System.Drawing.Point(38, 364);
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
            this.Btn_Details.Location = new System.Drawing.Point(216, 364);
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
            this.Btn_Excel.Location = new System.Drawing.Point(382, 364);
            this.Btn_Excel.Name = "Btn_Excel";
            this.Btn_Excel.Size = new System.Drawing.Size(113, 57);
            this.Btn_Excel.TabIndex = 8;
            this.Btn_Excel.Text = "Xuất Excel";
            this.Btn_Excel.UseVisualStyleBackColor = false;
            this.Btn_Excel.Click += new System.EventHandler(this.Btn_Excel_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Refresh.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Btn_Refresh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.Btn_Refresh.Location = new System.Drawing.Point(962, 64);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(124, 49);
            this.Btn_Refresh.TabIndex = 9;
            this.Btn_Refresh.Text = "Cập nhật dữ liệu";
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // txt_Search_ItemNumber
            // 
            this.txt_Search_ItemNumber.Font = new System.Drawing.Font("Arial", 15F);
            this.txt_Search_ItemNumber.Location = new System.Drawing.Point(38, 305);
            this.txt_Search_ItemNumber.Name = "txt_Search_ItemNumber";
            this.txt_Search_ItemNumber.Size = new System.Drawing.Size(383, 35);
            this.txt_Search_ItemNumber.TabIndex = 12;
            this.txt_Search_ItemNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyDown);
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Search.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Search.ForeColor = System.Drawing.Color.White;
            this.Btn_Search.Location = new System.Drawing.Point(848, 305);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(104, 40);
            this.Btn_Search.TabIndex = 13;
            this.Btn_Search.Text = "Tìm Kiếm";
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // txt_Search_ID
            // 
            this.txt_Search_ID.Font = new System.Drawing.Font("Arial", 15F);
            this.txt_Search_ID.Location = new System.Drawing.Point(444, 305);
            this.txt_Search_ID.Name = "txt_Search_ID";
            this.txt_Search_ID.Size = new System.Drawing.Size(383, 35);
            this.txt_Search_ID.TabIndex = 14;
            this.txt_Search_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyDown);
            // 
            // picLoading
            // 
            this.picLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLoading.Image = global::EVS_ProductionStatus.Properties.Resources._16;
            this.picLoading.Location = new System.Drawing.Point(1092, 76);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(29, 27);
            this.picLoading.TabIndex = 48;
            this.picLoading.TabStop = false;
            this.picLoading.Visible = false;
            // 
            // Form_HFG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.txt_Search_ID);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.txt_Search_ItemNumber);
            this.Controls.Add(this.Btn_Refresh);
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
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
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
        private Button Btn_Refresh;
        private TextBox txt_Search_ItemNumber;
        private Button Btn_Search;
        private TextBox txt_Search_ID;
        private PictureBox picLoading;
    }
}
