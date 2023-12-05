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
            this.lblRemoveItem = new System.Windows.Forms.Label();
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
            this.mnuStockMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuStockMenu.Size = new System.Drawing.Size(600, 24);
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
            // cboItemList
            // 
            this.cboItemList.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItemList.FormattingEnabled = true;
            this.cboItemList.ItemHeight = 12;
            this.cboItemList.Location = new System.Drawing.Point(276, 133);
            this.cboItemList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboItemList.Name = "cboItemList";
            this.cboItemList.Size = new System.Drawing.Size(299, 124);
            this.cboItemList.TabIndex = 77;
            this.cboItemList.SelectedIndexChanged += new System.EventHandler(this.cboItemList_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 133);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // cboSearch
            // 
            this.cboSearch.Location = new System.Drawing.Point(52, 133);
            this.cboSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(148, 20);
            this.cboSearch.TabIndex = 75;
            this.cboSearch.TextChanged += new System.EventHandler(this.cboSearch_TextChanged);
            // 
            // btnOrder_Items
            // 
            this.btnOrder_Items.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder_Items.Location = new System.Drawing.Point(335, 286);
            this.btnOrder_Items.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.lblChoose_Stock.Location = new System.Drawing.Point(27, 89);
            this.lblChoose_Stock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoose_Stock.Name = "lblChoose_Stock";
            this.lblChoose_Stock.Size = new System.Drawing.Size(104, 18);
            this.lblChoose_Stock.TabIndex = 73;
            this.lblChoose_Stock.Text = "Choose Stock";
            // 
            // txtShopping_Cart
            // 
            this.txtShopping_Cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtShopping_Cart.Location = new System.Drawing.Point(276, 109);
            this.txtShopping_Cart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtShopping_Cart.Name = "txtShopping_Cart";
            this.txtShopping_Cart.ReadOnly = true;
            this.txtShopping_Cart.Size = new System.Drawing.Size(299, 20);
            this.txtShopping_Cart.TabIndex = 72;
            this.txtShopping_Cart.Text = "Stock_ID:    Name:         Description:    Quantity:";
            // 
            // lblShopping_Cart
            // 
            this.lblShopping_Cart.AutoSize = true;
            this.lblShopping_Cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblShopping_Cart.Location = new System.Drawing.Point(273, 89);
            this.lblShopping_Cart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShopping_Cart.Name = "lblShopping_Cart";
            this.lblShopping_Cart.Size = new System.Drawing.Size(40, 18);
            this.lblShopping_Cart.TabIndex = 71;
            this.lblShopping_Cart.Text = " Cart";
            // 
            // cboStock_List
            // 
            this.cboStock_List.FormattingEnabled = true;
            this.cboStock_List.Location = new System.Drawing.Point(30, 150);
            this.cboStock_List.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboStock_List.Name = "cboStock_List";
            this.cboStock_List.Size = new System.Drawing.Size(170, 21);
            this.cboStock_List.TabIndex = 70;
            this.cboStock_List.SelectedIndexChanged += new System.EventHandler(this.cboStock_List_SelectedIndexChanged);
            // 
            // cboLowStock
            // 
            this.cboLowStock.AutoSize = true;
            this.cboLowStock.Location = new System.Drawing.Point(30, 109);
            this.cboLowStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.lblReplenishStock.Location = new System.Drawing.Point(186, 33);
            this.lblReplenishStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReplenishStock.Name = "lblReplenishStock";
            this.lblReplenishStock.Size = new System.Drawing.Size(247, 36);
            this.lblReplenishStock.TabIndex = 68;
            this.lblReplenishStock.Text = "Replenish Stock";
            // 
            // lblRemoveItem
            // 
            this.lblRemoveItem.AutoSize = true;
            this.lblRemoveItem.Location = new System.Drawing.Point(273, 259);
            this.lblRemoveItem.Name = "lblRemoveItem";
            this.lblRemoveItem.Size = new System.Drawing.Size(209, 13);
            this.lblRemoveItem.TabIndex = 78;
            this.lblRemoveItem.Text = "*Tip* to remove an item from cart click on it";
            // 
            // frmReplenishStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblRemoveItem);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label lblRemoveItem;
    }
}