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
    public partial class frmOrderMenuCustomer : Form
    {
        public frmOrderMenuCustomer(Form frmMainMenuCustomer)
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult Result = (MessageBox.Show("Are you sure you want to exit?", "Exit Looney's Liquer", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (Result == DialogResult.Yes)
            {

                MessageBox.Show("Goodbye!", "Exit Looney's Liquer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
                Application.Exit();
            }
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

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCancelOrder frm = (frmCancelOrder)Application.OpenForms["frmCancelOrder"];
            if (frm != null)
            {
                // The form is already open, so just bring it to the front
                frm.BringToFront();
            }
            else
            {
                // The form is not open, create a new instance and show it
                frm = new frmCancelOrder();
                frm.Show();
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

        private void frmOrderMenuCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPlaceOrder frm = (frmPlaceOrder)Application.OpenForms["frmPlaceOrder"];
            if (frm != null)
            {
                // The form is already open, so just bring it to the front
                frm.BringToFront();
            }
            else
            {
                // The form is not open, create a new instance and show it
                frm = new frmPlaceOrder();
                frm.Show();
            }
        }
    }

    }