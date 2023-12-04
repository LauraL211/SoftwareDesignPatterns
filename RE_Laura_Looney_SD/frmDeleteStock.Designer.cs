namespace RE_Laura_Looney_SD
{
    partial class frmDeleteStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteStock));
            this.mnuStockMenu = new System.Windows.Forms.MenuStrip();
            this.mnuMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExxit = new System.Windows.Forms.ToolStripMenuItem();
            this.cboType = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboSearch = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblStock_List = new System.Windows.Forms.Label();
            this.cboStock_List = new System.Windows.Forms.ComboBox();
            this.lblDeleteStock = new System.Windows.Forms.Label();
            this.btnDeleteStock = new System.Windows.Forms.Button();
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
            // cboType
            // 
            this.cboType.Location = new System.Drawing.Point(558, 183);
            this.cboType.MaxLength = 30;
            this.cboType.Name = "cboType";
            this.cboType.ReadOnly = true;
            this.cboType.Size = new System.Drawing.Size(93, 22);
            this.cboType.TabIndex = 70;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // cboSearch
            // 
            this.cboSearch.Location = new System.Drawing.Point(70, 170);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(160, 22);
            this.cboSearch.TabIndex = 1;
            this.cboSearch.TextChanged += new System.EventHandler(this.cboSearch_TextChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(414, 181);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(56, 22);
            this.lblType.TabIndex = 59;
            this.lblType.Text = "Type:";
            // 
            // lblStock_List
            // 
            this.lblStock_List.AutoSize = true;
            this.lblStock_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock_List.Location = new System.Drawing.Point(38, 142);
            this.lblStock_List.Name = "lblStock_List";
            this.lblStock_List.Size = new System.Drawing.Size(165, 22);
            this.lblStock_List.TabIndex = 68;
            this.lblStock_List.Text = "Choose Stock Item:";
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
            this.cboStock_List.Location = new System.Drawing.Point(42, 192);
            this.cboStock_List.Name = "cboStock_List";
            this.cboStock_List.Size = new System.Drawing.Size(269, 24);
            this.cboStock_List.TabIndex = 2;
            this.cboStock_List.SelectedIndexChanged += new System.EventHandler(this.cboStock_List_SelectedIndexChanged);
            // 
            // lblDeleteStock
            // 
            this.lblDeleteStock.AutoSize = true;
            this.lblDeleteStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteStock.Location = new System.Drawing.Point(251, 32);
            this.lblDeleteStock.Name = "lblDeleteStock";
            this.lblDeleteStock.Size = new System.Drawing.Size(242, 42);
            this.lblDeleteStock.TabIndex = 67;
            this.lblDeleteStock.Text = "Delete Stock";
            // 
            // btnDeleteStock
            // 
            this.btnDeleteStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStock.Location = new System.Drawing.Point(483, 368);
            this.btnDeleteStock.Name = "btnDeleteStock";
            this.btnDeleteStock.Size = new System.Drawing.Size(150, 50);
            this.btnDeleteStock.TabIndex = 66;
            this.btnDeleteStock.Text = "Delete Stock";
            this.btnDeleteStock.UseVisualStyleBackColor = true;
            this.btnDeleteStock.Click += new System.EventHandler(this.btnDeleteStock_Click);
            // 
            // cboDescription
            // 
            this.cboDescription.Location = new System.Drawing.Point(558, 144);
            this.cboDescription.MaxLength = 30;
            this.cboDescription.Name = "cboDescription";
            this.cboDescription.ReadOnly = true;
            this.cboDescription.Size = new System.Drawing.Size(205, 22);
            this.cboDescription.TabIndex = 58;
            // 
            // cboPrice
            // 
            this.cboPrice.Location = new System.Drawing.Point(558, 214);
            this.cboPrice.MaxLength = 5;
            this.cboPrice.Name = "cboPrice";
            this.cboPrice.ReadOnly = true;
            this.cboPrice.Size = new System.Drawing.Size(75, 22);
            this.cboPrice.TabIndex = 60;
            // 
            // cboReorderLVL
            // 
            this.cboReorderLVL.Location = new System.Drawing.Point(558, 285);
            this.cboReorderLVL.MaxLength = 3;
            this.cboReorderLVL.Name = "cboReorderLVL";
            this.cboReorderLVL.ReadOnly = true;
            this.cboReorderLVL.Size = new System.Drawing.Size(75, 22);
            this.cboReorderLVL.TabIndex = 64;
            // 
            // cboQuantity
            // 
            this.cboQuantity.Location = new System.Drawing.Point(558, 248);
            this.cboQuantity.MaxLength = 3;
            this.cboQuantity.Name = "cboQuantity";
            this.cboQuantity.ReadOnly = true;
            this.cboQuantity.Size = new System.Drawing.Size(75, 22);
            this.cboQuantity.TabIndex = 62;
            // 
            // cboName
            // 
            this.cboName.Location = new System.Drawing.Point(558, 106);
            this.cboName.MaxLength = 20;
            this.cboName.Name = "cboName";
            this.cboName.ReadOnly = true;
            this.cboName.Size = new System.Drawing.Size(144, 22);
            this.cboName.TabIndex = 56;
            // 
            // lblReorderLevel
            // 
            this.lblReorderLevel.AutoSize = true;
            this.lblReorderLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReorderLevel.Location = new System.Drawing.Point(414, 285);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(128, 22);
            this.lblReorderLevel.TabIndex = 65;
            this.lblReorderLevel.Text = "Reorder Level:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(414, 248);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(82, 22);
            this.lblQuantity.TabIndex = 63;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(414, 214);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 22);
            this.lblPrice.TabIndex = 61;
            this.lblPrice.Text = "Price:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(414, 144);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(105, 22);
            this.lblDescription.TabIndex = 57;
            this.lblDescription.Text = "Description:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(414, 106);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 22);
            this.lblName.TabIndex = 55;
            this.lblName.Text = "Name:";
            // 
            // frmDeleteStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblStock_List);
            this.Controls.Add(this.cboStock_List);
            this.Controls.Add(this.lblDeleteStock);
            this.Controls.Add(this.btnDeleteStock);
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
            this.Name = "frmDeleteStock";
            this.Text = "Looney\'s Liquer - [Delete Stock]";
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
        private System.Windows.Forms.TextBox cboType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox cboSearch;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblStock_List;
        private System.Windows.Forms.ComboBox cboStock_List;
        private System.Windows.Forms.Label lblDeleteStock;
        private System.Windows.Forms.Button btnDeleteStock;
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