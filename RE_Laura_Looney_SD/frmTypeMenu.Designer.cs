namespace RE_Laura_Looney_SD
{
    partial class frmTypeMenu
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
            this.btnUpdateStockType = new System.Windows.Forms.Button();
            this.btnAddStockType = new System.Windows.Forms.Button();
            this.mnuStockMenu = new System.Windows.Forms.MenuStrip();
            this.mnuMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExxit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStockMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateStockType
            // 
            this.btnUpdateStockType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStockType.Location = new System.Drawing.Point(418, 182);
            this.btnUpdateStockType.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateStockType.Name = "btnUpdateStockType";
            this.btnUpdateStockType.Size = new System.Drawing.Size(161, 67);
            this.btnUpdateStockType.TabIndex = 9;
            this.btnUpdateStockType.Text = "Update Stock Type";
            this.btnUpdateStockType.UseVisualStyleBackColor = true;
            this.btnUpdateStockType.Click += new System.EventHandler(this.btnUpdateStockType_Click);
            // 
            // btnAddStockType
            // 
            this.btnAddStockType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddStockType.Location = new System.Drawing.Point(234, 182);
            this.btnAddStockType.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddStockType.Name = "btnAddStockType";
            this.btnAddStockType.Size = new System.Drawing.Size(153, 67);
            this.btnAddStockType.TabIndex = 6;
            this.btnAddStockType.Text = "Add Stock Type";
            this.btnAddStockType.UseVisualStyleBackColor = true;
            this.btnAddStockType.Click += new System.EventHandler(this.btnAddStockType_Click);
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
            this.mnuStockMenu.Size = new System.Drawing.Size(800, 24);
            this.mnuStockMenu.TabIndex = 7;
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
            this.mnuStock.Click += new System.EventHandler(this.mnuAdminMenu_Click);
            // 
            // mnuExxit
            // 
            this.mnuExxit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExxit.Name = "mnuExxit";
            this.mnuExxit.Size = new System.Drawing.Size(38, 20);
            this.mnuExxit.Text = "Exit";
            this.mnuExxit.Click += new System.EventHandler(this.mnuExxit_Click);
            // 
            // frmTypeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateStockType);
            this.Controls.Add(this.btnAddStockType);
            this.Controls.Add(this.mnuStockMenu);
            this.Name = "frmTypeMenu";
            this.Text = "Type Menu";
            this.mnuStockMenu.ResumeLayout(false);
            this.mnuStockMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateStockType;
        private System.Windows.Forms.Button btnAddStockType;
        private System.Windows.Forms.MenuStrip mnuStockMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuStock;
        private System.Windows.Forms.ToolStripMenuItem mnuExxit;
    }
}