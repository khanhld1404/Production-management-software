namespace EVS_ProductionStatus.EVS_Inventories.Model
{
    partial class Main_EVS_Alowcate
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
            this.Menu_EVS_Total_Detail = new System.Windows.Forms.ToolStrip();
            this.TSX = new System.Windows.Forms.ToolStripDropDownButton();
            this.TSX_RM_WIP = new System.Windows.Forms.ToolStripMenuItem();
            this.TSX_HFG = new System.Windows.Forms.ToolStripMenuItem();
            this.NSX = new System.Windows.Forms.ToolStripButton();
            this.KSX = new System.Windows.Forms.ToolStripButton();
            this.Infor_Panel = new System.Windows.Forms.Panel();
            this.Menu_EVS_Total_Detail.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_EVS_Total_Detail
            // 
            this.Menu_EVS_Total_Detail.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Menu_EVS_Total_Detail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_EVS_Total_Detail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSX,
            this.NSX,
            this.KSX});
            this.Menu_EVS_Total_Detail.Location = new System.Drawing.Point(0, 0);
            this.Menu_EVS_Total_Detail.Name = "Menu_EVS_Total_Detail";
            this.Menu_EVS_Total_Detail.Padding = new System.Windows.Forms.Padding(0);
            this.Menu_EVS_Total_Detail.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menu_EVS_Total_Detail.Size = new System.Drawing.Size(1231, 32);
            this.Menu_EVS_Total_Detail.TabIndex = 28;
            this.Menu_EVS_Total_Detail.Text = "toolStrip1";
            // 
            // TSX
            // 
            this.TSX.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSX_RM_WIP,
            this.TSX_HFG});
            this.TSX.Image = global::EVS_ProductionStatus.Properties.Resources.icons8_production_machine_70;
            this.TSX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSX.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.TSX.Name = "TSX";
            this.TSX.Size = new System.Drawing.Size(29, 32);
            this.TSX.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.TSX_DropDownItemClicked);
            // 
            // TSX_RM_WIP
            // 
            this.TSX_RM_WIP.Name = "TSX_RM_WIP";
            this.TSX_RM_WIP.Size = new System.Drawing.Size(254, 22);
            this.TSX_RM_WIP.Text = "Trong Sản Xuất (RM WIP)";
            // 
            // TSX_HFG
            // 
            this.TSX_HFG.Name = "TSX_HFG";
            this.TSX_HFG.Size = new System.Drawing.Size(254, 22);
            this.TSX_HFG.Text = "Trong Sản Xuất (HFG)";
            // 
            // NSX
            // 
            this.NSX.Image = global::EVS_ProductionStatus.Properties.Resources.icons8_resend_production_order_70;
            this.NSX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NSX.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.NSX.Name = "NSX";
            this.NSX.Padding = new System.Windows.Forms.Padding(10, 5, 20, 5);
            this.NSX.Size = new System.Drawing.Size(166, 32);
            this.NSX.Text = "Ngoài Sản Xuất";
            this.NSX.Click += new System.EventHandler(this.NSX_Click);
            // 
            // KSX
            // 
            this.KSX.Image = global::EVS_ProductionStatus.Properties.Resources.icons8_delete_production_order_70;
            this.KSX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.KSX.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.KSX.Name = "KSX";
            this.KSX.Size = new System.Drawing.Size(142, 32);
            this.KSX.Text = "Không Sản Xuất";
            this.KSX.Click += new System.EventHandler(this.KSX_Click);
            // 
            // Infor_Panel
            // 
            this.Infor_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Infor_Panel.Location = new System.Drawing.Point(0, 35);
            this.Infor_Panel.Name = "Infor_Panel";
            this.Infor_Panel.Size = new System.Drawing.Size(1231, 714);
            this.Infor_Panel.TabIndex = 29;
            // 
            // Main_EVS_Alowcate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 751);
            this.Controls.Add(this.Infor_Panel);
            this.Controls.Add(this.Menu_EVS_Total_Detail);
            this.Name = "Main_EVS_Alowcate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Main_EVS_Alowcate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_EVS_Alowcate_Load);
            this.Menu_EVS_Total_Detail.ResumeLayout(false);
            this.Menu_EVS_Total_Detail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu_EVS_Total_Detail;
        private System.Windows.Forms.ToolStripButton NSX;
        private System.Windows.Forms.Panel Infor_Panel;
        private System.Windows.Forms.ToolStripButton KSX;
        private System.Windows.Forms.ToolStripDropDownButton TSX;
        private System.Windows.Forms.ToolStripMenuItem TSX_RM_WIP;
        private System.Windows.Forms.ToolStripMenuItem TSX_HFG;
    }
}