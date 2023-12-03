namespace RE_Laura_Looney_SD
{
    partial class frmMainMenuManager
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
            this.mnuMainM = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHomePage = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.mnuMainM.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainM
            // 
            this.mnuMainM.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMainM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuHomePage});
            this.mnuMainM.Location = new System.Drawing.Point(0, 0);
            this.mnuMainM.Name = "mnuMainM";
            this.mnuMainM.Size = new System.Drawing.Size(1067, 28);
            this.mnuMainM.TabIndex = 4;
            this.mnuMainM.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(47, 24);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuHomePage
            // 
            this.mnuHomePage.Name = "mnuHomePage";
            this.mnuHomePage.Size = new System.Drawing.Size(100, 24);
            this.mnuHomePage.Text = "Home Page";
            this.mnuHomePage.Click += new System.EventHandler(this.mnuHomePage_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(557, 220);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(197, 97);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnStock
            // 
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Location = new System.Drawing.Point(303, 220);
            this.btnStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(197, 94);
            this.btnStock.TabIndex = 1;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // frmMainMenuManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.mnuMainM);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMainMenuManager";
            this.Text = "Looney\'s Liquer - [Main Menu]";
            this.mnuMainM.ResumeLayout(false);
            this.mnuMainM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainM;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.ToolStripMenuItem mnuHomePage;
    }
}