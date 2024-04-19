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
    public partial class frmCustomerMenu : Form
    {
        public frmCustomerMenu()
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

        private void mnuOrderMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmOrderMenuCustomer frm = (frmOrderMenuCustomer)Application.OpenForms["frmOrderMenuCustomer"];
            if (frm != null)
            {
                frm.BringToFront();
            }
            else
            {
                frm = new frmOrderMenuCustomer(this);
                frm.Show();
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
            frmUpdateCustomer frm = (frmUpdateCustomer)Application.OpenForms["frmUpdateCustomer"];
            if (frm != null)
            {
                frm.BringToFront();
            }
            else
            {
                frm = new frmUpdateCustomer(this);
                frm.Show();
            }
        }

        private void btnDeRegisterCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDeRegisterCustomer frm = (frmDeRegisterCustomer)Application.OpenForms["frmDeRegisterCustomer"];
            if (frm != null)
            {
                frm.BringToFront();
            }
            else
            {
                frm = new frmDeRegisterCustomer(this);
                frm.Show();
            }
        }
    }
}
