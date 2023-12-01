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
            this.mnuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegisterCustomer = new System.Windows.Forms.Button();
            this.cboSurname = new System.Windows.Forms.TextBox();
            this.cboPhone = new System.Windows.Forms.TextBox();
            this.cboForename = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblInput_Information = new System.Windows.Forms.Label();
            this.lblRegisterCustomer = new System.Windows.Forms.Label();
            this.lblLoginDetails = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.cboPassword = new System.Windows.Forms.TextBox();
            this.cboUsername = new System.Windows.Forms.TextBox();
            this.mnuHomePage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegisterCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuRegisterCustomer
            // 
            this.mnuRegisterCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHomePage,
            this.mnuLogin,
            this.mnuExit});
            this.mnuRegisterCustomer.Location = new System.Drawing.Point(0, 0);
            this.mnuRegisterCustomer.Name = "mnuRegisterCustomer";
            this.mnuRegisterCustomer.Size = new System.Drawing.Size(800, 24);
            this.mnuRegisterCustomer.TabIndex = 0;
            this.mnuRegisterCustomer.Text = "menuStrip1";
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
            // btnRegisterCustomer
            // 
            this.btnRegisterCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnRegisterCustomer.Location = new System.Drawing.Point(345, 302);
            this.btnRegisterCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegisterCustomer.Name = "btnRegisterCustomer";
            this.btnRegisterCustomer.Size = new System.Drawing.Size(112, 54);
            this.btnRegisterCustomer.TabIndex = 25;
            this.btnRegisterCustomer.Text = "Register Customer";
            this.btnRegisterCustomer.UseVisualStyleBackColor = true;
            this.btnRegisterCustomer.Click += new System.EventHandler(this.btnRegisterCustomer_Click);
            // 
            // cboSurname
            // 
            this.cboSurname.Location = new System.Drawing.Point(570, 192);
            this.cboSurname.Margin = new System.Windows.Forms.Padding(2);
            this.cboSurname.MaxLength = 20;
            this.cboSurname.Name = "cboSurname";
            this.cboSurname.Size = new System.Drawing.Size(112, 20);
            this.cboSurname.TabIndex = 21;
            // 
            // cboPhone
            // 
            this.cboPhone.Location = new System.Drawing.Point(570, 224);
            this.cboPhone.Margin = new System.Windows.Forms.Padding(2);
            this.cboPhone.MaxLength = 10;
            this.cboPhone.Name = "cboPhone";
            this.cboPhone.Size = new System.Drawing.Size(78, 20);
            this.cboPhone.TabIndex = 23;
            // 
            // cboForename
            // 
            this.cboForename.Location = new System.Drawing.Point(570, 161);
            this.cboForename.Margin = new System.Windows.Forms.Padding(2);
            this.cboForename.MaxLength = 20;
            this.cboForename.Name = "cboForename";
            this.cboForename.Size = new System.Drawing.Size(109, 20);
            this.cboForename.TabIndex = 19;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(486, 224);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 18);
            this.lblPhone.TabIndex = 24;
            this.lblPhone.Text = "Phone:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(486, 192);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(72, 18);
            this.lblSurname.TabIndex = 22;
            this.lblSurname.Text = "Surname:";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(486, 161);
            this.lblForename.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(80, 18);
            this.lblForename.TabIndex = 20;
            this.lblForename.Text = "Forename:";
            // 
            // lblInput_Information
            // 
            this.lblInput_Information.AutoSize = true;
            this.lblInput_Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblInput_Information.Location = new System.Drawing.Point(496, 126);
            this.lblInput_Information.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInput_Information.Name = "lblInput_Information";
            this.lblInput_Information.Size = new System.Drawing.Size(196, 20);
            this.lblInput_Information.TabIndex = 27;
            this.lblInput_Information.Text = "Input General Information:";
            // 
            // lblRegisterCustomer
            // 
            this.lblRegisterCustomer.AutoSize = true;
            this.lblRegisterCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterCustomer.Location = new System.Drawing.Point(254, 54);
            this.lblRegisterCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegisterCustomer.Name = "lblRegisterCustomer";
            this.lblRegisterCustomer.Size = new System.Drawing.Size(278, 36);
            this.lblRegisterCustomer.TabIndex = 26;
            this.lblRegisterCustomer.Text = "Register Customer";
            // 
            // lblLoginDetails
            // 
            this.lblLoginDetails.AutoSize = true;
            this.lblLoginDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLoginDetails.Location = new System.Drawing.Point(64, 126);
            this.lblLoginDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginDetails.Name = "lblLoginDetails";
            this.lblLoginDetails.Size = new System.Drawing.Size(247, 20);
            this.lblLoginDetails.TabIndex = 28;
            this.lblLoginDetails.Text = "Enter a Username and Password:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblPassword.Location = new System.Drawing.Point(71, 192);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 18);
            this.lblPassword.TabIndex = 31;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblUsername.Location = new System.Drawing.Point(68, 161);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(81, 18);
            this.lblUsername.TabIndex = 29;
            this.lblUsername.Text = "Username:";
            // 
            // cboPassword
            // 
            this.cboPassword.Location = new System.Drawing.Point(145, 192);
            this.cboPassword.Margin = new System.Windows.Forms.Padding(2);
            this.cboPassword.MaxLength = 20;
            this.cboPassword.Name = "cboPassword";
            this.cboPassword.Size = new System.Drawing.Size(149, 20);
            this.cboPassword.TabIndex = 2;
            // 
            // cboUsername
            // 
            this.cboUsername.Location = new System.Drawing.Point(145, 161);
            this.cboUsername.Margin = new System.Windows.Forms.Padding(2);
            this.cboUsername.MaxLength = 20;
            this.cboUsername.Name = "cboUsername";
            this.cboUsername.Size = new System.Drawing.Size(149, 20);
            this.cboUsername.TabIndex = 1;
            // 
            // mnuHomePage
            // 
            this.mnuHomePage.Name = "mnuHomePage";
            this.mnuHomePage.Size = new System.Drawing.Size(81, 20);
            this.mnuHomePage.Text = "Home Page";
            this.mnuHomePage.Click += new System.EventHandler(this.mnuHomePage_Click);
            // 
            // frmRegisterCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLoginDetails);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.cboPassword);
            this.Controls.Add(this.cboUsername);
            this.Controls.Add(this.btnRegisterCustomer);
            this.Controls.Add(this.cboSurname);
            this.Controls.Add(this.cboPhone);
            this.Controls.Add(this.cboForename);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.lblInput_Information);
            this.Controls.Add(this.lblRegisterCustomer);
            this.Controls.Add(this.mnuRegisterCustomer);
            this.MainMenuStrip = this.mnuRegisterCustomer;
            this.Name = "frmRegisterCustomer";
            this.Text = "Looney\'s Liquer - [Register Customer]";
            this.mnuRegisterCustomer.ResumeLayout(false);
            this.mnuRegisterCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRegisterCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuLogin;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Button btnRegisterCustomer;
        private System.Windows.Forms.TextBox cboSurname;
        private System.Windows.Forms.TextBox cboPhone;
        private System.Windows.Forms.TextBox cboForename;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblInput_Information;
        private System.Windows.Forms.Label lblRegisterCustomer;
        private System.Windows.Forms.Label lblLoginDetails;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox cboPassword;
        private System.Windows.Forms.TextBox cboUsername;
        private System.Windows.Forms.ToolStripMenuItem mnuHomePage;
    }
}