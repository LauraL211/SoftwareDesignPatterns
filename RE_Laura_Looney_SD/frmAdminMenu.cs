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
    public partial class frmAdminMenu : Form
    {
        public frmAdminMenu(Form mainMenuManager)
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


        private void mnuStockMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmStockMenu frm = (frmStockMenu)Application.OpenForms["frmStockMenu"];
            if (frm != null)
            {
                // The form is already open, so just bring it to the front
                frm.BringToFront();
            }
            else
            {
                // The form is not open, create a new instance and show it
                frm = new frmStockMenu(this);
                frm.Show();
            }
        }

        private void mnuMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMainMenuManager frm = (frmMainMenuManager)Application.OpenForms["frmMainMenuManager"];
            if (frm != null)
            {
                // The form is already open, so just bring it to the front
                frm.BringToFront();
            }
            else
            {
                // The form is not open, create a new instance and show it
                frm = new frmMainMenuManager(this);
                frm.Show();
            }
        }

        private void btnStockSalesAnalysis_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdminStock frm = (frmAdminStock)Application.OpenForms["frmAdminStock"];
            if (frm != null)
            {
                // The form is already open, so just bring it to the front
                frm.BringToFront();
            }
            else
            {
                // The form is not open, create a new instance and show it
                frm = new frmAdminStock(this);
                frm.Show();
            }
        }

        private void btnRevAnalysis_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdminRevenue frm = (frmAdminRevenue)Application.OpenForms["frmAdminRevenue"];
            if (frm != null)
            {
                // The form is already open, so just bring it to the front
                frm.BringToFront();
            }
            else
            {
                // The form is not open, create a new instance and show it
                frm = new frmAdminRevenue(this);
                frm.Show();
            }
        }
    }
}
