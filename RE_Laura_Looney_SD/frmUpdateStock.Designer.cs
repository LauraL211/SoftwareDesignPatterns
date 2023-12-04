namespace RE_Laura_Looney_SD
{
    partial class frmUpdateStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateStock));
            this.mnuStockMenu = new System.Windows.Forms.MenuStrip();
            this.mnuMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExxit = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.cboSearch = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblStock_List = new System.Windows.Forms.Label();
            this.cboStock_List = new System.Windows.Forms.ComboBox();
            this.lblUpdateStock = new System.Windows.Forms.Label();
            this.btnUpdateStock = new System.Windows.Forms.Button();
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
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
            this.cboType.Location = new System.Drawing.Point(559, 188);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(107, 24);
            this.cboType.TabIndex = 40;
            // 
            // cboSearch
            // 
            this.cboSearch.Location = new System.Drawing.Point(69, 138);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(181, 22);
            this.cboSearch.TabIndex = 32;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(415, 186);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(56, 22);
            this.lblType.TabIndex = 39;
            this.lblType.Text = "Type:";
            // 
            // lblStock_List
            // 
            this.lblStock_List.AutoSize = true;
            this.lblStock_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock_List.Location = new System.Drawing.Point(36, 112);
            this.lblStock_List.Name = "lblStock_List";
            this.lblStock_List.Size = new System.Drawing.Size(110, 22);
            this.lblStock_List.TabIndex = 34;
            this.lblStock_List.Text = "Search Item:";
            // 
            // cboStock_List
            // 
            this.cboStock_List.FormattingEnabled = true;
            this.cboStock_List.Items.AddRange(new object[] {
            "1: Jameson, Black Barrell, Whiskey",
            "2: Smirnoff, Original, Vodka",
            "3: Cognak, Original, Brandy",
            "4: Baileys, Original, Liqeur",
            "5: Grey Goose, Original, Vodka"});
            this.cboStock_List.Location = new System.Drawing.Point(40, 165);
            this.cboStock_List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboStock_List.Name = "cboStock_List";
            this.cboStock_List.Size = new System.Drawing.Size(210, 24);
            this.cboStock_List.TabIndex = 33;
            this.cboStock_List.SelectedIndexChanged += new System.EventHandler(this.cboStock_List_SelectedIndexChanged);
            // 
            // lblUpdateStock
            // 
            this.lblUpdateStock.AutoSize = true;
            this.lblUpdateStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateStock.Location = new System.Drawing.Point(252, 20);
            this.lblUpdateStock.Name = "lblUpdateStock";
            this.lblUpdateStock.Size = new System.Drawing.Size(255, 42);
            this.lblUpdateStock.TabIndex = 48;
            this.lblUpdateStock.Text = "Update Stock";
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStock.Location = new System.Drawing.Point(485, 380);
            this.btnUpdateStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(149, 50);
            this.btnUpdateStock.TabIndex = 47;
            this.btnUpdateStock.Text = "Update Stock";
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // cboDescription
            // 
            this.cboDescription.Location = new System.Drawing.Point(559, 145);
            this.cboDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboDescription.MaxLength = 30;
            this.cboDescription.Name = "cboDescription";
            this.cboDescription.Size = new System.Drawing.Size(205, 22);
            this.cboDescription.TabIndex = 38;
            // 
            // cboPrice
            // 
            this.cboPrice.Location = new System.Drawing.Point(559, 223);
            this.cboPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPrice.MaxLength = 5;
            this.cboPrice.Name = "cboPrice";
            this.cboPrice.Size = new System.Drawing.Size(75, 22);
            this.cboPrice.TabIndex = 41;
            // 
            // cboReorderLVL
            // 
            this.cboReorderLVL.Location = new System.Drawing.Point(559, 301);
            this.cboReorderLVL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboReorderLVL.MaxLength = 3;
            this.cboReorderLVL.Name = "cboReorderLVL";
            this.cboReorderLVL.Size = new System.Drawing.Size(75, 22);
            this.cboReorderLVL.TabIndex = 45;
            // 
            // cboQuantity
            // 
            this.cboQuantity.Location = new System.Drawing.Point(559, 264);
            this.cboQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboQuantity.MaxLength = 3;
            this.cboQuantity.Name = "cboQuantity";
            this.cboQuantity.Size = new System.Drawing.Size(75, 22);
            this.cboQuantity.TabIndex = 43;
            // 
            // cboName
            // 
            this.cboName.Location = new System.Drawing.Point(559, 107);
            this.cboName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboName.MaxLength = 20;
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(144, 22);
            this.cboName.TabIndex = 36;
            // 
            // lblReorderLevel
            // 
            this.lblReorderLevel.AutoSize = true;
            this.lblReorderLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReorderLevel.Location = new System.Drawing.Point(415, 301);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(128, 22);
            this.lblReorderLevel.TabIndex = 46;
            this.lblReorderLevel.Text = "Reorder Level:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(415, 264);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(82, 22);
            this.lblQuantity.TabIndex = 44;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(415, 225);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 22);
            this.lblPrice.TabIndex = 42;
            this.lblPrice.Text = "Price:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(415, 145);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(105, 22);
            this.lblDescription.TabIndex = 37;
            this.lblDescription.Text = "Description:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(415, 107);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 22);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "Name:";
            // 
            // frmUpdateStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblStock_List);
            this.Controls.Add(this.cboStock_List);
            this.Controls.Add(this.lblUpdateStock);
            this.Controls.Add(this.btnUpdateStock);
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
            this.Name = "frmUpdateStock";
            this.Text = "Looney\'s Liquer - [Update Stock]";
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox cboSearch;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblStock_List;
        private System.Windows.Forms.ComboBox cboStock_List;
        private System.Windows.Forms.Label lblUpdateStock;
        private System.Windows.Forms.Button btnUpdateStock;
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