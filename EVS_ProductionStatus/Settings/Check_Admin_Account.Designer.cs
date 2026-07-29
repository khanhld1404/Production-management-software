namespace EVS_ProductionStatus.Settings
{
    partial class Check_Admin_Account
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
            this.txt_account = new System.Windows.Forms.TextBox();
            this.btn_check_account = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Mã Nhân Viên  :";
            // 
            // txt_account
            // 
            this.txt_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_account.Location = new System.Drawing.Point(15, 62);
            this.txt_account.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_account.Name = "txt_account";
            this.txt_account.Size = new System.Drawing.Size(234, 24);
            this.txt_account.TabIndex = 1;
            this.txt_account.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_account_KeyDown);
            // 
            // btn_check_account
            // 
            this.btn_check_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_check_account.Location = new System.Drawing.Point(265, 62);
            this.btn_check_account.Name = "btn_check_account";
            this.btn_check_account.Size = new System.Drawing.Size(75, 24);
            this.btn_check_account.TabIndex = 2;
            this.btn_check_account.Text = "Kiểm tra";
            this.btn_check_account.UseVisualStyleBackColor = false;
            this.btn_check_account.Click += new System.EventHandler(this.btn_check_account_Click);
            // 
            // Check_Admin_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 114);
            this.Controls.Add(this.btn_check_account);
            this.Controls.Add(this.txt_account);
            this.Controls.Add(this.label1);
            this.Name = "Check_Admin_Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiểm tra tài khoản Admin";
            this.Load += new System.EventHandler(this.Check_Admin_Account_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_account;
        private System.Windows.Forms.Button btn_check_account;
    }
}