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
            this.btnCancel_Order = new System.Windows.Forms.Button();
            this.lblChoose_Order = new System.Windows.Forms.Label();
            this.txtShopping_Cart = new System.Windows.Forms.TextBox();
            this.lblShopping_Cart = new System.Windows.Forms.Label();
            this.cboChooseOrder = new System.Windows.Forms.ComboBox();
            this.cboListBox = new System.Windows.Forms.ListBox();
            this.cboTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
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
            this.mnuOrderMenu.TabIndex = 2;
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
            // lblCancelOrder
            // 
            this.lblCancelOrder.AutoSize = true;
            this.lblCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelOrder.Location = new System.Drawing.Point(298, 35);
            this.lblCancelOrder.Name = "lblCancelOrder";
            this.lblCancelOrder.Size = new System.Drawing.Size(252, 42);
            this.lblCancelOrder.TabIndex = 87;
            this.lblCancelOrder.Text = "Cancel Order";
            // 
            // btnCancel_Order
            // 
            this.btnCancel_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel_Order.Location = new System.Drawing.Point(471, 358);
            this.btnCancel_Order.Name = "btnCancel_Order";
            this.btnCancel_Order.Size = new System.Drawing.Size(181, 57);
            this.btnCancel_Order.TabIndex = 4;
            this.btnCancel_Order.Text = "Cancel Order";
            this.btnCancel_Order.UseVisualStyleBackColor = true;
            this.btnCancel_Order.Click += new System.EventHandler(this.btnCancel_Order_Click);
            // 
            // lblChoose_Order
            // 
            this.lblChoose_Order.AutoSize = true;
            this.lblChoose_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblChoose_Order.Location = new System.Drawing.Point(60, 115);
            this.lblChoose_Order.Name = "lblChoose_Order";
            this.lblChoose_Order.Size = new System.Drawing.Size(128, 22);
            this.lblChoose_Order.TabIndex = 85;
            this.lblChoose_Order.Text = "Choose Order:";
            // 
            // txtShopping_Cart
            // 
            this.txtShopping_Cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtShopping_Cart.Location = new System.Drawing.Point(471, 140);
            this.txtShopping_Cart.Name = "txtShopping_Cart";
            this.txtShopping_Cart.Size = new System.Drawing.Size(269, 23);
            this.txtShopping_Cart.TabIndex = 2;
            this.txtShopping_Cart.Text = "Name:    Description:    Quantity:";
            // 
            // lblShopping_Cart
            // 
            this.lblShopping_Cart.AutoSize = true;
            this.lblShopping_Cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblShopping_Cart.Location = new System.Drawing.Point(467, 112);
            this.lblShopping_Cart.Name = "lblShopping_Cart";
            this.lblShopping_Cart.Size = new System.Drawing.Size(125, 22);
            this.lblShopping_Cart.TabIndex = 83;
            this.lblShopping_Cart.Text = "Shopping Cart";
            // 
            // cboChooseOrder
            // 
            this.cboChooseOrder.FormattingEnabled = true;
            this.cboChooseOrder.Location = new System.Drawing.Point(64, 139);
            this.cboChooseOrder.Name = "cboChooseOrder";
            this.cboChooseOrder.Size = new System.Drawing.Size(255, 24);
            this.cboChooseOrder.TabIndex = 1;
            this.cboChooseOrder.SelectedIndexChanged += new System.EventHandler(this.cboChooseOrder_SelectedIndexChanged);
            // 
            // cboListBox
            // 
            this.cboListBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboListBox.FormattingEnabled = true;
            this.cboListBox.ItemHeight = 18;
            this.cboListBox.Location = new System.Drawing.Point(471, 160);
            this.cboListBox.Name = "cboListBox";
            this.cboListBox.Size = new System.Drawing.Size(269, 94);
            this.cboListBox.TabIndex = 2;
            // 
            // cboTotal
            // 
            this.cboTotal.Location = new System.Drawing.Point(471, 277);
            this.cboTotal.Name = "cboTotal";
            this.cboTotal.ReadOnly = true;
            this.cboTotal.Size = new System.Drawing.Size(71, 22);
            this.cboTotal.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblTotal.Location = new System.Drawing.Point(467, 257);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 22);
            this.lblTotal.TabIndex = 89;
            this.lblTotal.Text = "Total:";
            // 
            // frmCancelOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cboTotal);
            this.Controls.Add(this.cboListBox);
            this.Controls.Add(this.lblCancelOrder);
            this.Controls.Add(this.btnCancel_Order);
            this.Controls.Add(this.lblChoose_Order);
            this.Controls.Add(this.txtShopping_Cart);
            this.Controls.Add(this.lblShopping_Cart);
            this.Controls.Add(this.cboChooseOrder);
            this.Controls.Add(this.mnuOrderMenu);
            this.Name = "frmCancelOrder";
            this.Text = "Looney\'s Liquer -[Cancel Order]";
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
        private System.Windows.Forms.Label lblCancelOrder;
        private System.Windows.Forms.Button btnCancel_Order;
        private System.Windows.Forms.Label lblChoose_Order;
        private System.Windows.Forms.TextBox txtShopping_Cart;
        private System.Windows.Forms.Label lblShopping_Cart;
        private System.Windows.Forms.ComboBox cboChooseOrder;
        private System.Windows.Forms.ListBox cboListBox;
        private System.Windows.Forms.TextBox cboTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}