namespace EVS_ProductionStatus.EVS_Inventories
{
    partial class Detail_EVS_Inventory
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
            this.location_box = new System.Windows.Forms.ComboBox();
            this.txt_Search_Batch = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.txt_Search_Material = new System.Windows.Forms.TextBox();
            this.label_suggest = new System.Windows.Forms.Label();
            this.Lab_Infor_Total = new System.Windows.Forms.Label();
            this.Total_EVS_Data = new System.Windows.Forms.DataGridView();
            this.Btn_Excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Total_EVS_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // location_box
            // 
            this.location_box.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_box.FormattingEnabled = true;
            this.location_box.Location = new System.Drawing.Point(811, 64);
            this.location_box.Name = "location_box";
            this.location_box.Size = new System.Drawing.Size(140, 31);
            this.location_box.TabIndex = 26;
            this.location_box.Tag = "";
            // 
            // txt_Search_Batch
            // 
            this.txt_Search_Batch.Font = new System.Drawing.Font("Arial", 15F);
            this.txt_Search_Batch.Location = new System.Drawing.Point(418, 64);
            this.txt_Search_Batch.Name = "txt_Search_Batch";
            this.txt_Search_Batch.Size = new System.Drawing.Size(373, 30);
            this.txt_Search_Batch.TabIndex = 25;
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Search.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Search.ForeColor = System.Drawing.Color.White;
            this.Btn_Search.Location = new System.Drawing.Point(977, 61);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(110, 42);
            this.Btn_Search.TabIndex = 21;
            this.Btn_Search.Text = "Tìm Kiếm";
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // txt_Search_Material
            // 
            this.txt_Search_Material.Font = new System.Drawing.Font("Arial", 15F);
            this.txt_Search_Material.Location = new System.Drawing.Point(23, 64);
            this.txt_Search_Material.Name = "txt_Search_Material";
            this.txt_Search_Material.Size = new System.Drawing.Size(373, 30);
            this.txt_Search_Material.TabIndex = 24;
            // 
            // label_suggest
            // 
            this.label_suggest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_suggest.AutoSize = true;
            this.label_suggest.Location = new System.Drawing.Point(614, 106);
            this.label_suggest.Name = "label_suggest";
            this.label_suggest.Size = new System.Drawing.Size(0, 13);
            this.label_suggest.TabIndex = 23;
            // 
            // Lab_Infor_Total
            // 
            this.Lab_Infor_Total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_Infor_Total.AutoSize = true;
            this.Lab_Infor_Total.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Lab_Infor_Total.Location = new System.Drawing.Point(523, 27);
            this.Lab_Infor_Total.Name = "Lab_Infor_Total";
            this.Lab_Infor_Total.Size = new System.Drawing.Size(43, 22);
            this.Lab_Infor_Total.TabIndex = 17;
            this.Lab_Infor_Total.Text = "123";
            // 
            // Total_EVS_Data
            // 
            this.Total_EVS_Data.AllowUserToAddRows = false;
            this.Total_EVS_Data.AllowUserToResizeColumns = false;
            this.Total_EVS_Data.AllowUserToResizeRows = false;
            this.Total_EVS_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Total_EVS_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Total_EVS_Data.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Total_EVS_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Total_EVS_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Total_EVS_Data.DefaultCellStyle = dataGridViewCellStyle2;
            this.Total_EVS_Data.EnableHeadersVisualStyles = false;
            this.Total_EVS_Data.Location = new System.Drawing.Point(26, 154);
            this.Total_EVS_Data.Name = "Total_EVS_Data";
            this.Total_EVS_Data.ReadOnly = true;
            this.Total_EVS_Data.RowHeadersVisible = false;
            this.Total_EVS_Data.RowTemplate.Height = 30;
            this.Total_EVS_Data.Size = new System.Drawing.Size(1160, 485);
            this.Total_EVS_Data.TabIndex = 18;
            // 
            // Btn_Excel
            // 
            this.Btn_Excel.BackColor = System.Drawing.Color.Green;
            this.Btn_Excel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Excel.ForeColor = System.Drawing.Color.White;
            this.Btn_Excel.Location = new System.Drawing.Point(26, 106);
            this.Btn_Excel.Name = "Btn_Excel";
            this.Btn_Excel.Size = new System.Drawing.Size(150, 42);
            this.Btn_Excel.TabIndex = 22;
            this.Btn_Excel.Text = "Xuất Excel";
            this.Btn_Excel.UseVisualStyleBackColor = false;
            this.Btn_Excel.Click += new System.EventHandler(this.Btn_Excel_Click);
            // 
            // Detail_EVS_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 651);
            this.Controls.Add(this.location_box);
            this.Controls.Add(this.txt_Search_Batch);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.txt_Search_Material);
            this.Controls.Add(this.label_suggest);
            this.Controls.Add(this.Lab_Infor_Total);
            this.Controls.Add(this.Total_EVS_Data);
            this.Controls.Add(this.Btn_Excel);
            this.Name = "Detail_EVS_Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Total_EVS_Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Total_EVS_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox location_box;
        private System.Windows.Forms.TextBox txt_Search_Batch;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.TextBox txt_Search_Material;
        private System.Windows.Forms.Label label_suggest;
        private System.Windows.Forms.Label Lab_Infor_Total;
        private System.Windows.Forms.DataGridView Total_EVS_Data;
        private System.Windows.Forms.Button Btn_Excel;
    }
}