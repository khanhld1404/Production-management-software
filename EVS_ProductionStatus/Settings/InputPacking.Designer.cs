namespace EVS_ProductionStatus.Settings
{
    partial class InputPacking
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.grBatDau = new System.Windows.Forms.DataGridView();
            this.WOID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grKetThuc = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.btnKetThucPacking = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grBatDau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grKetThuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 31);
            this.label1.TabIndex = 46;
            this.label1.Text = "NHẬP DỮ LIỆU ĐÓNG GÓI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKetThucPacking);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.grKetThuc);
            this.groupBox1.Controls.Add(this.grBatDau);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbThoiGian);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.lbError);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1245, 554);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quét mã vạch";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(11, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 20);
            this.label16.TabIndex = 52;
            this.label16.Text = "Quét WO";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(94, 54);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(95, 17);
            this.lbError.TabIndex = 13;
            this.lbError.Text = "Thông báo lỗi";
            this.lbError.Visible = false;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(97, 22);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(608, 29);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // grBatDau
            // 
            this.grBatDau.AllowUserToAddRows = false;
            this.grBatDau.AllowUserToDeleteRows = false;
            this.grBatDau.BackgroundColor = System.Drawing.Color.White;
            this.grBatDau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grBatDau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WOID,
            this.workorder,
            this.itemnumber,
            this.lot,
            this.desc1,
            this.desc2,
            this.qty});
            this.grBatDau.Location = new System.Drawing.Point(15, 140);
            this.grBatDau.Name = "grBatDau";
            this.grBatDau.RowHeadersVisible = false;
            this.grBatDau.Size = new System.Drawing.Size(1203, 105);
            this.grBatDau.TabIndex = 53;
            // 
            // WOID
            // 
            this.WOID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WOID.HeaderText = "WOID";
            this.WOID.Name = "WOID";
            // 
            // workorder
            // 
            this.workorder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workorder.HeaderText = "WorkOrder";
            this.workorder.Name = "workorder";
            // 
            // itemnumber
            // 
            this.itemnumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemnumber.HeaderText = "Item Number";
            this.itemnumber.Name = "itemnumber";
            // 
            // lot
            // 
            this.lot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lot.HeaderText = "Lot";
            this.lot.Name = "lot";
            // 
            // desc1
            // 
            this.desc1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desc1.FillWeight = 200F;
            this.desc1.HeaderText = "Description 1";
            this.desc1.Name = "desc1";
            // 
            // desc2
            // 
            this.desc2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desc2.FillWeight = 200F;
            this.desc2.HeaderText = "Description 2";
            this.desc2.Name = "desc2";
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(11, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "WO BẮT ĐẦU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(11, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "WO KẾT THÚC";
            // 
            // grKetThuc
            // 
            this.grKetThuc.AllowUserToAddRows = false;
            this.grKetThuc.AllowUserToDeleteRows = false;
            this.grKetThuc.BackgroundColor = System.Drawing.Color.White;
            this.grKetThuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grKetThuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.grKetThuc.Location = new System.Drawing.Point(15, 282);
            this.grKetThuc.Name = "grKetThuc";
            this.grKetThuc.RowHeadersVisible = false;
            this.grKetThuc.Size = new System.Drawing.Size(1203, 266);
            this.grKetThuc.TabIndex = 53;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "WOID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "WorkOrder";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Item Number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Lot";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.FillWeight = 200F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Description 1";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.FillWeight = 200F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Description 2";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(704, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Thời gian:";
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.AutoSize = true;
            this.lbThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGian.ForeColor = System.Drawing.Color.Red;
            this.lbThoiGian.Location = new System.Drawing.Point(787, 117);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(15, 20);
            this.lbThoiGian.TabIndex = 52;
            this.lbThoiGian.Text = "-";
            // 
            // btnKetThucPacking
            // 
            this.btnKetThucPacking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetThucPacking.ForeColor = System.Drawing.Color.Navy;
            this.btnKetThucPacking.Image = global::EVS_ProductionStatus.Properties.Resources.icons8_complete_32;
            this.btnKetThucPacking.Location = new System.Drawing.Point(1037, 14);
            this.btnKetThucPacking.Name = "btnKetThucPacking";
            this.btnKetThucPacking.Size = new System.Drawing.Size(181, 45);
            this.btnKetThucPacking.TabIndex = 55;
            this.btnKetThucPacking.Text = "Kết thúc packing";
            this.btnKetThucPacking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKetThucPacking.UseVisualStyleBackColor = true;
            this.btnKetThucPacking.Click += new System.EventHandler(this.btnKetThucPacking_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Navy;
            this.btnHuy.Image = global::EVS_ProductionStatus.Properties.Resources.icons8_cancel_32;
            this.btnHuy.Location = new System.Drawing.Point(744, 14);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(153, 45);
            this.btnHuy.TabIndex = 54;
            this.btnHuy.Text = "Hủy dữ liệu quét";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // InputPacking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 651);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "InputPacking";
            this.Text = "Nhập dữ liệu đóng gói";
            this.Load += new System.EventHandler(this.InputPacking_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grBatDau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grKetThuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.DataGridView grKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView grBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn WOID;
        private System.Windows.Forms.DataGridViewTextBoxColumn workorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn lot;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc2;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbThoiGian;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnKetThucPacking;
    }
}