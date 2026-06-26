namespace EVS_ProductionStatus
{
    partial class Box_Status
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.Box_Data = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_wo_scan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Box_Number = new System.Windows.Forms.TextBox();
            this.lab_emp1 = new System.Windows.Forms.Label();
            this.txt_emp_1 = new System.Windows.Forms.TextBox();
            this.lab_emp2 = new System.Windows.Forms.Label();
            this.txt_emp_2 = new System.Windows.Forms.TextBox();
            this.arrow1 = new System.Windows.Forms.PictureBox();
            this.arrow2 = new System.Windows.Forms.PictureBox();
            this.lab_nv2_error = new System.Windows.Forms.Label();
            this.lab_nv1_error = new System.Windows.Forms.Label();
            this.lab_box_error = new System.Windows.Forms.Label();
            this.Box_Overview = new System.Windows.Forms.DataGridView();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Excel = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Overview)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(457, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Danh sách sản phẩm của thùng";
            // 
            // Box_Data
            // 
            this.Box_Data.AllowUserToAddRows = false;
            this.Box_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Box_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Box_Data.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Box_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Box_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Box_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.WorkOrder,
            this.WO_ID,
            this.ItemNumber,
            this.Result});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Box_Data.DefaultCellStyle = dataGridViewCellStyle5;
            this.Box_Data.EnableHeadersVisualStyles = false;
            this.Box_Data.Location = new System.Drawing.Point(23, 262);
            this.Box_Data.Name = "Box_Data";
            this.Box_Data.ReadOnly = true;
            this.Box_Data.RowHeadersVisible = false;
            this.Box_Data.RowTemplate.Height = 30;
            this.Box_Data.Size = new System.Drawing.Size(1166, 354);
            this.Box_Data.TabIndex = 7;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // WorkOrder
            // 
            this.WorkOrder.HeaderText = "WorkOrder";
            this.WorkOrder.Name = "WorkOrder";
            this.WorkOrder.ReadOnly = true;
            // 
            // WO_ID
            // 
            this.WO_ID.HeaderText = "WO_ID";
            this.WO_ID.Name = "WO_ID";
            this.WO_ID.ReadOnly = true;
            // 
            // ItemNumber
            // 
            this.ItemNumber.HeaderText = "ItemNumber";
            this.ItemNumber.Name = "ItemNumber";
            this.ItemNumber.ReadOnly = true;
            // 
            // Result
            // 
            this.Result.HeaderText = "Kết Quả Quét";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "Mã quét :";
            // 
            // txt_wo_scan
            // 
            this.txt_wo_scan.Enabled = false;
            this.txt_wo_scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_wo_scan.Location = new System.Drawing.Point(101, 64);
            this.txt_wo_scan.Name = "txt_wo_scan";
            this.txt_wo_scan.Size = new System.Drawing.Size(540, 24);
            this.txt_wo_scan.TabIndex = 17;
            this.txt_wo_scan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_wo_scan_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số thùng :";
            // 
            // txt_Box_Number
            // 
            this.txt_Box_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Box_Number.Location = new System.Drawing.Point(153, 122);
            this.txt_Box_Number.Name = "txt_Box_Number";
            this.txt_Box_Number.Size = new System.Drawing.Size(228, 24);
            this.txt_Box_Number.TabIndex = 1;
            this.txt_Box_Number.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Box_Number_KeyDown);
            // 
            // lab_emp1
            // 
            this.lab_emp1.AutoSize = true;
            this.lab_emp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_emp1.Location = new System.Drawing.Point(305, 175);
            this.lab_emp1.Name = "lab_emp1";
            this.lab_emp1.Size = new System.Drawing.Size(124, 20);
            this.lab_emp1.TabIndex = 2;
            this.lab_emp1.Text = "Mã nhân viên 1 :";
            this.lab_emp1.Visible = false;
            // 
            // txt_emp_1
            // 
            this.txt_emp_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emp_1.Location = new System.Drawing.Point(435, 168);
            this.txt_emp_1.Name = "txt_emp_1";
            this.txt_emp_1.Size = new System.Drawing.Size(100, 24);
            this.txt_emp_1.TabIndex = 3;
            this.txt_emp_1.Visible = false;
            this.txt_emp_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_emp_1_KeyDown);
            // 
            // lab_emp2
            // 
            this.lab_emp2.AutoSize = true;
            this.lab_emp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_emp2.Location = new System.Drawing.Point(305, 222);
            this.lab_emp2.Name = "lab_emp2";
            this.lab_emp2.Size = new System.Drawing.Size(124, 20);
            this.lab_emp2.TabIndex = 4;
            this.lab_emp2.Text = "Mã nhân viên 2 :";
            this.lab_emp2.Visible = false;
            // 
            // txt_emp_2
            // 
            this.txt_emp_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emp_2.Location = new System.Drawing.Point(435, 220);
            this.txt_emp_2.Name = "txt_emp_2";
            this.txt_emp_2.Size = new System.Drawing.Size(100, 24);
            this.txt_emp_2.TabIndex = 5;
            this.txt_emp_2.Visible = false;
            this.txt_emp_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_emp_2_KeyDown);
            // 
            // arrow1
            // 
            this.arrow1.Image = global::EVS_ProductionStatus.Properties.Resources.icons8_right_70;
            this.arrow1.Location = new System.Drawing.Point(241, 166);
            this.arrow1.Name = "arrow1";
            this.arrow1.Size = new System.Drawing.Size(48, 41);
            this.arrow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow1.TabIndex = 58;
            this.arrow1.TabStop = false;
            this.arrow1.Visible = false;
            // 
            // arrow2
            // 
            this.arrow2.Image = global::EVS_ProductionStatus.Properties.Resources.icons8_right_70;
            this.arrow2.Location = new System.Drawing.Point(241, 211);
            this.arrow2.Name = "arrow2";
            this.arrow2.Size = new System.Drawing.Size(48, 41);
            this.arrow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow2.TabIndex = 59;
            this.arrow2.TabStop = false;
            this.arrow2.Visible = false;
            // 
            // lab_nv2_error
            // 
            this.lab_nv2_error.AutoSize = true;
            this.lab_nv2_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nv2_error.ForeColor = System.Drawing.Color.Red;
            this.lab_nv2_error.Location = new System.Drawing.Point(555, 226);
            this.lab_nv2_error.Name = "lab_nv2_error";
            this.lab_nv2_error.Size = new System.Drawing.Size(0, 18);
            this.lab_nv2_error.TabIndex = 62;
            // 
            // lab_nv1_error
            // 
            this.lab_nv1_error.AutoSize = true;
            this.lab_nv1_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nv1_error.ForeColor = System.Drawing.Color.Red;
            this.lab_nv1_error.Location = new System.Drawing.Point(555, 171);
            this.lab_nv1_error.Name = "lab_nv1_error";
            this.lab_nv1_error.Size = new System.Drawing.Size(0, 18);
            this.lab_nv1_error.TabIndex = 61;
            // 
            // lab_box_error
            // 
            this.lab_box_error.AutoSize = true;
            this.lab_box_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_box_error.ForeColor = System.Drawing.Color.Red;
            this.lab_box_error.Location = new System.Drawing.Point(398, 128);
            this.lab_box_error.Name = "lab_box_error";
            this.lab_box_error.Size = new System.Drawing.Size(0, 18);
            this.lab_box_error.TabIndex = 60;
            // 
            // Box_Overview
            // 
            this.Box_Overview.AllowUserToAddRows = false;
            this.Box_Overview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Box_Overview.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Box_Overview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Box_Overview.ColumnHeadersVisible = false;
            this.Box_Overview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten,
            this.GiaTri});
            this.Box_Overview.EnableHeadersVisualStyles = false;
            this.Box_Overview.Location = new System.Drawing.Point(852, 32);
            this.Box_Overview.Name = "Box_Overview";
            this.Box_Overview.ReadOnly = true;
            this.Box_Overview.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.Box_Overview.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Box_Overview.RowTemplate.Height = 34;
            this.Box_Overview.Size = new System.Drawing.Size(337, 204);
            this.Box_Overview.TabIndex = 63;
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Ten";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // GiaTri
            // 
            this.GiaTri.HeaderText = "GiaTri";
            this.GiaTri.Name = "GiaTri";
            this.GiaTri.ReadOnly = true;
            // 
            // Btn_Excel
            // 
            this.Btn_Excel.BackColor = System.Drawing.Color.Green;
            this.Btn_Excel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Excel.ForeColor = System.Drawing.Color.White;
            this.Btn_Excel.Location = new System.Drawing.Point(24, 214);
            this.Btn_Excel.Name = "Btn_Excel";
            this.Btn_Excel.Size = new System.Drawing.Size(150, 39);
            this.Btn_Excel.TabIndex = 66;
            this.Btn_Excel.Text = "Xuất Excel";
            this.Btn_Excel.UseVisualStyleBackColor = false;
            this.Btn_Excel.Click += new System.EventHandler(this.Btn_Excel_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.Orange;
            this.btn_stop.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_stop.ForeColor = System.Drawing.Color.White;
            this.btn_stop.Location = new System.Drawing.Point(24, 162);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(150, 39);
            this.btn_stop.TabIndex = 67;
            this.btn_stop.Text = "Dừng Đóng Thùng";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // Box_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 651);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.Btn_Excel);
            this.Controls.Add(this.Box_Overview);
            this.Controls.Add(this.lab_nv2_error);
            this.Controls.Add(this.lab_nv1_error);
            this.Controls.Add(this.lab_box_error);
            this.Controls.Add(this.arrow2);
            this.Controls.Add(this.arrow1);
            this.Controls.Add(this.txt_wo_scan);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Box_Data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_emp_2);
            this.Controls.Add(this.lab_emp2);
            this.Controls.Add(this.txt_emp_1);
            this.Controls.Add(this.lab_emp1);
            this.Controls.Add(this.txt_Box_Number);
            this.Controls.Add(this.label1);
            this.Name = "Box_Status";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Box_Status";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Box_Status_FormClosing);
            this.Load += new System.EventHandler(this.Box_Status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Box_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Overview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Box_Data;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_wo_scan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Box_Number;
        private System.Windows.Forms.Label lab_emp1;
        private System.Windows.Forms.TextBox txt_emp_1;
        private System.Windows.Forms.Label lab_emp2;
        private System.Windows.Forms.TextBox txt_emp_2;
        private System.Windows.Forms.PictureBox arrow1;
        private System.Windows.Forms.PictureBox arrow2;
        private System.Windows.Forms.Label lab_nv2_error;
        private System.Windows.Forms.Label lab_nv1_error;
        private System.Windows.Forms.Label lab_box_error;
        private System.Windows.Forms.DataGridView Box_Overview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn WO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.Button Btn_Excel;
        private System.Windows.Forms.Button btn_stop;
    }
}