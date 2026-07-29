namespace EVS_ProductionStatus.EVS_Inventories
{
    partial class EVS_Alowcate
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
            this.Btn_Search = new System.Windows.Forms.Button();
            this.txt_Search_Material = new System.Windows.Forms.TextBox();
            this.label_suggest = new System.Windows.Forms.Label();
            this.Lab_Infor_Total = new System.Windows.Forms.Label();
            this.EVS_Alowcate_Data = new System.Windows.Forms.DataGridView();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restricted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Blocked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alowcate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Excel = new System.Windows.Forms.Button();
            this.txt_Batch_Number = new System.Windows.Forms.TextBox();
            this.lab_Ton = new System.Windows.Forms.Label();
            this.EVS_BackGround = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.EVS_Alowcate_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // location_box
            // 
            this.location_box.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_box.FormattingEnabled = true;
            this.location_box.Location = new System.Drawing.Point(820, 51);
            this.location_box.Name = "location_box";
            this.location_box.Size = new System.Drawing.Size(140, 31);
            this.location_box.TabIndex = 26;
            this.location_box.Tag = "";
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Search.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Search.ForeColor = System.Drawing.Color.White;
            this.Btn_Search.Location = new System.Drawing.Point(984, 47);
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
            this.txt_Search_Material.Location = new System.Drawing.Point(24, 50);
            this.txt_Search_Material.Name = "txt_Search_Material";
            this.txt_Search_Material.Size = new System.Drawing.Size(387, 30);
            this.txt_Search_Material.TabIndex = 24;
            // 
            // label_suggest
            // 
            this.label_suggest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_suggest.AutoSize = true;
            this.label_suggest.Location = new System.Drawing.Point(612, 92);
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
            this.Lab_Infor_Total.Location = new System.Drawing.Point(449, 20);
            this.Lab_Infor_Total.Name = "Lab_Infor_Total";
            this.Lab_Infor_Total.Size = new System.Drawing.Size(43, 22);
            this.Lab_Infor_Total.TabIndex = 17;
            this.Lab_Infor_Total.Text = "123";
            // 
            // EVS_Alowcate_Data
            // 
            this.EVS_Alowcate_Data.AllowUserToAddRows = false;
            this.EVS_Alowcate_Data.AllowUserToResizeColumns = false;
            this.EVS_Alowcate_Data.AllowUserToResizeRows = false;
            this.EVS_Alowcate_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EVS_Alowcate_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EVS_Alowcate_Data.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EVS_Alowcate_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.EVS_Alowcate_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EVS_Alowcate_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Location,
            this.Item,
            this.Lot,
            this.Ton,
            this.UU,
            this.Restricted,
            this.Blocked,
            this.Alowcate,
            this.KD});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EVS_Alowcate_Data.DefaultCellStyle = dataGridViewCellStyle4;
            this.EVS_Alowcate_Data.EnableHeadersVisualStyles = false;
            this.EVS_Alowcate_Data.Location = new System.Drawing.Point(26, 160);
            this.EVS_Alowcate_Data.Name = "EVS_Alowcate_Data";
            this.EVS_Alowcate_Data.ReadOnly = true;
            this.EVS_Alowcate_Data.RowHeadersVisible = false;
            this.EVS_Alowcate_Data.RowTemplate.Height = 30;
            this.EVS_Alowcate_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.EVS_Alowcate_Data.Size = new System.Drawing.Size(1160, 479);
            this.EVS_Alowcate_Data.TabIndex = 18;
            this.EVS_Alowcate_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EVS_Alowcate_Data_CellClick);
            this.EVS_Alowcate_Data.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EVS_Alowcate_Data_ColumnHeaderMouseClick);
            this.EVS_Alowcate_Data.SelectionChanged += new System.EventHandler(this.EVS_Alowcate_Data_SelectionChanged);
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
            // Ton
            // 
            this.Ton.DataPropertyName = "Ton";
            this.Ton.HeaderText = "Total";
            this.Ton.Name = "Ton";
            this.Ton.ReadOnly = true;
            // 
            // UU
            // 
            this.UU.DataPropertyName = "UU";
            this.UU.HeaderText = "UU";
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
            this.Blocked.HeaderText = "Blocked";
            this.Blocked.Name = "Blocked";
            this.Blocked.ReadOnly = true;
            // 
            // Alowcate
            // 
            this.Alowcate.DataPropertyName = "Alowcate";
            this.Alowcate.HeaderText = "Số Lượng Allowcate";
            this.Alowcate.Name = "Alowcate";
            this.Alowcate.ReadOnly = true;
            // 
            // KD
            // 
            this.KD.DataPropertyName = "KD";
            this.KD.HeaderText = "Tồn Khả Dụng";
            this.KD.Name = "KD";
            this.KD.ReadOnly = true;
            // 
            // Btn_Excel
            // 
            this.Btn_Excel.BackColor = System.Drawing.Color.Green;
            this.Btn_Excel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Excel.ForeColor = System.Drawing.Color.White;
            this.Btn_Excel.Location = new System.Drawing.Point(26, 101);
            this.Btn_Excel.Name = "Btn_Excel";
            this.Btn_Excel.Size = new System.Drawing.Size(150, 42);
            this.Btn_Excel.TabIndex = 22;
            this.Btn_Excel.Text = "Xuất Excel";
            this.Btn_Excel.UseVisualStyleBackColor = false;
            this.Btn_Excel.Click += new System.EventHandler(this.Btn_Excel_Click);
            // 
            // txt_Batch_Number
            // 
            this.txt_Batch_Number.Font = new System.Drawing.Font("Arial", 15F);
            this.txt_Batch_Number.Location = new System.Drawing.Point(417, 51);
            this.txt_Batch_Number.Name = "txt_Batch_Number";
            this.txt_Batch_Number.Size = new System.Drawing.Size(385, 30);
            this.txt_Batch_Number.TabIndex = 27;
            // 
            // lab_Ton
            // 
            this.lab_Ton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_Ton.AutoSize = true;
            this.lab_Ton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lab_Ton.Location = new System.Drawing.Point(241, 109);
            this.lab_Ton.Name = "lab_Ton";
            this.lab_Ton.Size = new System.Drawing.Size(87, 22);
            this.lab_Ton.TabIndex = 30;
            this.lab_Ton.Text = "Tổng : 0";
            // 
            // EVS_BackGround
            // 
            this.EVS_BackGround.DoWork += new System.ComponentModel.DoWorkEventHandler(this.EVS_BackGround_DoWork);
            this.EVS_BackGround.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.EVS_BackGround_RunWorkerCompleted);
            // 
            // EVS_Alowcate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 651);
            this.Controls.Add(this.lab_Ton);
            this.Controls.Add(this.txt_Batch_Number);
            this.Controls.Add(this.location_box);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.txt_Search_Material);
            this.Controls.Add(this.label_suggest);
            this.Controls.Add(this.Lab_Infor_Total);
            this.Controls.Add(this.EVS_Alowcate_Data);
            this.Controls.Add(this.Btn_Excel);
            this.Name = "EVS_Alowcate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EVS_Alowcate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EVS_Alowcate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EVS_Alowcate_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox location_box;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.TextBox txt_Search_Material;
        private System.Windows.Forms.Label label_suggest;
        private System.Windows.Forms.Label Lab_Infor_Total;
        private System.Windows.Forms.DataGridView EVS_Alowcate_Data;
        private System.Windows.Forms.Button Btn_Excel;
        private System.Windows.Forms.TextBox txt_Batch_Number;
        private System.Windows.Forms.Label lab_Ton;
        private System.ComponentModel.BackgroundWorker EVS_BackGround;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ton;
        private System.Windows.Forms.DataGridViewTextBoxColumn UU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Restricted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Blocked;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alowcate;
        private System.Windows.Forms.DataGridViewTextBoxColumn KD;
    }
}