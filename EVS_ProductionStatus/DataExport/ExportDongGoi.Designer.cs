namespace EVS_ProductionStatus
{
    partial class ExportDongGoi
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
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WOID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DongGoi_Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DongGoi_End = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGDongThoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserKitting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNameKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhutTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWO = new System.Windows.Forms.TextBox();
            this.txtNguoiTT = new System.Windows.Forms.TextBox();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.txtLot = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grThongtin)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
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
            this.STT,
            this.workorder,
            this.WOID,
            this.itemnumber,
            this.lot,
            this.qty,
            this.desc1,
            this.desc2,
            this.DongGoi_Start,
            this.DongGoi_End,
            this.DGDongThoi,
            this.UserKitting,
            this.UserNameKhau,
            this.GioTT,
            this.PhutTT});
            this.grThongtin.Location = new System.Drawing.Point(12, 151);
            this.grThongtin.Name = "grThongtin";
            this.grThongtin.ReadOnly = true;
            this.grThongtin.Size = new System.Drawing.Size(1263, 490);
            this.grThongtin.TabIndex = 51;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.FillWeight = 50F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // workorder
            // 
            this.workorder.DataPropertyName = "workorder";
            this.workorder.HeaderText = "Số WO";
            this.workorder.Name = "workorder";
            this.workorder.ReadOnly = true;
            // 
            // WOID
            // 
            this.WOID.DataPropertyName = "WOID";
            this.WOID.HeaderText = "ID";
            this.WOID.Name = "WOID";
            this.WOID.ReadOnly = true;
            // 
            // itemnumber
            // 
            this.itemnumber.DataPropertyName = "itemnumber";
            this.itemnumber.HeaderText = "Mã chủng loại";
            this.itemnumber.Name = "itemnumber";
            this.itemnumber.ReadOnly = true;
            // 
            // lot
            // 
            this.lot.DataPropertyName = "lot";
            this.lot.HeaderText = "Số lô";
            this.lot.Name = "lot";
            this.lot.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            this.qty.HeaderText = "Số lượng";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // desc1
            // 
            this.desc1.DataPropertyName = "desc1";
            this.desc1.HeaderText = "Mô tả 1";
            this.desc1.Name = "desc1";
            this.desc1.ReadOnly = true;
            // 
            // desc2
            // 
            this.desc2.DataPropertyName = "desc2";
            this.desc2.HeaderText = "Mô tả 2";
            this.desc2.Name = "desc2";
            this.desc2.ReadOnly = true;
            // 
            // DongGoi_Start
            // 
            this.DongGoi_Start.DataPropertyName = "DongGoi_Start";
            this.DongGoi_Start.HeaderText = "Thời gian bắt đầu đóng gói";
            this.DongGoi_Start.Name = "DongGoi_Start";
            this.DongGoi_Start.ReadOnly = true;
            // 
            // DongGoi_End
            // 
            this.DongGoi_End.DataPropertyName = "DongGoi_End";
            this.DongGoi_End.HeaderText = "Thời gian kết thúc đóng gói";
            this.DongGoi_End.Name = "DongGoi_End";
            this.DongGoi_End.ReadOnly = true;
            // 
            // DGDongThoi
            // 
            this.DGDongThoi.DataPropertyName = "DGDongThoi";
            this.DGDongThoi.HeaderText = "Đóng gói đồng thời";
            this.DGDongThoi.Name = "DGDongThoi";
            this.DGDongThoi.ReadOnly = true;
            // 
            // UserKitting
            // 
            this.UserKitting.DataPropertyName = "UserDongGoi";
            this.UserKitting.HeaderText = "Mã người thao tác";
            this.UserKitting.Name = "UserKitting";
            this.UserKitting.ReadOnly = true;
            // 
            // UserNameKhau
            // 
            this.UserNameKhau.DataPropertyName = "name";
            this.UserNameKhau.HeaderText = "Tên người thao tác";
            this.UserNameKhau.Name = "UserNameKhau";
            this.UserNameKhau.ReadOnly = true;
            // 
            // GioTT
            // 
            this.GioTT.DataPropertyName = "GioTT";
            this.GioTT.HeaderText = "Thời gian thao tác (giờ)";
            this.GioTT.Name = "GioTT";
            this.GioTT.ReadOnly = true;
            // 
            // PhutTT
            // 
            this.PhutTT.DataPropertyName = "PhutTT";
            this.PhutTT.HeaderText = "Thời gian thao tác (phút)";
            this.PhutTT.Name = "PhutTT";
            this.PhutTT.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbLoaiSP);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtWO);
            this.groupBox1.Controls.Add(this.txtNguoiTT);
            this.groupBox1.Controls.Add(this.picLoading);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnThucHien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.txtLot);
            this.groupBox1.Controls.Add(this.txtItem);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1263, 100);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điều kiện tìm kiếm dữ liệu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(18, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "WO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(505, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Mã người TT";
            // 
            // txtWO
            // 
            this.txtWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWO.Location = new System.Drawing.Point(60, 56);
            this.txtWO.Name = "txtWO";
            this.txtWO.Size = new System.Drawing.Size(132, 23);
            this.txtWO.TabIndex = 47;
            // 
            // txtNguoiTT
            // 
            this.txtNguoiTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiTT.Location = new System.Drawing.Point(607, 23);
            this.txtNguoiTT.Name = "txtNguoiTT";
            this.txtNguoiTT.Size = new System.Drawing.Size(132, 23);
            this.txtNguoiTT.TabIndex = 46;
            // 
            // picLoading
            // 
            this.picLoading.Image = global::EVS_ProductionStatus.Properties.Resources._16;
            this.picLoading.Location = new System.Drawing.Point(1095, 42);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(29, 27);
            this.picLoading.TabIndex = 45;
            this.picLoading.TabStop = false;
            this.picLoading.Visible = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExport.Location = new System.Drawing.Point(1130, 60);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(127, 34);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "Trích xuất dữ liệu";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(553, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số lô";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(223, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã sản phẩm";
            // 
            // btnThucHien
            // 
            this.btnThucHien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThucHien.Location = new System.Drawing.Point(966, 24);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(123, 58);
            this.btnThucHien.TabIndex = 8;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = false;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(18, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Thời gian đóng gói";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(300, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "~";
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(150, 24);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(144, 23);
            this.dtFrom.TabIndex = 12;
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(324, 24);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(143, 23);
            this.dtTo.TabIndex = 12;
            // 
            // txtLot
            // 
            this.txtLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLot.Location = new System.Drawing.Point(607, 56);
            this.txtLot.Name = "txtLot";
            this.txtLot.Size = new System.Drawing.Size(195, 23);
            this.txtLot.TabIndex = 7;
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(324, 56);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(167, 23);
            this.txtItem.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(383, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 26);
            this.label1.TabIndex = 49;
            this.label1.Text = "TRÍCH XUẤT DỮ LIỆU ĐÓNG GÓI";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(756, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Loại SP";
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiSP.FormattingEnabled = true;
            this.cbLoaiSP.Location = new System.Drawing.Point(819, 23);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(121, 24);
            this.cbLoaiSP.TabIndex = 50;
            // 
            // ExportDongGoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 651);
            this.Controls.Add(this.grThongtin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ExportDongGoi";
            this.Text = "Trích xuất dữ liệu Đóng gói";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExportDongGoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grThongtin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grThongtin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.TextBox txtLot;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn workorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn WOID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn lot;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DongGoi_Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn DongGoi_End;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGDongThoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserKitting;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhutTT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWO;
        private System.Windows.Forms.TextBox txtNguoiTT;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private System.Windows.Forms.Label label8;
    }
}