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
            this.txt_Search_Material = new System.Windows.Forms.TextBox();
            this.label_suggest = new System.Windows.Forms.Label();
            this.Lab_Infor_Total = new System.Windows.Forms.Label();
            this.Detail_EVS_Data = new System.Windows.Forms.DataGridView();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restricted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Blocked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.lab_Ton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Detail_EVS_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // location_box
            // 
            this.location_box.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_box.FormattingEnabled = true;
            this.location_box.Location = new System.Drawing.Point(786, 63);
            this.location_box.Name = "location_box";
            this.location_box.Size = new System.Drawing.Size(140, 31);
            this.location_box.TabIndex = 26;
            this.location_box.Tag = "";
            // 
            // txt_Search_Batch
            // 
            this.txt_Search_Batch.Font = new System.Drawing.Font("Arial", 15F);
            this.txt_Search_Batch.Location = new System.Drawing.Point(380, 64);
            this.txt_Search_Batch.Name = "txt_Search_Batch";
            this.txt_Search_Batch.Size = new System.Drawing.Size(373, 30);
            this.txt_Search_Batch.TabIndex = 25;
            // 
            // txt_Search_Material
            // 
            this.txt_Search_Material.Font = new System.Drawing.Font("Arial", 15F);
            this.txt_Search_Material.Location = new System.Drawing.Point(12, 64);
            this.txt_Search_Material.Name = "txt_Search_Material";
            this.txt_Search_Material.Size = new System.Drawing.Size(346, 30);
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
            this.Lab_Infor_Total.Location = new System.Drawing.Point(469, 9);
            this.Lab_Infor_Total.Name = "Lab_Infor_Total";
            this.Lab_Infor_Total.Size = new System.Drawing.Size(43, 22);
            this.Lab_Infor_Total.TabIndex = 17;
            this.Lab_Infor_Total.Text = "123";
            // 
            // Detail_EVS_Data
            // 
            this.Detail_EVS_Data.AllowUserToAddRows = false;
            this.Detail_EVS_Data.AllowUserToResizeColumns = false;
            this.Detail_EVS_Data.AllowUserToResizeRows = false;
            this.Detail_EVS_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Detail_EVS_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Detail_EVS_Data.BackgroundColor = System.Drawing.Color.White;
            this.Detail_EVS_Data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Detail_EVS_Data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Detail_EVS_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Detail_EVS_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Detail_EVS_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Location,
            this.Item,
            this.Lot,
            this.Total,
            this.UU,
            this.Restricted,
            this.Blocked,
            this.QI});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Detail_EVS_Data.DefaultCellStyle = dataGridViewCellStyle2;
            this.Detail_EVS_Data.EnableHeadersVisualStyles = false;
            this.Detail_EVS_Data.Location = new System.Drawing.Point(12, 154);
            this.Detail_EVS_Data.Name = "Detail_EVS_Data";
            this.Detail_EVS_Data.ReadOnly = true;
            this.Detail_EVS_Data.RowHeadersVisible = false;
            this.Detail_EVS_Data.RowTemplate.Height = 40;
            this.Detail_EVS_Data.Size = new System.Drawing.Size(1191, 485);
            this.Detail_EVS_Data.TabIndex = 18;
            this.Detail_EVS_Data.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Total_EVS_Data_ColumnHeaderMouseClick);
            this.Detail_EVS_Data.SelectionChanged += new System.EventHandler(this.Total_EVS_Data_SelectionChanged);
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Lot
            // 
            this.Lot.DataPropertyName = "Lot";
            this.Lot.HeaderText = "Lot";
            this.Lot.Name = "Lot";
            this.Lot.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Tổng Tồn";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // UU
            // 
            this.UU.DataPropertyName = "UU";
            this.UU.HeaderText = "Unrestricted";
            this.UU.Name = "UU";
            this.UU.ReadOnly = true;
            // 
            // Restricted
            // 
            this.Restricted.DataPropertyName = "Restricted";
            this.Restricted.HeaderText = "Restricted";
            this.Restricted.Name = "Restricted";
            this.Restricted.ReadOnly = true;
            // 
            // Blocked
            // 
            this.Blocked.DataPropertyName = "Blocked";
            this.Blocked.HeaderText = "Block";
            this.Blocked.Name = "Blocked";
            this.Blocked.ReadOnly = true;
            // 
            // QI
            // 
            this.QI.DataPropertyName = "QI";
            this.QI.HeaderText = "QI";
            this.QI.Name = "QI";
            this.QI.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Lot";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(782, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "Location";
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Search.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Search.ForeColor = System.Drawing.Color.White;
            this.Btn_Search.Location = new System.Drawing.Point(955, 63);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(121, 36);
            this.Btn_Search.TabIndex = 38;
            this.Btn_Search.Text = "Tìm Kiếm";
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(1082, 63);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(121, 36);
            this.btn_Refresh.TabIndex = 39;
            this.btn_Refresh.Text = "Làm Mới";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Excel
            // 
            this.btn_Excel.BackColor = System.Drawing.Color.Green;
            this.btn_Excel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Excel.ForeColor = System.Drawing.Color.White;
            this.btn_Excel.Location = new System.Drawing.Point(955, 105);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(248, 36);
            this.btn_Excel.TabIndex = 40;
            this.btn_Excel.Text = "Xuất Excel";
            this.btn_Excel.UseVisualStyleBackColor = false;
            this.btn_Excel.Click += new System.EventHandler(this.Btn_Excel_Click);
            // 
            // lab_Ton
            // 
            this.lab_Ton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_Ton.AutoSize = true;
            this.lab_Ton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lab_Ton.ForeColor = System.Drawing.Color.Green;
            this.lab_Ton.Location = new System.Drawing.Point(12, 119);
            this.lab_Ton.Name = "lab_Ton";
            this.lab_Ton.Size = new System.Drawing.Size(87, 22);
            this.lab_Ton.TabIndex = 41;
            this.lab_Ton.Text = "Tổng : 0";
            // 
            // Detail_EVS_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 651);
            this.Controls.Add(this.lab_Ton);
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.location_box);
            this.Controls.Add(this.txt_Search_Batch);
            this.Controls.Add(this.txt_Search_Material);
            this.Controls.Add(this.label_suggest);
            this.Controls.Add(this.Lab_Infor_Total);
            this.Controls.Add(this.Detail_EVS_Data);
            this.Name = "Detail_EVS_Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Total_EVS_Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Detail_EVS_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox location_box;
        private System.Windows.Forms.TextBox txt_Search_Batch;
        private System.Windows.Forms.TextBox txt_Search_Material;
        private System.Windows.Forms.Label label_suggest;
        private System.Windows.Forms.Label Lab_Infor_Total;
        private System.Windows.Forms.DataGridView Detail_EVS_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn UU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Restricted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Blocked;
        private System.Windows.Forms.DataGridViewTextBoxColumn QI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.Label lab_Ton;
    }
}