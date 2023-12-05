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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlaceOrder));
            this.mnuOrderMenu = new System.Windows.Forms.MenuStrip();
            this.mnuMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExxit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPlaceOrder = new System.Windows.Forms.Label();
            this.cboTotal_Cost = new System.Windows.Forms.TextBox();
            this.lblTotal_Cost = new System.Windows.Forms.Label();
            this.btnPlace_Order = new System.Windows.Forms.Button();
            this.lblChoose_Stock = new System.Windows.Forms.Label();
            this.cboShopping_Cart = new System.Windows.Forms.TextBox();
            this.lblShopping_Cart = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboSearch = new System.Windows.Forms.TextBox();
            this.cboStock_List = new System.Windows.Forms.ComboBox();
            this.cboItemList = new System.Windows.Forms.ListBox();
            this.lblRemoveItem = new System.Windows.Forms.Label();
            this.mnuOrderMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.mnuOrderMenu.Size = new System.Drawing.Size(600, 24);
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
            this.lblPlaceOrder.Location = new System.Drawing.Point(224, 28);
            this.lblPlaceOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlaceOrder.Name = "lblPlaceOrder";
            this.lblPlaceOrder.Size = new System.Drawing.Size(183, 36);
            this.lblPlaceOrder.TabIndex = 77;
            this.lblPlaceOrder.Text = "Place Order";
            // 
            // cboTotal_Cost
            // 
            this.cboTotal_Cost.Location = new System.Drawing.Point(356, 281);
            this.cboTotal_Cost.Margin = new System.Windows.Forms.Padding(2);
            this.cboTotal_Cost.Name = "cboTotal_Cost";
            this.cboTotal_Cost.Size = new System.Drawing.Size(60, 20);
            this.cboTotal_Cost.TabIndex = 4;
            // 
            // lblTotal_Cost
            // 
            this.lblTotal_Cost.AutoSize = true;
            this.lblTotal_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblTotal_Cost.Location = new System.Drawing.Point(278, 281);
            this.lblTotal_Cost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal_Cost.Name = "lblTotal_Cost";
            this.lblTotal_Cost.Size = new System.Drawing.Size(81, 18);
            this.lblTotal_Cost.TabIndex = 75;
            this.lblTotal_Cost.Text = "Total Cost:";
            // 
            // btnPlace_Order
            // 
            this.btnPlace_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlace_Order.Location = new System.Drawing.Point(281, 301);
            this.btnPlace_Order.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlace_Order.Name = "btnPlace_Order";
            this.btnPlace_Order.Size = new System.Drawing.Size(136, 46);
            this.btnPlace_Order.TabIndex = 5;
            this.btnPlace_Order.Text = "Place Order";
            this.btnPlace_Order.UseVisualStyleBackColor = true;
            // 
            // lblChoose_Stock
            // 
            this.lblChoose_Stock.AutoSize = true;
            this.lblChoose_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblChoose_Stock.Location = new System.Drawing.Point(45, 93);
            this.lblChoose_Stock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoose_Stock.Name = "lblChoose_Stock";
            this.lblChoose_Stock.Size = new System.Drawing.Size(104, 18);
            this.lblChoose_Stock.TabIndex = 73;
            this.lblChoose_Stock.Text = "Choose Stock";
            // 
            // cboShopping_Cart
            // 
            this.cboShopping_Cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cboShopping_Cart.Location = new System.Drawing.Point(279, 111);
            this.cboShopping_Cart.Margin = new System.Windows.Forms.Padding(2);
            this.cboShopping_Cart.Name = "cboShopping_Cart";
            this.cboShopping_Cart.Size = new System.Drawing.Size(256, 20);
            this.cboShopping_Cart.TabIndex = 3;
            this.cboShopping_Cart.Text = "Stock_ID:    Name:    Description:    Quantity:";
            // 
            // lblShopping_Cart
            // 
            this.lblShopping_Cart.AutoSize = true;
            this.lblShopping_Cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblShopping_Cart.Location = new System.Drawing.Point(276, 93);
            this.lblShopping_Cart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShopping_Cart.Name = "lblShopping_Cart";
            this.lblShopping_Cart.Size = new System.Drawing.Size(102, 18);
            this.lblShopping_Cart.TabIndex = 71;
            this.lblShopping_Cart.Text = "Shopping Cart";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 113);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // cboSearch
            // 
            this.cboSearch.Location = new System.Drawing.Point(70, 113);
            this.cboSearch.Margin = new System.Windows.Forms.Padding(2);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(148, 20);
            this.cboSearch.TabIndex = 80;
            this.cboSearch.TextChanged += new System.EventHandler(this.cboSearch_TextChanged);
            // 
            // cboStock_List
            // 
            this.cboStock_List.FormattingEnabled = true;
            this.cboStock_List.Location = new System.Drawing.Point(48, 130);
            this.cboStock_List.Margin = new System.Windows.Forms.Padding(2);
            this.cboStock_List.Name = "cboStock_List";
            this.cboStock_List.Size = new System.Drawing.Size(170, 21);
            this.cboStock_List.TabIndex = 79;
            this.cboStock_List.SelectedIndexChanged += new System.EventHandler(this.cboStock_List_SelectedIndexChanged);
            // 
            // cboItemList
            // 
            this.cboItemList.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItemList.FormattingEnabled = true;
            this.cboItemList.ItemHeight = 12;
            this.cboItemList.Location = new System.Drawing.Point(279, 130);
            this.cboItemList.Margin = new System.Windows.Forms.Padding(2);
            this.cboItemList.Name = "cboItemList";
            this.cboItemList.Size = new System.Drawing.Size(299, 124);
            this.cboItemList.TabIndex = 82;
            this.cboItemList.SelectedIndexChanged += new System.EventHandler(this.cboItemList_SelectedIndexChanged);
            // 
            // lblRemoveItem
            // 
            this.lblRemoveItem.AutoSize = true;
            this.lblRemoveItem.Location = new System.Drawing.Point(276, 252);
            this.lblRemoveItem.Name = "lblRemoveItem";
            this.lblRemoveItem.Size = new System.Drawing.Size(209, 13);
            this.lblRemoveItem.TabIndex = 83;
            this.lblRemoveItem.Text = "*Tip* to remove an item from cart click on it";
            // 
            // frmPlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblRemoveItem);
            this.Controls.Add(this.cboItemList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.cboStock_List);
            this.Controls.Add(this.lblPlaceOrder);
            this.Controls.Add(this.cboTotal_Cost);
            this.Controls.Add(this.lblTotal_Cost);
            this.Controls.Add(this.btnPlace_Order);
            this.Controls.Add(this.lblChoose_Stock);
            this.Controls.Add(this.cboShopping_Cart);
            this.Controls.Add(this.lblShopping_Cart);
            this.Controls.Add(this.mnuOrderMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPlaceOrder";
            this.Text = "Looney\'s Liquer - [Place Order]";
            this.mnuOrderMenu.ResumeLayout(false);
            this.mnuOrderMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label lblChoose_Stock;
        private System.Windows.Forms.TextBox cboShopping_Cart;
        private System.Windows.Forms.Label lblShopping_Cart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox cboSearch;
        private System.Windows.Forms.ComboBox cboStock_List;
        private System.Windows.Forms.ListBox cboItemList;
        private System.Windows.Forms.Label lblRemoveItem;
    }
}