namespace RE_Laura_Looney_SD
{
    partial class frmCancelOrder
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
            this.mnuOrderMenu = new System.Windows.Forms.MenuStrip();
            this.mnuMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExxit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCancelOrder = new System.Windows.Forms.Label();
            this.DGVStock = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboSearch = new System.Windows.Forms.TextBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.cboCustID = new System.Windows.Forms.TextBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.OrderDeatilsbx = new System.Windows.Forms.GroupBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.cboLName = new System.Windows.Forms.TextBox();
            this.cboPrice = new System.Windows.Forms.TextBox();
            this.cboFName = new System.Windows.Forms.TextBox();
            this.DGVCart = new System.Windows.Forms.DataGridView();
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuOrderMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStock)).BeginInit();
            this.OrderDeatilsbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCart)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuOrderMenu
            // 
            this.mnuOrderMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuOrderMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenu,
            this.mnuOrder,
            this.mnuExxit});
            this.mnuOrderMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuOrderMenu.Name = "mnuOrderMenu";
            this.mnuOrderMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuOrderMenu.Size = new System.Drawing.Size(757, 24);
            this.mnuOrderMenu.TabIndex = 2;
            this.mnuOrderMenu.Text = "menuStrip1";
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(80, 20);
            this.mnuMainMenu.Text = "Main Menu";
            this.mnuMainMenu.Click += new System.EventHandler(this.mnuMainMenu_Click);
            // 
            // mnuOrder
            // 
            this.mnuOrder.Name = "mnuOrder";
            this.mnuOrder.Size = new System.Drawing.Size(83, 20);
            this.mnuOrder.Text = "Order Menu";
            this.mnuOrder.Click += new System.EventHandler(this.mnuOrder_Click);
            // 
            // mnuExxit
            // 
            this.mnuExxit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExxit.Name = "mnuExxit";
            this.mnuExxit.Size = new System.Drawing.Size(38, 20);
            this.mnuExxit.Text = "Exit";
            this.mnuExxit.Click += new System.EventHandler(this.mnuExxit_Click);
            // 
            // lblCancelOrder
            // 
            this.lblCancelOrder.AutoSize = true;
            this.lblCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelOrder.Location = new System.Drawing.Point(224, 28);
            this.lblCancelOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCancelOrder.Name = "lblCancelOrder";
            this.lblCancelOrder.Size = new System.Drawing.Size(202, 36);
            this.lblCancelOrder.TabIndex = 87;
            this.lblCancelOrder.Text = "Cancel Order";
            // 
            // DGVStock
            // 
            this.DGVStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockID,
            this.Total,
            this.CustID});
            this.DGVStock.Location = new System.Drawing.Point(47, 171);
            this.DGVStock.Name = "DGVStock";
            this.DGVStock.ReadOnly = true;
            this.DGVStock.Size = new System.Drawing.Size(225, 75);
            this.DGVStock.TabIndex = 112;
            this.DGVStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStock_CellContentClick);
            this.DGVStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStock_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSearch.Location = new System.Drawing.Point(47, 131);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 35);
            this.btnSearch.TabIndex = 106;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboSearch
            // 
            this.cboSearch.Location = new System.Drawing.Point(47, 111);
            this.cboSearch.Margin = new System.Windows.Forms.Padding(2);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(137, 20);
            this.cboSearch.TabIndex = 110;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblOrderID.Location = new System.Drawing.Point(44, 94);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(88, 15);
            this.lblOrderID.TabIndex = 111;
            this.lblOrderID.Text = "Enter Order ID:";
            // 
            // cboCustID
            // 
            this.cboCustID.Enabled = false;
            this.cboCustID.Location = new System.Drawing.Point(437, 72);
            this.cboCustID.Margin = new System.Windows.Forms.Padding(2);
            this.cboCustID.MaxLength = 20;
            this.cboCustID.Name = "cboCustID";
            this.cboCustID.ReadOnly = true;
            this.cboCustID.Size = new System.Drawing.Size(46, 20);
            this.cboCustID.TabIndex = 107;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCustID.Location = new System.Drawing.Point(386, 72);
            this.lblCustID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(46, 15);
            this.lblCustID.TabIndex = 109;
            this.lblCustID.Text = "CustID:";
            // 
            // OrderDeatilsbx
            // 
            this.OrderDeatilsbx.Controls.Add(this.lblFName);
            this.OrderDeatilsbx.Controls.Add(this.lblLName);
            this.OrderDeatilsbx.Controls.Add(this.lblPrice);
            this.OrderDeatilsbx.Controls.Add(this.btnCancelOrder);
            this.OrderDeatilsbx.Controls.Add(this.cboLName);
            this.OrderDeatilsbx.Controls.Add(this.cboPrice);
            this.OrderDeatilsbx.Controls.Add(this.cboFName);
            this.OrderDeatilsbx.Location = new System.Drawing.Point(389, 97);
            this.OrderDeatilsbx.Name = "OrderDeatilsbx";
            this.OrderDeatilsbx.Size = new System.Drawing.Size(306, 149);
            this.OrderDeatilsbx.TabIndex = 108;
            this.OrderDeatilsbx.TabStop = false;
            this.OrderDeatilsbx.Text = "Order Details";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFName.Location = new System.Drawing.Point(48, 27);
            this.lblFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(68, 15);
            this.lblFName.TabIndex = 30;
            this.lblFName.Text = "First name:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(46, 53);
            this.lblLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(68, 15);
            this.lblLName.TabIndex = 31;
            this.lblLName.Text = "Last name:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPrice.Location = new System.Drawing.Point(46, 81);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(68, 15);
            this.lblPrice.TabIndex = 33;
            this.lblPrice.Text = "Total Price:";
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCancelOrder.Location = new System.Drawing.Point(105, 107);
            this.btnCancelOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(97, 32);
            this.btnCancelOrder.TabIndex = 8;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // cboLName
            // 
            this.cboLName.Location = new System.Drawing.Point(154, 53);
            this.cboLName.Margin = new System.Windows.Forms.Padding(2);
            this.cboLName.MaxLength = 30;
            this.cboLName.Name = "cboLName";
            this.cboLName.ReadOnly = true;
            this.cboLName.Size = new System.Drawing.Size(138, 20);
            this.cboLName.TabIndex = 2;
            // 
            // cboPrice
            // 
            this.cboPrice.Location = new System.Drawing.Point(154, 83);
            this.cboPrice.Margin = new System.Windows.Forms.Padding(2);
            this.cboPrice.MaxLength = 5;
            this.cboPrice.Name = "cboPrice";
            this.cboPrice.ReadOnly = true;
            this.cboPrice.Size = new System.Drawing.Size(48, 20);
            this.cboPrice.TabIndex = 4;
            // 
            // cboFName
            // 
            this.cboFName.Location = new System.Drawing.Point(154, 22);
            this.cboFName.Margin = new System.Windows.Forms.Padding(2);
            this.cboFName.MaxLength = 20;
            this.cboFName.Name = "cboFName";
            this.cboFName.ReadOnly = true;
            this.cboFName.Size = new System.Drawing.Size(120, 20);
            this.cboFName.TabIndex = 1;
            // 
            // DGVCart
            // 
            this.DGVCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SID,
            this.Price,
            this.SQuantity});
            this.DGVCart.Location = new System.Drawing.Point(389, 252);
            this.DGVCart.Name = "DGVCart";
            this.DGVCart.Size = new System.Drawing.Size(237, 150);
            this.DGVCart.TabIndex = 113;
            // 
            // StockID
            // 
            this.StockID.HeaderText = "Order ID";
            this.StockID.Name = "StockID";
            this.StockID.ReadOnly = true;
            this.StockID.Width = 50;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total Price";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 80;
            // 
            // CustID
            // 
            this.CustID.HeaderText = "Cust ID";
            this.CustID.Name = "CustID";
            this.CustID.ReadOnly = true;
            this.CustID.Width = 50;
            // 
            // SID
            // 
            this.SID.HeaderText = "Stock ID";
            this.SID.Name = "SID";
            this.SID.ReadOnly = true;
            this.SID.Width = 70;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.Width = 70;
            // 
            // SQuantity
            // 
            this.SQuantity.HeaderText = "Quantity";
            this.SQuantity.Name = "SQuantity";
            this.SQuantity.ReadOnly = true;
            this.SQuantity.Width = 50;
            // 
            // frmCancelOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 437);
            this.Controls.Add(this.DGVCart);
            this.Controls.Add(this.DGVStock);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.cboCustID);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.OrderDeatilsbx);
            this.Controls.Add(this.lblCancelOrder);
            this.Controls.Add(this.mnuOrderMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCancelOrder";
            this.Text = "Looney\'s Liquer -[Cancel Order]";
            this.mnuOrderMenu.ResumeLayout(false);
            this.mnuOrderMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStock)).EndInit();
            this.OrderDeatilsbx.ResumeLayout(false);
            this.OrderDeatilsbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuOrderMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuExxit;
        private System.Windows.Forms.Label lblCancelOrder;
        private System.Windows.Forms.DataGridView DGVStock;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox cboSearch;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.TextBox cboCustID;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.GroupBox OrderDeatilsbx;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.TextBox cboLName;
        private System.Windows.Forms.TextBox cboPrice;
        private System.Windows.Forms.TextBox cboFName;
        private System.Windows.Forms.DataGridView DGVCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn SQuantity;
    }
}