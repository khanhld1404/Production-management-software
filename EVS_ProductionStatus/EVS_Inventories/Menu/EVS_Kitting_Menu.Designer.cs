namespace EVS_ProductionStatus.EVS_Inventories.Menu
{
    partial class EVS_Kitting_Menu
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
            this.btn_3010 = new System.Windows.Forms.Button();
            this.btn_3009 = new System.Windows.Forms.Button();
            this.btn_3008 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_3010
            // 
            this.btn_3010.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3010.Image = global::EVS_ProductionStatus.Properties.Resources.icons8_location_70__2_;
            this.btn_3010.Location = new System.Drawing.Point(496, 27);
            this.btn_3010.Name = "btn_3010";
            this.btn_3010.Size = new System.Drawing.Size(181, 146);
            this.btn_3010.TabIndex = 3;
            this.btn_3010.Text = "Location 3010";
            this.btn_3010.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_3010.UseVisualStyleBackColor = true;
            this.btn_3010.Click += new System.EventHandler(this.btn_3010_Click);
            // 
            // btn_3009
            // 
            this.btn_3009.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3009.Image = global::EVS_ProductionStatus.Properties.Resources.icons8_location_70__1_;
            this.btn_3009.Location = new System.Drawing.Point(255, 27);
            this.btn_3009.Name = "btn_3009";
            this.btn_3009.Size = new System.Drawing.Size(181, 146);
            this.btn_3009.TabIndex = 2;
            this.btn_3009.Text = "Location 3009";
            this.btn_3009.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_3009.UseVisualStyleBackColor = true;
            this.btn_3009.Click += new System.EventHandler(this.btn_3009_Click);
            // 
            // btn_3008
            // 
            this.btn_3008.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3008.Image = global::EVS_ProductionStatus.Properties.Resources.icons8_location_70;
            this.btn_3008.Location = new System.Drawing.Point(21, 27);
            this.btn_3008.Name = "btn_3008";
            this.btn_3008.Size = new System.Drawing.Size(181, 146);
            this.btn_3008.TabIndex = 1;
            this.btn_3008.Text = "Location 3008";
            this.btn_3008.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_3008.UseVisualStyleBackColor = true;
            this.btn_3008.Click += new System.EventHandler(this.btn_3008_Click);
            // 
            // EVS_Kitting_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 204);
            this.Controls.Add(this.btn_3010);
            this.Controls.Add(this.btn_3009);
            this.Controls.Add(this.btn_3008);
            this.Name = "EVS_Kitting_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu tồn kho";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_3008;
        private System.Windows.Forms.Button btn_3009;
        private System.Windows.Forms.Button btn_3010;
    }
}