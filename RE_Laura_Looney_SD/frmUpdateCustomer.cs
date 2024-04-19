using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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
                frm.BringToFront();
            }
            else
            {
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
                frm.BringToFront();
            }
            else
            {
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
            String username = Interaction.InputBox("Enter Your Username", "", "");

            Customer cust = new Customer();
            cust.FindingCustomer(username);

            cboCustID.Text = cust.getCustID().ToString();
            cboForname.Text = cust.getForename();
            cboLastname.Text = cust.getSurname();
            cboNumber.Text = cust.getPhone().ToString();
        }

        private void btnUpdateCustomer_Click_1(object sender, EventArgs e)
        {
            bool fname = false;
            bool lname = false;
            bool phone = false;

            if (!(cboForname.Text.Equals("")))
            {
                fname = true;
            }

            if (!(cboLastname.Text.Equals("")))
            {
                lname = true;
            }

            if (!(cboNumber.Text.Equals("")) && (int.TryParse(cboNumber.Text, out int a)))
            {
                phone = true;
            }


            if (fname && lname && phone )
            {
                DialogResult Result = (MessageBox.Show("Are you sure you want to update your information?", "Update Customer Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

                if (Result == DialogResult.Yes)
                {
                    Customer cust = new Customer();
                    cust.setCustID(int.Parse(cboCustID.Text));
                    cust.setForename(cboForname.Text);
                    cust.setSurname(cboLastname.Text);
                    cust.setPhone(cboNumber.Text);
                    cust.updateCustomer();

                    MessageBox.Show("Customer " + cboCustID.Text + " updated successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                if (Result == DialogResult.No)
                {
                    MessageBox.Show("Your information has not been changed", "Update Customer Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else if (!fname)
            {
                MessageBox.Show("The Forename entered cannot be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboForname.Focus();
                cboForname.Clear();
            }

            else if (!lname)
            {
                MessageBox.Show("The Surname  entered cannot be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboLastname.Focus();
                cboLastname.Clear();
            }

            else if (!phone)
            {
                if (cboNumber.Text.Equals(""))
                {
                    MessageBox.Show("The Phone Number entered cannot be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboNumber.Focus();
                    cboNumber.Clear();
                }

                else if (!(double.TryParse(cboNumber.Text, out double f)))
                {
                    MessageBox.Show("The Phone Number entered must be an integer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboNumber.Focus();
                    cboNumber.Clear();
                }

                else
                {
                    MessageBox.Show("The Phone Number entered is incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboNumber.Focus();
                    cboNumber.Clear();
                }
            }

        }
    }
}
