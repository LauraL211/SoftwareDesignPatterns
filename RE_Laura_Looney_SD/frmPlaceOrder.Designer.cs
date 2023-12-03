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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblPlaceOrder = new System.Windows.Forms.Label();
            this.txtbxTotal_Cost = new System.Windows.Forms.TextBox();
            this.lblTotal_Cost = new System.Windows.Forms.Label();
            this.btnPlace_Order = new System.Windows.Forms.Button();
            this.lblChoose_Stock = new System.Windows.Forms.Label();
            this.txtShopping_Cart = new System.Windows.Forms.TextBox();
            this.lblShopping_Cart = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mnuOrderMenu.SuspendLayout();
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
            this.mnuOrderMenu.Size = new System.Drawing.Size(800, 28);
            this.mnuOrderMenu.TabIndex = 3;
            this.mnuOrderMenu.Text = "menuStrip1";
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(97, 24);
            this.mnuMainMenu.Text = "Main Menu";
            this.mnuMainMenu.Click += new System.EventHandler(this.mnuMainMenu_Click);
            // 
            // mnuOrder
            // 
            this.mnuOrder.Name = "mnuOrder";
            this.mnuOrder.Size = new System.Drawing.Size(102, 24);
            this.mnuOrder.Text = "Order Menu";
            this.mnuOrder.Click += new System.EventHandler(this.mnuOrder_Click);
            // 
            // mnuExxit
            // 
            this.mnuExxit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExxit.Name = "mnuExxit";
            this.mnuExxit.Size = new System.Drawing.Size(47, 24);
            this.mnuExxit.Text = "Exit";
            this.mnuExxit.Click += new System.EventHandler(this.mnuExxit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(143, 141);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(176, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblSearch.Location = new System.Drawing.Point(65, 139);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(72, 22);
            this.lblSearch.TabIndex = 78;
            this.lblSearch.Text = "Search:";
            // 
            // lblPlaceOrder
            // 
            this.lblPlaceOrder.AutoSize = true;
            this.lblPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceOrder.Location = new System.Drawing.Point(298, 35);
            this.lblPlaceOrder.Name = "lblPlaceOrder";
            this.lblPlaceOrder.Size = new System.Drawing.Size(228, 42);
            this.lblPlaceOrder.TabIndex = 77;
            this.lblPlaceOrder.Text = "Place Order";
            // 
            // txtbxTotal_Cost
            // 
            this.txtbxTotal_Cost.Location = new System.Drawing.Point(571, 333);
            this.txtbxTotal_Cost.Name = "txtbxTotal_Cost";
            this.txtbxTotal_Cost.Size = new System.Drawing.Size(79, 22);
            this.txtbxTotal_Cost.TabIndex = 4;
            this.txtbxTotal_Cost.Text = "£000.00";
            // 
            // lblTotal_Cost
            // 
            this.lblTotal_Cost.AutoSize = true;
            this.lblTotal_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblTotal_Cost.Location = new System.Drawing.Point(467, 333);
            this.lblTotal_Cost.Name = "lblTotal_Cost";
            this.lblTotal_Cost.Size = new System.Drawing.Size(98, 22);
            this.lblTotal_Cost.TabIndex = 75;
            this.lblTotal_Cost.Text = "Total Cost:";
            // 
            // btnPlace_Order
            // 
            this.btnPlace_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlace_Order.Location = new System.Drawing.Point(471, 358);
            this.btnPlace_Order.Name = "btnPlace_Order";
            this.btnPlace_Order.Size = new System.Drawing.Size(181, 57);
            this.btnPlace_Order.TabIndex = 5;
            this.btnPlace_Order.Text = "Place Order";
            this.btnPlace_Order.UseVisualStyleBackColor = true;
            // 
            // lblChoose_Stock
            // 
            this.lblChoose_Stock.AutoSize = true;
            this.lblChoose_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblChoose_Stock.Location = new System.Drawing.Point(60, 115);
            this.lblChoose_Stock.Name = "lblChoose_Stock";
            this.lblChoose_Stock.Size = new System.Drawing.Size(122, 22);
            this.lblChoose_Stock.TabIndex = 73;
            this.lblChoose_Stock.Text = "Choose Stock";
            // 
            // txtShopping_Cart
            // 
            this.txtShopping_Cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtShopping_Cart.Location = new System.Drawing.Point(471, 140);
            this.txtShopping_Cart.Name = "txtShopping_Cart";
            this.txtShopping_Cart.Size = new System.Drawing.Size(269, 23);
            this.txtShopping_Cart.TabIndex = 3;
            this.txtShopping_Cart.Text = "Stock_ID:    Name:    Description:    Quantity:";
            // 
            // lblShopping_Cart
            // 
            this.lblShopping_Cart.AutoSize = true;
            this.lblShopping_Cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblShopping_Cart.Location = new System.Drawing.Point(467, 112);
            this.lblShopping_Cart.Name = "lblShopping_Cart";
            this.lblShopping_Cart.Size = new System.Drawing.Size(125, 22);
            this.lblShopping_Cart.TabIndex = 71;
            this.lblShopping_Cart.Text = "Shopping Cart";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 16;
            this.comboBox1.Location = new System.Drawing.Point(64, 161);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(255, 24);
            this.comboBox1.TabIndex = 70;
            // 
            // frmPlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblPlaceOrder);
            this.Controls.Add(this.txtbxTotal_Cost);
            this.Controls.Add(this.lblTotal_Cost);
            this.Controls.Add(this.btnPlace_Order);
            this.Controls.Add(this.lblChoose_Stock);
            this.Controls.Add(this.txtShopping_Cart);
            this.Controls.Add(this.lblShopping_Cart);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.mnuOrderMenu);
            this.Name = "frmPlaceOrder";
            this.Text = "Looney\'s Liquer - [Place Order]";
            this.mnuOrderMenu.ResumeLayout(false);
            this.mnuOrderMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuOrderMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuExxit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblPlaceOrder;
        private System.Windows.Forms.TextBox txtbxTotal_Cost;
        private System.Windows.Forms.Label lblTotal_Cost;
        private System.Windows.Forms.Button btnPlace_Order;
        private System.Windows.Forms.Label lblChoose_Stock;
        private System.Windows.Forms.TextBox txtShopping_Cart;
        private System.Windows.Forms.Label lblShopping_Cart;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}