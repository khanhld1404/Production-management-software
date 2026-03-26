namespace EVS_ProductionStatus.Settings
{
    partial class WOChamDongGoi
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
            this.btnExport = new System.Windows.Forms.Button();
            this.btnHuyTimKiem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.grThongtin = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WOID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wostatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grThongtin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExport.Location = new System.Drawing.Point(1111, 44);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(164, 25);
            this.btnExport.TabIndex = 47;
            this.btnExport.Text = "Trích xuất dữ liệu";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnHuyTimKiem
            // 
            this.btnHuyTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHuyTimKiem.Location = new System.Drawing.Point(475, 43);
            this.btnHuyTimKiem.Name = "btnHuyTimKiem";
            this.btnHuyTimKiem.Size = new System.Drawing.Size(123, 26);
            this.btnHuyTimKiem.TabIndex = 46;
            this.btnHuyTimKiem.Text = "Hủy tìm kiếm";
            this.btnHuyTimKiem.UseVisualStyleBackColor = false;
            this.btnHuyTimKiem.Click += new System.EventHandler(this.btnHuyTimKiem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTimKiem.Location = new System.Drawing.Point(332, 43);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 26);
            this.btnTimKiem.TabIndex = 45;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(12, 42);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(298, 26);
            this.txtTimKiem.TabIndex = 44;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
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
            this.WOID,
            this.workorder,
            this.wostatus,
            this.itemnumber,
            this.lot,
            this.desc1,
            this.desc2,
            this.qty});
            this.grThongtin.Location = new System.Drawing.Point(12, 75);
            this.grThongtin.Name = "grThongtin";
            this.grThongtin.ReadOnly = true;
            this.grThongtin.Size = new System.Drawing.Size(1263, 565);
            this.grThongtin.TabIndex = 48;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.DataPropertyName = "STT";
            this.STT.FillWeight = 50F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // WOID
            // 
            this.WOID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WOID.DataPropertyName = "WOID";
            this.WOID.HeaderText = "ID";
            this.WOID.Name = "WOID";
            this.WOID.ReadOnly = true;
            // 
            // workorder
            // 
            this.workorder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workorder.DataPropertyName = "workorder";
            this.workorder.HeaderText = "Số chỉ thị";
            this.workorder.Name = "workorder";
            this.workorder.ReadOnly = true;
            // 
            // wostatus
            // 
            this.wostatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.wostatus.DataPropertyName = "wostatus";
            this.wostatus.FillWeight = 50F;
            this.wostatus.HeaderText = "Trạng thái WO";
            this.wostatus.Name = "wostatus";
            this.wostatus.ReadOnly = true;
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
            // desc1
            // 
            this.desc1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desc1.DataPropertyName = "desc1";
            this.desc1.FillWeight = 300F;
            this.desc1.HeaderText = "Mô tả sản phẩm 1";
            this.desc1.Name = "desc1";
            this.desc1.ReadOnly = true;
            // 
            // desc2
            // 
            this.desc2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desc2.DataPropertyName = "desc2";
            this.desc2.FillWeight = 300F;
            this.desc2.HeaderText = "Mô tả sản phẩm 2";
            this.desc2.Name = "desc2";
            this.desc2.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qty.DataPropertyName = "qty";
            this.qty.FillWeight = 50F;
            this.qty.HeaderText = "Số lượng";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(375, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 26);
            this.label1.TabIndex = 49;
            this.label1.Text = "DANH SÁCH WORK ORDER CHẬM ĐÓNG GÓI";
            // 
            // WOChamDongGoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 651);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnHuyTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.grThongtin);
            this.Controls.Add(this.label1);
            this.Name = "WOChamDongGoi";
            this.Text = "WO chậm đóng gói";
            this.Load += new System.EventHandler(this.WOChamDongGoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grThongtin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnHuyTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView grThongtin;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn WOID;
        private System.Windows.Forms.DataGridViewTextBoxColumn workorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn wostatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn lot;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc2;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}