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
    public partial class frmStockMenu : Form
    {
        public frmStockMenu(Form mainMenuManager)
        {
            InitializeComponent();
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

        private void mnuMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMainMenuManager frm = (frmMainMenuManager)Application.OpenForms["frmMainMenuManager"];
            if (frm != null)
            {
                frm.BringToFront();
            }
            else
            {
                frm = new frmMainMenuManager(this);
                frm.Show();
            }
        }

        private void mnuAdminMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdminMenu frm = (frmAdminMenu)Application.OpenForms["frmAdminMenu"];
            if (frm != null)
            {
                frm.BringToFront();
            }
            else
            {
                frm = new frmAdminMenu(this);
                frm.Show();
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAddStock frm = (frmAddStock)Application.OpenForms["frmAddStock"];
            if (frm != null)
            {
                frm.BringToFront();
            }
            else
            {
                frm = new frmAddStock(this);
                frm.Show();
            }
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            this.Close();
            frmUpdateStock frm = (frmUpdateStock)Application.OpenForms["frmUpdateStock"];
            if (frm != null)
            {
                frm.BringToFront();
            }
            else
            {
                frm = new frmUpdateStock(this);
                frm.Show();
            }
        }

        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDeleteStock frm = (frmDeleteStock)Application.OpenForms["frmDeleteStock"];
            if (frm != null)
            {
                frm.BringToFront();
            }
            else
            {
                frm = new frmDeleteStock(this);
                frm.Show();
            }
        }

        private void btnCheck_Stock_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCheckStock frm = (frmCheckStock)Application.OpenForms["frmCheckStock"];
            if (frm != null)
            {
                frm.BringToFront();
            }
            else
            {
                frm = new frmCheckStock(this);
                frm.Show();
            }
        }

        private void btnReplenishStock_Click(object sender, EventArgs e)
        {
            this.Close();
            frmReplenishStock frm = (frmReplenishStock)Application.OpenForms["frmReplenishStock"];
            if (frm != null)
            {
                frm.BringToFront();
            }
            else
            {
                frm = new frmReplenishStock(this);
                frm.Show();
            }
        }
    }
}
