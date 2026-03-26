namespace EVS_ProductionStatus
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thiếtLậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemThietLapFile = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTrangThaiWO = new System.Windows.Forms.ToolStripMenuItem();
            this.itemThoiGianNghi = new System.Windows.Forms.ToolStripMenuItem();
            this.itemNguoiThaoTac = new System.Windows.Forms.ToolStripMenuItem();
            this.itemWOBaoLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.itemWOChamDG = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMaBanVe = new System.Windows.Forms.ToolStripMenuItem();
            this.itemThoiGianKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolInput = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolPacking = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTrangThaiSP = new System.Windows.Forms.ToolStripButton();
            this.btnOperatorStatus = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnTrangthaiSX_Treo = new System.Windows.Forms.Button();
            this.btnTrangthaiSX_AnaThora = new System.Windows.Forms.Button();
            this.btnTrangthaiSXOther = new System.Windows.Forms.Button();
            this.btnTrangthaiSX_Relay = new System.Windows.Forms.Button();
            this.btn_HFG = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_RM_WIP = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(181, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "TRẠNG THÁI SẢN XUẤT EVS";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thiếtLậpToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.masterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thiếtLậpToolStripMenuItem
            // 
            this.thiếtLậpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemThietLapFile});
            this.thiếtLậpToolStripMenuItem.Name = "thiếtLậpToolStripMenuItem";
            this.thiếtLậpToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thiếtLậpToolStripMenuItem.Text = "Hệ thống";
            // 
            // itemThietLapFile
            // 
            this.itemThietLapFile.Name = "itemThietLapFile";
            this.itemThietLapFile.Size = new System.Drawing.Size(175, 22);
            this.itemThietLapFile.Text = "Thiết lập file chỉ thị";
            this.itemThietLapFile.Click += new System.EventHandler(this.itemThietLapFile_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemTrangThaiWO,
            this.itemThoiGianNghi,
            this.itemNguoiThaoTac,
            this.itemWOBaoLuu,
            this.itemWOChamDG});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // itemTrangThaiWO
            // 
            this.itemTrangThaiWO.Name = "itemTrangThaiWO";
            this.itemTrangThaiWO.Size = new System.Drawing.Size(195, 22);
            this.itemTrangThaiWO.Text = "Trạng thái WO";
            this.itemTrangThaiWO.Click += new System.EventHandler(this.itemTrangThaiWO_Click);
            // 
            // itemThoiGianNghi
            // 
            this.itemThoiGianNghi.Name = "itemThoiGianNghi";
            this.itemThoiGianNghi.Size = new System.Drawing.Size(195, 22);
            this.itemThoiGianNghi.Text = "Thời gian nghỉ";
            this.itemThoiGianNghi.Click += new System.EventHandler(this.itemThoiGianNghi_Click);
            // 
            // itemNguoiThaoTac
            // 
            this.itemNguoiThaoTac.Name = "itemNguoiThaoTac";
            this.itemNguoiThaoTac.Size = new System.Drawing.Size(195, 22);
            this.itemNguoiThaoTac.Text = "Người thao tác";
            this.itemNguoiThaoTac.Click += new System.EventHandler(this.itemNguoiThaoTac_Click);
            // 
            // itemWOBaoLuu
            // 
            this.itemWOBaoLuu.Name = "itemWOBaoLuu";
            this.itemWOBaoLuu.Size = new System.Drawing.Size(195, 22);
            this.itemWOBaoLuu.Text = "Danh sách WO bảo lưu";
            this.itemWOBaoLuu.Click += new System.EventHandler(this.itemWOBaoLuu_Click);
            // 
            // itemWOChamDG
            // 
            this.itemWOChamDG.Name = "itemWOChamDG";
            this.itemWOChamDG.Size = new System.Drawing.Size(195, 22);
            this.itemWOChamDG.Text = "WO chậm đóng gói";
            this.itemWOChamDG.Click += new System.EventHandler(this.itemWOChamDG_Click);
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMaBanVe,
            this.itemThoiGianKhau});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // itemMaBanVe
            // 
            this.itemMaBanVe.Name = "itemMaBanVe";
            this.itemMaBanVe.Size = new System.Drawing.Size(212, 22);
            this.itemMaBanVe.Text = "Mã bản vẽ";
            this.itemMaBanVe.Click += new System.EventHandler(this.itemMaBanVe_Click);
            // 
            // itemThoiGianKhau
            // 
            this.itemThoiGianKhau.Name = "itemThoiGianKhau";
            this.itemThoiGianKhau.Size = new System.Drawing.Size(212, 22);
            this.itemThoiGianKhau.Text = "Thời gian khâu tiêu chuẩn";
            this.itemThoiGianKhau.Click += new System.EventHandler(this.itemThoiGianKhau_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolInput,
            this.toolTrangThaiSP});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(775, 39);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolInput
            // 
            this.toolInput.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolPacking});
            this.toolInput.Image = ((System.Drawing.Image)(resources.GetObject("toolInput.Image")));
            this.toolInput.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolInput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolInput.Name = "toolInput";
            this.toolInput.Size = new System.Drawing.Size(120, 36);
            this.toolInput.Text = "Nhập dữ liệu";
            // 
            // toolPacking
            // 
            this.toolPacking.AutoSize = false;
            this.toolPacking.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolPacking.Name = "toolPacking";
            this.toolPacking.Size = new System.Drawing.Size(180, 30);
            this.toolPacking.Text = "Đóng gói";
            this.toolPacking.Click += new System.EventHandler(this.toolPacking_Click);
            // 
            // toolTrangThaiSP
            // 
            this.toolTrangThaiSP.Image = global::EVS_ProductionStatus.Properties.Resources.icons8_idea_32;
            this.toolTrangThaiSP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTrangThaiSP.Name = "toolTrangThaiSP";
            this.toolTrangThaiSP.Size = new System.Drawing.Size(136, 36);
            this.toolTrangThaiSP.Text = "Trạng thái thiết bị";
            this.toolTrangThaiSP.Click += new System.EventHandler(this.toolTrangThaiSP_Click);
            // 
            // btnOperatorStatus
            // 
            this.btnOperatorStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOperatorStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOperatorStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperatorStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperatorStatus.ForeColor = System.Drawing.Color.Navy;
            this.btnOperatorStatus.Image = global::EVS_ProductionStatus.Properties.Resources.icons8_user_groups_64;
            this.btnOperatorStatus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOperatorStatus.Location = new System.Drawing.Point(487, 272);
            this.btnOperatorStatus.Name = "btnOperatorStatus";
            this.btnOperatorStatus.Size = new System.Drawing.Size(162, 132);
            this.btnOperatorStatus.TabIndex = 8;
            this.btnOperatorStatus.Text = "Tình trạng người thao tác";
            this.btnOperatorStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOperatorStatus.UseVisualStyleBackColor = true;
            this.btnOperatorStatus.Click += new System.EventHandler(this.btnOperatorStatus_Click);
            // 
            // btnExport
            // 
            this.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.Navy;
            this.btnExport.Image = global::EVS_ProductionStatus.Properties.Resources.icons8_xls_64;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExport.Location = new System.Drawing.Point(487, 124);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(162, 132);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Trích xuất dữ liệu";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnTrangthaiSX_Treo
            // 
            this.btnTrangthaiSX_Treo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTrangthaiSX_Treo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTrangthaiSX_Treo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangthaiSX_Treo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangthaiSX_Treo.ForeColor = System.Drawing.Color.Navy;
            this.btnTrangthaiSX_Treo.Image = global::EVS_ProductionStatus.Properties.Resources.icons8_circuit_70_recolor1;
            this.btnTrangthaiSX_Treo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTrangthaiSX_Treo.Location = new System.Drawing.Point(64, 272);
            this.btnTrangthaiSX_Treo.Name = "btnTrangthaiSX_Treo";
            this.btnTrangthaiSX_Treo.Size = new System.Drawing.Size(162, 132);
            this.btnTrangthaiSX_Treo.TabIndex = 4;
            this.btnTrangthaiSX_Treo.Text = "Trạng thái sản xuất - TREO";
            this.btnTrangthaiSX_Treo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTrangthaiSX_Treo.UseVisualStyleBackColor = true;
            this.btnTrangthaiSX_Treo.Click += new System.EventHandler(this.btnTrangthaiSX_Treo_Click);
            // 
            // btnTrangthaiSX_AnaThora
            // 
            this.btnTrangthaiSX_AnaThora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTrangthaiSX_AnaThora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTrangthaiSX_AnaThora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangthaiSX_AnaThora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangthaiSX_AnaThora.ForeColor = System.Drawing.Color.Navy;
            this.btnTrangthaiSX_AnaThora.Image = global::EVS_ProductionStatus.Properties.Resources.icons8_circuit_70_recolor2;
            this.btnTrangthaiSX_AnaThora.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTrangthaiSX_AnaThora.Location = new System.Drawing.Point(266, 272);
            this.btnTrangthaiSX_AnaThora.Name = "btnTrangthaiSX_AnaThora";
            this.btnTrangthaiSX_AnaThora.Size = new System.Drawing.Size(181, 132);
            this.btnTrangthaiSX_AnaThora.TabIndex = 4;
            this.btnTrangthaiSX_AnaThora.Text = "Trạng thái sản xuất - THORA";
            this.btnTrangthaiSX_AnaThora.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTrangthaiSX_AnaThora.UseVisualStyleBackColor = true;
            this.btnTrangthaiSX_AnaThora.Click += new System.EventHandler(this.btnTrangthaiSX_AnaThora_Click);
            // 
            // btnTrangthaiSXOther
            // 
            this.btnTrangthaiSXOther.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTrangthaiSXOther.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTrangthaiSXOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangthaiSXOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangthaiSXOther.ForeColor = System.Drawing.Color.Navy;
            this.btnTrangthaiSXOther.Image = global::EVS_ProductionStatus.Properties.Resources.icons8_circuit_70;
            this.btnTrangthaiSXOther.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTrangthaiSXOther.Location = new System.Drawing.Point(64, 124);
            this.btnTrangthaiSXOther.Name = "btnTrangthaiSXOther";
            this.btnTrangthaiSXOther.Size = new System.Drawing.Size(162, 132);
            this.btnTrangthaiSXOther.TabIndex = 4;
            this.btnTrangthaiSXOther.Text = "Trạng thái sản xuất";
            this.btnTrangthaiSXOther.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTrangthaiSXOther.UseVisualStyleBackColor = true;
            this.btnTrangthaiSXOther.Click += new System.EventHandler(this.btnTrangthaiSXOther_Click);
            // 
            // btnTrangthaiSX_Relay
            // 
            this.btnTrangthaiSX_Relay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTrangthaiSX_Relay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTrangthaiSX_Relay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangthaiSX_Relay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangthaiSX_Relay.ForeColor = System.Drawing.Color.Navy;
            this.btnTrangthaiSX_Relay.Image = global::EVS_ProductionStatus.Properties.Resources.icons8_circuit_70_recolor;
            this.btnTrangthaiSX_Relay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTrangthaiSX_Relay.Location = new System.Drawing.Point(266, 124);
            this.btnTrangthaiSX_Relay.Name = "btnTrangthaiSX_Relay";
            this.btnTrangthaiSX_Relay.Size = new System.Drawing.Size(181, 132);
            this.btnTrangthaiSX_Relay.TabIndex = 4;
            this.btnTrangthaiSX_Relay.Text = "Trạng thái sản xuất - RELAY";
            this.btnTrangthaiSX_Relay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTrangthaiSX_Relay.UseVisualStyleBackColor = true;
            this.btnTrangthaiSX_Relay.Click += new System.EventHandler(this.btnTrangthaiSX_Click);
            // 
            // btn_HFG
            // 
            this.btn_HFG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_HFG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_HFG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HFG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HFG.ForeColor = System.Drawing.Color.Navy;
            this.btn_HFG.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_HFG.ImageIndex = 0;
            this.btn_HFG.ImageList = this.imageList1;
            this.btn_HFG.Location = new System.Drawing.Point(64, 435);
            this.btn_HFG.Name = "btn_HFG";
            this.btn_HFG.Size = new System.Drawing.Size(162, 132);
            this.btn_HFG.TabIndex = 10;
            this.btn_HFG.Text = "Tồn HFG";
            this.btn_HFG.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_HFG.UseVisualStyleBackColor = true;
            this.btn_HFG.Click += new System.EventHandler(this.btn_HFG_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "warehouse-storage.png");
            // 
            // btn_RM_WIP
            // 
            this.btn_RM_WIP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_RM_WIP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_RM_WIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RM_WIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RM_WIP.ForeColor = System.Drawing.Color.Navy;
            this.btn_RM_WIP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_RM_WIP.ImageIndex = 0;
            this.btn_RM_WIP.ImageList = this.imageList2;
            this.btn_RM_WIP.Location = new System.Drawing.Point(266, 435);
            this.btn_RM_WIP.Name = "btn_RM_WIP";
            this.btn_RM_WIP.Size = new System.Drawing.Size(181, 132);
            this.btn_RM_WIP.TabIndex = 11;
            this.btn_RM_WIP.Text = "Tồn RM WIP";
            this.btn_RM_WIP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_RM_WIP.UseVisualStyleBackColor = true;
            this.btn_RM_WIP.Click += new System.EventHandler(this.btn_RM_WIP_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "warehouse.png");
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 623);
            this.Controls.Add(this.btn_RM_WIP);
            this.Controls.Add(this.btn_HFG);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnOperatorStatus);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnTrangthaiSX_Treo);
            this.Controls.Add(this.btnTrangthaiSX_AnaThora);
            this.Controls.Add(this.btnTrangthaiSXOther);
            this.Controls.Add(this.btnTrangthaiSX_Relay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrangthaiSX_Relay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thiếtLậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemThietLapFile;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemTrangThaiWO;
        private System.Windows.Forms.ToolStripMenuItem itemThoiGianNghi;
        private System.Windows.Forms.ToolStripMenuItem itemNguoiThaoTac;
        private System.Windows.Forms.Button btnTrangthaiSXOther;
        private System.Windows.Forms.ToolStripMenuItem itemWOBaoLuu;
        private System.Windows.Forms.Button btnTrangthaiSX_AnaThora;
        private System.Windows.Forms.Button btnTrangthaiSX_Treo;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemMaBanVe;
        private System.Windows.Forms.Button btnOperatorStatus;
        private System.Windows.Forms.ToolStripMenuItem itemWOChamDG;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolInput;
        private System.Windows.Forms.ToolStripMenuItem toolPacking;
        private System.Windows.Forms.ToolStripButton toolTrangThaiSP;
        private System.Windows.Forms.ToolStripMenuItem itemThoiGianKhau;
        private System.Windows.Forms.Button btn_HFG;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_RM_WIP;
        private System.Windows.Forms.ImageList imageList2;
    }
}

