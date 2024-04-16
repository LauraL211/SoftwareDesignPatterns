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
            this.cboSurname = new System.Windows.Forms.TextBox();
            this.cboPhone = new System.Windows.Forms.TextBox();
            this.cboForename = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblUpdate_Information = new System.Windows.Forms.Label();
            this.cboCustID = new System.Windows.Forms.TextBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.UpdateCustDetailsBx = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblsurnames = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.cboLastname = new System.Windows.Forms.TextBox();
            this.cboPrice = new System.Windows.Forms.TextBox();
            this.cboForname = new System.Windows.Forms.TextBox();
            this.mnuOrderMenu.SuspendLayout();
            this.UpdateCustDetailsBx.SuspendLayout();
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
            this.mnuOrderMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuOrderMenu.Size = new System.Drawing.Size(613, 24);
            this.mnuOrderMenu.TabIndex = 1;
            this.mnuOrderMenu.Text = "menuStrip1";
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(80, 20);
            this.mnuMainMenu.Text = "Main Menu";
            this.mnuMainMenu.Click += new System.EventHandler(this.mnuMainMenu_Click);
            // 
            // mnuCustomerMenu
            // 
            this.mnuCustomerMenu.Name = "mnuCustomerMenu";
            this.mnuCustomerMenu.Size = new System.Drawing.Size(105, 20);
            this.mnuCustomerMenu.Text = "Customer Menu";
            this.mnuCustomerMenu.Click += new System.EventHandler(this.mnuCustomerMenu_Click);
            // 
            // mnuExxit
            // 
            this.mnuExxit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExxit.Name = "mnuExxit";
            this.mnuExxit.Size = new System.Drawing.Size(38, 20);
            this.mnuExxit.Text = "Exit";
            this.mnuExxit.Click += new System.EventHandler(this.mnuExxit_Click);
            // 
            // cboSurname
            // 
            this.cboSurname.Location = new System.Drawing.Point(339, 195);
            this.cboSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSurname.MaxLength = 30;
            this.cboSurname.Name = "cboSurname";
            this.cboSurname.Size = new System.Drawing.Size(112, 20);
            this.cboSurname.TabIndex = 2;
            // 
            // cboPhone
            // 
            this.cboPhone.Location = new System.Drawing.Point(339, 227);
            this.cboPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboPhone.MaxLength = 5;
            this.cboPhone.Name = "cboPhone";
            this.cboPhone.Size = new System.Drawing.Size(78, 20);
            this.cboPhone.TabIndex = 3;
            // 
            // cboForename
            // 
            this.cboForename.Location = new System.Drawing.Point(339, 164);
            this.cboForename.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboForename.MaxLength = 20;
            this.cboForename.Name = "cboForename";
            this.cboForename.Size = new System.Drawing.Size(109, 20);
            this.cboForename.TabIndex = 1;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(231, 227);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 18);
            this.lblPhone.TabIndex = 47;
            this.lblPhone.Text = "Phone:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(231, 195);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(72, 18);
            this.lblSurname.TabIndex = 46;
            this.lblSurname.Text = "Surname:";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(231, 164);
            this.lblForename.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(80, 18);
            this.lblForename.TabIndex = 45;
            this.lblForename.Text = "Forename:";
            // 
            // lblUpdate_Information
            // 
            this.lblUpdate_Information.AutoSize = true;
            this.lblUpdate_Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.lblUpdate_Information.Location = new System.Drawing.Point(211, 43);
            this.lblUpdate_Information.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdate_Information.Name = "lblUpdate_Information";
            this.lblUpdate_Information.Size = new System.Drawing.Size(203, 26);
            this.lblUpdate_Information.TabIndex = 44;
            this.lblUpdate_Information.Text = "Update Information:";
            // 
            // cboCustID
            // 
            this.cboCustID.Enabled = false;
            this.cboCustID.Location = new System.Drawing.Point(216, 88);
            this.cboCustID.Margin = new System.Windows.Forms.Padding(2);
            this.cboCustID.MaxLength = 20;
            this.cboCustID.Name = "cboCustID";
            this.cboCustID.ReadOnly = true;
            this.cboCustID.Size = new System.Drawing.Size(46, 20);
            this.cboCustID.TabIndex = 67;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCustID.Location = new System.Drawing.Point(142, 89);
            this.lblCustID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(75, 15);
            this.lblCustID.TabIndex = 69;
            this.lblCustID.Text = "CustomerID:";
            // 
            // UpdateCustDetailsBx
            // 
            this.UpdateCustDetailsBx.Controls.Add(this.lblName);
            this.UpdateCustDetailsBx.Controls.Add(this.lblsurnames);
            this.UpdateCustDetailsBx.Controls.Add(this.lblPrice);
            this.UpdateCustDetailsBx.Controls.Add(this.btnUpdateCustomer);
            this.UpdateCustDetailsBx.Controls.Add(this.cboLastname);
            this.UpdateCustDetailsBx.Controls.Add(this.cboPrice);
            this.UpdateCustDetailsBx.Controls.Add(this.cboForname);
            this.UpdateCustDetailsBx.Location = new System.Drawing.Point(145, 125);
            this.UpdateCustDetailsBx.Name = "UpdateCustDetailsBx";
            this.UpdateCustDetailsBx.Size = new System.Drawing.Size(320, 188);
            this.UpdateCustDetailsBx.TabIndex = 68;
            this.UpdateCustDetailsBx.TabStop = false;
            this.UpdateCustDetailsBx.Text = "Customer Details";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblName.Location = new System.Drawing.Point(47, 39);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 15);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "Forename:";
            // 
            // lblsurnames
            // 
            this.lblsurnames.AutoSize = true;
            this.lblsurnames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsurnames.Location = new System.Drawing.Point(45, 65);
            this.lblsurnames.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsurnames.Name = "lblsurnames";
            this.lblsurnames.Size = new System.Drawing.Size(61, 15);
            this.lblsurnames.TabIndex = 31;
            this.lblsurnames.Text = "Surname:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPrice.Location = new System.Drawing.Point(45, 95);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 15);
            this.lblPrice.TabIndex = 33;
            this.lblPrice.Text = "Phone:";
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnUpdateCustomer.Location = new System.Drawing.Point(153, 137);
            this.btnUpdateCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(76, 46);
            this.btnUpdateCustomer.TabIndex = 8;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            // 
            // cboLastname
            // 
            this.cboLastname.Location = new System.Drawing.Point(153, 65);
            this.cboLastname.Margin = new System.Windows.Forms.Padding(2);
            this.cboLastname.MaxLength = 30;
            this.cboLastname.Name = "cboLastname";
            this.cboLastname.Size = new System.Drawing.Size(138, 20);
            this.cboLastname.TabIndex = 2;
            // 
            // cboPrice
            // 
            this.cboPrice.Location = new System.Drawing.Point(153, 95);
            this.cboPrice.Margin = new System.Windows.Forms.Padding(2);
            this.cboPrice.MaxLength = 5;
            this.cboPrice.Name = "cboPrice";
            this.cboPrice.Size = new System.Drawing.Size(92, 20);
            this.cboPrice.TabIndex = 4;
            // 
            // cboForname
            // 
            this.cboForname.Location = new System.Drawing.Point(153, 34);
            this.cboForname.Margin = new System.Windows.Forms.Padding(2);
            this.cboForname.MaxLength = 20;
            this.cboForname.Name = "cboForname";
            this.cboForname.Size = new System.Drawing.Size(120, 20);
            this.cboForname.TabIndex = 1;
            // 
            // frmUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 354);
            this.Controls.Add(this.cboCustID);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.UpdateCustDetailsBx);
            this.Controls.Add(this.cboSurname);
            this.Controls.Add(this.cboPhone);
            this.Controls.Add(this.cboForename);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.lblUpdate_Information);
            this.Controls.Add(this.mnuOrderMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmUpdateCustomer";
            this.Text = "Looney\'s Liquer - [Update Customer Information]";
            this.Load += new System.EventHandler(this.frmUpdateCustomer_Load);
            this.mnuOrderMenu.ResumeLayout(false);
            this.mnuOrderMenu.PerformLayout();
            this.UpdateCustDetailsBx.ResumeLayout(false);
            this.UpdateCustDetailsBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuOrderMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomerMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuExxit;
        private System.Windows.Forms.TextBox cboSurname;
        private System.Windows.Forms.TextBox cboPhone;
        private System.Windows.Forms.TextBox cboForename;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblUpdate_Information;
        private System.Windows.Forms.TextBox cboCustID;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.GroupBox UpdateCustDetailsBx;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblsurnames;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.TextBox cboLastname;
        private System.Windows.Forms.TextBox cboPrice;
        private System.Windows.Forms.TextBox cboForname;
    }
}