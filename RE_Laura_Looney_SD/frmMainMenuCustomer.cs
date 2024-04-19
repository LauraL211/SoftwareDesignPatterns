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
    public partial class frmMainMenuCustomer : Form
    {
        public frmMainMenuCustomer(Form frmLoginPage)
        {
            InitializeComponent();
        }

        private void mnuHomePage_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHomePage frm = (frmHomePage)Application.OpenForms["frmHomePage"];
            frm.Show();
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

        private void btnOrder_Click(object sender, EventArgs e)
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

        private void btnCustomer_Click(object sender, EventArgs e)
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
        }
    }

