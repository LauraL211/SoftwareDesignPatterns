using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RE_Laura_Looney_SD
{
    public partial class frmLoginPage : Form
    {
        public String Username
        { get; set; }

        public frmLoginPage(Form frmHomePage)
        {
            InitializeComponent();
           
        }
        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult Result = (MessageBox.Show("Are you sure you want to exit?", "Exit Looney's Liquer", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (Result == DialogResult.Yes)
            {

                MessageBox.Show("Goodbye!", "Exit Looney's Liquer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
            frmRegisterCustomer nextForm = new frmRegisterCustomer(this);
            nextForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (!(cboUsername.Text.Equals("")) && !(cboPassword.Text.Equals("")))
            {
                Customer customer = new Customer();
               bool isValid = customer.CheckCustomer(cboUsername.Text, cboPassword.Text);

                if (cboUsername.Text.Equals("Manager") && cboPassword.Text.Equals("Manager"))
                {
                    //manager view
                    this.Close();
                    frmMainMenuManager nextForm = new frmMainMenuManager(this);
                    nextForm.Show();
                }

                else if (isValid == true)
                   { 
                            //customer view
                            this.Close();
                            frmMainMenuCustomer nextForm = new frmMainMenuCustomer(this);
                            nextForm.Show();
                   }

                else
                {
                    MessageBox.Show("The Username/Password entered is not in our System . Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboUsername.Focus();
                    cboUsername.Clear();
                    cboPassword.Clear();
                }


                
            }

            

            else if (cboUsername.Text.Length == 0)
            {
                MessageBox.Show("The Username entered must not be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboUsername.Focus();
                cboUsername.Clear();
            }

            else if (cboPassword.Text.Length == 0)
            {
                MessageBox.Show("The Password entered must not be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPassword.Focus();
                cboPassword.Clear();
            }
            }

        private void cboUsername_TextChanged(object sender, EventArgs e)
        {
            String username = cboUsername.Text;
        }
    }
}
