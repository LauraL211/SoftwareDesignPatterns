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
    public partial class frmDeRegisterCustomer : Form
    {
        public frmDeRegisterCustomer(frmCustomerMenu frmCustomerMenu)
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

        private void btnDeRegisterCustomer_Click(object sender, EventArgs e)
        {
            DialogResult Result = (MessageBox.Show("Are you sure you want to De-register your account?", "De-Register  Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (Result == DialogResult.Yes)
            {

                MessageBox.Show(cboForename.Text + " " + cboSurname.Text + ", your account has been deregistered within our System "
                                , "Customer De-Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //Refreshing the page
                //cboForename.Clear();
                //cboSurname.Clear();
                //cboPhone.Clear();
            }

            if (Result == DialogResult.No)
            {
                MessageBox.Show("The Customer has not been removed from the system", "De-Registration Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
