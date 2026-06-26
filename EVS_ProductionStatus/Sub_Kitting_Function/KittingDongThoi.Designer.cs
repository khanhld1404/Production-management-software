namespace EVS_ProductionStatus
{
    partial class KittingDongThoi
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
            this.label1 = new System.Windows.Forms.Label();
            this.grThongtin = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnNhanVien = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lnkCancel = new System.Windows.Forms.LinkLabel();
            this.lbScanned = new System.Windows.Forms.Label();
            this.lbBarcode2 = new System.Windows.Forms.Label();
            this.txtMaBanVe = new System.Windows.Forms.TextBox();
            this.lbError = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoa = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grThongtin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "KITTING ĐỒNG THỜI NHIỀU CHỈ THỊ";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grThongtin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grThongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grThongtin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.workorder,
            this.itemnumber,
            this.lot,
            this.xoa});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grThongtin.DefaultCellStyle = dataGridViewCellStyle2;
            this.grThongtin.Location = new System.Drawing.Point(24, 159);
            this.grThongtin.Name = "grThongtin";
            this.grThongtin.ReadOnly = true;
            this.grThongtin.Size = new System.Drawing.Size(753, 331);
            this.grThongtin.TabIndex = 54;
            this.grThongtin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grThongtin_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnNhanVien);
            this.groupBox1.Controls.Add(this.lbError);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 115);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quét mã vạch";
            // 
            // pnNhanVien
            // 
            this.pnNhanVien.Controls.Add(this.pictureBox2);
            this.pnNhanVien.Controls.Add(this.lnkCancel);
            this.pnNhanVien.Controls.Add(this.lbScanned);
            this.pnNhanVien.Controls.Add(this.lbBarcode2);
            this.pnNhanVien.Controls.Add(this.txtMaBanVe);
            this.pnNhanVien.Location = new System.Drawing.Point(15, 60);
            this.pnNhanVien.Name = "pnNhanVien";
            this.pnNhanVien.Size = new System.Drawing.Size(413, 47);
            this.pnNhanVien.TabIndex = 54;
            this.pnNhanVien.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EVS_ProductionStatus.Properties.Resources.blinking_arrow;
            this.pictureBox2.Location = new System.Drawing.Point(141, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // lnkCancel
            // 
            this.lnkCancel.AutoSize = true;
            this.lnkCancel.Location = new System.Drawing.Point(345, 7);
            this.lnkCancel.Name = "lnkCancel";
            this.lnkCancel.Size = new System.Drawing.Size(58, 20);
            this.lnkCancel.TabIndex = 55;
            this.lnkCancel.TabStop = true;
            this.lnkCancel.Text = "Cancel";
            this.lnkCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCancel_LinkClicked);
            // 
            // lbScanned
            // 
            this.lbScanned.AutoSize = true;
            this.lbScanned.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScanned.ForeColor = System.Drawing.Color.Peru;
            this.lbScanned.Location = new System.Drawing.Point(174, 31);
            this.lbScanned.Name = "lbScanned";
            this.lbScanned.Size = new System.Drawing.Size(32, 13);
            this.lbScanned.TabIndex = 54;
            this.lbScanned.Text = "Scan";
            // 
            // lbBarcode2
            // 
            this.lbBarcode2.AutoSize = true;
            this.lbBarcode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBarcode2.ForeColor = System.Drawing.Color.Navy;
            this.lbBarcode2.Location = new System.Drawing.Point(2, 6);
            this.lbBarcode2.Name = "lbBarcode2";
            this.lbBarcode2.Size = new System.Drawing.Size(121, 20);
            this.lbBarcode2.TabIndex = 54;
            this.lbBarcode2.Text = "Quét mã bản vẽ";
            // 
            // txtMaBanVe
            // 
            this.txtMaBanVe.BackColor = System.Drawing.Color.Lime;
            this.txtMaBanVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBanVe.Location = new System.Drawing.Point(175, 2);
            this.txtMaBanVe.Name = "txtMaBanVe";
            this.txtMaBanVe.Size = new System.Drawing.Size(164, 29);
            this.txtMaBanVe.TabIndex = 53;
            this.txtMaBanVe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaBanVe_KeyDown);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(433, 34);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(95, 17);
            this.lbError.TabIndex = 13;
            this.lbError.Text = "Thông báo lỗi";
            this.lbError.Visible = false;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(15, 25);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(412, 29);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.LightGreen;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Navy;
            this.btnStart.Location = new System.Drawing.Point(618, 496);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(159, 37);
            this.btnStart.TabIndex = 55;
            this.btnStart.Text = "Bắt đầu kitting";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "WOID";
            this.ID.HeaderText = "WOID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // workorder
            // 
            this.workorder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workorder.DataPropertyName = "workorder";
            this.workorder.HeaderText = "Work Order";
            this.workorder.Name = "workorder";
            this.workorder.ReadOnly = true;
            // 
            // itemnumber
            // 
            this.itemnumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemnumber.DataPropertyName = "itemnumber";
            this.itemnumber.HeaderText = "Mã sản phẩm";
            this.itemnumber.Name = "itemnumber";
            this.itemnumber.ReadOnly = true;
            // 
            // lot
            // 
            this.lot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lot.DataPropertyName = "lot";
            this.lot.HeaderText = "Số lô";
            this.lot.Name = "lot";
            this.lot.ReadOnly = true;
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
            // KittingDongThoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grThongtin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "KittingDongThoi";
            this.Text = "Kitting đồng thời nhiều chỉ thị";
            this.Load += new System.EventHandler(this.KittingDongThoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grThongtin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnNhanVien.ResumeLayout(false);
            this.pnNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grThongtin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnNhanVien;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel lnkCancel;
        private System.Windows.Forms.Label lbScanned;
        private System.Windows.Forms.Label lbBarcode2;
        private System.Windows.Forms.TextBox txtMaBanVe;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn workorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn lot;
        private System.Windows.Forms.DataGridViewLinkColumn xoa;
    }
}