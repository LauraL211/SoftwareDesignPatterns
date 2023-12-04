namespace RE_Laura_Looney_SD
{
    partial class frmAddStock
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
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAddStock = new System.Windows.Forms.Label();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.cboDescription = new System.Windows.Forms.TextBox();
            this.cboPrice = new System.Windows.Forms.TextBox();
            this.cboReorderLVL = new System.Windows.Forms.TextBox();
            this.cboQuantity = new System.Windows.Forms.TextBox();
            this.cboName = new System.Windows.Forms.TextBox();
            this.lblReorderLevel = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.mnuStockMenu.SuspendLayout();
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
            this.mnuStockMenu.TabIndex = 3;
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
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Whiskey",
            "Spirit",
            "Bourbon",
            "Gin",
            "Cider",
            "Non-Alcho"});
            this.cboType.Location = new System.Drawing.Point(346, 190);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 24);
            this.cboType.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(202, 190);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(56, 22);
            this.lblType.TabIndex = 15;
            this.lblType.Text = "Type:";
            // 
            // lblAddStock
            // 
            this.lblAddStock.AutoSize = true;
            this.lblAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStock.Location = new System.Drawing.Point(322, 44);
            this.lblAddStock.Name = "lblAddStock";
            this.lblAddStock.Size = new System.Drawing.Size(198, 42);
            this.lblAddStock.TabIndex = 10;
            this.lblAddStock.Text = "Add Stock";
            // 
            // btnAddStock
            // 
            this.btnAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStock.Location = new System.Drawing.Point(346, 366);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(150, 50);
            this.btnAddStock.TabIndex = 7;
            this.btnAddStock.Text = "Add Stock";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // cboDescription
            // 
            this.cboDescription.Location = new System.Drawing.Point(346, 152);
            this.cboDescription.MaxLength = 30;
            this.cboDescription.Name = "cboDescription";
            this.cboDescription.Size = new System.Drawing.Size(183, 22);
            this.cboDescription.TabIndex = 2;
            // 
            // cboPrice
            // 
            this.cboPrice.Location = new System.Drawing.Point(346, 229);
            this.cboPrice.MaxLength = 5;
            this.cboPrice.Name = "cboPrice";
            this.cboPrice.Size = new System.Drawing.Size(63, 22);
            this.cboPrice.TabIndex = 4;
            // 
            // cboReorderLVL
            // 
            this.cboReorderLVL.Location = new System.Drawing.Point(346, 300);
            this.cboReorderLVL.MaxLength = 3;
            this.cboReorderLVL.Name = "cboReorderLVL";
            this.cboReorderLVL.Size = new System.Drawing.Size(63, 22);
            this.cboReorderLVL.TabIndex = 6;
            // 
            // cboQuantity
            // 
            this.cboQuantity.Location = new System.Drawing.Point(346, 263);
            this.cboQuantity.MaxLength = 3;
            this.cboQuantity.Name = "cboQuantity";
            this.cboQuantity.Size = new System.Drawing.Size(63, 22);
            this.cboQuantity.TabIndex = 5;
            // 
            // cboName
            // 
            this.cboName.Location = new System.Drawing.Point(346, 114);
            this.cboName.MaxLength = 20;
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(158, 22);
            this.cboName.TabIndex = 1;
            // 
            // lblReorderLevel
            // 
            this.lblReorderLevel.AutoSize = true;
            this.lblReorderLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReorderLevel.Location = new System.Drawing.Point(202, 298);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(128, 22);
            this.lblReorderLevel.TabIndex = 21;
            this.lblReorderLevel.Text = "Reorder Level:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(202, 261);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(82, 22);
            this.lblQuantity.TabIndex = 19;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(202, 227);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 22);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Price:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(202, 152);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(105, 22);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(202, 114);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 22);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name:";
            // 
            // frmAddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAddStock);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.cboDescription);
            this.Controls.Add(this.cboPrice);
            this.Controls.Add(this.cboReorderLVL);
            this.Controls.Add(this.cboQuantity);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.lblReorderLevel);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.mnuStockMenu);
            this.Name = "frmAddStock";
            this.Text = "Looney\'s Liquer - [Add Stock]";
            this.mnuStockMenu.ResumeLayout(false);
            this.mnuStockMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStockMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuStock;
        private System.Windows.Forms.ToolStripMenuItem mnuExxit;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAddStock;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.TextBox cboDescription;
        private System.Windows.Forms.TextBox cboPrice;
        private System.Windows.Forms.TextBox cboReorderLVL;
        private System.Windows.Forms.TextBox cboQuantity;
        private System.Windows.Forms.TextBox cboName;
        private System.Windows.Forms.Label lblReorderLevel;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
    }
}