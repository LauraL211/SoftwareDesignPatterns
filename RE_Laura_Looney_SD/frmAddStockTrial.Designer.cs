namespace RE_Laura_Looney_SD
{
    partial class frmAddStockTrial
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
            this.mnuAddStock = new System.Windows.Forms.MenuStrip();
            this.mnuBackBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStockID = new System.Windows.Forms.Label();
            this.cboStockID = new System.Windows.Forms.TextBox();
            this.mnuAddStock.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.cboType.Location = new System.Drawing.Point(153, 95);
            this.cboType.Margin = new System.Windows.Forms.Padding(2);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(92, 21);
            this.cboType.TabIndex = 24;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblType.Location = new System.Drawing.Point(45, 95);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(36, 15);
            this.lblType.TabIndex = 32;
            this.lblType.Text = "Type:";
            // 
            // lblAddStock
            // 
            this.lblAddStock.AutoSize = true;
            this.lblAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStock.Location = new System.Drawing.Point(312, 24);
            this.lblAddStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddStock.Name = "lblAddStock";
            this.lblAddStock.Size = new System.Drawing.Size(162, 36);
            this.lblAddStock.TabIndex = 29;
            this.lblAddStock.Text = "Add Stock";
            // 
            // btnAddStock
            // 
            this.btnAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddStock.Location = new System.Drawing.Point(153, 225);
            this.btnAddStock.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(92, 35);
            this.btnAddStock.TabIndex = 28;
            this.btnAddStock.Text = "Add Stock";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // cboDescription
            // 
            this.cboDescription.Location = new System.Drawing.Point(153, 65);
            this.cboDescription.Margin = new System.Windows.Forms.Padding(2);
            this.cboDescription.MaxLength = 30;
            this.cboDescription.Name = "cboDescription";
            this.cboDescription.Size = new System.Drawing.Size(138, 20);
            this.cboDescription.TabIndex = 23;
            // 
            // cboPrice
            // 
            this.cboPrice.Location = new System.Drawing.Point(153, 127);
            this.cboPrice.Margin = new System.Windows.Forms.Padding(2);
            this.cboPrice.MaxLength = 5;
            this.cboPrice.Name = "cboPrice";
            this.cboPrice.Size = new System.Drawing.Size(48, 20);
            this.cboPrice.TabIndex = 25;
            // 
            // cboReorderLVL
            // 
            this.cboReorderLVL.Location = new System.Drawing.Point(153, 185);
            this.cboReorderLVL.Margin = new System.Windows.Forms.Padding(2);
            this.cboReorderLVL.MaxLength = 3;
            this.cboReorderLVL.Name = "cboReorderLVL";
            this.cboReorderLVL.Size = new System.Drawing.Size(48, 20);
            this.cboReorderLVL.TabIndex = 27;
            // 
            // cboQuantity
            // 
            this.cboQuantity.Location = new System.Drawing.Point(153, 155);
            this.cboQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.cboQuantity.MaxLength = 3;
            this.cboQuantity.Name = "cboQuantity";
            this.cboQuantity.Size = new System.Drawing.Size(48, 20);
            this.cboQuantity.TabIndex = 26;
            // 
            // cboName
            // 
            this.cboName.Location = new System.Drawing.Point(153, 34);
            this.cboName.Margin = new System.Windows.Forms.Padding(2);
            this.cboName.MaxLength = 20;
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(120, 20);
            this.cboName.TabIndex = 22;
            // 
            // lblReorderLevel
            // 
            this.lblReorderLevel.AutoSize = true;
            this.lblReorderLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblReorderLevel.Location = new System.Drawing.Point(45, 183);
            this.lblReorderLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Size = new System.Drawing.Size(87, 15);
            this.lblReorderLevel.TabIndex = 35;
            this.lblReorderLevel.Text = "Reorder Level:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblQuantity.Location = new System.Drawing.Point(45, 153);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(54, 15);
            this.lblQuantity.TabIndex = 34;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPrice.Location = new System.Drawing.Point(45, 125);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 15);
            this.lblPrice.TabIndex = 33;
            this.lblPrice.Text = "Price:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(45, 65);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(72, 15);
            this.lblDescription.TabIndex = 31;
            this.lblDescription.Text = "Description:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblName.Location = new System.Drawing.Point(47, 39);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 15);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "Name:";
            // 
            // mnuAddStock
            // 
            this.mnuAddStock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBackBtn});
            this.mnuAddStock.Location = new System.Drawing.Point(0, 0);
            this.mnuAddStock.Name = "mnuAddStock";
            this.mnuAddStock.Size = new System.Drawing.Size(800, 24);
            this.mnuAddStock.TabIndex = 36;
            this.mnuAddStock.Text = "menuStrip1";
            // 
            // mnuBackBtn
            // 
            this.mnuBackBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBackBtn.Name = "mnuBackBtn";
            this.mnuBackBtn.Size = new System.Drawing.Size(44, 20);
            this.mnuBackBtn.Text = "Back";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboQuantity);
            this.groupBox1.Controls.Add(this.cboType);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.btnAddStock);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.cboDescription);
            this.groupBox1.Controls.Add(this.lblReorderLevel);
            this.groupBox1.Controls.Add(this.cboPrice);
            this.groupBox1.Controls.Add(this.cboName);
            this.groupBox1.Controls.Add(this.cboReorderLVL);
            this.groupBox1.Location = new System.Drawing.Point(192, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 265);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Stock Details";
            // 
            // lblStockID
            // 
            this.lblStockID.AutoSize = true;
            this.lblStockID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblStockID.Location = new System.Drawing.Point(189, 89);
            this.lblStockID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockID.Name = "lblStockID";
            this.lblStockID.Size = new System.Drawing.Size(52, 15);
            this.lblStockID.TabIndex = 38;
            this.lblStockID.Text = "StockID:";
            // 
            // cboStockID
            // 
            this.cboStockID.Location = new System.Drawing.Point(245, 88);
            this.cboStockID.Margin = new System.Windows.Forms.Padding(2);
            this.cboStockID.MaxLength = 20;
            this.cboStockID.Name = "cboStockID";
            this.cboStockID.Size = new System.Drawing.Size(46, 20);
            this.cboStockID.TabIndex = 36;
            // 
            // frmAddStockTrial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboStockID);
            this.Controls.Add(this.lblStockID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAddStock);
            this.Controls.Add(this.mnuAddStock);
            this.MainMenuStrip = this.mnuAddStock;
            this.Name = "frmAddStockTrial";
            this.Text = "Add Stock-(Trial)";
            this.Load += new System.EventHandler(this.frmAddStockTrial_Load);
            this.mnuAddStock.ResumeLayout(false);
            this.mnuAddStock.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.MenuStrip mnuAddStock;
        private System.Windows.Forms.ToolStripMenuItem mnuBackBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStockID;
        private System.Windows.Forms.TextBox cboStockID;
    }
}