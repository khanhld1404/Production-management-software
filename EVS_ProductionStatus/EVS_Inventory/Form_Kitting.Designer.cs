using System.Windows.Forms;

namespace EVS_ProductionStatus
{
    partial class Form_Kitting
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
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Txt_NVL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lab_TT_Kitting = new System.Windows.Forms.Label();
            this.Data_Kitting_NVL = new System.Windows.Forms.DataGridView();
            this.Btn_Excel = new System.Windows.Forms.Button();
            this.Btn_Rewatch = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.picLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Kitting_NVL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Search.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Search.ForeColor = System.Drawing.Color.White;
            this.Btn_Search.Location = new System.Drawing.Point(866, 76);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(104, 49);
            this.Btn_Search.TabIndex = 8;
            this.Btn_Search.Text = "Tìm Kiếm";
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Txt_NVL
            // 
            this.Txt_NVL.Font = new System.Drawing.Font("Arial", 15F);
            this.Txt_NVL.Location = new System.Drawing.Point(51, 83);
            this.Txt_NVL.Name = "Txt_NVL";
            this.Txt_NVL.Size = new System.Drawing.Size(785, 35);
            this.Txt_NVL.TabIndex = 1;
            this.Txt_NVL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_NVL_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Vạch NVL";
            // 
            // Lab_TT_Kitting
            // 
            this.Lab_TT_Kitting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_TT_Kitting.AutoSize = true;
            this.Lab_TT_Kitting.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.Lab_TT_Kitting.Location = new System.Drawing.Point(414, 157);
            this.Lab_TT_Kitting.Name = "Lab_TT_Kitting";
            this.Lab_TT_Kitting.Size = new System.Drawing.Size(262, 27);
            this.Lab_TT_Kitting.TabIndex = 3;
            this.Lab_TT_Kitting.Text = "Thông Tin Kitting NVL";
            // 
            // Data_Kitting_NVL
            // 
            this.Data_Kitting_NVL.AllowUserToAddRows = false;
            this.Data_Kitting_NVL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Data_Kitting_NVL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data_Kitting_NVL.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_Kitting_NVL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Data_Kitting_NVL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_Kitting_NVL.DefaultCellStyle = dataGridViewCellStyle6;
            this.Data_Kitting_NVL.EnableHeadersVisualStyles = false;
            this.Data_Kitting_NVL.Location = new System.Drawing.Point(51, 207);
            this.Data_Kitting_NVL.Name = "Data_Kitting_NVL";
            this.Data_Kitting_NVL.ReadOnly = true;
            this.Data_Kitting_NVL.RowHeadersVisible = false;
            this.Data_Kitting_NVL.RowTemplate.Height = 30;
            this.Data_Kitting_NVL.Size = new System.Drawing.Size(1030, 470);
            this.Data_Kitting_NVL.TabIndex = 4;
            // 
            // Btn_Excel
            // 
            this.Btn_Excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Excel.BackColor = System.Drawing.Color.Green;
            this.Btn_Excel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Excel.ForeColor = System.Drawing.Color.White;
            this.Btn_Excel.Location = new System.Drawing.Point(977, 714);
            this.Btn_Excel.Name = "Btn_Excel";
            this.Btn_Excel.Size = new System.Drawing.Size(104, 52);
            this.Btn_Excel.TabIndex = 9;
            this.Btn_Excel.Text = "Xuất Excel";
            this.Btn_Excel.UseVisualStyleBackColor = false;
            this.Btn_Excel.Click += new System.EventHandler(this.Btn_Excel_Click);
            // 
            // Btn_Rewatch
            // 
            this.Btn_Rewatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Rewatch.BackColor = System.Drawing.Color.Orange;
            this.Btn_Rewatch.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Rewatch.ForeColor = System.Drawing.Color.White;
            this.Btn_Rewatch.Location = new System.Drawing.Point(846, 714);
            this.Btn_Rewatch.Name = "Btn_Rewatch";
            this.Btn_Rewatch.Size = new System.Drawing.Size(104, 52);
            this.Btn_Rewatch.TabIndex = 10;
            this.Btn_Rewatch.Text = "Xem lại";
            this.Btn_Rewatch.UseVisualStyleBackColor = false;
            this.Btn_Rewatch.Click += new System.EventHandler(this.Btn_Rewatch_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Refresh.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Btn_Refresh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.Btn_Refresh.Location = new System.Drawing.Point(686, 714);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(126, 52);
            this.Btn_Refresh.TabIndex = 11;
            this.Btn_Refresh.Text = "Cập nhật dữ liệu";
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // picLoading
            // 
            this.picLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picLoading.Image = global::EVS_ProductionStatus.Properties.Resources._16;
            this.picLoading.Location = new System.Drawing.Point(651, 728);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(29, 27);
            this.picLoading.TabIndex = 48;
            this.picLoading.TabStop = false;
            this.picLoading.Visible = false;
            // 
            // Form_Kitting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.Btn_Rewatch);
            this.Controls.Add(this.Btn_Excel);
            this.Controls.Add(this.Data_Kitting_NVL);
            this.Controls.Add(this.Lab_TT_Kitting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_NVL);
            this.Controls.Add(this.Btn_Search);
            this.Name = "Form_Kitting";
            this.Size = new System.Drawing.Size(1119, 799);
            this.Load += new System.EventHandler(this.Form_Kitting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Kitting_NVL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.TextBox Txt_NVL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lab_TT_Kitting;
        private System.Windows.Forms.DataGridView Data_Kitting_NVL;
        private System.Windows.Forms.Button Btn_Excel;
        private System.Windows.Forms.Button Btn_Rewatch;
        private Button Btn_Refresh;
        private PictureBox picLoading;
    }
}
