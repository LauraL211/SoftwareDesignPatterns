namespace RE_Laura_Looney_SD
{
    partial class frmRegisterCustomer
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
            this.mnuRegisterCustomer = new System.Windows.Forms.MenuStrip();
            this.mnuHomePage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.cboCustID = new System.Windows.Forms.TextBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.grpCustDetails = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.TextBox();
            this.cboSurname = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.btnARegisterCustomer = new System.Windows.Forms.Button();
            this.lblSurname = new System.Windows.Forms.Label();
            this.cboPassword = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.cboForename = new System.Windows.Forms.TextBox();
            this.cboUsername = new System.Windows.Forms.TextBox();
            this.cboPhone = new System.Windows.Forms.TextBox();
            this.lblRegisterCustomer = new System.Windows.Forms.Label();
            this.mnuRegisterCustomer.SuspendLayout();
            this.grpCustDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuRegisterCustomer
            // 
            this.mnuRegisterCustomer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuRegisterCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHomePage,
            this.mnuLogin,
            this.mnuExit});
            this.mnuRegisterCustomer.Location = new System.Drawing.Point(0, 0);
            this.mnuRegisterCustomer.Name = "mnuRegisterCustomer";
            this.mnuRegisterCustomer.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuRegisterCustomer.Size = new System.Drawing.Size(800, 24);
            this.mnuRegisterCustomer.TabIndex = 0;
            this.mnuRegisterCustomer.Text = "menuStrip1";
            // 
            // mnuHomePage
            // 
            this.mnuHomePage.Name = "mnuHomePage";
            this.mnuHomePage.Size = new System.Drawing.Size(81, 20);
            this.mnuHomePage.Text = "Home Page";
            this.mnuHomePage.Click += new System.EventHandler(this.mnuHomePage_Click);
            // 
            // mnuLogin
            // 
            this.mnuLogin.Name = "mnuLogin";
            this.mnuLogin.Size = new System.Drawing.Size(49, 20);
            this.mnuLogin.Text = "Login";
            this.mnuLogin.Click += new System.EventHandler(this.mnuLogin_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // cboCustID
            // 
            this.cboCustID.Enabled = false;
            this.cboCustID.Location = new System.Drawing.Point(278, 90);
            this.cboCustID.Margin = new System.Windows.Forms.Padding(2);
            this.cboCustID.MaxLength = 20;
            this.cboCustID.Name = "cboCustID";
            this.cboCustID.ReadOnly = true;
            this.cboCustID.Size = new System.Drawing.Size(46, 20);
            this.cboCustID.TabIndex = 40;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCustID.Location = new System.Drawing.Point(201, 91);
            this.lblCustID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(78, 15);
            this.lblCustID.TabIndex = 42;
            this.lblCustID.Text = "Customer ID:";
            // 
            // grpCustDetails
            // 
            this.grpCustDetails.Controls.Add(this.lblStatus);
            this.grpCustDetails.Controls.Add(this.cboStatus);
            this.grpCustDetails.Controls.Add(this.cboSurname);
            this.grpCustDetails.Controls.Add(this.lblUsername);
            this.grpCustDetails.Controls.Add(this.lblPassword);
            this.grpCustDetails.Controls.Add(this.lblForename);
            this.grpCustDetails.Controls.Add(this.btnARegisterCustomer);
            this.grpCustDetails.Controls.Add(this.lblSurname);
            this.grpCustDetails.Controls.Add(this.cboPassword);
            this.grpCustDetails.Controls.Add(this.lblPhone);
            this.grpCustDetails.Controls.Add(this.cboForename);
            this.grpCustDetails.Controls.Add(this.cboUsername);
            this.grpCustDetails.Controls.Add(this.cboPhone);
            this.grpCustDetails.Location = new System.Drawing.Point(204, 121);
            this.grpCustDetails.Name = "grpCustDetails";
            this.grpCustDetails.Size = new System.Drawing.Size(395, 292);
            this.grpCustDetails.TabIndex = 41;
            this.grpCustDetails.TabStop = false;
            this.grpCustDetails.Text = "Enter Customer Details";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblStatus.Location = new System.Drawing.Point(45, 208);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 15);
            this.lblStatus.TabIndex = 37;
            this.lblStatus.Text = "Status:";
            // 
            // cboStatus
            // 
            this.cboStatus.Enabled = false;
            this.cboStatus.Location = new System.Drawing.Point(153, 210);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cboStatus.MaxLength = 3;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.ReadOnly = true;
            this.cboStatus.Size = new System.Drawing.Size(48, 20);
            this.cboStatus.TabIndex = 7;
            this.cboStatus.Text = "O";
            // 
            // cboSurname
            // 
            this.cboSurname.Location = new System.Drawing.Point(153, 147);
            this.cboSurname.Margin = new System.Windows.Forms.Padding(2);
            this.cboSurname.MaxLength = 20;
            this.cboSurname.Name = "cboSurname";
            this.cboSurname.Size = new System.Drawing.Size(120, 20);
            this.cboSurname.TabIndex = 5;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblUsername.Location = new System.Drawing.Point(47, 23);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(68, 15);
            this.lblUsername.TabIndex = 30;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(45, 49);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 15);
            this.lblPassword.TabIndex = 31;
            this.lblPassword.Text = "Password:";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblForename.Location = new System.Drawing.Point(45, 117);
            this.lblForename.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(67, 15);
            this.lblForename.TabIndex = 33;
            this.lblForename.Text = "Forename:";
            // 
            // btnARegisterCustomer
            // 
            this.btnARegisterCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnARegisterCustomer.Location = new System.Drawing.Point(144, 243);
            this.btnARegisterCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnARegisterCustomer.Name = "btnARegisterCustomer";
            this.btnARegisterCustomer.Size = new System.Drawing.Size(139, 35);
            this.btnARegisterCustomer.TabIndex = 8;
            this.btnARegisterCustomer.Text = "Register Customer";
            this.btnARegisterCustomer.UseVisualStyleBackColor = true;
            this.btnARegisterCustomer.Click += new System.EventHandler(this.btnARegisterCustomer_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSurname.Location = new System.Drawing.Point(45, 145);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(61, 15);
            this.lblSurname.TabIndex = 34;
            this.lblSurname.Text = "Surname:";
            // 
            // cboPassword
            // 
            this.cboPassword.Location = new System.Drawing.Point(153, 49);
            this.cboPassword.Margin = new System.Windows.Forms.Padding(2);
            this.cboPassword.MaxLength = 30;
            this.cboPassword.Name = "cboPassword";
            this.cboPassword.Size = new System.Drawing.Size(120, 20);
            this.cboPassword.TabIndex = 2;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPhone.Location = new System.Drawing.Point(45, 175);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(46, 15);
            this.lblPhone.TabIndex = 35;
            this.lblPhone.Text = "Phone:";
            // 
            // cboForename
            // 
            this.cboForename.Location = new System.Drawing.Point(153, 119);
            this.cboForename.Margin = new System.Windows.Forms.Padding(2);
            this.cboForename.MaxLength = 20;
            this.cboForename.Name = "cboForename";
            this.cboForename.Size = new System.Drawing.Size(120, 20);
            this.cboForename.TabIndex = 4;
            // 
            // cboUsername
            // 
            this.cboUsername.Location = new System.Drawing.Point(153, 18);
            this.cboUsername.Margin = new System.Windows.Forms.Padding(2);
            this.cboUsername.MaxLength = 20;
            this.cboUsername.Name = "cboUsername";
            this.cboUsername.Size = new System.Drawing.Size(120, 20);
            this.cboUsername.TabIndex = 1;
            // 
            // cboPhone
            // 
            this.cboPhone.Location = new System.Drawing.Point(153, 177);
            this.cboPhone.Margin = new System.Windows.Forms.Padding(2);
            this.cboPhone.MaxLength = 10;
            this.cboPhone.Name = "cboPhone";
            this.cboPhone.Size = new System.Drawing.Size(120, 20);
            this.cboPhone.TabIndex = 6;
            // 
            // lblRegisterCustomer
            // 
            this.lblRegisterCustomer.AutoSize = true;
            this.lblRegisterCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterCustomer.Location = new System.Drawing.Point(272, 37);
            this.lblRegisterCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegisterCustomer.Name = "lblRegisterCustomer";
            this.lblRegisterCustomer.Size = new System.Drawing.Size(287, 36);
            this.lblRegisterCustomer.TabIndex = 39;
            this.lblRegisterCustomer.Text = "Register  Customer";
            // 
            // frmRegisterCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboCustID);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.grpCustDetails);
            this.Controls.Add(this.lblRegisterCustomer);
            this.Controls.Add(this.mnuRegisterCustomer);
            this.MainMenuStrip = this.mnuRegisterCustomer;
            this.Name = "frmRegisterCustomer";
            this.Text = "Looney\'s Liquer - [Register Customer]";
            this.Load += new System.EventHandler(this.frmRegisterCustomer_Load);
            this.mnuRegisterCustomer.ResumeLayout(false);
            this.mnuRegisterCustomer.PerformLayout();
            this.grpCustDetails.ResumeLayout(false);
            this.grpCustDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRegisterCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuLogin;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHomePage;
        private System.Windows.Forms.TextBox cboCustID;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.GroupBox grpCustDetails;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox cboStatus;
        private System.Windows.Forms.TextBox cboSurname;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Button btnARegisterCustomer;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox cboPassword;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox cboForename;
        private System.Windows.Forms.TextBox cboUsername;
        private System.Windows.Forms.TextBox cboPhone;
        private System.Windows.Forms.Label lblRegisterCustomer;
    }
}