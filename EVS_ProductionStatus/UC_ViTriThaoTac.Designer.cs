namespace EVS_ProductionStatus
{
    partial class UC_ViTriThaoTac
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbVitri = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbVitri
            // 
            this.lbVitri.AutoSize = true;
            this.lbVitri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVitri.ForeColor = System.Drawing.Color.Navy;
            this.lbVitri.Location = new System.Drawing.Point(5, 14);
            this.lbVitri.Name = "lbVitri";
            this.lbVitri.Size = new System.Drawing.Size(45, 20);
            this.lbVitri.TabIndex = 0;
            this.lbVitri.Text = "0000";
            // 
            // UC_ViTriThaoTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbVitri);
            this.Name = "UC_ViTriThaoTac";
            this.Size = new System.Drawing.Size(53, 48);
            this.Load += new System.EventHandler(this.UC_ViTriThaoTac_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVitri;
    }
}
