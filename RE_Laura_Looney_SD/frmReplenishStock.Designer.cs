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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReplenishStock));
            this.mnuStockMenu = new System.Windows.Forms.MenuStrip();
            this.mnuMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExxit = new System.Windows.Forms.ToolStripMenuItem();
            this.cboItemList = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboSearch = new System.Windows.Forms.TextBox();
            this.btnOrder_Items = new System.Windows.Forms.Button();
            this.lblChoose_Stock = new System.Windows.Forms.Label();
            this.txtShopping_Cart = new System.Windows.Forms.TextBox();
            this.lblShopping_Cart = new System.Windows.Forms.Label();
            this.cboStock_List = new System.Windows.Forms.ComboBox();
            this.cboLowStock = new System.Windows.Forms.CheckBox();
            this.lblReplenishStock = new System.Windows.Forms.Label();
            this.mnuStockMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.mnuStockMenu.Size = new System.Drawing.Size(800, 28);
            this.mnuStockMenu.TabIndex = 4;
            this.mnuStockMenu.Text = "menuStrip1";
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(97, 24);
            this.mnuMainMenu.Text = "Main Menu";
            this.mnuMainMenu.Click += new System.EventHandler(this.mnuMainMenu_Click);
            // 
            // mnuStock
            // 
            this.mnuStock.Name = "mnuStock";
            this.mnuStock.Size = new System.Drawing.Size(100, 24);
            this.mnuStock.Text = "Stock Menu";
            this.mnuStock.Click += new System.EventHandler(this.mnuStock_Click);
            // 
            // mnuExxit
            // 
            this.mnuExxit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExxit.Name = "mnuExxit";
            this.mnuExxit.Size = new System.Drawing.Size(47, 24);
            this.mnuExxit.Text = "Exit";
            this.mnuExxit.Click += new System.EventHandler(this.mnuExxit_Click);
            // 
            // cboItemList
            // 
            this.cboItemList.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItemList.FormattingEnabled = true;
            this.cboItemList.ItemHeight = 16;
            this.cboItemList.Location = new System.Drawing.Point(368, 164);
            this.cboItemList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboItemList.Name = "cboItemList";
            this.cboItemList.Size = new System.Drawing.Size(397, 164);
            this.cboItemList.TabIndex = 77;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 164);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // cboSearch
            // 
            this.cboSearch.Location = new System.Drawing.Point(69, 164);
            this.cboSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(196, 22);
            this.cboSearch.TabIndex = 75;
            this.cboSearch.TextChanged += new System.EventHandler(this.cboSearch_TextChanged);
            // 
            // btnOrder_Items
            // 
            this.btnOrder_Items.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder_Items.Location = new System.Drawing.Point(447, 352);
            this.btnOrder_Items.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrder_Items.Name = "btnOrder_Items";
            this.btnOrder_Items.Size = new System.Drawing.Size(181, 57);
            this.btnOrder_Items.TabIndex = 74;
            this.btnOrder_Items.Text = "Order Items";
            this.btnOrder_Items.UseVisualStyleBackColor = true;
            this.btnOrder_Items.Click += new System.EventHandler(this.btnOrder_Items_Click);
            // 
            // lblChoose_Stock
            // 
            this.lblChoose_Stock.AutoSize = true;
            this.lblChoose_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblChoose_Stock.Location = new System.Drawing.Point(36, 109);
            this.lblChoose_Stock.Name = "lblChoose_Stock";
            this.lblChoose_Stock.Size = new System.Drawing.Size(122, 22);
            this.lblChoose_Stock.TabIndex = 73;
            this.lblChoose_Stock.Text = "Choose Stock";
            // 
            // txtShopping_Cart
            // 
            this.txtShopping_Cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtShopping_Cart.Location = new System.Drawing.Point(368, 134);
            this.txtShopping_Cart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtShopping_Cart.Name = "txtShopping_Cart";
            this.txtShopping_Cart.Size = new System.Drawing.Size(397, 23);
            this.txtShopping_Cart.TabIndex = 72;
            this.txtShopping_Cart.Text = "Stock_ID:    Name:         Description:    Quantity:";
            // 
            // lblShopping_Cart
            // 
            this.lblShopping_Cart.AutoSize = true;
            this.lblShopping_Cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblShopping_Cart.Location = new System.Drawing.Point(377, 109);
            this.lblShopping_Cart.Name = "lblShopping_Cart";
            this.lblShopping_Cart.Size = new System.Drawing.Size(49, 22);
            this.lblShopping_Cart.TabIndex = 71;
            this.lblShopping_Cart.Text = " Cart";
            // 
            // cboStock_List
            // 
            this.cboStock_List.FormattingEnabled = true;
            this.cboStock_List.Location = new System.Drawing.Point(40, 185);
            this.cboStock_List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboStock_List.Name = "cboStock_List";
            this.cboStock_List.Size = new System.Drawing.Size(225, 24);
            this.cboStock_List.TabIndex = 70;
            this.cboStock_List.SelectedIndexChanged += new System.EventHandler(this.cboStock_List_SelectedIndexChanged);
            // 
            // cboLowStock
            // 
            this.cboLowStock.AutoSize = true;
            this.cboLowStock.Location = new System.Drawing.Point(40, 134);
            this.cboLowStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLowStock.Name = "cboLowStock";
            this.cboLowStock.Size = new System.Drawing.Size(90, 20);
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
            this.lblReplenishStock.Location = new System.Drawing.Point(248, 41);
            this.lblReplenishStock.Name = "lblReplenishStock";
            this.lblReplenishStock.Size = new System.Drawing.Size(304, 42);
            this.lblReplenishStock.TabIndex = 68;
            this.lblReplenishStock.Text = "Replenish Stock";
            // 
            // frmReplenishStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboItemList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.btnOrder_Items);
            this.Controls.Add(this.lblChoose_Stock);
            this.Controls.Add(this.txtShopping_Cart);
            this.Controls.Add(this.lblShopping_Cart);
            this.Controls.Add(this.cboStock_List);
            this.Controls.Add(this.cboLowStock);
            this.Controls.Add(this.lblReplenishStock);
            this.Controls.Add(this.mnuStockMenu);
            this.Name = "frmReplenishStock";
            this.Text = "Looney\'s Liquer - [Replenish Stock]";
            this.mnuStockMenu.ResumeLayout(false);
            this.mnuStockMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStockMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuStock;
        private System.Windows.Forms.ToolStripMenuItem mnuExxit;
        private System.Windows.Forms.ListBox cboItemList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox cboSearch;
        private System.Windows.Forms.Button btnOrder_Items;
        private System.Windows.Forms.Label lblChoose_Stock;
        private System.Windows.Forms.TextBox txtShopping_Cart;
        private System.Windows.Forms.Label lblShopping_Cart;
        private System.Windows.Forms.ComboBox cboStock_List;
        private System.Windows.Forms.CheckBox cboLowStock;
        private System.Windows.Forms.Label lblReplenishStock;
    }
}