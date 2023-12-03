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
    public partial class frmCancelOrder : Form
    {
        public frmCancelOrder()
        {
            InitializeComponent();

            cboChooseOrder.Items.Add("50314");
            cboChooseOrder.Items.Add("32145");
            cboChooseOrder.Items.Add("22222");
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

        private void mnuOrder_Click(object sender, EventArgs e)
        {
            this.Close();
            frmOrderMenuCustomer frm = (frmOrderMenuCustomer)Application.OpenForms["frmOrderMenuCustomer"];
            if (frm != null)
            {
                // The form is already open, so just bring it to the front
                frm.BringToFront();
            }
            else
            {
                // The form is not open, create a new instance and show it
                frm = new frmOrderMenuCustomer(this);
                frm.Show();
            }
        }

        private void mnuExxit_Click(object sender, EventArgs e)
        {
            DialogResult Result = (MessageBox.Show("Are you sure you want to exit?", "Exit Looney's Liquer", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (Result == DialogResult.Yes)
            {

                MessageBox.Show("Goodbye!", "Exit Looney's Liquer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
                Application.Exit();
            }
        }

        private void cboChooseOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboChooseOrder.SelectedIndex == 0)
            {
                cboListBox.Items.Clear();
                cboListBox.Items.Add("Jameson,    Whiskey,        35");
                cboListBox.Items.Add("Smirnoff,   Fruity Passion, 21");
                cboListBox.Items.Add("Hennessey,  Cognak,         21");
                cboListBox.Items.Add("Bailey's,   Original,       69");
                cboListBox.Items.Add("Grey Goose, Original        10");
                cboTotal.Text = "£999.00";
            }

            if (cboChooseOrder.SelectedIndex == 1)
            {
                cboListBox.Items.Clear();
                cboListBox.Items.Add("Carlsberg,  Beer,      35");
                cboListBox.Items.Add("Guiness,    Beer,      21");
                cboListBox.Items.Add("Hennessey,  Cognak,    21");
                cboListBox.Items.Add("Red Breast, Whiskey,   69");
                cboListBox.Items.Add("Grey Goose, Original   10");
                cboTotal.Text = "£10000.00";
            }

            if (cboChooseOrder.SelectedIndex == 2)
            {
                cboListBox.Items.Clear();
                cboListBox.Items.Add("Jameson,    Whiskey,        35");
                cboListBox.Items.Add("Smirnoff,   Fruity Passion, 21");
                cboListBox.Items.Add("Hennessey,  Cognak,         21");
                cboListBox.Items.Add("Red Breast, Whiskey,        69");
                cboListBox.Items.Add("Grey Goose, Original        10");
                cboTotal.Text = "£6969.00";
            }
        }

        private void btnCancel_Order_Click(object sender, EventArgs e)
        {
            DialogResult Result = (MessageBox.Show("Are you sure you want to cancel your order?", "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (Result == DialogResult.Yes)
            {

                MessageBox.Show("Your order has been cancelled."
                                , "Order Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Result == DialogResult.No)
            {
                MessageBox.Show("The order has not been cancelled", "Order Not Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
