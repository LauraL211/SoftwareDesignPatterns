namespace RE_Laura_Looney_SD
{
    partial class frmStockMenu
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
            this.mnuAdminMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExxit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCheck_Stock = new System.Windows.Forms.Button();
            this.btnReplenishStock = new System.Windows.Forms.Button();
            this.btnDeleteStock = new System.Windows.Forms.Button();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.mnuStockMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStockMenu
            // 
            this.mnuStockMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuStockMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenu,
            this.mnuAdminMenu,
            this.mnuExxit});
            this.mnuStockMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuStockMenu.Name = "mnuStockMenu";
            this.mnuStockMenu.Size = new System.Drawing.Size(800, 28);
            this.mnuStockMenu.TabIndex = 1;
            this.mnuStockMenu.Text = "menuStrip1";
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(97, 24);
            this.mnuMainMenu.Text = "Main Menu";
            this.mnuMainMenu.Click += new System.EventHandler(this.mnuMainMenu_Click);
            // 
            // mnuAdminMenu
            // 
            this.mnuAdminMenu.Name = "mnuAdminMenu";
            this.mnuAdminMenu.Size = new System.Drawing.Size(108, 24);
            this.mnuAdminMenu.Text = "Admin Menu";
            this.mnuAdminMenu.Click += new System.EventHandler(this.mnuAdminMenu_Click);
            // 
            // mnuExxit
            // 
            this.mnuExxit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExxit.Name = "mnuExxit";
            this.mnuExxit.Size = new System.Drawing.Size(47, 24);
            this.mnuExxit.Text = "Exit";
            this.mnuExxit.Click += new System.EventHandler(this.mnuExxit_Click);
            // 
            // btnCheck_Stock
            // 
            this.btnCheck_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck_Stock.Location = new System.Drawing.Point(211, 234);
            this.btnCheck_Stock.Name = "btnCheck_Stock";
            this.btnCheck_Stock.Size = new System.Drawing.Size(178, 82);
            this.btnCheck_Stock.TabIndex = 4;
            this.btnCheck_Stock.Text = "Check Stock";
            this.btnCheck_Stock.UseVisualStyleBackColor = true;
            this.btnCheck_Stock.Click += new System.EventHandler(this.btnCheck_Stock_Click);
            // 
            // btnReplenishStock
            // 
            this.btnReplenishStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplenishStock.Location = new System.Drawing.Point(414, 234);
            this.btnReplenishStock.Name = "btnReplenishStock";
            this.btnReplenishStock.Size = new System.Drawing.Size(178, 82);
            this.btnReplenishStock.TabIndex = 5;
            this.btnReplenishStock.Text = "Replenish Stock";
            this.btnReplenishStock.UseVisualStyleBackColor = true;
            this.btnReplenishStock.Click += new System.EventHandler(this.btnReplenishStock_Click);
            // 
            // btnDeleteStock
            // 
            this.btnDeleteStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStock.Location = new System.Drawing.Point(505, 134);
            this.btnDeleteStock.Name = "btnDeleteStock";
            this.btnDeleteStock.Size = new System.Drawing.Size(178, 82);
            this.btnDeleteStock.TabIndex = 3;
            this.btnDeleteStock.Text = "Delete Stock";
            this.btnDeleteStock.UseVisualStyleBackColor = true;
            this.btnDeleteStock.Click += new System.EventHandler(this.btnDeleteStock_Click);
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdateStock.Location = new System.Drawing.Point(308, 134);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(178, 82);
            this.btnUpdateStock.TabIndex = 2;
            this.btnUpdateStock.Text = "Update Stock";
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddStock.Location = new System.Drawing.Point(117, 134);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(178, 82);
            this.btnAddStock.TabIndex = 1;
            this.btnAddStock.Text = "Add Stock";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // frmStockMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheck_Stock);
            this.Controls.Add(this.btnReplenishStock);
            this.Controls.Add(this.btnDeleteStock);
            this.Controls.Add(this.btnUpdateStock);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.mnuStockMenu);
            this.Name = "frmStockMenu";
            this.Text = "Looney\'s Liquer - [Stock Menu]";
            this.mnuStockMenu.ResumeLayout(false);
            this.mnuStockMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStockMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuAdminMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuExxit;
        private System.Windows.Forms.Button btnCheck_Stock;
        private System.Windows.Forms.Button btnReplenishStock;
        private System.Windows.Forms.Button btnDeleteStock;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.Button btnAddStock;
    }
}