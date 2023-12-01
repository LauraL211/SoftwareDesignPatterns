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
        public frmLoginPage(frmHomePage frmHomePage)
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult Result = (MessageBox.Show("Are you sure you want to exit?", "Exit Looney's Liquer", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (Result == DialogResult.Yes)
            {

                MessageBox.Show("Goodbye!", "Exit Looney's Liquer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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
            bool User = false;
            bool Pass = false;

            if (!(cboUsername.Text.Equals("")))
            {
                User = true;
            }

            if (!(cboPassword.Text.Equals("")))
            {
                Pass = true;
            }

            if (User && Pass)
            {
                //if user = manager(m)
                if (cboUsername.Text.Equals("m") && cboPassword.Text.Equals("m"))
                {
                    //manager view
                    this.Close();
                    frmMainMenuManager nextForm = new frmMainMenuManager(this);
                    nextForm.Show();
                }

                //if user = worker(w)
                else if (cboUsername.Text.Equals("w") && cboPassword.Text.Equals("w"))
                {
                    //worker view
                    this.Close();
                    frmMainMenuWorker nextForm = new frmMainMenuWorker(this);
                    nextForm.Show();
                }

                //if user = customer(c)
                else
                {
                    //customer view
                    this.Close();
                    frmMainMenuCustomer nextForm = new frmMainMenuCustomer(this);
                    nextForm.Show();
                }
            }

            else if (!User)
            {
                MessageBox.Show("The Username entered must not be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboUsername.Focus();
                cboUsername.Clear();
            }

            else if (!Pass)
            {
                MessageBox.Show("The Password entered must not be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPassword.Focus();
                cboPassword.Clear();
            }
            }
    }
}
