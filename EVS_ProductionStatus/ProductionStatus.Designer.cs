namespace EVS_ProductionStatus
{
    partial class ProductionStatus
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
            this.components = new System.ComponentModel.Container();
            this.btnDongBoDL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.pnData = new System.Windows.Forms.Panel();
            this.lnkClear = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lbNguoiTT = new System.Windows.Forms.Label();
            this.lbTenNguoiTT = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lbWO = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lbQty = new System.Windows.Forms.Label();
            this.lbLot = new System.Windows.Forms.Label();
            this.lbItem = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.pnCongDoan = new System.Windows.Forms.Panel();
            this.lbCongdoan = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnNhanVien = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lnkCancel = new System.Windows.Forms.LinkLabel();
            this.lbScanned = new System.Windows.Forms.Label();
            this.lbBarcode2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbType = new System.Windows.Forms.Label();
            this.btnNhapKhau = new System.Windows.Forms.Button();
            this.btnQCDoDang = new System.Windows.Forms.Button();
            this.btnKittingDongThoi = new System.Windows.Forms.Button();
            this.btnDongGoiDongThoi = new System.Windows.Forms.Button();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.btn_Kitting = new System.Windows.Forms.Button();
            this.pnData.SuspendLayout();
            this.pnCongDoan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDongBoDL
            // 
            this.btnDongBoDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDongBoDL.Location = new System.Drawing.Point(1140, 9);
            this.btnDongBoDL.Name = "btnDongBoDL";
            this.btnDongBoDL.Size = new System.Drawing.Size(123, 33);
            this.btnDongBoDL.TabIndex = 44;
            this.btnDongBoDL.Text = "Đồng bộ dữ liệu";
            this.btnDongBoDL.UseVisualStyleBackColor = false;
            this.btnDongBoDL.Click += new System.EventHandler(this.btnDongBoDL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 31);
            this.label1.TabIndex = 45;
            this.label1.Text = "TRẠNG THÁI SẢN XUẤT EVS - ";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(97, 22);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(313, 29);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // pnData
            // 
            this.pnData.BackColor = System.Drawing.Color.Gainsboro;
            this.pnData.Controls.Add(this.lnkClear);
            this.pnData.Controls.Add(this.label3);
            this.pnData.Controls.Add(this.label29);
            this.pnData.Controls.Add(this.lbNguoiTT);
            this.pnData.Controls.Add(this.lbTenNguoiTT);
            this.pnData.Controls.Add(this.lbID);
            this.pnData.Controls.Add(this.label30);
            this.pnData.Controls.Add(this.lbWO);
            this.pnData.Controls.Add(this.label31);
            this.pnData.Controls.Add(this.lbQty);
            this.pnData.Controls.Add(this.lbLot);
            this.pnData.Controls.Add(this.lbItem);
            this.pnData.Controls.Add(this.label32);
            this.pnData.Controls.Add(this.pnCongDoan);
            this.pnData.Location = new System.Drawing.Point(438, 15);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(712, 106);
            this.pnData.TabIndex = 51;
            this.pnData.Visible = false;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(448, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Navy;
            this.label29.Location = new System.Drawing.Point(6, 10);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(90, 20);
            this.label29.TabIndex = 4;
            this.label29.Text = "WorkOrder:";
            // 
            // lbNguoiTT
            // 
            this.lbNguoiTT.AutoSize = true;
            this.lbNguoiTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNguoiTT.ForeColor = System.Drawing.Color.Navy;
            this.lbNguoiTT.Location = new System.Drawing.Point(15, 85);
            this.lbNguoiTT.Name = "lbNguoiTT";
            this.lbNguoiTT.Size = new System.Drawing.Size(104, 17);
            this.lbNguoiTT.TabIndex = 13;
            this.lbNguoiTT.Text = "Người thao tác:";
            this.lbNguoiTT.Visible = false;
            // 
            // lbTenNguoiTT
            // 
            this.lbTenNguoiTT.AutoSize = true;
            this.lbTenNguoiTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNguoiTT.ForeColor = System.Drawing.Color.Blue;
            this.lbTenNguoiTT.Location = new System.Drawing.Point(121, 85);
            this.lbTenNguoiTT.Name = "lbTenNguoiTT";
            this.lbTenNguoiTT.Size = new System.Drawing.Size(145, 17);
            this.lbTenNguoiTT.TabIndex = 13;
            this.lbTenNguoiTT.Text = "Tên người thao tác";
            this.lbTenNguoiTT.Visible = false;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.Red;
            this.lbID.Location = new System.Drawing.Point(478, 85);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(42, 20);
            this.lbID.TabIndex = 6;
            this.lbID.Text = "lbID";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Navy;
            this.label30.Location = new System.Drawing.Point(622, 10);
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
            this.lbWO.Location = new System.Drawing.Point(92, 10);
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
            this.label31.Location = new System.Drawing.Point(442, 10);
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
            this.lbQty.Location = new System.Drawing.Point(659, 10);
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
            this.lbLot.Location = new System.Drawing.Point(473, 10);
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
            this.lbItem.Location = new System.Drawing.Point(240, 10);
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
            this.label32.Location = new System.Drawing.Point(200, 10);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(45, 20);
            this.label32.TabIndex = 11;
            this.label32.Text = "Item:";
            // 
            // pnCongDoan
            // 
            this.pnCongDoan.BackColor = System.Drawing.Color.Aquamarine;
            this.pnCongDoan.Controls.Add(this.lbCongdoan);
            this.pnCongDoan.Location = new System.Drawing.Point(18, 39);
            this.pnCongDoan.Name = "pnCongDoan";
            this.pnCongDoan.Size = new System.Drawing.Size(601, 44);
            this.pnCongDoan.TabIndex = 3;
            // 
            // lbCongdoan
            // 
            this.lbCongdoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCongdoan.ForeColor = System.Drawing.Color.Navy;
            this.lbCongdoan.Location = new System.Drawing.Point(106, 2);
            this.lbCongdoan.Name = "lbCongdoan";
            this.lbCongdoan.Size = new System.Drawing.Size(385, 41);
            this.lbCongdoan.TabIndex = 1;
            this.lbCongdoan.Text = "lbCongdoan";
            this.lbCongdoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnNhanVien);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.lbError);
            this.groupBox1.Controls.Add(this.pnData);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 521);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1153, 127);
            this.groupBox1.TabIndex = 0;
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
            this.pnNhanVien.Location = new System.Drawing.Point(6, 74);
            this.pnNhanVien.Name = "pnNhanVien";
            this.pnNhanVien.Size = new System.Drawing.Size(413, 47);
            this.pnNhanVien.TabIndex = 53;
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
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(11, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 20);
            this.label16.TabIndex = 52;
            this.label16.Text = "Quét WO";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(94, 54);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(95, 17);
            this.lbError.TabIndex = 13;
            this.lbError.Text = "Thông báo lỗi";
            this.lbError.Visible = false;
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            this.backgroundWorker3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker3_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.ForeColor = System.Drawing.Color.Navy;
            this.lbType.Location = new System.Drawing.Point(435, 9);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(89, 31);
            this.lbType.TabIndex = 45;
            this.lbType.Text = "TYPE";
            // 
            // btnNhapKhau
            // 
            this.btnNhapKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapKhau.ForeColor = System.Drawing.Color.Navy;
            this.btnNhapKhau.Location = new System.Drawing.Point(1163, 559);
            this.btnNhapKhau.Name = "btnNhapKhau";
            this.btnNhapKhau.Size = new System.Drawing.Size(123, 25);
            this.btnNhapKhau.TabIndex = 48;
            this.btnNhapKhau.Text = "Khâu in ngắt quãng";
            this.btnNhapKhau.UseVisualStyleBackColor = true;
            this.btnNhapKhau.Click += new System.EventHandler(this.btnNhapKhau_Click);
            // 
            // btnQCDoDang
            // 
            this.btnQCDoDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQCDoDang.ForeColor = System.Drawing.Color.Navy;
            this.btnQCDoDang.Location = new System.Drawing.Point(1163, 588);
            this.btnQCDoDang.Name = "btnQCDoDang";
            this.btnQCDoDang.Size = new System.Drawing.Size(123, 25);
            this.btnQCDoDang.TabIndex = 49;
            this.btnQCDoDang.Text = "QC dở dang";
            this.btnQCDoDang.UseVisualStyleBackColor = true;
            this.btnQCDoDang.Click += new System.EventHandler(this.btnQCDoDang_Click);
            // 
            // btnKittingDongThoi
            // 
            this.btnKittingDongThoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKittingDongThoi.ForeColor = System.Drawing.Color.Navy;
            this.btnKittingDongThoi.Location = new System.Drawing.Point(1163, 530);
            this.btnKittingDongThoi.Name = "btnKittingDongThoi";
            this.btnKittingDongThoi.Size = new System.Drawing.Size(123, 25);
            this.btnKittingDongThoi.TabIndex = 50;
            this.btnKittingDongThoi.Text = "Kitting đồng thời";
            this.btnKittingDongThoi.UseVisualStyleBackColor = true;
            this.btnKittingDongThoi.Click += new System.EventHandler(this.btnKittingDongThoi_Click);
            // 
            // btnDongGoiDongThoi
            // 
            this.btnDongGoiDongThoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongGoiDongThoi.ForeColor = System.Drawing.Color.Navy;
            this.btnDongGoiDongThoi.Location = new System.Drawing.Point(1163, 617);
            this.btnDongGoiDongThoi.Name = "btnDongGoiDongThoi";
            this.btnDongGoiDongThoi.Size = new System.Drawing.Size(123, 25);
            this.btnDongGoiDongThoi.TabIndex = 51;
            this.btnDongGoiDongThoi.Text = "Đóng gói đồng thời";
            this.btnDongGoiDongThoi.UseVisualStyleBackColor = true;
            this.btnDongGoiDongThoi.Click += new System.EventHandler(this.btnDongGoiDongThoi_Click);
            // 
            // picLoading
            // 
            this.picLoading.Image = global::EVS_ProductionStatus.Properties.Resources._16;
            this.picLoading.Location = new System.Drawing.Point(1105, 13);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(29, 27);
            this.picLoading.TabIndex = 47;
            this.picLoading.TabStop = false;
            this.picLoading.Visible = false;
            // 
            // btn_Kitting
            // 
            this.btn_Kitting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Kitting.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Kitting.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_Kitting.Location = new System.Drawing.Point(1018, 469);
            this.btn_Kitting.Name = "btn_Kitting";
            this.btn_Kitting.Size = new System.Drawing.Size(145, 46);
            this.btn_Kitting.TabIndex = 52;
            this.btn_Kitting.Text = "Gợi ý Kitting";
            this.btn_Kitting.UseVisualStyleBackColor = false;
            this.btn_Kitting.Click += new System.EventHandler(this.btn_Kitting_Click);
            // 
            // ProductionStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 751);
            this.Controls.Add(this.btn_Kitting);
            this.Controls.Add(this.btnDongGoiDongThoi);
            this.Controls.Add(this.btnKittingDongThoi);
            this.Controls.Add(this.btnQCDoDang);
            this.Controls.Add(this.btnNhapKhau);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDongBoDL);
            this.Name = "ProductionStatus";
            this.Text = "EVS Production Status";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductionStatus_Load);
            this.pnData.ResumeLayout(false);
            this.pnData.PerformLayout();
            this.pnCongDoan.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnNhanVien.ResumeLayout(false);
            this.pnNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDongBoDL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picLoading;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Panel pnData;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbError;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnNhanVien;
        private System.Windows.Forms.Label lbBarcode2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.LinkLabel lnkCancel;
        private System.Windows.Forms.Label lbTenNguoiTT;
        private System.Windows.Forms.Label lbNguoiTT;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbScanned;
        private System.Windows.Forms.Button btnNhapKhau;
        private System.Windows.Forms.Button btnQCDoDang;
        private System.Windows.Forms.Button btnKittingDongThoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnDongGoiDongThoi;
        private System.Windows.Forms.Button btn_Kitting;
    }
}