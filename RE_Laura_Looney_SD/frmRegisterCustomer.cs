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
    public partial class frmRegisterCustomer : Form
    {
        public frmRegisterCustomer(frmLoginPage frmLoginPage)
        {
            InitializeComponent();
        }

        private void btnRegisterCustomer_Click(object sender, EventArgs e)
        {

            bool User = false;
            bool Pass = false;
            bool FName = false;
            bool SName = false;
            bool Phone = false;

            if (!(cboUsername.Text.Equals("")))
            {
                User = true;
            }

            if (!(cboPassword.Text.Equals("")))
            {
                Pass = true;
            }

            if (!(cboForename.Text.Equals("")))
            {
                FName = true;
            }

            if (!(cboSurname.Text.Equals("")))
            {
                SName = true;
            }

            if (!(cboPhone.Text.Equals("")) && (int.TryParse(cboPhone.Text, out int a)) && (cboPhone.TextLength==10))
            {
                Phone = true;
            }


            if (User && Pass && FName && SName && Phone)
            {
                DialogResult Result = (MessageBox.Show("Are you sure you want to register?", "Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

                if (Result == DialogResult.Yes)
                {

                    MessageBox.Show("The following Customer has been registered to the system "
                                    , "Customer Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    //Refreshing the page
                    cboForename.Clear();
                    cboSurname.Clear();
                    cboPhone.Clear();

                    this.Close();
                    frmLoginPage frm = (frmLoginPage)Application.OpenForms["frmLoginPage"];
                    if (frm != null)
                    {
                        // The form is already open, so just bring it to the front
                        frm.BringToFront();
                    }
                    else
                    {
                        // The form is not open, create a new instance and show it
                        frm = new frmLoginPage(this);
                        frm.Show();
                    }
                }

                if (Result == DialogResult.No)
                {
                    MessageBox.Show("TheCustomer has not been registered to the system", "Registeration Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Refreshing the page
                    cboForename.Clear();
                    cboSurname.Clear();
                    cboPhone.Clear();

                    this.Close();
                    frmLoginPage frm = (frmLoginPage)Application.OpenForms["frmLoginPage"];
                    if (frm != null)
                    {
                        // The form is already open, so just bring it to the front
                        frm.BringToFront();
                    }
                    else
                    {
                        // The form is not open, create a new instance and show it
                        frm = new frmLoginPage(this);
                        frm.Show();
                    }

                }
            }

            else if (!User)
            {
                MessageBox.Show("The Username entered cannot be Null. Please enter something.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboUsername.Focus();
                cboUsername.Clear();
            }

            else if (!Pass)
            {
                MessageBox.Show("The Password entered cannot be Null. Please enter something.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPassword.Focus();
                cboPassword.Clear();
            }

            else if (!FName)
            {
                MessageBox.Show("The Forename entered cannot be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboForename.Focus();
                cboForename.Clear();
            }

            else if (!SName)
            {
                MessageBox.Show("The Surname entered cannot be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSurname.Focus();
                cboSurname.Clear();
            }

            else if (!Phone)
            {
                if(cboPhone.Text == "")
                {
                    MessageBox.Show("The Phone Number cannot be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboPhone.Focus();
                    cboPhone.Clear();
                }

                else if(cboPhone.TextLength != 10)
                    {
                        MessageBox.Show("The Phone Number must be 10 digits long. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cboPhone.Focus();
                        cboPhone.Clear();
                    }

                else
                {
                    MessageBox.Show("The Phone Number entered is incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboPhone.Focus();
                    cboPhone.Clear();
                }
                
            }
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLoginPage frm = (frmLoginPage)Application.OpenForms["frmLoginPage"];
            frm.Show();
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

        private void mnuHomePage_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHomePage frm = (frmHomePage)Application.OpenForms["frmHomePage"];
            frm.Show();
        }
    }
}
