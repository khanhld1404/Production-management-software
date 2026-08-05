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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.location_box = new System.Windows.Forms.ComboBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.txt_Search_Material = new System.Windows.Forms.TextBox();
            this.label_suggest = new System.Windows.Forms.Label();
            this.Lab_Infor_Total = new System.Windows.Forms.Label();
            this.EVS_Alowcate_Data = new System.Windows.Forms.DataGridView();
            this.Btn_Excel = new System.Windows.Forms.Button();
            this.txt_Batch_Number = new System.Windows.Forms.TextBox();
            this.lab_Ton = new System.Windows.Forms.Label();
            this.EVS_BackGround = new System.ComponentModel.BackgroundWorker();
            this.txt_search_mac_eink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restricted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Blocked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alowcate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Kitting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Real_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EVS_Alowcate_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // location_box
            // 
            this.location_box.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_box.FormattingEnabled = true;
            this.location_box.Location = new System.Drawing.Point(793, 73);
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
            this.Btn_Search.Location = new System.Drawing.Point(953, 69);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(121, 36);
            this.Btn_Search.TabIndex = 21;
            this.Btn_Search.Text = "Tìm Kiếm";
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // txt_Search_Material
            // 
            this.txt_Search_Material.Font = new System.Drawing.Font("Arial", 15F);
            this.txt_Search_Material.Location = new System.Drawing.Point(16, 72);
            this.txt_Search_Material.Name = "txt_Search_Material";
            this.txt_Search_Material.Size = new System.Drawing.Size(307, 30);
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
            this.Lab_Infor_Total.Location = new System.Drawing.Point(429, 9);
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
            this.EVS_Alowcate_Data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EVS_Alowcate_Data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EVS_Alowcate_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.KD,
            this.Total_Kitting,
            this.Real_Total});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EVS_Alowcate_Data.DefaultCellStyle = dataGridViewCellStyle2;
            this.EVS_Alowcate_Data.EnableHeadersVisualStyles = false;
            this.EVS_Alowcate_Data.Location = new System.Drawing.Point(12, 165);
            this.EVS_Alowcate_Data.Name = "EVS_Alowcate_Data";
            this.EVS_Alowcate_Data.ReadOnly = true;
            this.EVS_Alowcate_Data.RowHeadersVisible = false;
            this.EVS_Alowcate_Data.RowTemplate.Height = 40;
            this.EVS_Alowcate_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.EVS_Alowcate_Data.Size = new System.Drawing.Size(1189, 559);
            this.EVS_Alowcate_Data.TabIndex = 18;
            this.EVS_Alowcate_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EVS_Alowcate_Data_CellClick);
            this.EVS_Alowcate_Data.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EVS_Alowcate_Data_ColumnHeaderMouseClick);
            this.EVS_Alowcate_Data.SelectionChanged += new System.EventHandler(this.EVS_Alowcate_Data_SelectionChanged);
            // 
            // Btn_Excel
            // 
            this.Btn_Excel.BackColor = System.Drawing.Color.Green;
            this.Btn_Excel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Excel.ForeColor = System.Drawing.Color.White;
            this.Btn_Excel.Location = new System.Drawing.Point(953, 110);
            this.Btn_Excel.Name = "Btn_Excel";
            this.Btn_Excel.Size = new System.Drawing.Size(248, 36);
            this.Btn_Excel.TabIndex = 22;
            this.Btn_Excel.Text = "Xuất Excel";
            this.Btn_Excel.UseVisualStyleBackColor = false;
            this.Btn_Excel.Click += new System.EventHandler(this.Btn_Excel_Click);
            // 
            // txt_Batch_Number
            // 
            this.txt_Batch_Number.Font = new System.Drawing.Font("Arial", 15F);
            this.txt_Batch_Number.Location = new System.Drawing.Point(332, 72);
            this.txt_Batch_Number.Name = "txt_Batch_Number";
            this.txt_Batch_Number.Size = new System.Drawing.Size(277, 30);
            this.txt_Batch_Number.TabIndex = 27;
            // 
            // lab_Ton
            // 
            this.lab_Ton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_Ton.AutoSize = true;
            this.lab_Ton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lab_Ton.ForeColor = System.Drawing.Color.Green;
            this.lab_Ton.Location = new System.Drawing.Point(12, 124);
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
            // txt_search_mac_eink
            // 
            this.txt_search_mac_eink.Font = new System.Drawing.Font("Arial", 15F);
            this.txt_search_mac_eink.Location = new System.Drawing.Point(615, 73);
            this.txt_search_mac_eink.Name = "txt_search_mac_eink";
            this.txt_search_mac_eink.Size = new System.Drawing.Size(164, 30);
            this.txt_search_mac_eink.TabIndex = 32;
            this.txt_search_mac_eink.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_mac_eink_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Lot";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(611, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "Mac Eink";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(789, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "Location";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(1080, 69);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(121, 36);
            this.btn_Refresh.TabIndex = 37;
            this.btn_Refresh.Text = "Làm Mới";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
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
            this.Item.FillWeight = 125F;
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Lot
            // 
            this.Lot.DataPropertyName = "Lot";
            this.Lot.FillWeight = 110F;
            this.Lot.HeaderText = "Lot";
            this.Lot.Name = "Lot";
            this.Lot.ReadOnly = true;
            // 
            // Ton
            // 
            this.Ton.DataPropertyName = "Ton";
            this.Ton.FillWeight = 95F;
            this.Ton.HeaderText = "Tổng Tồn";
            this.Ton.Name = "Ton";
            this.Ton.ReadOnly = true;
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
            this.Restricted.FillWeight = 95F;
            this.Restricted.HeaderText = "Restricted";
            this.Restricted.Name = "Restricted";
            this.Restricted.ReadOnly = true;
            // 
            // Blocked
            // 
            this.Blocked.DataPropertyName = "Blocked";
            this.Blocked.FillWeight = 95F;
            this.Blocked.HeaderText = "Block";
            this.Blocked.Name = "Blocked";
            this.Blocked.ReadOnly = true;
            // 
            // Alowcate
            // 
            this.Alowcate.DataPropertyName = "Alowcate";
            this.Alowcate.FillWeight = 95F;
            this.Alowcate.HeaderText = "Tồn Allowcate";
            this.Alowcate.Name = "Alowcate";
            this.Alowcate.ReadOnly = true;
            // 
            // KD
            // 
            this.KD.DataPropertyName = "KD";
            this.KD.FillWeight = 95F;
            this.KD.HeaderText = "Tồn Khả Dụng";
            this.KD.Name = "KD";
            this.KD.ReadOnly = true;
            // 
            // Total_Kitting
            // 
            this.Total_Kitting.FillWeight = 95F;
            this.Total_Kitting.HeaderText = "Tồn Kitting";
            this.Total_Kitting.Name = "Total_Kitting";
            this.Total_Kitting.ReadOnly = true;
            // 
            // Real_Total
            // 
            this.Real_Total.FillWeight = 95F;
            this.Real_Total.HeaderText = "Tồn Thực Tế";
            this.Real_Total.Name = "Real_Total";
            this.Real_Total.ReadOnly = true;
            // 
            // EVS_Alowcate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 753);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search_mac_eink);
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
        private System.Windows.Forms.TextBox txt_search_mac_eink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ton;
        private System.Windows.Forms.DataGridViewTextBoxColumn UU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Restricted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Blocked;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alowcate;
        private System.Windows.Forms.DataGridViewTextBoxColumn KD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Kitting;
        private System.Windows.Forms.DataGridViewTextBoxColumn Real_Total;
    }
}