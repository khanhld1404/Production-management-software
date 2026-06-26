namespace EVS_ProductionStatus
{
    partial class NhapKhauIn
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnNhanVien = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lnkCancel = new System.Windows.Forms.LinkLabel();
            this.lbScanned = new System.Windows.Forms.Label();
            this.lbBarcode2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbError = new System.Windows.Forms.Label();
            this.pnData = new System.Windows.Forms.Panel();
            this.lbNguoiTT = new System.Windows.Forms.Label();
            this.lbTenNguoiTT = new System.Windows.Forms.Label();
            this.lnkClear = new System.Windows.Forms.LinkLabel();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lbWO = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lbQty = new System.Windows.Forms.Label();
            this.lbLot = new System.Windows.Forms.Label();
            this.lbItem = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.pnCongDoan = new System.Windows.Forms.Panel();
            this.lbCongdoan = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.grThongtin = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InTime_Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InTime_End = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.pnNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnData.SuspendLayout();
            this.pnCongDoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grThongtin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 26);
            this.label1.TabIndex = 47;
            this.label1.Text = "NHẬP KHÂU NGẮT QUÃNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnNhanVien);
            this.groupBox1.Controls.Add(this.lbError);
            this.groupBox1.Controls.Add(this.pnData);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 218);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quét mã vạch";
            // 
            // pnNhanVien
            // 
            this.pnNhanVien.Controls.Add(this.pictureBox2);
            this.pnNhanVien.Controls.Add(this.lnkCancel);
            this.pnNhanVien.Controls.Add(this.lbScanned);
            this.pnNhanVien.Controls.Add(this.lbBarcode2);
            this.pnNhanVien.Controls.Add(this.txtUsername);
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
            this.lbBarcode2.Size = new System.Drawing.Size(142, 20);
            this.lbBarcode2.TabIndex = 54;
            this.lbBarcode2.Text = "Quét mã nhân viên";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Lime;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(175, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(164, 29);
            this.txtUsername.TabIndex = 53;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
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
            // pnData
            // 
            this.pnData.BackColor = System.Drawing.Color.Gainsboro;
            this.pnData.Controls.Add(this.label2);
            this.pnData.Controls.Add(this.lbID);
            this.pnData.Controls.Add(this.lbNguoiTT);
            this.pnData.Controls.Add(this.lbTenNguoiTT);
            this.pnData.Controls.Add(this.lnkClear);
            this.pnData.Controls.Add(this.label29);
            this.pnData.Controls.Add(this.label30);
            this.pnData.Controls.Add(this.lbWO);
            this.pnData.Controls.Add(this.label31);
            this.pnData.Controls.Add(this.lbQty);
            this.pnData.Controls.Add(this.lbLot);
            this.pnData.Controls.Add(this.lbItem);
            this.pnData.Controls.Add(this.label32);
            this.pnData.Controls.Add(this.pnCongDoan);
            this.pnData.Location = new System.Drawing.Point(15, 114);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(720, 99);
            this.pnData.TabIndex = 51;
            this.pnData.Visible = false;
            // 
            // lbNguoiTT
            // 
            this.lbNguoiTT.AutoSize = true;
            this.lbNguoiTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNguoiTT.ForeColor = System.Drawing.Color.Navy;
            this.lbNguoiTT.Location = new System.Drawing.Point(13, 79);
            this.lbNguoiTT.Name = "lbNguoiTT";
            this.lbNguoiTT.Size = new System.Drawing.Size(104, 17);
            this.lbNguoiTT.TabIndex = 14;
            this.lbNguoiTT.Text = "Người thao tác:";
            // 
            // lbTenNguoiTT
            // 
            this.lbTenNguoiTT.AutoSize = true;
            this.lbTenNguoiTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNguoiTT.ForeColor = System.Drawing.Color.Blue;
            this.lbTenNguoiTT.Location = new System.Drawing.Point(119, 79);
            this.lbTenNguoiTT.Name = "lbTenNguoiTT";
            this.lbTenNguoiTT.Size = new System.Drawing.Size(145, 17);
            this.lbTenNguoiTT.TabIndex = 15;
            this.lbTenNguoiTT.Text = "Tên người thao tác";
            // 
            // lnkClear
            // 
            this.lnkClear.AutoSize = true;
            this.lnkClear.Location = new System.Drawing.Point(635, 47);
            this.lnkClear.Name = "lnkClear";
            this.lnkClear.Size = new System.Drawing.Size(46, 20);
            this.lnkClear.TabIndex = 12;
            this.lnkClear.TabStop = true;
            this.lnkClear.Text = "Clear";
            this.lnkClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClear_LinkClicked);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Navy;
            this.label29.Location = new System.Drawing.Point(12, 10);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(90, 20);
            this.label29.TabIndex = 4;
            this.label29.Text = "WorkOrder:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Navy;
            this.label30.Location = new System.Drawing.Point(594, 10);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(37, 20);
            this.label30.TabIndex = 5;
            this.label30.Text = "Qty:";
            // 
            // lbWO
            // 
            this.lbWO.AutoSize = true;
            this.lbWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWO.ForeColor = System.Drawing.Color.Red;
            this.lbWO.Location = new System.Drawing.Point(108, 10);
            this.lbWO.Name = "lbWO";
            this.lbWO.Size = new System.Drawing.Size(52, 20);
            this.lbWO.TabIndex = 6;
            this.lbWO.Text = "lbWO";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.Navy;
            this.label31.Location = new System.Drawing.Point(424, 10);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(36, 20);
            this.label31.TabIndex = 7;
            this.label31.Text = "Lot:";
            // 
            // lbQty
            // 
            this.lbQty.AutoSize = true;
            this.lbQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQty.ForeColor = System.Drawing.Color.Red;
            this.lbQty.Location = new System.Drawing.Point(631, 10);
            this.lbQty.Name = "lbQty";
            this.lbQty.Size = new System.Drawing.Size(50, 20);
            this.lbQty.TabIndex = 8;
            this.lbQty.Text = "lbQty";
            // 
            // lbLot
            // 
            this.lbLot.AutoSize = true;
            this.lbLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLot.ForeColor = System.Drawing.Color.Red;
            this.lbLot.Location = new System.Drawing.Point(466, 10);
            this.lbLot.Name = "lbLot";
            this.lbLot.Size = new System.Drawing.Size(49, 20);
            this.lbLot.TabIndex = 9;
            this.lbLot.Text = "lbLot";
            // 
            // lbItem
            // 
            this.lbItem.AutoSize = true;
            this.lbItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItem.ForeColor = System.Drawing.Color.Red;
            this.lbItem.Location = new System.Drawing.Point(264, 10);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(59, 20);
            this.lbItem.TabIndex = 10;
            this.lbItem.Text = "lbItem";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Navy;
            this.label32.Location = new System.Drawing.Point(213, 10);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(45, 20);
            this.label32.TabIndex = 11;
            this.label32.Text = "Item:";
            // 
            // pnCongDoan
            // 
            this.pnCongDoan.BackColor = System.Drawing.Color.Aquamarine;
            this.pnCongDoan.Controls.Add(this.lbCongdoan);
            this.pnCongDoan.Location = new System.Drawing.Point(18, 33);
            this.pnCongDoan.Name = "pnCongDoan";
            this.pnCongDoan.Size = new System.Drawing.Size(576, 43);
            this.pnCongDoan.TabIndex = 3;
            // 
            // lbCongdoan
            // 
            this.lbCongdoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCongdoan.ForeColor = System.Drawing.Color.Navy;
            this.lbCongdoan.Location = new System.Drawing.Point(70, 2);
            this.lbCongdoan.Name = "lbCongdoan";
            this.lbCongdoan.Size = new System.Drawing.Size(460, 37);
            this.lbCongdoan.TabIndex = 1;
            this.lbCongdoan.Text = "lbCongdoan";
            this.lbCongdoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.InTime_Start,
            this.InTime_End,
            this.UserIn,
            this.UserName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grThongtin.DefaultCellStyle = dataGridViewCellStyle2;
            this.grThongtin.Location = new System.Drawing.Point(21, 276);
            this.grThongtin.Name = "grThongtin";
            this.grThongtin.ReadOnly = true;
            this.grThongtin.Size = new System.Drawing.Size(753, 251);
            this.grThongtin.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(437, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.Red;
            this.lbID.Location = new System.Drawing.Point(473, 76);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(71, 20);
            this.lbID.TabIndex = 17;
            this.lbID.Text = "lbWOID";
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "WOID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // workorder
            // 
            this.workorder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workorder.DataPropertyName = "workorder";
            this.workorder.HeaderText = "Work Order";
            this.workorder.Name = "workorder";
            this.workorder.ReadOnly = true;
            // 
            // InTime_Start
            // 
            this.InTime_Start.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InTime_Start.DataPropertyName = "InTime_Start";
            this.InTime_Start.FillWeight = 150F;
            this.InTime_Start.HeaderText = "Khâu in _ start";
            this.InTime_Start.Name = "InTime_Start";
            this.InTime_Start.ReadOnly = true;
            // 
            // InTime_End
            // 
            this.InTime_End.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InTime_End.DataPropertyName = "InTime_End";
            this.InTime_End.FillWeight = 150F;
            this.InTime_End.HeaderText = "Khâu in _ end";
            this.InTime_End.Name = "InTime_End";
            this.InTime_End.ReadOnly = true;
            // 
            // UserIn
            // 
            this.UserIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserIn.DataPropertyName = "UserIn";
            this.UserIn.HeaderText = "Mã người thao tác";
            this.UserIn.Name = "UserIn";
            this.UserIn.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.DataPropertyName = "name";
            this.UserName.FillWeight = 200F;
            this.UserName.HeaderText = "Tên người thao tác";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // NhapKhauIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 539);
            this.Controls.Add(this.grThongtin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NhapKhauIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập khâu ngắt quãng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnNhanVien.ResumeLayout(false);
            this.pnNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnData.ResumeLayout(false);
            this.pnData.PerformLayout();
            this.pnCongDoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grThongtin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Panel pnData;
        private System.Windows.Forms.Label lbNguoiTT;
        private System.Windows.Forms.Label lbTenNguoiTT;
        private System.Windows.Forms.LinkLabel lnkClear;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lbWO;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lbQty;
        private System.Windows.Forms.Label lbLot;
        private System.Windows.Forms.Label lbItem;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Panel pnCongDoan;
        private System.Windows.Forms.Label lbCongdoan;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.DataGridView grThongtin;
        private System.Windows.Forms.Panel pnNhanVien;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel lnkCancel;
        private System.Windows.Forms.Label lbScanned;
        private System.Windows.Forms.Label lbBarcode2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn workorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn InTime_Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn InTime_End;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
    }
}