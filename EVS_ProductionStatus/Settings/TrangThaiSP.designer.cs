namespace EVS_ProductionStatus.Settings
{
    partial class TrangThaiSP
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
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WOID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KittingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhauTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QCTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grTotal = new System.Windows.Forms.DataGridView();
            this.totalKitting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalKittingNext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalKhauNext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQCNext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grContent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbSX3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbSX4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbHT1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSX4 = new System.Windows.Forms.TextBox();
            this.txtSX3 = new System.Windows.Forms.TextBox();
            this.txtSX2 = new System.Windows.Forms.TextBox();
            this.txtSX1 = new System.Windows.Forms.TextBox();
            this.lbSX2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbSX1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHT1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grThongtin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grContent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 31);
            this.label1.TabIndex = 47;
            this.label1.Text = "TRẠNG THÁI SẢN PHẨM";
            // 
            // grThongtin
            // 
            this.grThongtin.AllowUserToAddRows = false;
            this.grThongtin.AllowUserToDeleteRows = false;
            this.grThongtin.BackgroundColor = System.Drawing.Color.White;
            this.grThongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grThongtin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.WOID,
            this.workorder,
            this.itemnumber,
            this.lot,
            this.desc1,
            this.desc2,
            this.KittingTime,
            this.StartKhau,
            this.KhauTime,
            this.QCTime,
            this.TrangThai});
            this.grThongtin.Location = new System.Drawing.Point(12, 234);
            this.grThongtin.Name = "grThongtin";
            this.grThongtin.RowHeadersVisible = false;
            this.grThongtin.Size = new System.Drawing.Size(1263, 405);
            this.grThongtin.TabIndex = 54;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.DataPropertyName = "STT";
            this.STT.FillWeight = 30F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // WOID
            // 
            this.WOID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WOID.DataPropertyName = "WOID";
            this.WOID.FillWeight = 70F;
            this.WOID.HeaderText = "WOID";
            this.WOID.Name = "WOID";
            // 
            // workorder
            // 
            this.workorder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workorder.DataPropertyName = "workorder";
            this.workorder.FillWeight = 70F;
            this.workorder.HeaderText = "Số_WO";
            this.workorder.Name = "workorder";
            // 
            // itemnumber
            // 
            this.itemnumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemnumber.DataPropertyName = "itemnumber";
            this.itemnumber.HeaderText = "Mã_chủng_loại";
            this.itemnumber.Name = "itemnumber";
            // 
            // lot
            // 
            this.lot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lot.DataPropertyName = "lot";
            this.lot.FillWeight = 70F;
            this.lot.HeaderText = "Lot";
            this.lot.Name = "lot";
            // 
            // desc1
            // 
            this.desc1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desc1.DataPropertyName = "desc1";
            this.desc1.HeaderText = "Desc1";
            this.desc1.Name = "desc1";
            // 
            // desc2
            // 
            this.desc2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desc2.DataPropertyName = "desc2";
            this.desc2.HeaderText = "Desc2";
            this.desc2.Name = "desc2";
            // 
            // KittingTime
            // 
            this.KittingTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KittingTime.DataPropertyName = "KittingTime";
            this.KittingTime.HeaderText = "Kitting";
            this.KittingTime.Name = "KittingTime";
            // 
            // StartKhau
            // 
            this.StartKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StartKhau.DataPropertyName = "StartKhau";
            this.StartKhau.HeaderText = "Bắt đầu khâu";
            this.StartKhau.Name = "StartKhau";
            // 
            // KhauTime
            // 
            this.KhauTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KhauTime.DataPropertyName = "KhauTime";
            this.KhauTime.HeaderText = "Khâu";
            this.KhauTime.Name = "KhauTime";
            // 
            // QCTime
            // 
            this.QCTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QCTime.DataPropertyName = "QCTime";
            this.QCTime.HeaderText = "QC";
            this.QCTime.Name = "QCTime";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "TrangThai";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Visible = false;
            // 
            // grTotal
            // 
            this.grTotal.AllowUserToAddRows = false;
            this.grTotal.AllowUserToDeleteRows = false;
            this.grTotal.AllowUserToResizeRows = false;
            this.grTotal.BackgroundColor = System.Drawing.Color.White;
            this.grTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grTotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.totalKitting,
            this.totalKittingNext,
            this.totalKhau,
            this.totalKhauNext,
            this.totalQC,
            this.totalQCNext});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grTotal.DefaultCellStyle = dataGridViewCellStyle1;
            this.grTotal.Location = new System.Drawing.Point(735, 35);
            this.grTotal.Name = "grTotal";
            this.grTotal.ReadOnly = true;
            this.grTotal.RowHeadersVisible = false;
            this.grTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grTotal.Size = new System.Drawing.Size(540, 152);
            this.grTotal.TabIndex = 56;
            // 
            // totalKitting
            // 
            this.totalKitting.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalKitting.HeaderText = "02-2024";
            this.totalKitting.Name = "totalKitting";
            this.totalKitting.ReadOnly = true;
            // 
            // totalKittingNext
            // 
            this.totalKittingNext.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalKittingNext.HeaderText = "03-2024";
            this.totalKittingNext.Name = "totalKittingNext";
            this.totalKittingNext.ReadOnly = true;
            // 
            // totalKhau
            // 
            this.totalKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalKhau.FillWeight = 200F;
            this.totalKhau.HeaderText = "02-2024";
            this.totalKhau.Name = "totalKhau";
            this.totalKhau.ReadOnly = true;
            // 
            // totalKhauNext
            // 
            this.totalKhauNext.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalKhauNext.FillWeight = 200F;
            this.totalKhauNext.HeaderText = "03-2024";
            this.totalKhauNext.Name = "totalKhauNext";
            this.totalKhauNext.ReadOnly = true;
            // 
            // totalQC
            // 
            this.totalQC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalQC.HeaderText = "02-2024";
            this.totalQC.Name = "totalQC";
            this.totalQC.ReadOnly = true;
            // 
            // totalQCNext
            // 
            this.totalQCNext.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalQCNext.HeaderText = "03-2024";
            this.totalQCNext.Name = "totalQCNext";
            this.totalQCNext.ReadOnly = true;
            // 
            // grContent
            // 
            this.grContent.AllowUserToAddRows = false;
            this.grContent.AllowUserToDeleteRows = false;
            this.grContent.AllowUserToResizeRows = false;
            this.grContent.BackgroundColor = System.Drawing.Color.White;
            this.grContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grContent.DefaultCellStyle = dataGridViewCellStyle2;
            this.grContent.Location = new System.Drawing.Point(492, 35);
            this.grContent.Name = "grContent";
            this.grContent.ReadOnly = true;
            this.grContent.RowHeadersVisible = false;
            this.grContent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grContent.Size = new System.Drawing.Size(244, 152);
            this.grContent.TabIndex = 56;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Hạng mục";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(14, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 20);
            this.label16.TabIndex = 59;
            this.label16.Text = "Loại sản phẩm";
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiSP.FormattingEnabled = true;
            this.cbLoaiSP.Items.AddRange(new object[] {
            "RELAY",
            "THORA",
            "TREO"});
            this.cbLoaiSP.Location = new System.Drawing.Point(18, 73);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(151, 28);
            this.cbLoaiSP.TabIndex = 60;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Green;
            this.panel13.Location = new System.Drawing.Point(271, 105);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(57, 18);
            this.panel13.TabIndex = 61;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(112, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 18);
            this.panel1.TabIndex = 61;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Location = new System.Drawing.Point(17, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 18);
            this.panel2.TabIndex = 61;
            // 
            // lbSX3
            // 
            this.lbSX3.AutoSize = true;
            this.lbSX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSX3.Location = new System.Drawing.Point(121, 46);
            this.lbSX3.Name = "lbSX3";
            this.lbSX3.Size = new System.Drawing.Size(10, 13);
            this.lbSX3.TabIndex = 62;
            this.lbSX3.Text = "-";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Pink;
            this.panel3.Location = new System.Drawing.Point(71, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 18);
            this.panel3.TabIndex = 61;
            // 
            // lbSX4
            // 
            this.lbSX4.AutoSize = true;
            this.lbSX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSX4.Location = new System.Drawing.Point(23, 95);
            this.lbSX4.Name = "lbSX4";
            this.lbSX4.Size = new System.Drawing.Size(10, 13);
            this.lbSX4.TabIndex = 62;
            this.lbSX4.Text = "-";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Aquamarine;
            this.panel4.Location = new System.Drawing.Point(108, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 18);
            this.panel4.TabIndex = 61;
            // 
            // lbHT1
            // 
            this.lbHT1.AutoSize = true;
            this.lbHT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHT1.Location = new System.Drawing.Point(71, 43);
            this.lbHT1.Name = "lbHT1";
            this.lbHT1.Size = new System.Drawing.Size(10, 13);
            this.lbHT1.TabIndex = 62;
            this.lbHT1.Text = "-";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel5.Location = new System.Drawing.Point(6, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(30, 18);
            this.panel5.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "<=";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Thistle;
            this.panel6.Location = new System.Drawing.Point(57, 72);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(30, 18);
            this.panel6.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(60, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = ">";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSX4);
            this.groupBox1.Controls.Add(this.txtSX3);
            this.groupBox1.Controls.Add(this.txtSX2);
            this.groupBox1.Controls.Add(this.txtSX1);
            this.groupBox1.Controls.Add(this.lbSX2);
            this.groupBox1.Controls.Add(this.lbSX4);
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.lbSX1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.lbSX3);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Location = new System.Drawing.Point(18, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 120);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đang sản xuất";
            // 
            // txtSX4
            // 
            this.txtSX4.Location = new System.Drawing.Point(73, 92);
            this.txtSX4.Name = "txtSX4";
            this.txtSX4.Size = new System.Drawing.Size(36, 20);
            this.txtSX4.TabIndex = 68;
            this.txtSX4.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // txtSX3
            // 
            this.txtSX3.Location = new System.Drawing.Point(0, 92);
            this.txtSX3.Name = "txtSX3";
            this.txtSX3.Size = new System.Drawing.Size(24, 20);
            this.txtSX3.TabIndex = 68;
            this.txtSX3.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // txtSX2
            // 
            this.txtSX2.Location = new System.Drawing.Point(98, 42);
            this.txtSX2.Name = "txtSX2";
            this.txtSX2.Size = new System.Drawing.Size(24, 20);
            this.txtSX2.TabIndex = 68;
            this.txtSX2.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // txtSX1
            // 
            this.txtSX1.Location = new System.Drawing.Point(47, 42);
            this.txtSX1.Name = "txtSX1";
            this.txtSX1.Size = new System.Drawing.Size(24, 20);
            this.txtSX1.TabIndex = 68;
            this.txtSX1.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // lbSX2
            // 
            this.lbSX2.AutoSize = true;
            this.lbSX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSX2.Location = new System.Drawing.Point(70, 46);
            this.lbSX2.Name = "lbSX2";
            this.lbSX2.Size = new System.Drawing.Size(10, 13);
            this.lbSX2.TabIndex = 62;
            this.lbSX2.Text = "-";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Moccasin;
            this.panel8.Location = new System.Drawing.Point(6, 22);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(30, 18);
            this.panel8.TabIndex = 61;
            // 
            // lbSX1
            // 
            this.lbSX1.AutoSize = true;
            this.lbSX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSX1.Location = new System.Drawing.Point(3, 45);
            this.lbSX1.Name = "lbSX1";
            this.lbSX1.Size = new System.Drawing.Size(10, 13);
            this.lbSX1.TabIndex = 62;
            this.lbSX1.Text = "-";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Olive;
            this.panel7.Location = new System.Drawing.Point(57, 22);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(30, 18);
            this.panel7.TabIndex = 61;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHT1);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.lbHT1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(190, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 120);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hoàn thành";
            // 
            // txtHT1
            // 
            this.txtHT1.Location = new System.Drawing.Point(31, 42);
            this.txtHT1.Name = "txtHT1";
            this.txtHT1.Size = new System.Drawing.Size(34, 20);
            this.txtHT1.TabIndex = 68;
            this.txtHT1.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // picLoading
            // 
            this.picLoading.Image = global::EVS_ProductionStatus.Properties.Resources._16;
            this.picLoading.Location = new System.Drawing.Point(330, 73);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(29, 27);
            this.picLoading.TabIndex = 65;
            this.picLoading.TabStop = false;
            this.picLoading.Visible = false;
            // 
            // btnHienThi
            // 
            this.btnHienThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHienThi.Location = new System.Drawing.Point(190, 73);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(123, 28);
            this.btnHienThi.TabIndex = 57;
            this.btnHienThi.Text = "Hiển thị dữ liệu";
            this.btnHienThi.UseVisualStyleBackColor = false;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExport.Location = new System.Drawing.Point(1109, 197);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(166, 30);
            this.btnExport.TabIndex = 66;
            this.btnExport.Text = "Trích xuất dữ liệu";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(346, 201);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(60, 23);
            this.btnLuu.TabIndex = 67;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // TrangThaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 651);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbLoaiSP);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.grContent);
            this.Controls.Add(this.grTotal);
            this.Controls.Add(this.grThongtin);
            this.Controls.Add(this.label1);
            this.Name = "TrangThaiSP";
            this.Text = "Trạng thái sản phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TrangThaiSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grThongtin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grContent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grThongtin;
        private System.Windows.Forms.DataGridView grTotal;
        private System.Windows.Forms.DataGridView grContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbSX3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbSX4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbHT1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.Label lbSX2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbSX1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalKitting;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalKittingNext;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalKhauNext;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQC;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQCNext;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn WOID;
        private System.Windows.Forms.DataGridViewTextBoxColumn workorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn lot;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc2;
        private System.Windows.Forms.DataGridViewTextBoxColumn KittingTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhauTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn QCTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtSX4;
        private System.Windows.Forms.TextBox txtSX3;
        private System.Windows.Forms.TextBox txtSX2;
        private System.Windows.Forms.TextBox txtSX1;
        private System.Windows.Forms.TextBox txtHT1;
    }
}