namespace EVS_ProductionStatus
{
    partial class QuanLyThoiGianNghi
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
            this.grThongtin = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCongDoan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CongDoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BreakStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BreakEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoa = new System.Windows.Forms.DataGridViewLinkColumn();
            this.txtStartHour = new System.Windows.Forms.TextBox();
            this.txtStartMin = new System.Windows.Forms.TextBox();
            this.txtEndHour = new System.Windows.Forms.TextBox();
            this.txtEndMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grThongtin)).BeginInit();
            this.SuspendLayout();
            // 
            // grThongtin
            // 
            this.grThongtin.AllowUserToAddRows = false;
            this.grThongtin.AllowUserToDeleteRows = false;
            this.grThongtin.AllowUserToResizeRows = false;
            this.grThongtin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grThongtin.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grThongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grThongtin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.CongDoan,
            this.BreakStart,
            this.BreakEnd,
            this.xoa});
            this.grThongtin.Location = new System.Drawing.Point(12, 132);
            this.grThongtin.Name = "grThongtin";
            this.grThongtin.ReadOnly = true;
            this.grThongtin.Size = new System.Drawing.Size(531, 422);
            this.grThongtin.TabIndex = 6;
            this.grThongtin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grThongtin_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(115, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 26);
            this.label3.TabIndex = 47;
            this.label3.Text = "QUẢN LÝ THỜI GIAN NGHỈ";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(17, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 35);
            this.label5.TabIndex = 50;
            this.label5.Text = "Khoảng thời gian nghỉ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbCongDoan
            // 
            this.cbCongDoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCongDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCongDoan.FormattingEnabled = true;
            this.cbCongDoan.Items.AddRange(new object[] {
            " ",
            "RELAY",
            "TREO",
            "THORA",
            "ANA"});
            this.cbCongDoan.Location = new System.Drawing.Point(193, 47);
            this.cbCongDoan.Name = "cbCongDoan";
            this.cbCongDoan.Size = new System.Drawing.Size(142, 28);
            this.cbCongDoan.TabIndex = 0;
            this.cbCongDoan.SelectedIndexChanged += new System.EventHandler(this.cbCongDoan_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(18, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 35);
            this.label6.TabIndex = 50;
            this.label6.Text = "Công đoạn";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(305, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "~";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Navy;
            this.btnThem.Location = new System.Drawing.Point(449, 85);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 26);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // CongDoan
            // 
            this.CongDoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CongDoan.DataPropertyName = "CongDoan";
            this.CongDoan.HeaderText = "Công đoạn";
            this.CongDoan.Name = "CongDoan";
            this.CongDoan.ReadOnly = true;
            // 
            // BreakStart
            // 
            this.BreakStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BreakStart.DataPropertyName = "BreakStart";
            this.BreakStart.HeaderText = "Bắt đầu";
            this.BreakStart.Name = "BreakStart";
            this.BreakStart.ReadOnly = true;
            // 
            // BreakEnd
            // 
            this.BreakEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BreakEnd.DataPropertyName = "BreakEnd";
            this.BreakEnd.HeaderText = "Kết thúc";
            this.BreakEnd.Name = "BreakEnd";
            this.BreakEnd.ReadOnly = true;
            // 
            // xoa
            // 
            this.xoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xoa.FillWeight = 50F;
            this.xoa.HeaderText = "Xóa";
            this.xoa.Name = "xoa";
            this.xoa.ReadOnly = true;
            this.xoa.Text = "Xóa";
            this.xoa.UseColumnTextForLinkValue = true;
            // 
            // txtStartHour
            // 
            this.txtStartHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartHour.Location = new System.Drawing.Point(193, 84);
            this.txtStartHour.Name = "txtStartHour";
            this.txtStartHour.Size = new System.Drawing.Size(46, 26);
            this.txtStartHour.TabIndex = 1;
            this.txtStartHour.Text = "00";
            // 
            // txtStartMin
            // 
            this.txtStartMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartMin.Location = new System.Drawing.Point(250, 84);
            this.txtStartMin.Name = "txtStartMin";
            this.txtStartMin.Size = new System.Drawing.Size(46, 26);
            this.txtStartMin.TabIndex = 2;
            this.txtStartMin.Text = "00";
            // 
            // txtEndHour
            // 
            this.txtEndHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndHour.Location = new System.Drawing.Point(327, 84);
            this.txtEndHour.Name = "txtEndHour";
            this.txtEndHour.Size = new System.Drawing.Size(46, 26);
            this.txtEndHour.TabIndex = 3;
            this.txtEndHour.Text = "00";
            // 
            // txtEndMin
            // 
            this.txtEndMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndMin.Location = new System.Drawing.Point(384, 84);
            this.txtEndMin.Name = "txtEndMin";
            this.txtEndMin.Size = new System.Drawing.Size(46, 26);
            this.txtEndMin.TabIndex = 4;
            this.txtEndMin.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(239, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(373, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = ":";
            // 
            // QuanLyThoiGianNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 560);
            this.Controls.Add(this.txtEndMin);
            this.Controls.Add(this.txtStartMin);
            this.Controls.Add(this.txtEndHour);
            this.Controls.Add(this.txtStartHour);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbCongDoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grThongtin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuanLyThoiGianNghi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thời gian nghỉ";
            this.Load += new System.EventHandler(this.QuanLyThoiGianNghi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grThongtin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grThongtin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCongDoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CongDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BreakStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn BreakEnd;
        private System.Windows.Forms.DataGridViewLinkColumn xoa;
        private System.Windows.Forms.TextBox txtStartHour;
        private System.Windows.Forms.TextBox txtStartMin;
        private System.Windows.Forms.TextBox txtEndHour;
        private System.Windows.Forms.TextBox txtEndMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}