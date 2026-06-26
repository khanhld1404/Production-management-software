namespace EVS_ProductionStatus.Settings
{
    partial class KetThucPacking
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbBarcode2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.lbMSG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 31);
            this.label1.TabIndex = 56;
            this.label1.Text = "KẾT THÚC ĐÓNG GÓI";
            // 
            // lbBarcode2
            // 
            this.lbBarcode2.AutoSize = true;
            this.lbBarcode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBarcode2.ForeColor = System.Drawing.Color.Navy;
            this.lbBarcode2.Location = new System.Drawing.Point(21, 62);
            this.lbBarcode2.Name = "lbBarcode2";
            this.lbBarcode2.Size = new System.Drawing.Size(142, 20);
            this.lbBarcode2.TabIndex = 54;
            this.lbBarcode2.Text = "Quét mã nhân viên";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Lime;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(169, 58);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(189, 29);
            this.txtUsername.TabIndex = 53;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiSP.FormattingEnabled = true;
            this.cbLoaiSP.Items.AddRange(new object[] {
            "ANA",
            "RELAY",
            "THORA",
            "TREO"});
            this.cbLoaiSP.Location = new System.Drawing.Point(169, 106);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(189, 32);
            this.cbLoaiSP.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(21, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Loại sản phẩm";
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnKetThuc.ForeColor = System.Drawing.Color.Navy;
            this.btnKetThuc.Location = new System.Drawing.Point(384, 58);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(129, 80);
            this.btnKetThuc.TabIndex = 59;
            this.btnKetThuc.Text = "Kết thúc đóng gói";
            this.btnKetThuc.UseVisualStyleBackColor = false;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // lbMSG
            // 
            this.lbMSG.AutoSize = true;
            this.lbMSG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMSG.ForeColor = System.Drawing.Color.Red;
            this.lbMSG.Location = new System.Drawing.Point(166, 141);
            this.lbMSG.Name = "lbMSG";
            this.lbMSG.Size = new System.Drawing.Size(84, 17);
            this.lbMSG.TabIndex = 60;
            this.lbMSG.Text = "Thành công";
            this.lbMSG.Visible = false;
            // 
            // KetThucPacking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 172);
            this.Controls.Add(this.lbMSG);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.cbLoaiSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbBarcode2);
            this.Controls.Add(this.txtUsername);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KetThucPacking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết thúc đóng gói";
            this.Load += new System.EventHandler(this.KetThucPacking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbBarcode2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Label lbMSG;
    }
}