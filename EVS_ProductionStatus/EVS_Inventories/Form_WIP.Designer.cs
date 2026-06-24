using System.Windows.Forms;

namespace EVS_Management
{
    partial class Form_WIP
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

        #region Windows FoWIP Designer generated code

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
            this.Dgv_Main_WIP = new System.Windows.Forms.DataGridView();
            this.Lab_Main_WIP = new System.Windows.Forms.Label();
            this.Btn_Total = new System.Windows.Forms.Button();
            this.Btn_Details = new System.Windows.Forms.Button();
            this.Btn_Excel = new System.Windows.Forms.Button();
            this.Dgv_Details_WIP = new System.Windows.Forms.DataGridView();
            this.Lab_Details_WIP = new System.Windows.Forms.Label();
            this.label_suggest = new System.Windows.Forms.Label();
            this.txt_Search_ItemCode = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.txt_Search_Lotno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Main_WIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Details_WIP)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Main_WIP
            // 
            this.Dgv_Main_WIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Main_WIP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(7, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Main_WIP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Main_WIP.ColumnHeadersHeight = 48;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Main_WIP.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Main_WIP.EnableHeadersVisualStyles = false;
            this.Dgv_Main_WIP.Location = new System.Drawing.Point(38, 95);
            this.Dgv_Main_WIP.Name = "Dgv_Main_WIP";
            this.Dgv_Main_WIP.ReadOnly = true;
            this.Dgv_Main_WIP.RowHeadersVisible = false;
            this.Dgv_Main_WIP.RowTemplate.Height = 30;
            this.Dgv_Main_WIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Dgv_Main_WIP.Size = new System.Drawing.Size(1160, 132);
            this.Dgv_Main_WIP.TabIndex = 0;
            this.Dgv_Main_WIP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_Main_WIP_CellClick);
            // 
            // Lab_Main_WIP
            // 
            this.Lab_Main_WIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_Main_WIP.AutoSize = true;
            this.Lab_Main_WIP.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Lab_Main_WIP.Location = new System.Drawing.Point(480, 46);
            this.Lab_Main_WIP.Name = "Lab_Main_WIP";
            this.Lab_Main_WIP.Size = new System.Drawing.Size(130, 22);
            this.Lab_Main_WIP.TabIndex = 2;
            this.Lab_Main_WIP.Text = "Tồn Kho WIP ";
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
            // Dgv_Details_WIP
            // 
            this.Dgv_Details_WIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Details_WIP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Details_WIP.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Details_WIP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Details_WIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Details_WIP.DefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_Details_WIP.EnableHeadersVisualStyles = false;
            this.Dgv_Details_WIP.Location = new System.Drawing.Point(38, 432);
            this.Dgv_Details_WIP.Name = "Dgv_Details_WIP";
            this.Dgv_Details_WIP.ReadOnly = true;
            this.Dgv_Details_WIP.RowHeadersVisible = false;
            this.Dgv_Details_WIP.RowTemplate.Height = 30;
            this.Dgv_Details_WIP.Size = new System.Drawing.Size(1160, 424);
            this.Dgv_Details_WIP.TabIndex = 5;
            this.Dgv_Details_WIP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_Details_WIP_CellClick);
            // 
            // Lab_Details_WIP
            // 
            this.Lab_Details_WIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_Details_WIP.AutoSize = true;
            this.Lab_Details_WIP.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Lab_Details_WIP.Location = new System.Drawing.Point(469, 241);
            this.Lab_Details_WIP.Name = "Lab_Details_WIP";
            this.Lab_Details_WIP.Size = new System.Drawing.Size(141, 22);
            this.Lab_Details_WIP.TabIndex = 4;
            this.Lab_Details_WIP.Text = "Thông Tin WIP";
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
            // FoWIP_WIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Search_Lotno);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.txt_Search_ItemCode);
            this.Controls.Add(this.label_suggest);
            this.Controls.Add(this.Lab_Details_WIP);
            this.Controls.Add(this.Dgv_Details_WIP);
            this.Controls.Add(this.Btn_Excel);
            this.Controls.Add(this.Btn_Details);
            this.Controls.Add(this.Btn_Total);
            this.Controls.Add(this.Lab_Main_WIP);
            this.Controls.Add(this.Dgv_Main_WIP);
            this.Name = "FoWIP_WIP";
            this.Size = new System.Drawing.Size(1235, 901);
            this.Load += new System.EventHandler(this.FoWIP_WIP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Main_WIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Details_WIP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Main_WIP;
        private Label Lab_Main_WIP;
        private Button Btn_Total;
        private Button Btn_Details;
        private Button Btn_Excel;
        private DataGridView Dgv_Details_WIP;
        private Label Lab_Details_WIP;
        private Label label_suggest;
        private TextBox txt_Search_ItemCode;
        private Button Btn_Search;
        private TextBox txt_Search_Lotno;
    }
}