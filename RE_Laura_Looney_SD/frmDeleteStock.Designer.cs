namespace RE_Laura_Looney_SD
{
    partial class frmDeleteStock
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
            this.mnuStockMenu = new System.Windows.Forms.MenuStrip();
            this.mnuMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExxit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDeleteStock = new System.Windows.Forms.Label();
            this.DGVStock = new System.Windows.Forms.DataGridView();
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboSearch = new System.Windows.Forms.TextBox();
            this.lblStock_List = new System.Windows.Forms.Label();
            this.cboStockID = new System.Windows.Forms.TextBox();
            this.lblStockID = new System.Windows.Forms.Label();
            this.UpdateStockDetailsBx = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.TextBox();
            this.cboQuantity = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnDeleteStock = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cboDescription = new System.Windows.Forms.TextBox();
            this.lblReorderLevel = new System.Windows.Forms.Label();
            this.cboPrice = new System.Windows.Forms.TextBox();
            this.cboName = new System.Windows.Forms.TextBox();
            this.cboReorderLVL = new System.Windows.Forms.TextBox();
            this.mnuStockMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStock)).BeginInit();
            this.UpdateStockDetailsBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStockMenu
            // 
            this.mnuStockMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuStockMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenu,
            this.mnuStock,
            this.mnuExxit});
            this.mnuStockMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuStockMenu.Name = "mnuStockMenu";
            this.mnuStockMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuStockMenu.Size = new System.Drawing.Size(765, 24);
            this.mnuStockMenu.TabIndex = 4;
            this.mnuStockMenu.Text = "menuStrip1";
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(80, 20);
            this.mnuMainMenu.Text = "Main Menu";
            this.mnuMainMenu.Click += new System.EventHandler(this.mnuMainMenu_Click);
            // 
            // mnuStock
            // 
            this.mnuStock.Name = "mnuStock";
            this.mnuStock.Size = new System.Drawing.Size(82, 20);
            this.mnuStock.Text = "Stock Menu";
            this.mnuStock.Click += new System.EventHandler(this.mnuStock_Click);
            // 
            // mnuExxit
            // 
            this.mnuExxit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExxit.Name = "mnuExxit";
            this.mnuExxit.Size = new System.Drawing.Size(38, 20);
            this.mnuExxit.Text = "Exit";
            this.mnuExxit.Click += new System.EventHandler(this.mnuExxit_Click);
            // 
            // lblDeleteStock
            // 
            this.lblDeleteStock.AutoSize = true;
            this.lblDeleteStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteStock.Location = new System.Drawing.Point(280, 40);
            this.lblDeleteStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeleteStock.Name = "lblDeleteStock";
            this.lblDeleteStock.Size = new System.Drawing.Size(194, 36);
            this.lblDeleteStock.TabIndex = 67;
            this.lblDeleteStock.Text = "Delete Stock";
            // 
            // DGVStock
            // 
            this.DGVStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockID,
            this.StockName,
            this.Description});
            this.DGVStock.Location = new System.Drawing.Point(31, 223);
            this.DGVStock.Name = "DGVStock";
            this.DGVStock.ReadOnly = true;
            this.DGVStock.Size = new System.Drawing.Size(348, 202);
            this.DGVStock.TabIndex = 85;
            this.DGVStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStock_CellContentClick);
            this.DGVStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStock_CellContentClick);
            // 
            // StockID
            // 
            this.StockID.HeaderText = "Stock ID";
            this.StockID.Name = "StockID";
            this.StockID.ReadOnly = true;
            // 
            // Name
            // 
            this.StockName.HeaderText = "Stock Name";
            this.StockName.Name = "Name";
            this.StockName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Stock Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSearch.Location = new System.Drawing.Point(31, 152);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 35);
            this.btnSearch.TabIndex = 78;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboSearch
            // 
            this.cboSearch.Location = new System.Drawing.Point(31, 127);
            this.cboSearch.Margin = new System.Windows.Forms.Padding(2);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(137, 20);
            this.cboSearch.TabIndex = 83;
            // 
            // lblStock_List
            // 
            this.lblStock_List.AutoSize = true;
            this.lblStock_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblStock_List.Location = new System.Drawing.Point(28, 110);
            this.lblStock_List.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock_List.Name = "lblStock_List";
            this.lblStock_List.Size = new System.Drawing.Size(109, 15);
            this.lblStock_List.TabIndex = 84;
            this.lblStock_List.Text = "Enter Stock Name:";
            // 
            // cboStockID
            // 
            this.cboStockID.Enabled = false;
            this.cboStockID.Location = new System.Drawing.Point(458, 103);
            this.cboStockID.Margin = new System.Windows.Forms.Padding(2);
            this.cboStockID.MaxLength = 20;
            this.cboStockID.Name = "cboStockID";
            this.cboStockID.ReadOnly = true;
            this.cboStockID.Size = new System.Drawing.Size(46, 20);
            this.cboStockID.TabIndex = 80;
            // 
            // lblStockID
            // 
            this.lblStockID.AutoSize = true;
            this.lblStockID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblStockID.Location = new System.Drawing.Point(407, 103);
            this.lblStockID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockID.Name = "lblStockID";
            this.lblStockID.Size = new System.Drawing.Size(52, 15);
            this.lblStockID.TabIndex = 82;
            this.lblStockID.Text = "StockID:";
            // 
            // UpdateStockDetailsBx
            // 
            this.UpdateStockDetailsBx.Controls.Add(this.lblStatus);
            this.UpdateStockDetailsBx.Controls.Add(this.cboStatus);
            this.UpdateStockDetailsBx.Controls.Add(this.cboQuantity);
            this.UpdateStockDetailsBx.Controls.Add(this.cboType);
            this.UpdateStockDetailsBx.Controls.Add(this.lblName);
            this.UpdateStockDetailsBx.Controls.Add(this.lblType);
            this.UpdateStockDetailsBx.Controls.Add(this.lblDescription);
            this.UpdateStockDetailsBx.Controls.Add(this.lblPrice);
            this.UpdateStockDetailsBx.Controls.Add(this.btnDeleteStock);
            this.UpdateStockDetailsBx.Controls.Add(this.lblQuantity);
            this.UpdateStockDetailsBx.Controls.Add(this.cboDescription);
            this.UpdateStockDetailsBx.Controls.Add(this.lblReorderLevel);
            this.UpdateStockDetailsBx.Controls.Add(this.cboPrice);
            this.UpdateStockDetailsBx.Controls.Add(this.cboName);
            this.UpdateStockDetailsBx.Controls.Add(this.cboReorderLVL);
            this.UpdateStockDetailsBx.Location = new System.Drawing.Point(410, 128);
            this.UpdateStockDetailsBx.Name = "UpdateStockDetailsBx";
            this.UpdateStockDetailsBx.Size = new System.Drawing.Size(336, 298);
            this.UpdateStockDetailsBx.TabIndex = 81;
            this.UpdateStockDetailsBx.TabStop = false;
            this.UpdateStockDetailsBx.Text = " Stock Details";
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
            this.cboStatus.ReadOnly = true;
            this.cboStatus.Size = new System.Drawing.Size(48, 20);
            this.cboStatus.TabIndex = 7;
            // 
            // cboQuantity
            // 
            this.cboQuantity.Location = new System.Drawing.Point(153, 155);
            this.cboQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.cboQuantity.MaxLength = 3;
            this.cboQuantity.Name = "cboQuantity";
            this.cboQuantity.ReadOnly = true;
            this.cboQuantity.Size = new System.Drawing.Size(48, 20);
            this.cboQuantity.TabIndex = 5;
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(153, 95);
            this.cboType.Margin = new System.Windows.Forms.Padding(2);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(92, 21);
            this.cboType.TabIndex = 3;
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
            // btnDeleteStock
            // 
            this.btnDeleteStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDeleteStock.Location = new System.Drawing.Point(153, 252);
            this.btnDeleteStock.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteStock.Name = "btnDeleteStock";
            this.btnDeleteStock.Size = new System.Drawing.Size(92, 35);
            this.btnDeleteStock.TabIndex = 8;
            this.btnDeleteStock.Text = "Delete Stock";
            this.btnDeleteStock.UseVisualStyleBackColor = true;
            this.btnDeleteStock.Click += new System.EventHandler(this.btnDeleteStock_Click_1);
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
            this.cboDescription.ReadOnly = true;
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
            this.cboPrice.ReadOnly = true;
            this.cboPrice.Size = new System.Drawing.Size(48, 20);
            this.cboPrice.TabIndex = 4;
            // 
            // cboName
            // 
            this.cboName.Location = new System.Drawing.Point(153, 34);
            this.cboName.Margin = new System.Windows.Forms.Padding(2);
            this.cboName.MaxLength = 20;
            this.cboName.Name = "cboName";
            this.cboName.ReadOnly = true;
            this.cboName.Size = new System.Drawing.Size(120, 20);
            this.cboName.TabIndex = 1;
            // 
            // cboReorderLVL
            // 
            this.cboReorderLVL.Location = new System.Drawing.Point(153, 185);
            this.cboReorderLVL.Margin = new System.Windows.Forms.Padding(2);
            this.cboReorderLVL.MaxLength = 3;
            this.cboReorderLVL.Name = "cboReorderLVL";
            this.cboReorderLVL.ReadOnly = true;
            this.cboReorderLVL.Size = new System.Drawing.Size(48, 20);
            this.cboReorderLVL.TabIndex = 6;
            // 
            // frmDeleteStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 444);
            this.Controls.Add(this.DGVStock);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.lblStock_List);
            this.Controls.Add(this.cboStockID);
            this.Controls.Add(this.lblStockID);
            this.Controls.Add(this.UpdateStockDetailsBx);
            this.Controls.Add(this.lblDeleteStock);
            this.Controls.Add(this.mnuStockMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Text = "Looney\'s Liquer - [Delete Stock]";
            this.Load += new System.EventHandler(this.frmDeleteStock_Load);
            this.mnuStockMenu.ResumeLayout(false);
            this.mnuStockMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStock)).EndInit();
            this.UpdateStockDetailsBx.ResumeLayout(false);
            this.UpdateStockDetailsBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStockMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuStock;
        private System.Windows.Forms.ToolStripMenuItem mnuExxit;
        private System.Windows.Forms.Label lblDeleteStock;
        private System.Windows.Forms.DataGridView DGVStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox cboSearch;
        private System.Windows.Forms.Label lblStock_List;
        private System.Windows.Forms.TextBox cboStockID;
        private System.Windows.Forms.Label lblStockID;
        private System.Windows.Forms.GroupBox UpdateStockDetailsBx;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox cboStatus;
        private System.Windows.Forms.TextBox cboQuantity;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnDeleteStock;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox cboDescription;
        private System.Windows.Forms.Label lblReorderLevel;
        private System.Windows.Forms.TextBox cboPrice;
        private System.Windows.Forms.TextBox cboName;
        private System.Windows.Forms.TextBox cboReorderLVL;
    }
}