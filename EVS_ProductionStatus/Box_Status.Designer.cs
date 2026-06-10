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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Box_Number = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Box_Data = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lab_total_box = new System.Windows.Forms.Label();
            this.lab_total_ok = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lab_total_ng = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lab_Box = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_wo_scan = new System.Windows.Forms.TextBox();
            this.lab_emp1 = new System.Windows.Forms.Label();
            this.txt_emp_1 = new System.Windows.Forms.TextBox();
            this.lab_emp2 = new System.Windows.Forms.Label();
            this.txt_emp_2 = new System.Windows.Forms.TextBox();
            this.arrow1 = new System.Windows.Forms.PictureBox();
            this.arrow2 = new System.Windows.Forms.PictureBox();
            this.lab_box_error = new System.Windows.Forms.Label();
            this.lab_nv1_error = new System.Windows.Forms.Label();
            this.lab_nv2_error = new System.Windows.Forms.Label();
            this.lab_code_error = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số thùng :";
            // 
            // txt_Box_Number
            // 
            this.txt_Box_Number.Location = new System.Drawing.Point(146, 77);
            this.txt_Box_Number.Name = "txt_Box_Number";
            this.txt_Box_Number.Size = new System.Drawing.Size(194, 20);
            this.txt_Box_Number.TabIndex = 1;
            this.txt_Box_Number.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Box_Number_KeyDown);
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
            this.Box_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Box_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Box_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Box_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.WorkOrder,
            this.WO_ID,
            this.ItemNumber,
            this.Result});
            this.Box_Data.Location = new System.Drawing.Point(23, 262);
            this.Box_Data.Name = "Box_Data";
            this.Box_Data.Size = new System.Drawing.Size(1166, 354);
            this.Box_Data.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(868, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số lượng OK :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(868, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số lượng trong thùng :";
            // 
            // lab_total_box
            // 
            this.lab_total_box.AutoSize = true;
            this.lab_total_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_total_box.Location = new System.Drawing.Point(1052, 55);
            this.lab_total_box.Name = "lab_total_box";
            this.lab_total_box.Size = new System.Drawing.Size(0, 20);
            this.lab_total_box.TabIndex = 10;
            // 
            // lab_total_ok
            // 
            this.lab_total_ok.AutoSize = true;
            this.lab_total_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_total_ok.Location = new System.Drawing.Point(1052, 114);
            this.lab_total_ok.Name = "lab_total_ok";
            this.lab_total_ok.Size = new System.Drawing.Size(0, 20);
            this.lab_total_ok.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(868, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Số lượng chưa OK :";
            // 
            // lab_total_ng
            // 
            this.lab_total_ng.AutoSize = true;
            this.lab_total_ng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_total_ng.Location = new System.Drawing.Point(1052, 161);
            this.lab_total_ng.Name = "lab_total_ng";
            this.lab_total_ng.Size = new System.Drawing.Size(0, 20);
            this.lab_total_ng.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Số thùng :";
            // 
            // lab_Box
            // 
            this.lab_Box.AutoSize = true;
            this.lab_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Box.Location = new System.Drawing.Point(107, 214);
            this.lab_Box.Name = "lab_Box";
            this.lab_Box.Size = new System.Drawing.Size(0, 20);
            this.lab_Box.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "Mã quét :";
            // 
            // txt_wo_scan
            // 
            this.txt_wo_scan.Enabled = false;
            this.txt_wo_scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_wo_scan.Location = new System.Drawing.Point(111, 158);
            this.txt_wo_scan.Name = "txt_wo_scan";
            this.txt_wo_scan.Size = new System.Drawing.Size(529, 26);
            this.txt_wo_scan.TabIndex = 17;
            this.txt_wo_scan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_wo_scan_KeyDown);
            // 
            // lab_emp1
            // 
            this.lab_emp1.AutoSize = true;
            this.lab_emp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_emp1.Location = new System.Drawing.Point(410, 77);
            this.lab_emp1.Name = "lab_emp1";
            this.lab_emp1.Size = new System.Drawing.Size(124, 20);
            this.lab_emp1.TabIndex = 2;
            this.lab_emp1.Text = "Mã nhân viên 1 :";
            this.lab_emp1.Visible = false;
            // 
            // txt_emp_1
            // 
            this.txt_emp_1.Location = new System.Drawing.Point(540, 77);
            this.txt_emp_1.Name = "txt_emp_1";
            this.txt_emp_1.Size = new System.Drawing.Size(100, 20);
            this.txt_emp_1.TabIndex = 3;
            this.txt_emp_1.Visible = false;
            this.txt_emp_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_emp_1_KeyDown);
            // 
            // lab_emp2
            // 
            this.lab_emp2.AutoSize = true;
            this.lab_emp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_emp2.Location = new System.Drawing.Point(410, 124);
            this.lab_emp2.Name = "lab_emp2";
            this.lab_emp2.Size = new System.Drawing.Size(124, 20);
            this.lab_emp2.TabIndex = 4;
            this.lab_emp2.Text = "Mã nhân viên 2 :";
            this.lab_emp2.Visible = false;
            // 
            // txt_emp_2
            // 
            this.txt_emp_2.Location = new System.Drawing.Point(540, 124);
            this.txt_emp_2.Name = "txt_emp_2";
            this.txt_emp_2.Size = new System.Drawing.Size(100, 20);
            this.txt_emp_2.TabIndex = 5;
            this.txt_emp_2.Visible = false;
            this.txt_emp_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_emp_2_KeyDown);
            // 
            // arrow1
            // 
            this.arrow1.Image = global::EVS_ProductionStatus.Properties.Resources.icons8_right_70;
            this.arrow1.Location = new System.Drawing.Point(346, 68);
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
            this.arrow2.Location = new System.Drawing.Point(346, 113);
            this.arrow2.Name = "arrow2";
            this.arrow2.Size = new System.Drawing.Size(48, 41);
            this.arrow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow2.TabIndex = 59;
            this.arrow2.TabStop = false;
            this.arrow2.Visible = false;
            // 
            // lab_box_error
            // 
            this.lab_box_error.AutoSize = true;
            this.lab_box_error.ForeColor = System.Drawing.Color.Red;
            this.lab_box_error.Location = new System.Drawing.Point(146, 113);
            this.lab_box_error.Name = "lab_box_error";
            this.lab_box_error.Size = new System.Drawing.Size(0, 13);
            this.lab_box_error.TabIndex = 60;
            // 
            // lab_nv1_error
            // 
            this.lab_nv1_error.AutoSize = true;
            this.lab_nv1_error.ForeColor = System.Drawing.Color.Red;
            this.lab_nv1_error.Location = new System.Drawing.Point(657, 83);
            this.lab_nv1_error.Name = "lab_nv1_error";
            this.lab_nv1_error.Size = new System.Drawing.Size(0, 13);
            this.lab_nv1_error.TabIndex = 61;
            // 
            // lab_nv2_error
            // 
            this.lab_nv2_error.AutoSize = true;
            this.lab_nv2_error.ForeColor = System.Drawing.Color.Red;
            this.lab_nv2_error.Location = new System.Drawing.Point(660, 130);
            this.lab_nv2_error.Name = "lab_nv2_error";
            this.lab_nv2_error.Size = new System.Drawing.Size(0, 13);
            this.lab_nv2_error.TabIndex = 62;
            // 
            // lab_code_error
            // 
            this.lab_code_error.AutoSize = true;
            this.lab_code_error.ForeColor = System.Drawing.Color.Red;
            this.lab_code_error.Location = new System.Drawing.Point(660, 170);
            this.lab_code_error.Name = "lab_code_error";
            this.lab_code_error.Size = new System.Drawing.Size(0, 13);
            this.lab_code_error.TabIndex = 63;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // WorkOrder
            // 
            this.WorkOrder.HeaderText = "WorkOrder";
            this.WorkOrder.Name = "WorkOrder";
            // 
            // WO_ID
            // 
            this.WO_ID.HeaderText = "WO_ID";
            this.WO_ID.Name = "WO_ID";
            // 
            // ItemNumber
            // 
            this.ItemNumber.HeaderText = "ItemNumber";
            this.ItemNumber.Name = "ItemNumber";
            // 
            // Result
            // 
            this.Result.HeaderText = "Kết quả OK";
            this.Result.Name = "Result";
            // 
            // Box_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 651);
            this.Controls.Add(this.lab_code_error);
            this.Controls.Add(this.lab_nv2_error);
            this.Controls.Add(this.lab_nv1_error);
            this.Controls.Add(this.lab_box_error);
            this.Controls.Add(this.arrow2);
            this.Controls.Add(this.arrow1);
            this.Controls.Add(this.txt_wo_scan);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lab_Box);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lab_total_ng);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lab_total_ok);
            this.Controls.Add(this.lab_total_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
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
            this.Load += new System.EventHandler(this.Box_Status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Box_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Box_Number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Box_Data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lab_total_box;
        private System.Windows.Forms.Label lab_total_ok;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lab_total_ng;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lab_Box;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_wo_scan;
        private System.Windows.Forms.Label lab_emp1;
        private System.Windows.Forms.TextBox txt_emp_1;
        private System.Windows.Forms.Label lab_emp2;
        private System.Windows.Forms.TextBox txt_emp_2;
        private System.Windows.Forms.PictureBox arrow1;
        private System.Windows.Forms.PictureBox arrow2;
        private System.Windows.Forms.Label lab_box_error;
        private System.Windows.Forms.Label lab_nv1_error;
        private System.Windows.Forms.Label lab_nv2_error;
        private System.Windows.Forms.Label lab_code_error;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn WO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
    }
}