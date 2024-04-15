namespace RE_Laura_Looney_SD
{
    partial class Trial
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
            this.mnuAddStock = new System.Windows.Forms.MenuStrip();
            this.mnuBackBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblUpdateStock = new System.Windows.Forms.Label();
            this.cboSearch = new System.Windows.Forms.TextBox();
            this.lblStock_List = new System.Windows.Forms.Label();
            this.cboStockID = new System.Windows.Forms.TextBox();
            this.lblStockID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.TextBox();
            this.cboQuantity = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cboDescription = new System.Windows.Forms.TextBox();
            this.lblReorderLevel = new System.Windows.Forms.Label();
            this.cboPrice = new System.Windows.Forms.TextBox();
            this.cboName = new System.Windows.Forms.TextBox();
            this.cboReorderLVL = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.DGVStock = new System.Windows.Forms.DataGridView();
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStock)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuAddStock
            // 
            this.mnuAddStock.Location = new System.Drawing.Point(0, 0);
            this.mnuAddStock.Name = "mnuAddStock";
            this.mnuAddStock.Size = new System.Drawing.Size(800, 24);
            this.mnuAddStock.TabIndex = 36;
            this.mnuAddStock.Text = "menuStrip1";
            // 
            // mnuBackBtn
            // 
            this.mnuBackBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBackBtn.Name = "mnuBackBtn";
            this.mnuBackBtn.Size = new System.Drawing.Size(44, 20);
            this.mnuBackBtn.Text = "Back";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(303, 36);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(287, 36);
            this.lblRegister.TabIndex = 29;
            this.lblRegister.Text = "Register  Customer";
            // 
            // lblUpdateStock
            // 
            this.lblUpdateStock.AutoSize = true;
            this.lblUpdateStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateStock.Location = new System.Drawing.Point(254, 43);
            this.lblUpdateStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateStock.Name = "lblUpdateStock";
            this.lblUpdateStock.Size = new System.Drawing.Size(206, 36);
            this.lblUpdateStock.TabIndex = 53;
            this.lblUpdateStock.Text = "Update Stock";
            this.lblUpdateStock.Click += new System.EventHandler(this.lblUpdateStock_Click);
            // 
            // cboSearch
            // 
            this.cboSearch.Location = new System.Drawing.Point(39, 129);
            this.cboSearch.Margin = new System.Windows.Forms.Padding(2);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(137, 20);
            this.cboSearch.TabIndex = 58;
            this.cboSearch.TextChanged += new System.EventHandler(this.cboSearch_TextChanged);
            // 
            // lblStock_List
            // 
            this.lblStock_List.AutoSize = true;
            this.lblStock_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblStock_List.Location = new System.Drawing.Point(36, 112);
            this.lblStock_List.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock_List.Name = "lblStock_List";
            this.lblStock_List.Size = new System.Drawing.Size(109, 15);
            this.lblStock_List.TabIndex = 60;
            this.lblStock_List.Text = "Enter Stock Name:";
            this.lblStock_List.Click += new System.EventHandler(this.lblStock_List_Click);
            // 
            // cboStockID
            // 
            this.cboStockID.Enabled = false;
            this.cboStockID.Location = new System.Drawing.Point(441, 99);
            this.cboStockID.Margin = new System.Windows.Forms.Padding(2);
            this.cboStockID.MaxLength = 20;
            this.cboStockID.Name = "cboStockID";
            this.cboStockID.ReadOnly = true;
            this.cboStockID.Size = new System.Drawing.Size(46, 20);
            this.cboStockID.TabIndex = 55;
            this.cboStockID.TextChanged += new System.EventHandler(this.cboStockID_TextChanged);
            // 
            // lblStockID
            // 
            this.lblStockID.AutoSize = true;
            this.lblStockID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblStockID.Location = new System.Drawing.Point(390, 99);
            this.lblStockID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockID.Name = "lblStockID";
            this.lblStockID.Size = new System.Drawing.Size(52, 15);
            this.lblStockID.TabIndex = 57;
            this.lblStockID.Text = "StockID:";
            this.lblStockID.Click += new System.EventHandler(this.lblStockID_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.cboStatus);
            this.groupBox1.Controls.Add(this.cboQuantity);
            this.groupBox1.Controls.Add(this.cboType);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.btnUpdateStock);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.cboDescription);
            this.groupBox1.Controls.Add(this.lblReorderLevel);
            this.groupBox1.Controls.Add(this.cboPrice);
            this.groupBox1.Controls.Add(this.cboName);
            this.groupBox1.Controls.Add(this.cboReorderLVL);
            this.groupBox1.Location = new System.Drawing.Point(393, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 298);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Stock Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblStatus.Location = new System.Drawing.Point(45, 216);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 15);
            this.lblStatus.TabIndex = 37;
            this.lblStatus.Text = "Status:";
            // 
            // cboStatus
            // 
            this.cboStatus.Location = new System.Drawing.Point(153, 218);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cboStatus.MaxLength = 3;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(48, 20);
            this.cboStatus.TabIndex = 7;
            this.cboStatus.Text = "A";
            this.cboStatus.TextChanged += new System.EventHandler(this.cboStatus_TextChanged);
            // 
            // cboQuantity
            // 
            this.cboQuantity.Location = new System.Drawing.Point(153, 155);
            this.cboQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.cboQuantity.MaxLength = 3;
            this.cboQuantity.Name = "cboQuantity";
            this.cboQuantity.Size = new System.Drawing.Size(48, 20);
            this.cboQuantity.TabIndex = 5;
            // 
            // cboType
            // 
            this.cboType.AllowDrop = true;
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(153, 95);
            this.cboType.Margin = new System.Windows.Forms.Padding(2);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(92, 21);
            this.cboType.TabIndex = 3;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblName.Location = new System.Drawing.Point(47, 39);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 15);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "Name:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblType.Location = new System.Drawing.Point(45, 95);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(36, 15);
            this.lblType.TabIndex = 32;
            this.lblType.Text = "Type:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(45, 65);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(72, 15);
            this.lblDescription.TabIndex = 31;
            this.lblDescription.Text = "Description:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPrice.Location = new System.Drawing.Point(45, 125);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 15);
            this.lblPrice.TabIndex = 33;
            this.lblPrice.Text = "Price:";
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnUpdateStock.Location = new System.Drawing.Point(153, 252);
            this.btnUpdateStock.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(92, 35);
            this.btnUpdateStock.TabIndex = 8;
            this.btnUpdateStock.Text = "Update Stock";
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblQuantity.Location = new System.Drawing.Point(45, 153);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(54, 15);
            this.lblQuantity.TabIndex = 34;
            this.lblQuantity.Text = "Quantity:";
            // 
            // cboDescription
            // 
            this.cboDescription.Location = new System.Drawing.Point(153, 65);
            this.cboDescription.Margin = new System.Windows.Forms.Padding(2);
            this.cboDescription.MaxLength = 30;
            this.cboDescription.Name = "cboDescription";
            this.cboDescription.Size = new System.Drawing.Size(138, 20);
            this.cboDescription.TabIndex = 2;
            // 
            // lblReorderLevel
            // 
            this.lblReorderLevel.AutoSize = true;
            this.lblReorderLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblReorderLevel.Location = new System.Drawing.Point(45, 183);
            this.lblReorderLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(87, 15);
            this.lblReorderLevel.TabIndex = 35;
            this.lblReorderLevel.Text = "Reorder Level:";
            // 
            // cboPrice
            // 
            this.cboPrice.Location = new System.Drawing.Point(153, 127);
            this.cboPrice.Margin = new System.Windows.Forms.Padding(2);
            this.cboPrice.MaxLength = 5;
            this.cboPrice.Name = "cboPrice";
            this.cboPrice.Size = new System.Drawing.Size(48, 20);
            this.cboPrice.TabIndex = 4;
            // 
            // cboName
            // 
            this.cboName.Location = new System.Drawing.Point(153, 34);
            this.cboName.Margin = new System.Windows.Forms.Padding(2);
            this.cboName.MaxLength = 20;
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(120, 20);
            this.cboName.TabIndex = 1;
            // 
            // cboReorderLVL
            // 
            this.cboReorderLVL.Location = new System.Drawing.Point(153, 185);
            this.cboReorderLVL.Margin = new System.Windows.Forms.Padding(2);
            this.cboReorderLVL.MaxLength = 3;
            this.cboReorderLVL.Name = "cboReorderLVL";
            this.cboReorderLVL.Size = new System.Drawing.Size(48, 20);
            this.cboReorderLVL.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSearch.Location = new System.Drawing.Point(39, 153);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 35);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // DGVStock
            // 
            this.DGVStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockID,
            this.Name,
            this.Description});
            this.DGVStock.Location = new System.Drawing.Point(39, 220);
            this.DGVStock.Name = "DGVStock";
            this.DGVStock.ReadOnly = true;
            this.DGVStock.Size = new System.Drawing.Size(348, 202);
            this.DGVStock.TabIndex = 61;
            this.DGVStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStock_CellContentClick);
            this.DGVStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStock_CellContentClick_1);
            // 
            // StockID
            // 
            this.StockID.HeaderText = "Stock ID";
            this.StockID.Name = "StockID";
            this.StockID.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Stock Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Stock Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Trial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVStock);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.lblStock_List);
            this.Controls.Add(this.cboStockID);
            this.Controls.Add(this.lblStockID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblUpdateStock);
            this.Controls.Add(this.mnuAddStock);
            this.MainMenuStrip = this.mnuAddStock;
            this.Text = "Add Stock-(Trial)";
            this.Load += new System.EventHandler(this.frmAddStockTrial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuAddStock;
        private System.Windows.Forms.ToolStripMenuItem mnuBackBtn;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblUpdateStock;
        private System.Windows.Forms.TextBox cboSearch;
        private System.Windows.Forms.Label lblStock_List;
        private System.Windows.Forms.TextBox cboStockID;
        private System.Windows.Forms.Label lblStockID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox cboStatus;
        private System.Windows.Forms.TextBox cboQuantity;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox cboDescription;
        private System.Windows.Forms.Label lblReorderLevel;
        private System.Windows.Forms.TextBox cboPrice;
        private System.Windows.Forms.TextBox cboName;
        private System.Windows.Forms.TextBox cboReorderLVL;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView DGVStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}