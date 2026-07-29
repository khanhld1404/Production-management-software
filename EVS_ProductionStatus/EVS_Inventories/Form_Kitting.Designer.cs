using System.Windows.Forms;

namespace EVS_ProductionStatus
{
    partial class Form_Kitting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Txt_NVL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lab_TT_Kitting = new System.Windows.Forms.Label();
            this.Data_Kitting_NVL = new System.Windows.Forms.DataGridView();
            this.Kitting_Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WORK_ORDER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MES_PART = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Kitting_NVL)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Search.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Search.ForeColor = System.Drawing.Color.White;
            this.Btn_Search.Location = new System.Drawing.Point(755, 82);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(104, 37);
            this.Btn_Search.TabIndex = 8;
            this.Btn_Search.Text = "Tìm Kiếm";
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Txt_NVL
            // 
            this.Txt_NVL.Font = new System.Drawing.Font("Arial", 15F);
            this.Txt_NVL.Location = new System.Drawing.Point(29, 83);
            this.Txt_NVL.Name = "Txt_NVL";
            this.Txt_NVL.Size = new System.Drawing.Size(695, 30);
            this.Txt_NVL.TabIndex = 1;
            this.Txt_NVL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_NVL_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Vạch NVL";
            // 
            // Lab_TT_Kitting
            // 
            this.Lab_TT_Kitting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_TT_Kitting.AutoSize = true;
            this.Lab_TT_Kitting.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.Lab_TT_Kitting.Location = new System.Drawing.Point(356, 151);
            this.Lab_TT_Kitting.Name = "Lab_TT_Kitting";
            this.Lab_TT_Kitting.Size = new System.Drawing.Size(262, 27);
            this.Lab_TT_Kitting.TabIndex = 3;
            this.Lab_TT_Kitting.Text = "Thông Tin Kitting NVL";
            // 
            // Data_Kitting_NVL
            // 
            this.Data_Kitting_NVL.AllowUserToAddRows = false;
            this.Data_Kitting_NVL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Data_Kitting_NVL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data_Kitting_NVL.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_Kitting_NVL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Data_Kitting_NVL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Kitting_NVL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kitting_Group,
            this.WORK_ORDER_ID,
            this.MES_PART,
            this.Group_Quantity});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_Kitting_NVL.DefaultCellStyle = dataGridViewCellStyle2;
            this.Data_Kitting_NVL.EnableHeadersVisualStyles = false;
            this.Data_Kitting_NVL.Location = new System.Drawing.Point(29, 214);
            this.Data_Kitting_NVL.Name = "Data_Kitting_NVL";
            this.Data_Kitting_NVL.ReadOnly = true;
            this.Data_Kitting_NVL.RowHeadersVisible = false;
            this.Data_Kitting_NVL.RowTemplate.Height = 30;
            this.Data_Kitting_NVL.Size = new System.Drawing.Size(1052, 508);
            this.Data_Kitting_NVL.TabIndex = 4;
            // 
            // Kitting_Group
            // 
            this.Kitting_Group.HeaderText = "Nhóm Kitting";
            this.Kitting_Group.Name = "Kitting_Group";
            this.Kitting_Group.ReadOnly = true;
            this.Kitting_Group.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // WORK_ORDER_ID
            // 
            this.WORK_ORDER_ID.HeaderText = "Item Wo";
            this.WORK_ORDER_ID.Name = "WORK_ORDER_ID";
            this.WORK_ORDER_ID.ReadOnly = true;
            this.WORK_ORDER_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MES_PART
            // 
            this.MES_PART.HeaderText = "ID Wo";
            this.MES_PART.Name = "MES_PART";
            this.MES_PART.ReadOnly = true;
            this.MES_PART.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Group_Quantity
            // 
            this.Group_Quantity.HeaderText = "Số Lượng Kitting Theo Nhóm";
            this.Group_Quantity.Name = "Group_Quantity";
            this.Group_Quantity.ReadOnly = true;
            this.Group_Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Btn_Excel
            // 
            this.Btn_Excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Excel.BackColor = System.Drawing.Color.Green;
            this.Btn_Excel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Excel.ForeColor = System.Drawing.Color.White;
            this.Btn_Excel.Location = new System.Drawing.Point(977, 728);
            this.Btn_Excel.Name = "Btn_Excel";
            this.Btn_Excel.Size = new System.Drawing.Size(104, 52);
            this.Btn_Excel.TabIndex = 9;
            this.Btn_Excel.Text = " Xuất Excel";
            this.Btn_Excel.UseVisualStyleBackColor = false;
            this.Btn_Excel.Click += new System.EventHandler(this.Btn_Excel_Click);
            // 
            // Form_Kitting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Excel);
            this.Controls.Add(this.Data_Kitting_NVL);
            this.Controls.Add(this.Lab_TT_Kitting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_NVL);
            this.Controls.Add(this.Btn_Search);
            this.Name = "Form_Kitting";
            this.Size = new System.Drawing.Size(1119, 799);
            this.Load += new System.EventHandler(this.Form_Kitting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Kitting_NVL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.TextBox Txt_NVL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lab_TT_Kitting;
        private System.Windows.Forms.DataGridView Data_Kitting_NVL;
        private System.Windows.Forms.Button Btn_Excel;
        private DataGridViewTextBoxColumn Kitting_Group;
        private DataGridViewTextBoxColumn WORK_ORDER_ID;
        private DataGridViewTextBoxColumn MES_PART;
        private DataGridViewTextBoxColumn Group_Quantity;
    }
}
