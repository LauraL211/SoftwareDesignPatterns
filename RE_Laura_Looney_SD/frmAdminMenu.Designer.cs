namespace RE_Laura_Looney_SD
{
    partial class frmAdminMenu
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
            this.mnuAdminMenu = new System.Windows.Forms.MenuStrip();
            this.mnuMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStockMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExxit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRevAnalysis = new System.Windows.Forms.Button();
            this.btnStockSalesAnalysis = new System.Windows.Forms.Button();
            this.mnuAdminMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAdminMenu
            // 
            this.mnuAdminMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAdminMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenu,
            this.mnuStockMenu,
            this.mnuExxit});
            this.mnuAdminMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuAdminMenu.Name = "mnuAdminMenu";
            this.mnuAdminMenu.Size = new System.Drawing.Size(800, 28);
            this.mnuAdminMenu.TabIndex = 2;
            this.mnuAdminMenu.Text = "menuStrip1";
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(97, 24);
            this.mnuMainMenu.Text = "Main Menu";
            this.mnuMainMenu.Click += new System.EventHandler(this.mnuMainMenu_Click);
            // 
            // mnuStockMenu
            // 
            this.mnuStockMenu.Name = "mnuStockMenu";
            this.mnuStockMenu.Size = new System.Drawing.Size(100, 24);
            this.mnuStockMenu.Text = "Stock Menu";
            this.mnuStockMenu.Click += new System.EventHandler(this.mnuStockMenu_Click);
            // 
            // mnuExxit
            // 
            this.mnuExxit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExxit.Name = "mnuExxit";
            this.mnuExxit.Size = new System.Drawing.Size(47, 24);
            this.mnuExxit.Text = "Exit";
            this.mnuExxit.Click += new System.EventHandler(this.mnuExxit_Click);
            // 
            // btnRevAnalysis
            // 
            this.btnRevAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevAnalysis.Location = new System.Drawing.Point(191, 179);
            this.btnRevAnalysis.Name = "btnRevAnalysis";
            this.btnRevAnalysis.Size = new System.Drawing.Size(178, 99);
            this.btnRevAnalysis.TabIndex = 1;
            this.btnRevAnalysis.Text = "Revenue Analysis";
            this.btnRevAnalysis.UseVisualStyleBackColor = true;
            this.btnRevAnalysis.Click += new System.EventHandler(this.btnRevAnalysis_Click);
            // 
            // btnStockSalesAnalysis
            // 
            this.btnStockSalesAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockSalesAnalysis.Location = new System.Drawing.Point(435, 179);
            this.btnStockSalesAnalysis.Name = "btnStockSalesAnalysis";
            this.btnStockSalesAnalysis.Size = new System.Drawing.Size(178, 99);
            this.btnStockSalesAnalysis.TabIndex = 2;
            this.btnStockSalesAnalysis.Text = "Stock Sales Analysis";
            this.btnStockSalesAnalysis.UseVisualStyleBackColor = true;
            this.btnStockSalesAnalysis.Click += new System.EventHandler(this.btnStockSalesAnalysis_Click);
            // 
            // frmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStockSalesAnalysis);
            this.Controls.Add(this.btnRevAnalysis);
            this.Controls.Add(this.mnuAdminMenu);
            this.Name = "frmAdminMenu";
            this.Text = "Looney\'s Liquer - [Admin Menu]";
            this.mnuAdminMenu.ResumeLayout(false);
            this.mnuAdminMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAdminMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuStockMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuExxit;
        private System.Windows.Forms.Button btnRevAnalysis;
        private System.Windows.Forms.Button btnStockSalesAnalysis;
    }
}