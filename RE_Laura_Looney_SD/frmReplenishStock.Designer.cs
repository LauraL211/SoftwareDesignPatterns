namespace RE_Laura_Looney_SD
{
    partial class frmReplenishStock
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
            this.btnOrder_Items = new System.Windows.Forms.Button();
            this.lblChoose_Stock = new System.Windows.Forms.Label();
            this.cboLowStock = new System.Windows.Forms.CheckBox();
            this.lblReplenishStock = new System.Windows.Forms.Label();
            this.DGVStock = new System.Windows.Forms.DataGridView();
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboSearch = new System.Windows.Forms.TextBox();
            this.lblStock_List = new System.Windows.Forms.Label();
            this.DGVReplenish = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuStockMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReplenish)).BeginInit();
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
            this.mnuStockMenu.Size = new System.Drawing.Size(751, 24);
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
            // btnOrder_Items
            // 
            this.btnOrder_Items.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder_Items.Location = new System.Drawing.Point(506, 360);
            this.btnOrder_Items.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrder_Items.Name = "btnOrder_Items";
            this.btnOrder_Items.Size = new System.Drawing.Size(136, 46);
            this.btnOrder_Items.TabIndex = 74;
            this.btnOrder_Items.Text = "Order Items";
            this.btnOrder_Items.UseVisualStyleBackColor = true;
            this.btnOrder_Items.Click += new System.EventHandler(this.btnOrder_Items_Click);
            // 
            // lblChoose_Stock
            // 
            this.lblChoose_Stock.AutoSize = true;
            this.lblChoose_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblChoose_Stock.Location = new System.Drawing.Point(27, 66);
            this.lblChoose_Stock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoose_Stock.Name = "lblChoose_Stock";
            this.lblChoose_Stock.Size = new System.Drawing.Size(104, 18);
            this.lblChoose_Stock.TabIndex = 73;
            this.lblChoose_Stock.Text = "Choose Stock";
            // 
            // cboLowStock
            // 
            this.cboLowStock.AutoSize = true;
            this.cboLowStock.Location = new System.Drawing.Point(30, 86);
            this.cboLowStock.Margin = new System.Windows.Forms.Padding(2);
            this.cboLowStock.Name = "cboLowStock";
            this.cboLowStock.Size = new System.Drawing.Size(77, 17);
            this.cboLowStock.TabIndex = 69;
            this.cboLowStock.Text = "Low Stock";
            this.cboLowStock.UseVisualStyleBackColor = true;
            this.cboLowStock.CheckedChanged += new System.EventHandler(this.cboLowStock_CheckedChanged);
            // 
            // lblReplenishStock
            // 
            this.lblReplenishStock.AutoSize = true;
            this.lblReplenishStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplenishStock.Location = new System.Drawing.Point(253, 48);
            this.lblReplenishStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReplenishStock.Name = "lblReplenishStock";
            this.lblReplenishStock.Size = new System.Drawing.Size(247, 36);
            this.lblReplenishStock.TabIndex = 68;
            this.lblReplenishStock.Text = "Replenish Stock";
            // 
            // DGVStock
            // 
            this.DGVStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockID,
            this.Name,
            this.Description});
            this.DGVStock.Location = new System.Drawing.Point(30, 204);
            this.DGVStock.Name = "DGVStock";
            this.DGVStock.ReadOnly = true;
            this.DGVStock.Size = new System.Drawing.Size(303, 202);
            this.DGVStock.TabIndex = 78;
            this.DGVStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStock_CellContentClick);
            this.DGVStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStock_CellContentClick);
            // 
            // StockID
            // 
            this.StockID.HeaderText = "Stock ID";
            this.StockID.Name = "StockID";
            this.StockID.ReadOnly = true;
            this.StockID.Width = 60;
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
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSearch.Location = new System.Drawing.Point(30, 154);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 35);
            this.btnSearch.TabIndex = 75;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboSearch
            // 
            this.cboSearch.Location = new System.Drawing.Point(30, 129);
            this.cboSearch.Margin = new System.Windows.Forms.Padding(2);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(137, 20);
            this.cboSearch.TabIndex = 76;
            // 
            // lblStock_List
            // 
            this.lblStock_List.AutoSize = true;
            this.lblStock_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblStock_List.Location = new System.Drawing.Point(27, 112);
            this.lblStock_List.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock_List.Name = "lblStock_List";
            this.lblStock_List.Size = new System.Drawing.Size(109, 15);
            this.lblStock_List.TabIndex = 77;
            this.lblStock_List.Text = "Enter Stock Name:";
            // 
            // DGVReplenish
            // 
            this.DGVReplenish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVReplenish.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SName,
            this.SDescription,
            this.SQuantity});
            this.DGVReplenish.Location = new System.Drawing.Point(401, 154);
            this.DGVReplenish.Name = "DGVReplenish";
            this.DGVReplenish.Size = new System.Drawing.Size(303, 150);
            this.DGVReplenish.TabIndex = 79;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // SName
            // 
            this.SName.HeaderText = "Stock Name";
            this.SName.Name = "SName";
            this.SName.ReadOnly = true;
            this.SName.Width = 80;
            // 
            // SDescription
            // 
            this.SDescription.HeaderText = "Description";
            this.SDescription.Name = "SDescription";
            this.SDescription.ReadOnly = true;
            this.SDescription.Width = 80;
            // 
            // SQuantity
            // 
            this.SQuantity.HeaderText = "Quantity";
            this.SQuantity.Name = "SQuantity";
            this.SQuantity.ReadOnly = true;
            this.SQuantity.Width = 50;
            // 
            // frmReplenishStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 439);
            this.Controls.Add(this.DGVReplenish);
            this.Controls.Add(this.DGVStock);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.lblStock_List);
            this.Controls.Add(this.btnOrder_Items);
            this.Controls.Add(this.lblChoose_Stock);
            this.Controls.Add(this.cboLowStock);
            this.Controls.Add(this.lblReplenishStock);
            this.Controls.Add(this.mnuStockMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Text = "Looney\'s Liquer - [Replenish Stock]";
            this.mnuStockMenu.ResumeLayout(false);
            this.mnuStockMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReplenish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStockMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuStock;
        private System.Windows.Forms.ToolStripMenuItem mnuExxit;
        private System.Windows.Forms.Button btnOrder_Items;
        private System.Windows.Forms.Label lblChoose_Stock;
        private System.Windows.Forms.CheckBox cboLowStock;
        private System.Windows.Forms.Label lblReplenishStock;
        private System.Windows.Forms.DataGridView DGVStock;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox cboSearch;
        private System.Windows.Forms.Label lblStock_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridView DGVReplenish;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn SQuantity;
    }
}