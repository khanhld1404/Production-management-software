namespace EVS_ProductionStatus
{
    partial class View_MasterBanVe
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
            this.btnImport = new System.Windows.Forms.Button();
            this.txtFileURL = new System.Windows.Forms.TextBox();
            this.grThongtin = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.itemnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mabanve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grThongtin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnImport.Location = new System.Drawing.Point(857, 41);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(164, 31);
            this.btnImport.TabIndex = 44;
            this.btnImport.Text = "Nhập dữ liệu từ file";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txtFileURL
            // 
            this.txtFileURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileURL.Location = new System.Drawing.Point(147, 49);
            this.txtFileURL.Name = "txtFileURL";
            this.txtFileURL.ReadOnly = true;
            this.txtFileURL.Size = new System.Drawing.Size(524, 23);
            this.txtFileURL.TabIndex = 43;
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
            this.itemnumber,
            this.mabanve});
            this.grThongtin.Location = new System.Drawing.Point(12, 78);
            this.grThongtin.Name = "grThongtin";
            this.grThongtin.ReadOnly = true;
            this.grThongtin.Size = new System.Drawing.Size(1263, 555);
            this.grThongtin.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(20, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Chọn file dữ liệu";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(387, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 26);
            this.label1.TabIndex = 47;
            this.label1.Text = "NHẬP DỮ LIỆU MASTER BẢN VẼ";
            // 
            // btnChonFile
            // 
            this.btnChonFile.Location = new System.Drawing.Point(688, 49);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(101, 23);
            this.btnChonFile.TabIndex = 48;
            this.btnChonFile.Text = "Chọn file";
            this.btnChonFile.UseVisualStyleBackColor = true;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // itemnumber
            // 
            this.itemnumber.DataPropertyName = "itemnumber";
            this.itemnumber.HeaderText = "Mã sản phẩm";
            this.itemnumber.Name = "itemnumber";
            this.itemnumber.ReadOnly = true;
            this.itemnumber.Width = 300;
            // 
            // mabanve
            // 
            this.mabanve.DataPropertyName = "mabanve";
            this.mabanve.HeaderText = "Mã bản vẽ";
            this.mabanve.Name = "mabanve";
            this.mabanve.ReadOnly = true;
            this.mabanve.Width = 300;
            // 
            // View_MasterBanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 651);
            this.Controls.Add(this.btnChonFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtFileURL);
            this.Controls.Add(this.grThongtin);
            this.Controls.Add(this.label6);
            this.Name = "View_MasterBanVe";
            this.Text = "Master mã bản vẽ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.View_MasterBanVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grThongtin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox txtFileURL;
        private System.Windows.Forms.DataGridView grThongtin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabanve;
    }
}