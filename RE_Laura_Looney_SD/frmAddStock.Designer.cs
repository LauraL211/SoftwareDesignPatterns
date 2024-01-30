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
            this.mnuStockMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuStockMenu.Name = "mnuStockMenu";
            this.mnuStockMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuStockMenu.Size = new System.Drawing.Size(600, 24);
            this.mnuStockMenu.TabIndex = 3;
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
            this.cboType.Location = new System.Drawing.Point(260, 154);
            this.cboType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(92, 21);
            this.cboType.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(152, 154);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 18);
            this.lblType.TabIndex = 15;
            this.lblType.Text = "Type:";
            // 
            // lblAddStock
            // 
            this.lblAddStock.AutoSize = true;
            this.lblAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStock.Location = new System.Drawing.Point(242, 36);
            this.lblAddStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddStock.Name = "lblAddStock";
            this.lblAddStock.Size = new System.Drawing.Size(162, 36);
            this.lblAddStock.TabIndex = 10;
            this.lblAddStock.Text = "Add Stock";
            // 
            // btnAddStock
            // 
            this.btnAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStock.Location = new System.Drawing.Point(260, 297);
            this.btnAddStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(112, 41);
            this.btnAddStock.TabIndex = 7;
            this.btnAddStock.Text = "Add Stock";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // cboDescription
            // 
            this.cboDescription.Location = new System.Drawing.Point(260, 124);
            this.cboDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboDescription.MaxLength = 30;
            this.cboDescription.Name = "cboDescription";
            this.cboDescription.Size = new System.Drawing.Size(138, 20);
            this.cboDescription.TabIndex = 2;
            // 
            // cboPrice
            // 
            this.cboPrice.Location = new System.Drawing.Point(260, 186);
            this.cboPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboPrice.MaxLength = 5;
            this.cboPrice.Name = "cboPrice";
            this.cboPrice.Size = new System.Drawing.Size(48, 20);
            this.cboPrice.TabIndex = 4;
            // 
            // cboReorderLVL
            // 
            this.cboReorderLVL.Location = new System.Drawing.Point(260, 244);
            this.cboReorderLVL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboReorderLVL.MaxLength = 3;
            this.cboReorderLVL.Name = "cboReorderLVL";
            this.cboReorderLVL.Size = new System.Drawing.Size(48, 20);
            this.cboReorderLVL.TabIndex = 6;
            // 
            // cboQuantity
            // 
            this.cboQuantity.Location = new System.Drawing.Point(260, 214);
            this.cboQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboQuantity.MaxLength = 3;
            this.cboQuantity.Name = "cboQuantity";
            this.cboQuantity.Size = new System.Drawing.Size(48, 20);
            this.cboQuantity.TabIndex = 5;
            // 
            // cboName
            // 
            this.cboName.Location = new System.Drawing.Point(260, 93);
            this.cboName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboName.MaxLength = 20;
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(120, 20);
            this.cboName.TabIndex = 1;
            // 
            // lblReorderLevel
            // 
            this.lblReorderLevel.AutoSize = true;
            this.lblReorderLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReorderLevel.Location = new System.Drawing.Point(152, 242);
            this.lblReorderLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(104, 18);
            this.lblReorderLevel.TabIndex = 21;
            this.lblReorderLevel.Text = "Reorder Level:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(152, 212);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(66, 18);
            this.lblQuantity.TabIndex = 19;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(152, 184);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 18);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Price:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(152, 124);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(87, 18);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(152, 93);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 18);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name:";
            // 
            // frmAddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAddStock";
            this.Text = "Looney\'s Liquer - [Add Stock]";
            this.Load += new System.EventHandler(this.frmAddStock_Load);
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