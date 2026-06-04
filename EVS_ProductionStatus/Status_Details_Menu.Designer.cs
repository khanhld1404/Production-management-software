namespace EVS_ProductionStatus
{
    partial class Status_Details_Menu
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
            this.btn_Relay_Status = new System.Windows.Forms.Button();
            this.btn_Treo_Status = new System.Windows.Forms.Button();
            this.btn_Thora_Status = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Relay_Status
            // 
            this.btn_Relay_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Relay_Status.Image = global::EVS_ProductionStatus.Properties.Resources.icons8_book_70__2_;
            this.btn_Relay_Status.Location = new System.Drawing.Point(484, 35);
            this.btn_Relay_Status.Name = "btn_Relay_Status";
            this.btn_Relay_Status.Size = new System.Drawing.Size(181, 146);
            this.btn_Relay_Status.TabIndex = 2;
            this.btn_Relay_Status.Text = "Relay";
            this.btn_Relay_Status.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Relay_Status.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Relay_Status.UseVisualStyleBackColor = true;
            this.btn_Relay_Status.Click += new System.EventHandler(this.btn_Relay_Status_Click);
            // 
            // btn_Treo_Status
            // 
            this.btn_Treo_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Treo_Status.Image = global::EVS_ProductionStatus.Properties.Resources.icons8_book_70__1_;
            this.btn_Treo_Status.Location = new System.Drawing.Point(257, 35);
            this.btn_Treo_Status.Name = "btn_Treo_Status";
            this.btn_Treo_Status.Size = new System.Drawing.Size(181, 146);
            this.btn_Treo_Status.TabIndex = 1;
            this.btn_Treo_Status.Text = "Treo";
            this.btn_Treo_Status.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Treo_Status.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Treo_Status.UseVisualStyleBackColor = true;
            this.btn_Treo_Status.Click += new System.EventHandler(this.btn_Treo_Status_Click);
            // 
            // btn_Thora_Status
            // 
            this.btn_Thora_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thora_Status.Image = global::EVS_ProductionStatus.Properties.Resources.icons8_book_70;
            this.btn_Thora_Status.Location = new System.Drawing.Point(31, 35);
            this.btn_Thora_Status.Name = "btn_Thora_Status";
            this.btn_Thora_Status.Size = new System.Drawing.Size(181, 146);
            this.btn_Thora_Status.TabIndex = 0;
            this.btn_Thora_Status.Text = "Thora";
            this.btn_Thora_Status.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Thora_Status.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Thora_Status.UseVisualStyleBackColor = true;
            this.btn_Thora_Status.Click += new System.EventHandler(this.btn_Thora_Status_Click);
            // 
            // Status_Details_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 221);
            this.Controls.Add(this.btn_Relay_Status);
            this.Controls.Add(this.btn_Treo_Status);
            this.Controls.Add(this.btn_Thora_Status);
            this.Name = "Status_Details_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu bảng trạng thái";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Thora_Status;
        private System.Windows.Forms.Button btn_Treo_Status;
        private System.Windows.Forms.Button btn_Relay_Status;
    }
}