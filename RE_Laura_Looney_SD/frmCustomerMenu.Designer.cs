namespace RE_Laura_Looney_SD
{
    partial class frmCustomerMenu
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
            this.mnuCustomer = new System.Windows.Forms.MenuStrip();
            this.mnuMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrderMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExxit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeRegisterCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.mnuCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuCustomer
            // 
            this.mnuCustomer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenu,
            this.mnuOrderMenu,
            this.mnuExxit});
            this.mnuCustomer.Location = new System.Drawing.Point(0, 0);
            this.mnuCustomer.Name = "mnuCustomer";
            this.mnuCustomer.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuCustomer.Size = new System.Drawing.Size(600, 24);
            this.mnuCustomer.TabIndex = 1;
            this.mnuCustomer.Text = "menuStrip1";
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(80, 20);
            this.mnuMainMenu.Text = "Main Menu";
            this.mnuMainMenu.Click += new System.EventHandler(this.mnuMainMenu_Click);
            // 
            // mnuOrderMenu
            // 
            this.mnuOrderMenu.Name = "mnuOrderMenu";
            this.mnuOrderMenu.Size = new System.Drawing.Size(83, 20);
            this.mnuOrderMenu.Text = "Order Menu";
            this.mnuOrderMenu.Click += new System.EventHandler(this.mnuOrderMenu_Click);
            // 
            // mnuExxit
            // 
            this.mnuExxit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExxit.Name = "mnuExxit";
            this.mnuExxit.Size = new System.Drawing.Size(38, 20);
            this.mnuExxit.Text = "Exit";
            this.mnuExxit.Click += new System.EventHandler(this.mnuExxit_Click);
            // 
            // btnDeRegisterCustomer
            // 
            this.btnDeRegisterCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeRegisterCustomer.Location = new System.Drawing.Point(313, 150);
            this.btnDeRegisterCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeRegisterCustomer.Name = "btnDeRegisterCustomer";
            this.btnDeRegisterCustomer.Size = new System.Drawing.Size(134, 67);
            this.btnDeRegisterCustomer.TabIndex = 2;
            this.btnDeRegisterCustomer.Text = "De-Register Customer";
            this.btnDeRegisterCustomer.UseVisualStyleBackColor = true;
            this.btnDeRegisterCustomer.Click += new System.EventHandler(this.btnDeRegisterCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdateCustomer.Location = new System.Drawing.Point(155, 150);
            this.btnUpdateCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(134, 67);
            this.btnUpdateCustomer.TabIndex = 1;
            this.btnUpdateCustomer.Text = "Update Customer Details";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // frmCustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnDeRegisterCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.mnuCustomer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCustomerMenu";
            this.Text = "Looney\'s Liquer - [Customer Menu]";
            this.mnuCustomer.ResumeLayout(false);
            this.mnuCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuOrderMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuExxit;
        private System.Windows.Forms.Button btnDeRegisterCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
    }
}