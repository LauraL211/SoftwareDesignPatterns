namespace RE_Laura_Looney_SD
{
    partial class frmCollectOrder
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.cboTotal = new System.Windows.Forms.TextBox();
            this.cboListBox = new System.Windows.Forms.ListBox();
            this.lblCollectOrder = new System.Windows.Forms.Label();
            this.btnCollectOrder = new System.Windows.Forms.Button();
            this.lblChoose_Order = new System.Windows.Forms.Label();
            this.lblShopping_Cart = new System.Windows.Forms.Label();
            this.cboChooseOrder = new System.Windows.Forms.ComboBox();
            this.mnuOrderMenu = new System.Windows.Forms.MenuStrip();
            this.mnuMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExxit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCustID = new System.Windows.Forms.Label();
            this.cboCustID = new System.Windows.Forms.TextBox();
            this.mnuOrderMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblTotal.Location = new System.Drawing.Point(467, 288);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 22);
            this.lblTotal.TabIndex = 99;
            this.lblTotal.Text = "Total:";
            this.lblTotal.Visible = false;
            // 
            // cboTotal
            // 
            this.cboTotal.Location = new System.Drawing.Point(471, 313);
            this.cboTotal.Name = "cboTotal";
            this.cboTotal.ReadOnly = true;
            this.cboTotal.Size = new System.Drawing.Size(71, 22);
            this.cboTotal.TabIndex = 94;
            this.cboTotal.Visible = false;
            // 
            // cboListBox
            // 
            this.cboListBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboListBox.FormattingEnabled = true;
            this.cboListBox.ItemHeight = 18;
            this.cboListBox.Location = new System.Drawing.Point(471, 172);
            this.cboListBox.Name = "cboListBox";
            this.cboListBox.Size = new System.Drawing.Size(269, 94);
            this.cboListBox.TabIndex = 91;
            this.cboListBox.Visible = false;
            // 
            // lblCollectOrder
            // 
            this.lblCollectOrder.AutoSize = true;
            this.lblCollectOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollectOrder.Location = new System.Drawing.Point(298, 53);
            this.lblCollectOrder.Name = "lblCollectOrder";
            this.lblCollectOrder.Size = new System.Drawing.Size(250, 42);
            this.lblCollectOrder.TabIndex = 98;
            this.lblCollectOrder.Text = "Collect Order";
            // 
            // btnCollectOrder
            // 
            this.btnCollectOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollectOrder.Location = new System.Drawing.Point(471, 376);
            this.btnCollectOrder.Name = "btnCollectOrder";
            this.btnCollectOrder.Size = new System.Drawing.Size(181, 57);
            this.btnCollectOrder.TabIndex = 95;
            this.btnCollectOrder.Text = "Collect Order";
            this.btnCollectOrder.UseVisualStyleBackColor = true;
            this.btnCollectOrder.Visible = false;
            this.btnCollectOrder.Click += new System.EventHandler(this.btnCollectOrder_Click);
            // 
            // lblChoose_Order
            // 
            this.lblChoose_Order.AutoSize = true;
            this.lblChoose_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblChoose_Order.Location = new System.Drawing.Point(60, 172);
            this.lblChoose_Order.Name = "lblChoose_Order";
            this.lblChoose_Order.Size = new System.Drawing.Size(128, 22);
            this.lblChoose_Order.TabIndex = 97;
            this.lblChoose_Order.Text = "Choose Order:";
            this.lblChoose_Order.Visible = false;
            // 
            // lblShopping_Cart
            // 
            this.lblShopping_Cart.AutoSize = true;
            this.lblShopping_Cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblShopping_Cart.Location = new System.Drawing.Point(467, 143);
            this.lblShopping_Cart.Name = "lblShopping_Cart";
            this.lblShopping_Cart.Size = new System.Drawing.Size(125, 22);
            this.lblShopping_Cart.TabIndex = 96;
            this.lblShopping_Cart.Text = "Shopping Cart";
            this.lblShopping_Cart.Visible = false;
            // 
            // cboChooseOrder
            // 
            this.cboChooseOrder.FormattingEnabled = true;
            this.cboChooseOrder.Location = new System.Drawing.Point(64, 191);
            this.cboChooseOrder.Name = "cboChooseOrder";
            this.cboChooseOrder.Size = new System.Drawing.Size(255, 24);
            this.cboChooseOrder.TabIndex = 90;
            this.cboChooseOrder.Visible = false;
            this.cboChooseOrder.SelectedIndexChanged += new System.EventHandler(this.cboChooseOrder_SelectedIndexChanged);
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
            this.mnuOrderMenu.TabIndex = 93;
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
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblCustID.Location = new System.Drawing.Point(60, 109);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(114, 22);
            this.lblCustID.TabIndex = 100;
            this.lblCustID.Text = "Customer ID:";
            // 
            // cboCustID
            // 
            this.cboCustID.Location = new System.Drawing.Point(64, 134);
            this.cboCustID.Name = "cboCustID";
            this.cboCustID.Size = new System.Drawing.Size(100, 22);
            this.cboCustID.TabIndex = 101;
            this.cboCustID.TextChanged += new System.EventHandler(this.cboCustID_TextChanged);
            // 
            // frmCollectOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboCustID);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cboTotal);
            this.Controls.Add(this.cboListBox);
            this.Controls.Add(this.lblCollectOrder);
            this.Controls.Add(this.btnCollectOrder);
            this.Controls.Add(this.lblChoose_Order);
            this.Controls.Add(this.lblShopping_Cart);
            this.Controls.Add(this.cboChooseOrder);
            this.Controls.Add(this.mnuOrderMenu);
            this.Name = "frmCollectOrder";
            this.Text = "Looney\'s Liquer - [Collect Order]";
            this.Load += new System.EventHandler(this.frmCollectOrder_Load);
            this.mnuOrderMenu.ResumeLayout(false);
            this.mnuOrderMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox cboTotal;
        private System.Windows.Forms.ListBox cboListBox;
        private System.Windows.Forms.Label lblCollectOrder;
        private System.Windows.Forms.Button btnCollectOrder;
        private System.Windows.Forms.Label lblChoose_Order;
        private System.Windows.Forms.Label lblShopping_Cart;
        private System.Windows.Forms.ComboBox cboChooseOrder;
        private System.Windows.Forms.MenuStrip mnuOrderMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuExxit;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.TextBox cboCustID;
    }
}