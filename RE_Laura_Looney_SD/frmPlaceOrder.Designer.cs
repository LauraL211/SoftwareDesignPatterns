namespace RE_Laura_Looney_SD
{
    partial class frmPlaceOrder
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
            this.lblPlaceOrder = new System.Windows.Forms.Label();
            this.cboTotal_Cost = new System.Windows.Forms.TextBox();
            this.lblTotal_Cost = new System.Windows.Forms.Label();
            this.btnPlace_Order = new System.Windows.Forms.Button();
            this.lblShopping_Cart = new System.Windows.Forms.Label();
            this.DGVCart = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVStock = new System.Windows.Forms.DataGridView();
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboSearch = new System.Windows.Forms.TextBox();
            this.lblStock_List = new System.Windows.Forms.Label();
            this.mnuOrderMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStock)).BeginInit();
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
            this.mnuOrderMenu.Size = new System.Drawing.Size(747, 24);
            this.mnuOrderMenu.TabIndex = 3;
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
            // lblPlaceOrder
            // 
            this.lblPlaceOrder.AutoSize = true;
            this.lblPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceOrder.Location = new System.Drawing.Point(262, 33);
            this.lblPlaceOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlaceOrder.Name = "lblPlaceOrder";
            this.lblPlaceOrder.Size = new System.Drawing.Size(183, 36);
            this.lblPlaceOrder.TabIndex = 77;
            this.lblPlaceOrder.Text = "Place Order";
            // 
            // cboTotal_Cost
            // 
            this.cboTotal_Cost.Location = new System.Drawing.Point(547, 306);
            this.cboTotal_Cost.Margin = new System.Windows.Forms.Padding(2);
            this.cboTotal_Cost.Name = "cboTotal_Cost";
            this.cboTotal_Cost.Size = new System.Drawing.Size(60, 20);
            this.cboTotal_Cost.TabIndex = 4;
            // 
            // lblTotal_Cost
            // 
            this.lblTotal_Cost.AutoSize = true;
            this.lblTotal_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblTotal_Cost.Location = new System.Drawing.Point(469, 306);
            this.lblTotal_Cost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal_Cost.Name = "lblTotal_Cost";
            this.lblTotal_Cost.Size = new System.Drawing.Size(81, 18);
            this.lblTotal_Cost.TabIndex = 75;
            this.lblTotal_Cost.Text = "Total Cost:";
            // 
            // btnPlace_Order
            // 
            this.btnPlace_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlace_Order.Location = new System.Drawing.Point(472, 326);
            this.btnPlace_Order.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlace_Order.Name = "btnPlace_Order";
            this.btnPlace_Order.Size = new System.Drawing.Size(136, 46);
            this.btnPlace_Order.TabIndex = 5;
            this.btnPlace_Order.Text = "Place Order";
            this.btnPlace_Order.UseVisualStyleBackColor = true;
            this.btnPlace_Order.Click += new System.EventHandler(this.btnPlace_Order_Click);
            // 
            // lblShopping_Cart
            // 
            this.lblShopping_Cart.AutoSize = true;
            this.lblShopping_Cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblShopping_Cart.Location = new System.Drawing.Point(505, 95);
            this.lblShopping_Cart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShopping_Cart.Name = "lblShopping_Cart";
            this.lblShopping_Cart.Size = new System.Drawing.Size(102, 18);
            this.lblShopping_Cart.TabIndex = 71;
            this.lblShopping_Cart.Text = "Shopping Cart";
            // 
            // DGVCart
            // 
            this.DGVCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SName,
            this.SDescription,
            this.SQuantity,
            this.Price});
            this.DGVCart.Location = new System.Drawing.Point(384, 116);
            this.DGVCart.Name = "DGVCart";
            this.DGVCart.Size = new System.Drawing.Size(351, 150);
            this.DGVCart.TabIndex = 86;
            this.DGVCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCart_CellContentClick);
            this.DGVCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCart_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // SName
            // 
            this.SName.HeaderText = "Stock Name";
            this.SName.Name = "SName";
            this.SName.ReadOnly = true;
            this.SName.Width = 70;
            // 
            // SDescription
            // 
            this.SDescription.HeaderText = "Description";
            this.SDescription.Name = "SDescription";
            this.SDescription.ReadOnly = true;
            this.SDescription.Width = 70;
            // 
            // SQuantity
            // 
            this.SQuantity.HeaderText = "Quantity";
            this.SQuantity.Name = "SQuantity";
            this.SQuantity.ReadOnly = true;
            this.SQuantity.Width = 50;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.Width = 70;
            // 
            // DGVStock
            // 
            this.DGVStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockID,
            this.Name,
            this.Description});
            this.DGVStock.Location = new System.Drawing.Point(38, 170);
            this.DGVStock.Name = "DGVStock";
            this.DGVStock.ReadOnly = true;
            this.DGVStock.Size = new System.Drawing.Size(303, 202);
            this.DGVStock.TabIndex = 85;
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
            this.btnSearch.Location = new System.Drawing.Point(38, 120);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 35);
            this.btnSearch.TabIndex = 82;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboSearch
            // 
            this.cboSearch.Location = new System.Drawing.Point(38, 95);
            this.cboSearch.Margin = new System.Windows.Forms.Padding(2);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(137, 20);
            this.cboSearch.TabIndex = 83;
            // 
            // lblStock_List
            // 
            this.lblStock_List.AutoSize = true;
            this.lblStock_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblStock_List.Location = new System.Drawing.Point(35, 78);
            this.lblStock_List.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock_List.Name = "lblStock_List";
            this.lblStock_List.Size = new System.Drawing.Size(109, 15);
            this.lblStock_List.TabIndex = 84;
            this.lblStock_List.Text = "Enter Stock Name:";
            // 
            // frmPlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 399);
            this.Controls.Add(this.DGVCart);
            this.Controls.Add(this.DGVStock);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.lblStock_List);
            this.Controls.Add(this.lblPlaceOrder);
            this.Controls.Add(this.cboTotal_Cost);
            this.Controls.Add(this.lblTotal_Cost);
            this.Controls.Add(this.btnPlace_Order);
            this.Controls.Add(this.lblShopping_Cart);
            this.Controls.Add(this.mnuOrderMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Text = "Looney\'s Liquer - [Place Order]";
            this.mnuOrderMenu.ResumeLayout(false);
            this.mnuOrderMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuOrderMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuExxit;
        private System.Windows.Forms.Label lblPlaceOrder;
        private System.Windows.Forms.TextBox cboTotal_Cost;
        private System.Windows.Forms.Label lblTotal_Cost;
        private System.Windows.Forms.Button btnPlace_Order;
        private System.Windows.Forms.Label lblShopping_Cart;
        private System.Windows.Forms.DataGridView DGVCart;
        private System.Windows.Forms.DataGridView DGVStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox cboSearch;
        private System.Windows.Forms.Label lblStock_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn SQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}