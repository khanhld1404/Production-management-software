namespace EVS_ProductionStatus.Kitting_Process
{
    partial class Kitting_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblItemValue;
        private System.Windows.Forms.Label lblKittingConcurrent;
        private System.Windows.Forms.Label lblKittingConcurrentValue;

        private System.Windows.Forms.Label lblEmpCode;
        private System.Windows.Forms.Label lblEmpCodeValue;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblEmpNameValue;

        private System.Windows.Forms.Panel pnlBarcode;
        private System.Windows.Forms.Label lblBarcodeTitle;
        private System.Windows.Forms.TextBox txtBarcode;

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblKittingTitle;
        private System.Windows.Forms.DataGridView dgvKitting;

        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrawing;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlNotKittingTitle;
        private System.Windows.Forms.Label lblNotKittingTitle;
        private System.Windows.Forms.Panel pnlNotKittingValue;
        private System.Windows.Forms.Label lblNotKittingValue;

        private System.Windows.Forms.Panel pnlWoKittingTitle;
        private System.Windows.Forms.Label lblWoKittingTitle;
        private System.Windows.Forms.Panel pnlWoKittingValue;
        private System.Windows.Forms.Label lblWoKittingValue;

        private System.Windows.Forms.Button btnConfirm;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed, otherwise false.</param>
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
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblItemValue = new System.Windows.Forms.Label();
            this.lblKittingConcurrent = new System.Windows.Forms.Label();
            this.lblKittingConcurrentValue = new System.Windows.Forms.Label();
            this.lblEmpCode = new System.Windows.Forms.Label();
            this.lblEmpCodeValue = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblEmpNameValue = new System.Windows.Forms.Label();
            this.pnlBarcode = new System.Windows.Forms.Panel();
            this.lblBarcodeTitle = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblKittingTitle = new System.Windows.Forms.Label();
            this.dgvKitting = new System.Windows.Forms.DataGridView();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDrawing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlNotKittingTitle = new System.Windows.Forms.Panel();
            this.lblNotKittingTitle = new System.Windows.Forms.Label();
            this.pnlNotKittingValue = new System.Windows.Forms.Panel();
            this.lblNotKittingValue = new System.Windows.Forms.Label();
            this.pnlWoKittingTitle = new System.Windows.Forms.Panel();
            this.lblWoKittingTitle = new System.Windows.Forms.Label();
            this.pnlWoKittingValue = new System.Windows.Forms.Panel();
            this.lblWoKittingValue = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlBarcode.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitting)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.pnlNotKittingTitle.SuspendLayout();
            this.pnlNotKittingValue.SuspendLayout();
            this.pnlWoKittingTitle.SuspendLayout();
            this.pnlWoKittingValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblItem);
            this.pnlHeader.Controls.Add(this.lblItemValue);
            this.pnlHeader.Controls.Add(this.lblKittingConcurrent);
            this.pnlHeader.Controls.Add(this.lblKittingConcurrentValue);
            this.pnlHeader.Controls.Add(this.lblEmpCode);
            this.pnlHeader.Controls.Add(this.lblEmpCodeValue);
            this.pnlHeader.Controls.Add(this.lblEmpName);
            this.pnlHeader.Controls.Add(this.lblEmpNameValue);
            this.pnlHeader.Location = new System.Drawing.Point(10, 10);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1080, 129);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(-1, -1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(1080, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Màn Hình Kitting";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItem
            // 
            this.lblItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblItem.ForeColor = System.Drawing.Color.White;
            this.lblItem.Location = new System.Drawing.Point(15, 55);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(150, 25);
            this.lblItem.TabIndex = 1;
            this.lblItem.Text = "Item                          :";
            this.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItemValue
            // 
            this.lblItemValue.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblItemValue.ForeColor = System.Drawing.Color.White;
            this.lblItemValue.Location = new System.Drawing.Point(170, 55);
            this.lblItemValue.Name = "lblItemValue";
            this.lblItemValue.Size = new System.Drawing.Size(300, 25);
            this.lblItemValue.TabIndex = 2;
            this.lblItemValue.Text = "28-33-0651-03";
            this.lblItemValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKittingConcurrent
            // 
            this.lblKittingConcurrent.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblKittingConcurrent.ForeColor = System.Drawing.Color.White;
            this.lblKittingConcurrent.Location = new System.Drawing.Point(15, 92);
            this.lblKittingConcurrent.Name = "lblKittingConcurrent";
            this.lblKittingConcurrent.Size = new System.Drawing.Size(150, 25);
            this.lblKittingConcurrent.TabIndex = 3;
            this.lblKittingConcurrent.Text = "Kitting đồng thời     : ";
            this.lblKittingConcurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKittingConcurrentValue
            // 
            this.lblKittingConcurrentValue.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblKittingConcurrentValue.ForeColor = System.Drawing.Color.White;
            this.lblKittingConcurrentValue.Location = new System.Drawing.Point(170, 92);
            this.lblKittingConcurrentValue.Name = "lblKittingConcurrentValue";
            this.lblKittingConcurrentValue.Size = new System.Drawing.Size(300, 25);
            this.lblKittingConcurrentValue.TabIndex = 4;
            this.lblKittingConcurrentValue.Text = "5";
            this.lblKittingConcurrentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmpCode
            // 
            this.lblEmpCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpCode.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEmpCode.ForeColor = System.Drawing.Color.White;
            this.lblEmpCode.Location = new System.Drawing.Point(540, 37);
            this.lblEmpCode.Name = "lblEmpCode";
            this.lblEmpCode.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblEmpCode.Size = new System.Drawing.Size(170, 46);
            this.lblEmpCode.TabIndex = 5;
            this.lblEmpCode.Text = "Mã nhân viên";
            this.lblEmpCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmpCodeValue
            // 
            this.lblEmpCodeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpCodeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpCodeValue.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEmpCodeValue.ForeColor = System.Drawing.Color.White;
            this.lblEmpCodeValue.Location = new System.Drawing.Point(710, 37);
            this.lblEmpCodeValue.Name = "lblEmpCodeValue";
            this.lblEmpCodeValue.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblEmpCodeValue.Size = new System.Drawing.Size(368, 46);
            this.lblEmpCodeValue.TabIndex = 6;
            this.lblEmpCodeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmpName
            // 
            this.lblEmpName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEmpName.ForeColor = System.Drawing.Color.White;
            this.lblEmpName.Location = new System.Drawing.Point(540, 83);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblEmpName.Size = new System.Drawing.Size(170, 46);
            this.lblEmpName.TabIndex = 7;
            this.lblEmpName.Text = "Tên nhân viên";
            this.lblEmpName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmpNameValue
            // 
            this.lblEmpNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpNameValue.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEmpNameValue.ForeColor = System.Drawing.Color.White;
            this.lblEmpNameValue.Location = new System.Drawing.Point(710, 83);
            this.lblEmpNameValue.Name = "lblEmpNameValue";
            this.lblEmpNameValue.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblEmpNameValue.Size = new System.Drawing.Size(368, 46);
            this.lblEmpNameValue.TabIndex = 8;
            this.lblEmpNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBarcode
            // 
            this.pnlBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBarcode.BackColor = System.Drawing.Color.White;
            this.pnlBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBarcode.Controls.Add(this.lblBarcodeTitle);
            this.pnlBarcode.Controls.Add(this.txtBarcode);
            this.pnlBarcode.Location = new System.Drawing.Point(10, 145);
            this.pnlBarcode.Name = "pnlBarcode";
            this.pnlBarcode.Size = new System.Drawing.Size(1080, 90);
            this.pnlBarcode.TabIndex = 1;
            // 
            // lblBarcodeTitle
            // 
            this.lblBarcodeTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBarcodeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.lblBarcodeTitle.Location = new System.Drawing.Point(15, 8);
            this.lblBarcodeTitle.Name = "lblBarcodeTitle";
            this.lblBarcodeTitle.Size = new System.Drawing.Size(180, 25);
            this.lblBarcodeTitle.TabIndex = 0;
            this.lblBarcodeTitle.Text = "Đọc mã vạch";
            this.lblBarcodeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtBarcode.Location = new System.Drawing.Point(35, 42);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(1010, 32);
            this.txtBarcode.TabIndex = 1;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.lblKittingTitle);
            this.pnlMain.Controls.Add(this.dgvKitting);
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Location = new System.Drawing.Point(10, 245);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1080, 394);
            this.pnlMain.TabIndex = 2;
            // 
            // lblKittingTitle
            // 
            this.lblKittingTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKittingTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblKittingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.lblKittingTitle.Location = new System.Drawing.Point(12, 4);
            this.lblKittingTitle.Name = "lblKittingTitle";
            this.lblKittingTitle.Size = new System.Drawing.Size(1050, 32);
            this.lblKittingTitle.TabIndex = 0;
            this.lblKittingTitle.Text = "Kitting";
            this.lblKittingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvKitting
            // 
            this.dgvKitting.AllowUserToAddRows = false;
            this.dgvKitting.AllowUserToDeleteRows = false;
            this.dgvKitting.AllowUserToResizeColumns = false;
            this.dgvKitting.AllowUserToResizeRows = false;
            this.dgvKitting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKitting.BackgroundColor = System.Drawing.Color.White;
            this.dgvKitting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKitting.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(201)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(201)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvKitting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKitting.ColumnHeadersHeight = 45;
            this.dgvKitting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKitting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colId,
            this.colDrawing,
            this.colStatus});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKitting.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvKitting.EnableHeadersVisualStyles = false;
            this.dgvKitting.GridColor = System.Drawing.Color.Silver;
            this.dgvKitting.Location = new System.Drawing.Point(0, 38);
            this.dgvKitting.MultiSelect = false;
            this.dgvKitting.Name = "dgvKitting";
            this.dgvKitting.ReadOnly = true;
            this.dgvKitting.RowHeadersVisible = false;
            this.dgvKitting.RowTemplate.Height = 34;
            this.dgvKitting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvKitting.Size = new System.Drawing.Size(1078, 279);
            this.dgvKitting.TabIndex = 1;
            // 
            // colItem
            // 
            this.colItem.HeaderText = "Item";
            this.colItem.Name = "colItem";
            this.colItem.ReadOnly = true;
            this.colItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colItem.Width = 310;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colId.Width = 270;
            // 
            // colDrawing
            // 
            this.colDrawing.HeaderText = "Mã bản vẽ";
            this.colDrawing.Name = "colDrawing";
            this.colDrawing.ReadOnly = true;
            this.colDrawing.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDrawing.Width = 320;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.colStatus.DefaultCellStyle = dataGridViewCellStyle5;
            this.colStatus.HeaderText = "Trạng thái";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFooter.Controls.Add(this.pnlNotKittingTitle);
            this.pnlFooter.Controls.Add(this.pnlNotKittingValue);
            this.pnlFooter.Controls.Add(this.pnlWoKittingTitle);
            this.pnlFooter.Controls.Add(this.pnlWoKittingValue);
            this.pnlFooter.Controls.Add(this.btnConfirm);
            this.pnlFooter.Location = new System.Drawing.Point(0, 319);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1078, 74);
            this.pnlFooter.TabIndex = 2;
            // 
            // pnlNotKittingTitle
            // 
            this.pnlNotKittingTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.pnlNotKittingTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNotKittingTitle.Controls.Add(this.lblNotKittingTitle);
            this.pnlNotKittingTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlNotKittingTitle.Name = "pnlNotKittingTitle";
            this.pnlNotKittingTitle.Size = new System.Drawing.Size(170, 70);
            this.pnlNotKittingTitle.TabIndex = 0;
            // 
            // lblNotKittingTitle
            // 
            this.lblNotKittingTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNotKittingTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNotKittingTitle.ForeColor = System.Drawing.Color.White;
            this.lblNotKittingTitle.Location = new System.Drawing.Point(0, 0);
            this.lblNotKittingTitle.Name = "lblNotKittingTitle";
            this.lblNotKittingTitle.Size = new System.Drawing.Size(168, 68);
            this.lblNotKittingTitle.TabIndex = 0;
            this.lblNotKittingTitle.Text = "Số lượng\r\nchưa kitting";
            this.lblNotKittingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlNotKittingValue
            // 
            this.pnlNotKittingValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(96)))));
            this.pnlNotKittingValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNotKittingValue.Controls.Add(this.lblNotKittingValue);
            this.pnlNotKittingValue.Location = new System.Drawing.Point(170, 0);
            this.pnlNotKittingValue.Name = "pnlNotKittingValue";
            this.pnlNotKittingValue.Size = new System.Drawing.Size(110, 70);
            this.pnlNotKittingValue.TabIndex = 1;
            // 
            // lblNotKittingValue
            // 
            this.lblNotKittingValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNotKittingValue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblNotKittingValue.ForeColor = System.Drawing.Color.White;
            this.lblNotKittingValue.Location = new System.Drawing.Point(0, 0);
            this.lblNotKittingValue.Name = "lblNotKittingValue";
            this.lblNotKittingValue.Size = new System.Drawing.Size(108, 68);
            this.lblNotKittingValue.TabIndex = 0;
            this.lblNotKittingValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlWoKittingTitle
            // 
            this.pnlWoKittingTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(221)))), ((int)(((byte)(145)))));
            this.pnlWoKittingTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWoKittingTitle.Controls.Add(this.lblWoKittingTitle);
            this.pnlWoKittingTitle.Location = new System.Drawing.Point(280, 0);
            this.pnlWoKittingTitle.Name = "pnlWoKittingTitle";
            this.pnlWoKittingTitle.Size = new System.Drawing.Size(210, 70);
            this.pnlWoKittingTitle.TabIndex = 2;
            // 
            // lblWoKittingTitle
            // 
            this.lblWoKittingTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWoKittingTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblWoKittingTitle.ForeColor = System.Drawing.Color.Black;
            this.lblWoKittingTitle.Location = new System.Drawing.Point(0, 0);
            this.lblWoKittingTitle.Name = "lblWoKittingTitle";
            this.lblWoKittingTitle.Size = new System.Drawing.Size(208, 68);
            this.lblWoKittingTitle.TabIndex = 0;
            this.lblWoKittingTitle.Text = "Số lượng WO\r\nkitting";
            this.lblWoKittingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlWoKittingValue
            // 
            this.pnlWoKittingValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(221)))), ((int)(((byte)(145)))));
            this.pnlWoKittingValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWoKittingValue.Controls.Add(this.lblWoKittingValue);
            this.pnlWoKittingValue.Location = new System.Drawing.Point(490, 0);
            this.pnlWoKittingValue.Name = "pnlWoKittingValue";
            this.pnlWoKittingValue.Size = new System.Drawing.Size(120, 70);
            this.pnlWoKittingValue.TabIndex = 3;
            // 
            // lblWoKittingValue
            // 
            this.lblWoKittingValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWoKittingValue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblWoKittingValue.ForeColor = System.Drawing.Color.Black;
            this.lblWoKittingValue.Location = new System.Drawing.Point(0, 0);
            this.lblWoKittingValue.Name = "lblWoKittingValue";
            this.lblWoKittingValue.Size = new System.Drawing.Size(118, 68);
            this.lblWoKittingValue.TabIndex = 0;
            this.lblWoKittingValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(221)))), ((int)(((byte)(145)))));
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Location = new System.Drawing.Point(918, 0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(160, 70);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // Kitting_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 651);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBarcode);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1116, 690);
            this.Name = "Kitting_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KITTING";
            this.pnlHeader.ResumeLayout(false);
            this.pnlBarcode.ResumeLayout(false);
            this.pnlBarcode.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitting)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlNotKittingTitle.ResumeLayout(false);
            this.pnlNotKittingValue.ResumeLayout(false);
            this.pnlWoKittingTitle.ResumeLayout(false);
            this.pnlWoKittingValue.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}