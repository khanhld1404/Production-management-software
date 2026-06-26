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
            this.btn_WIP_Inventory = new System.Windows.Forms.Button();
            this.btn_RM_Inventory = new System.Windows.Forms.Button();
            this.btn_HFG_Inventory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_WIP_Inventory
            // 
            this.btn_WIP_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WIP_Inventory.Image = global::EVS_ProductionStatus.Properties.Resources.anh3;
            this.btn_WIP_Inventory.Location = new System.Drawing.Point(496, 27);
            this.btn_WIP_Inventory.Name = "btn_WIP_Inventory";
            this.btn_WIP_Inventory.Size = new System.Drawing.Size(181, 146);
            this.btn_WIP_Inventory.TabIndex = 3;
            this.btn_WIP_Inventory.Text = "Tồn kho WIP";
            this.btn_WIP_Inventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_WIP_Inventory.UseVisualStyleBackColor = true;
            this.btn_WIP_Inventory.Click += new System.EventHandler(this.btn_WIP_Inventory_Click);
            // 
            // btn_RM_Inventory
            // 
            this.btn_RM_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RM_Inventory.Image = global::EVS_ProductionStatus.Properties.Resources.anh2;
            this.btn_RM_Inventory.Location = new System.Drawing.Point(255, 27);
            this.btn_RM_Inventory.Name = "btn_RM_Inventory";
            this.btn_RM_Inventory.Size = new System.Drawing.Size(181, 146);
            this.btn_RM_Inventory.TabIndex = 2;
            this.btn_RM_Inventory.Text = "Tồn kho RM";
            this.btn_RM_Inventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_RM_Inventory.UseVisualStyleBackColor = true;
            this.btn_RM_Inventory.Click += new System.EventHandler(this.btn_RM_Inventory_Click);
            // 
            // btn_HFG_Inventory
            // 
            this.btn_HFG_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HFG_Inventory.Image = global::EVS_ProductionStatus.Properties.Resources.anh1;
            this.btn_HFG_Inventory.Location = new System.Drawing.Point(21, 27);
            this.btn_HFG_Inventory.Name = "btn_HFG_Inventory";
            this.btn_HFG_Inventory.Size = new System.Drawing.Size(181, 146);
            this.btn_HFG_Inventory.TabIndex = 1;
            this.btn_HFG_Inventory.Text = "Tồn kho HFG";
            this.btn_HFG_Inventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_HFG_Inventory.UseVisualStyleBackColor = true;
            this.btn_HFG_Inventory.Click += new System.EventHandler(this.btn_HFG_Inventory_Click);
            // 
            // EVS_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 204);
            this.Controls.Add(this.btn_WIP_Inventory);
            this.Controls.Add(this.btn_RM_Inventory);
            this.Controls.Add(this.btn_HFG_Inventory);
            this.Name = "EVS_Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu tồn kho";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_HFG_Inventory;
        private System.Windows.Forms.Button btn_RM_Inventory;
        private System.Windows.Forms.Button btn_WIP_Inventory;
    }
}