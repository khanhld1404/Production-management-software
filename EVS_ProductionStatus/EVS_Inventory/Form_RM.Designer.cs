using System.Windows.Forms;

namespace EVS_ProductionStatus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dgv_Main_RM = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Main_RM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Details_RM)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Main_RM
            // 
            this.Dgv_Main_RM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Main_RM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(7, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Main_RM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Main_RM.ColumnHeadersHeight = 48;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Main_RM.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Main_RM.EnableHeadersVisualStyles = false;
            this.Dgv_Main_RM.Location = new System.Drawing.Point(38, 95);
            this.Dgv_Main_RM.Name = "Dgv_Main_RM";
            this.Dgv_Main_RM.ReadOnly = true;
            this.Dgv_Main_RM.RowHeadersVisible = false;
            this.Dgv_Main_RM.RowTemplate.Height = 30;
            this.Dgv_Main_RM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Dgv_Main_RM.Size = new System.Drawing.Size(1160, 132);
            this.Dgv_Main_RM.TabIndex = 0;
            this.Dgv_Main_RM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_Main_RM_CellClick);
            // 
            // Lab_Main_RM
            // 
            this.Lab_Main_RM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_Main_RM.AutoSize = true;
            this.Lab_Main_RM.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Lab_Main_RM.Location = new System.Drawing.Point(480, 46);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Details_RM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Details_RM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Details_RM.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.txt_Search_ItemCode.Size = new System.Drawing.Size(445, 40);
            this.txt_Search_ItemCode.TabIndex = 11;
            this.AutoSize = false;

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
            this.txt_Search_Lotno.Size = new System.Drawing.Size(445, 40);
            this.txt_Search_Lotno.TabIndex = 12;
            this.AutoSize = false;
            
            this.txt_Search_Lotno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyDown);
            // 
            // Form_RM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}