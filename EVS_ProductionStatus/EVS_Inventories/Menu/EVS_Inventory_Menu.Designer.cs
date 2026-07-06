namespace EVS_ProductionStatus.EVS_Inventories
{
    partial class EVS_Inventory_Menu
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
            this.btn_Alowcate = new System.Windows.Forms.Button();
            this.btn_Detail = new System.Windows.Forms.Button();
            this.btn_Total = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Alowcate
            // 
            this.btn_Alowcate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alowcate.Image = global::EVS_ProductionStatus.Properties.Resources.anh3;
            this.btn_Alowcate.Location = new System.Drawing.Point(496, 27);
            this.btn_Alowcate.Name = "btn_Alowcate";
            this.btn_Alowcate.Size = new System.Drawing.Size(181, 146);
            this.btn_Alowcate.TabIndex = 3;
            this.btn_Alowcate.Text = "Tồn Alowcate";
            this.btn_Alowcate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Alowcate.UseVisualStyleBackColor = true;
            this.btn_Alowcate.Click += new System.EventHandler(this.btn_Alowcate_Click);
            // 
            // btn_Detail
            // 
            this.btn_Detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Detail.Image = global::EVS_ProductionStatus.Properties.Resources.anh2;
            this.btn_Detail.Location = new System.Drawing.Point(255, 27);
            this.btn_Detail.Name = "btn_Detail";
            this.btn_Detail.Size = new System.Drawing.Size(181, 146);
            this.btn_Detail.TabIndex = 2;
            this.btn_Detail.Text = "Tồn Chi Tiết";
            this.btn_Detail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Detail.UseVisualStyleBackColor = true;
            this.btn_Detail.Click += new System.EventHandler(this.btn_Detail_Click);
            // 
            // btn_Total
            // 
            this.btn_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Total.Image = global::EVS_ProductionStatus.Properties.Resources.anh1;
            this.btn_Total.Location = new System.Drawing.Point(27, 27);
            this.btn_Total.Name = "btn_Total";
            this.btn_Total.Size = new System.Drawing.Size(181, 146);
            this.btn_Total.TabIndex = 1;
            this.btn_Total.Text = "Tồn Tổng Quan";
            this.btn_Total.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Total.UseVisualStyleBackColor = true;
            this.btn_Total.Click += new System.EventHandler(this.btn_Total_Click);
            // 
            // EVS_Inventory_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 204);
            this.Controls.Add(this.btn_Alowcate);
            this.Controls.Add(this.btn_Detail);
            this.Controls.Add(this.btn_Total);
            this.Name = "EVS_Inventory_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu tồn kho";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Total;
        private System.Windows.Forms.Button btn_Detail;
        private System.Windows.Forms.Button btn_Alowcate;
    }
}