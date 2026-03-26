using System.Windows.Forms;

namespace EVS_ProductionStatus
{
    partial class Form_RM_WIP
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
            this.Dgv_Main_RM_WIP = new System.Windows.Forms.DataGridView();
            this.Lab_Main_RM_WIP = new System.Windows.Forms.Label();
            this.Btn_Total = new System.Windows.Forms.Button();
            this.Btn_Details = new System.Windows.Forms.Button();
            this.Btn_Excel = new System.Windows.Forms.Button();
            this.Dgv_Details_RM_WIP = new System.Windows.Forms.DataGridView();
            this.Lab_Details_RM_WIP = new System.Windows.Forms.Label();
            this.label_suggest = new System.Windows.Forms.Label();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.txt_Search_ItemCode = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.txt_Search_Lotno = new System.Windows.Forms.TextBox();
            this.picLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Main_RM_WIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Details_RM_WIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Main_RM_WIP
            // 
            this.Dgv_Main_RM_WIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Main_RM_WIP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(7, 10, 0, 10);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Main_RM_WIP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_Main_RM_WIP.ColumnHeadersHeight = 48;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Main_RM_WIP.DefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_Main_RM_WIP.EnableHeadersVisualStyles = false;
            this.Dgv_Main_RM_WIP.Location = new System.Drawing.Point(38, 95);
            this.Dgv_Main_RM_WIP.Name = "Dgv_Main_RM_WIP";
            this.Dgv_Main_RM_WIP.ReadOnly = true;
            this.Dgv_Main_RM_WIP.RowHeadersVisible = false;
            this.Dgv_Main_RM_WIP.RowTemplate.Height = 30;
            this.Dgv_Main_RM_WIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Dgv_Main_RM_WIP.Size = new System.Drawing.Size(915, 132);
            this.Dgv_Main_RM_WIP.TabIndex = 0;
            this.Dgv_Main_RM_WIP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_Main_RM_WIP_CellClick);
            // 
            // Lab_Main_RM_WIP
            // 
            this.Lab_Main_RM_WIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_Main_RM_WIP.AutoSize = true;
            this.Lab_Main_RM_WIP.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Lab_Main_RM_WIP.Location = new System.Drawing.Point(379, 48);
            this.Lab_Main_RM_WIP.Name = "Lab_Main_RM_WIP";
            this.Lab_Main_RM_WIP.Size = new System.Drawing.Size(192, 22);
            this.Lab_Main_RM_WIP.TabIndex = 2;
            this.Lab_Main_RM_WIP.Text = "Tồn Kho RM và WIP";
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
            // Dgv_Details_RM_WIP
            // 
            this.Dgv_Details_RM_WIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Details_RM_WIP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Details_RM_WIP.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Details_RM_WIP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Dgv_Details_RM_WIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Details_RM_WIP.DefaultCellStyle = dataGridViewCellStyle8;
            this.Dgv_Details_RM_WIP.EnableHeadersVisualStyles = false;
            this.Dgv_Details_RM_WIP.Location = new System.Drawing.Point(38, 432);
            this.Dgv_Details_RM_WIP.Name = "Dgv_Details_RM_WIP";
            this.Dgv_Details_RM_WIP.ReadOnly = true;
            this.Dgv_Details_RM_WIP.RowHeadersVisible = false;
            this.Dgv_Details_RM_WIP.RowTemplate.Height = 30;
            this.Dgv_Details_RM_WIP.Size = new System.Drawing.Size(1121, 424);
            this.Dgv_Details_RM_WIP.TabIndex = 5;
            this.Dgv_Details_RM_WIP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_Details_RM_WIP_CellClick);
            // 
            // Lab_Details_RM_WIP
            // 
            this.Lab_Details_RM_WIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_Details_RM_WIP.AutoSize = true;
            this.Lab_Details_RM_WIP.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Lab_Details_RM_WIP.Location = new System.Drawing.Point(425, 244);
            this.Lab_Details_RM_WIP.Name = "Lab_Details_RM_WIP";
            this.Lab_Details_RM_WIP.Size = new System.Drawing.Size(208, 22);
            this.Lab_Details_RM_WIP.TabIndex = 4;
            this.Lab_Details_RM_WIP.Text = "Thông Tin RM và WIP";
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
            // Btn_Refresh
            // 
            this.Btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Refresh.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Btn_Refresh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.Btn_Refresh.Location = new System.Drawing.Point(1007, 95);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(126, 49);
            this.Btn_Refresh.TabIndex = 10;
            this.Btn_Refresh.Text = "Cập nhật dữ liệu";
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // txt_Search_ItemCode
            // 
            this.txt_Search_ItemCode.Font = new System.Drawing.Font("Arial", 15F);
            this.txt_Search_ItemCode.Location = new System.Drawing.Point(38, 284);
            this.txt_Search_ItemCode.Name = "txt_Search_ItemCode";
            this.txt_Search_ItemCode.Size = new System.Drawing.Size(445, 35);
            this.txt_Search_ItemCode.TabIndex = 11;
            this.txt_Search_ItemCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyDown);
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Search.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Search.ForeColor = System.Drawing.Color.White;
            this.Btn_Search.Location = new System.Drawing.Point(972, 284);
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
            this.txt_Search_Lotno.Location = new System.Drawing.Point(508, 284);
            this.txt_Search_Lotno.Name = "txt_Search_Lotno";
            this.txt_Search_Lotno.Size = new System.Drawing.Size(445, 35);
            this.txt_Search_Lotno.TabIndex = 12;
            this.txt_Search_Lotno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyDown);
            // 
            // picLoading
            // 
            this.picLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLoading.Image = global::EVS_ProductionStatus.Properties.Resources._16;
            this.picLoading.Location = new System.Drawing.Point(1139, 108);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(35, 26);
            this.picLoading.TabIndex = 48;
            this.picLoading.TabStop = false;
            this.picLoading.Visible = false;
            // 
            // Form_RM_WIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.txt_Search_Lotno);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.txt_Search_ItemCode);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.label_suggest);
            this.Controls.Add(this.Lab_Details_RM_WIP);
            this.Controls.Add(this.Dgv_Details_RM_WIP);
            this.Controls.Add(this.Btn_Excel);
            this.Controls.Add(this.Btn_Details);
            this.Controls.Add(this.Btn_Total);
            this.Controls.Add(this.Lab_Main_RM_WIP);
            this.Controls.Add(this.Dgv_Main_RM_WIP);
            this.Name = "Form_RM_WIP";
            this.Size = new System.Drawing.Size(1235, 901);
            this.Load += new System.EventHandler(this.Form_RM_WIP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Main_RM_WIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Details_RM_WIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Main_RM_WIP;
        private Label Lab_Main_RM_WIP;
        private Button Btn_Total;
        private Button Btn_Details;
        private Button Btn_Excel;
        private DataGridView Dgv_Details_RM_WIP;
        private Label Lab_Details_RM_WIP;
        private Label label_suggest;
        private Button Btn_Refresh;
        private TextBox txt_Search_ItemCode;
        private Button Btn_Search;
        private TextBox txt_Search_Lotno;
        private PictureBox picLoading;
    }
}