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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.location_box = new System.Windows.Forms.ComboBox();
            this.txt_Search_Batch = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.txt_Search_Material = new System.Windows.Forms.TextBox();
            this.label_suggest = new System.Windows.Forms.Label();
            this.Lab_Infor_Total = new System.Windows.Forms.Label();
            this.Total_EVS_Data = new System.Windows.Forms.DataGridView();
            this.Btn_Excel = new System.Windows.Forms.Button();
            this.Menu_EVS_Total_Detail = new System.Windows.Forms.ToolStrip();
            this.TSX = new System.Windows.Forms.ToolStripButton();
            this.NSX = new System.Windows.Forms.ToolStripButton();
            this.KSX = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.Total_EVS_Data)).BeginInit();
            this.Menu_EVS_Total_Detail.SuspendLayout();
            this.SuspendLayout();
            // 
            // location_box
            // 
            this.location_box.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_box.FormattingEnabled = true;
            this.location_box.Location = new System.Drawing.Point(811, 74);
            this.location_box.Name = "location_box";
            this.location_box.Size = new System.Drawing.Size(140, 31);
            this.location_box.TabIndex = 26;
            this.location_box.Tag = "";
            // 
            // txt_Search_Batch
            // 
            this.txt_Search_Batch.Font = new System.Drawing.Font("Arial", 15F);
            this.txt_Search_Batch.Location = new System.Drawing.Point(418, 74);
            this.txt_Search_Batch.Name = "txt_Search_Batch";
            this.txt_Search_Batch.Size = new System.Drawing.Size(373, 30);
            this.txt_Search_Batch.TabIndex = 25;
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Search.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Search.ForeColor = System.Drawing.Color.White;
            this.Btn_Search.Location = new System.Drawing.Point(977, 71);
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
            this.txt_Search_Material.Location = new System.Drawing.Point(23, 74);
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
            this.Lab_Infor_Total.Location = new System.Drawing.Point(448, 44);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Total_EVS_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Total_EVS_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Total_EVS_Data.DefaultCellStyle = dataGridViewCellStyle4;
            this.Total_EVS_Data.EnableHeadersVisualStyles = false;
            this.Total_EVS_Data.Location = new System.Drawing.Point(26, 164);
            this.Total_EVS_Data.Name = "Total_EVS_Data";
            this.Total_EVS_Data.ReadOnly = true;
            this.Total_EVS_Data.RowHeadersVisible = false;
            this.Total_EVS_Data.RowTemplate.Height = 30;
            this.Total_EVS_Data.Size = new System.Drawing.Size(1160, 475);
            this.Total_EVS_Data.TabIndex = 18;
            // 
            // Btn_Excel
            // 
            this.Btn_Excel.BackColor = System.Drawing.Color.Green;
            this.Btn_Excel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Excel.ForeColor = System.Drawing.Color.White;
            this.Btn_Excel.Location = new System.Drawing.Point(26, 116);
            this.Btn_Excel.Name = "Btn_Excel";
            this.Btn_Excel.Size = new System.Drawing.Size(150, 42);
            this.Btn_Excel.TabIndex = 22;
            this.Btn_Excel.Text = "Xuất Excel";
            this.Btn_Excel.UseVisualStyleBackColor = false;
            this.Btn_Excel.Click += new System.EventHandler(this.Btn_Excel_Click);
            // 
            // Menu_EVS_Total_Detail
            // 
            this.Menu_EVS_Total_Detail.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Menu_EVS_Total_Detail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_EVS_Total_Detail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSX,
            this.NSX,
            this.KSX});
            this.Menu_EVS_Total_Detail.Location = new System.Drawing.Point(0, 0);
            this.Menu_EVS_Total_Detail.Name = "Menu_EVS_Total_Detail";
            this.Menu_EVS_Total_Detail.Padding = new System.Windows.Forms.Padding(0);
            this.Menu_EVS_Total_Detail.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menu_EVS_Total_Detail.Size = new System.Drawing.Size(1231, 32);
            this.Menu_EVS_Total_Detail.TabIndex = 27;
            this.Menu_EVS_Total_Detail.Text = "toolStrip1";
            // 
            // TSX
            // 
            this.TSX.BackColor = System.Drawing.SystemColors.Highlight;
            this.TSX.ForeColor = System.Drawing.SystemColors.Control;
            this.TSX.Image = global::EVS_ProductionStatus.Properties.Resources.icons8_production_machine_70;
            this.TSX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSX.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.TSX.Name = "TSX";
            this.TSX.Padding = new System.Windows.Forms.Padding(10, 5, 20, 5);
            this.TSX.Size = new System.Drawing.Size(167, 32);
            this.TSX.Text = "Trong Sản Xuất";
            this.TSX.Click += new System.EventHandler(this.TSX_Click);
            // 
            // NSX
            // 
            this.NSX.Image = global::EVS_ProductionStatus.Properties.Resources.icons8_resend_production_order_70;
            this.NSX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NSX.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.NSX.Name = "NSX";
            this.NSX.Padding = new System.Windows.Forms.Padding(10, 5, 20, 5);
            this.NSX.Size = new System.Drawing.Size(166, 32);
            this.NSX.Text = "Ngoài Sản Xuất";
            this.NSX.Click += new System.EventHandler(this.NSX_Click);
            // 
            // KSX
            // 
            this.KSX.Image = global::EVS_ProductionStatus.Properties.Resources.icons8_delete_production_order_70;
            this.KSX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.KSX.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.KSX.Name = "KSX";
            this.KSX.Padding = new System.Windows.Forms.Padding(10, 5, 20, 5);
            this.KSX.Size = new System.Drawing.Size(172, 32);
            this.KSX.Text = "Không Sản Xuất";
            this.KSX.Click += new System.EventHandler(this.KSX_Click);
            // 
            // Total_EVS_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 651);
            this.Controls.Add(this.Menu_EVS_Total_Detail);
            this.Controls.Add(this.location_box);
            this.Controls.Add(this.txt_Search_Batch);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.txt_Search_Material);
            this.Controls.Add(this.label_suggest);
            this.Controls.Add(this.Lab_Infor_Total);
            this.Controls.Add(this.Total_EVS_Data);
            this.Controls.Add(this.Btn_Excel);
            this.Name = "Total_EVS_Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total_EVS_Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Total_EVS_Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Total_EVS_Data)).EndInit();
            this.Menu_EVS_Total_Detail.ResumeLayout(false);
            this.Menu_EVS_Total_Detail.PerformLayout();
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
        private System.Windows.Forms.ToolStrip Menu_EVS_Total_Detail;
        private System.Windows.Forms.ToolStripButton TSX;
        private System.Windows.Forms.ToolStripButton NSX;
        private System.Windows.Forms.ToolStripButton KSX;
    }
}