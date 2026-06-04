using System.Drawing;

namespace EVS_ProductionStatus
{
    partial class Elink_NVL
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
        /// </summary/>

        #endregion
        private void InitializeComponent()
        {
            this.lab_item_code = new System.Windows.Forms.Label();
            this.lab_lot = new System.Windows.Forms.Label();
            this.lab_qty = new System.Windows.Forms.Label();
            this.lab_qty_allocate = new System.Windows.Forms.Label();
            this.lab_mac = new System.Windows.Forms.Label();
            this.lab_variant = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.txt_MAC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_card_eink = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Itemcode = new System.Windows.Forms.Label();
            this.txt_Qty = new System.Windows.Forms.Label();
            this.txt_Lotno = new System.Windows.Forms.Label();
            this.txt_Qty_allocate = new System.Windows.Forms.Label();
            this.txt_Variant = new System.Windows.Forms.Label();
            this.btn_un_connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_item_code
            // 
            this.lab_item_code.AutoSize = true;
            this.lab_item_code.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lab_item_code.Location = new System.Drawing.Point(53, 135);
            this.lab_item_code.Name = "lab_item_code";
            this.lab_item_code.Size = new System.Drawing.Size(112, 21);
            this.lab_item_code.TabIndex = 0;
            this.lab_item_code.Text = "Item Code :";
            // 
            // lab_lot
            // 
            this.lab_lot.AutoSize = true;
            this.lab_lot.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lab_lot.Location = new System.Drawing.Point(488, 135);
            this.lab_lot.Name = "lab_lot";
            this.lab_lot.Size = new System.Drawing.Size(79, 21);
            this.lab_lot.TabIndex = 1;
            this.lab_lot.Text = "Lot No :";
            // 
            // lab_qty
            // 
            this.lab_qty.AutoSize = true;
            this.lab_qty.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lab_qty.Location = new System.Drawing.Point(53, 192);
            this.lab_qty.Name = "lab_qty";
            this.lab_qty.Size = new System.Drawing.Size(55, 21);
            this.lab_qty.TabIndex = 2;
            this.lab_qty.Text = "Tồn :";
            // 
            // lab_qty_allocate
            // 
            this.lab_qty_allocate.AutoSize = true;
            this.lab_qty_allocate.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lab_qty_allocate.Location = new System.Drawing.Point(488, 192);
            this.lab_qty_allocate.Name = "lab_qty_allocate";
            this.lab_qty_allocate.Size = new System.Drawing.Size(108, 21);
            this.lab_qty_allocate.TabIndex = 3;
            this.lab_qty_allocate.Text = "Allowcate :";
            // 
            // lab_mac
            // 
            this.lab_mac.AutoSize = true;
            this.lab_mac.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lab_mac.Location = new System.Drawing.Point(53, 319);
            this.lab_mac.Name = "lab_mac";
            this.lab_mac.Size = new System.Drawing.Size(63, 21);
            this.lab_mac.TabIndex = 4;
            this.lab_mac.Text = "MAC :";
            // 
            // lab_variant
            // 
            this.lab_variant.AutoSize = true;
            this.lab_variant.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.lab_variant.Location = new System.Drawing.Point(53, 374);
            this.lab_variant.Name = "lab_variant";
            this.lab_variant.Size = new System.Drawing.Size(83, 21);
            this.lab_variant.TabIndex = 5;
            this.lab_variant.Text = "Variant :";
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_connect.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_connect.ForeColor = System.Drawing.Color.Transparent;
            this.btn_connect.Location = new System.Drawing.Point(585, 429);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(110, 51);
            this.btn_connect.TabIndex = 6;
            this.btn_connect.Text = "Kết Nối";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // txt_MAC
            // 
            this.txt_MAC.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.txt_MAC.Location = new System.Drawing.Point(124, 310);
            this.txt_MAC.Name = "txt_MAC";
            this.txt_MAC.Size = new System.Drawing.Size(698, 29);
            this.txt_MAC.TabIndex = 10;
            this.txt_MAC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_get_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(299, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Thông Tin Đăng Ký NVL Lên Thẻ Eink";
            // 
            // lab_card_eink
            // 
            this.lab_card_eink.AutoSize = true;
            this.lab_card_eink.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lab_card_eink.Location = new System.Drawing.Point(53, 261);
            this.lab_card_eink.Name = "lab_card_eink";
            this.lab_card_eink.Size = new System.Drawing.Size(121, 22);
            this.lab_card_eink.TabIndex = 15;
            this.lab_card_eink.Text = "Quét mã thẻ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(53, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Thông tin sản phẩm";
            // 
            // txt_Itemcode
            // 
            this.txt_Itemcode.AutoSize = true;
            this.txt_Itemcode.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.txt_Itemcode.Location = new System.Drawing.Point(181, 135);
            this.txt_Itemcode.Name = "txt_Itemcode";
            this.txt_Itemcode.Size = new System.Drawing.Size(0, 21);
            this.txt_Itemcode.TabIndex = 17;
            // 
            // txt_Qty
            // 
            this.txt_Qty.AutoSize = true;
            this.txt_Qty.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.txt_Qty.Location = new System.Drawing.Point(181, 192);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(0, 21);
            this.txt_Qty.TabIndex = 18;
            // 
            // txt_Lotno
            // 
            this.txt_Lotno.AutoSize = true;
            this.txt_Lotno.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.txt_Lotno.Location = new System.Drawing.Point(629, 135);
            this.txt_Lotno.Name = "txt_Lotno";
            this.txt_Lotno.Size = new System.Drawing.Size(0, 21);
            this.txt_Lotno.TabIndex = 19;
            // 
            // txt_Qty_allocate
            // 
            this.txt_Qty_allocate.AutoSize = true;
            this.txt_Qty_allocate.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.txt_Qty_allocate.Location = new System.Drawing.Point(629, 192);
            this.txt_Qty_allocate.Name = "txt_Qty_allocate";
            this.txt_Qty_allocate.Size = new System.Drawing.Size(0, 21);
            this.txt_Qty_allocate.TabIndex = 20;
            // 
            // txt_Variant
            // 
            this.txt_Variant.AutoSize = true;
            this.txt_Variant.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.txt_Variant.Location = new System.Drawing.Point(152, 374);
            this.txt_Variant.Name = "txt_Variant";
            this.txt_Variant.Size = new System.Drawing.Size(0, 21);
            this.txt_Variant.TabIndex = 21;
            // 
            // btn_un_connect
            // 
            this.btn_un_connect.BackColor = System.Drawing.Color.Red;
            this.btn_un_connect.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_un_connect.ForeColor = System.Drawing.Color.Transparent;
            this.btn_un_connect.Location = new System.Drawing.Point(712, 429);
            this.btn_un_connect.Name = "btn_un_connect";
            this.btn_un_connect.Size = new System.Drawing.Size(110, 51);
            this.btn_un_connect.TabIndex = 22;
            this.btn_un_connect.Text = "Hủy Kết Nối";
            this.btn_un_connect.UseVisualStyleBackColor = false;
            this.btn_un_connect.Click += new System.EventHandler(this.btn_un_connect_Click);
            // 
            // Elink_NVL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 549);
            this.Controls.Add(this.btn_un_connect);
            this.Controls.Add(this.txt_Variant);
            this.Controls.Add(this.txt_Qty_allocate);
            this.Controls.Add(this.txt_Lotno);
            this.Controls.Add(this.txt_Qty);
            this.Controls.Add(this.txt_Itemcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lab_card_eink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MAC);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.lab_variant);
            this.Controls.Add(this.lab_mac);
            this.Controls.Add(this.lab_qty_allocate);
            this.Controls.Add(this.lab_qty);
            this.Controls.Add(this.lab_lot);
            this.Controls.Add(this.lab_item_code);
            this.Name = "Elink_NVL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin thẻ Elink";
            this.Load += new System.EventHandler(this.Elink_NVL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lab_item_code;
        private System.Windows.Forms.Label lab_lot;
        private System.Windows.Forms.Label lab_qty;
        private System.Windows.Forms.Label lab_qty_allocate;
        private System.Windows.Forms.Label lab_mac;
        private System.Windows.Forms.Label lab_variant;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox txt_MAC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_card_eink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_Itemcode;
        private System.Windows.Forms.Label txt_Qty;
        private System.Windows.Forms.Label txt_Lotno;
        private System.Windows.Forms.Label txt_Qty_allocate;
        private System.Windows.Forms.Label txt_Variant;
        private System.Windows.Forms.Button btn_un_connect;
    }
}