namespace RE_Laura_Looney_SD
{
    partial class frmUpdateCustomer
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
            this.mnuOrderMenu = new System.Windows.Forms.MenuStrip();
            this.mnuMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExxit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.cboSurname = new System.Windows.Forms.TextBox();
            this.cboPhone = new System.Windows.Forms.TextBox();
            this.cboForename = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblUpdate_Information = new System.Windows.Forms.Label();
            this.mnuOrderMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuOrderMenu
            // 
            this.mnuOrderMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuOrderMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainMenu,
            this.mnuCustomerMenu,
            this.mnuExxit});
            this.mnuOrderMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuOrderMenu.Name = "mnuOrderMenu";
            this.mnuOrderMenu.Size = new System.Drawing.Size(800, 28);
            this.mnuOrderMenu.TabIndex = 1;
            this.mnuOrderMenu.Text = "menuStrip1";
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(97, 24);
            this.mnuMainMenu.Text = "Main Menu";
            this.mnuMainMenu.Click += new System.EventHandler(this.mnuMainMenu_Click);
            // 
            // mnuCustomerMenu
            // 
            this.mnuCustomerMenu.Name = "mnuCustomerMenu";
            this.mnuCustomerMenu.Size = new System.Drawing.Size(127, 24);
            this.mnuCustomerMenu.Text = "Customer Menu";
            this.mnuCustomerMenu.Click += new System.EventHandler(this.mnuCustomerMenu_Click);
            // 
            // mnuExxit
            // 
            this.mnuExxit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExxit.Name = "mnuExxit";
            this.mnuExxit.Size = new System.Drawing.Size(47, 24);
            this.mnuExxit.Text = "Exit";
            this.mnuExxit.Click += new System.EventHandler(this.mnuExxit_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnUpdateCustomer.Location = new System.Drawing.Point(333, 329);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(150, 67);
            this.btnUpdateCustomer.TabIndex = 4;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // cboSurname
            // 
            this.cboSurname.Location = new System.Drawing.Point(398, 157);
            this.cboSurname.MaxLength = 30;
            this.cboSurname.Name = "cboSurname";
            this.cboSurname.Size = new System.Drawing.Size(148, 22);
            this.cboSurname.TabIndex = 2;
            this.cboSurname.Text = "Bloggs";
            // 
            // cboPhone
            // 
            this.cboPhone.Location = new System.Drawing.Point(398, 197);
            this.cboPhone.MaxLength = 5;
            this.cboPhone.Name = "cboPhone";
            this.cboPhone.Size = new System.Drawing.Size(102, 22);
            this.cboPhone.TabIndex = 3;
            this.cboPhone.Text = "0863334321";
            // 
            // cboForename
            // 
            this.cboForename.Location = new System.Drawing.Point(398, 119);
            this.cboForename.MaxLength = 20;
            this.cboForename.Name = "cboForename";
            this.cboForename.Size = new System.Drawing.Size(144, 22);
            this.cboForename.TabIndex = 1;
            this.cboForename.Text = "Joe";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(254, 197);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(67, 22);
            this.lblPhone.TabIndex = 47;
            this.lblPhone.Text = "Phone:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(254, 157);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(87, 22);
            this.lblSurname.TabIndex = 46;
            this.lblSurname.Text = "Surname:";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(254, 119);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(96, 22);
            this.lblForename.TabIndex = 45;
            this.lblForename.Text = "Forename:";
            // 
            // lblUpdate_Information
            // 
            this.lblUpdate_Information.AutoSize = true;
            this.lblUpdate_Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.lblUpdate_Information.Location = new System.Drawing.Point(269, 55);
            this.lblUpdate_Information.Name = "lblUpdate_Information";
            this.lblUpdate_Information.Size = new System.Drawing.Size(253, 31);
            this.lblUpdate_Information.TabIndex = 44;
            this.lblUpdate_Information.Text = "Update Information:";
            // 
            // frmUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.cboSurname);
            this.Controls.Add(this.cboPhone);
            this.Controls.Add(this.cboForename);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.lblUpdate_Information);
            this.Controls.Add(this.mnuOrderMenu);
            this.Name = "frmUpdateCustomer";
            this.Text = "Looney\'s Liquer - [Update Customer Information]";
            this.mnuOrderMenu.ResumeLayout(false);
            this.mnuOrderMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuOrderMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomerMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuExxit;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.TextBox cboSurname;
        private System.Windows.Forms.TextBox cboPhone;
        private System.Windows.Forms.TextBox cboForename;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblUpdate_Information;
    }
}