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
    public partial class frmUpdateCustomer : Form
    {
        public frmUpdateCustomer(frmCustomerMenu frmCustomerMenu)
        {
            InitializeComponent();
        }

        private void mnuMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMainMenuCustomer frm = (frmMainMenuCustomer)Application.OpenForms["frmMainMenuCustomer"];
            if (frm != null)
            {
                // The form is already open, so just bring it to the front
                frm.BringToFront();
            }
            else
            {
                // The form is not open, create a new instance and show it
                frm = new frmMainMenuCustomer(this);
                frm.Show();
            }
        }

        private void mnuExxit_Click(object sender, EventArgs e)
        {
            DialogResult Result = (MessageBox.Show("Are you sure you want to exit?", "Exit Looney's Liquer", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (Result == DialogResult.Yes)
            {

                MessageBox.Show("Goodbye!", "Exit Looney's Liquer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void mnuCustomerMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCustomerMenu frm = (frmCustomerMenu)Application.OpenForms["frmCustomerMenu"];
            if (frm != null)
            {
                // The form is already open, so just bring it to the front
                frm.BringToFront();
            }
            else
            {
                // The form is not open, create a new instance and show it
                frm = new frmCustomerMenu();
                frm.Show();
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            bool FName = false;
            bool SName = false;
            bool Phone = false;

            if (!(cboForename.Text.Equals("")))
            {
                FName = true;
            }

            if (!(cboSurname.Text.Equals("")))
            {
                SName = true;
            }

            if (!(cboPhone.Text.Equals("")) && (int.TryParse(cboPhone.Text, out int a)) && (cboPhone.TextLength == 10))
            {
                Phone = true;
            }


            if (FName && SName && Phone)
            {
                DialogResult Result = (MessageBox.Show("Are you sure you want to update your information?", "Update Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

                if (Result == DialogResult.Yes)
                {

                    MessageBox.Show( cboForename.Text + " " + cboSurname.Text +", your information has been upated within the System "
                                    , "Customer Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (Result == DialogResult.No)
                {
                    MessageBox.Show("TheCustomer has not been updated in the system", "Update Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


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
                if (cboPhone.Text == "")
                {
                    MessageBox.Show("The Phone Number cannot be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboPhone.Focus();
                    cboPhone.Clear();
                }

                else if (cboPhone.TextLength != 10)
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

        private void frmUpdateCustomer_Load(object sender, EventArgs e)
        {
            frmLoginPage loginPage = new frmLoginPage(null);
            string username = loginPage.Username;

            Customer cust = new Customer();
            cust.FindingCustomer(username);

            cboCustID.Text = cust.getCustID().ToString();
            cboForename.Text = cust.getForename();
            cboLastname.Text = cust.getSurname();
            cboPhone.Text = cust.getPhone().ToString();
        }
    }
}
