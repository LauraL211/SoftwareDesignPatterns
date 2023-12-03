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
    public partial class frmCollectOrder : Form
    {
        public frmCollectOrder()
        {
            InitializeComponent();

        }

        private void cboChooseOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblShopping_Cart.Visible = true;
            cboListBox.Visible = true;
            lblTotal.Visible = true;
            cboTotal.Visible = true;
            btnCollectOrder.Visible = true;

            if (cboCustID.Text == "1234")
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

            else if (cboCustID.Text == "1111")
            {
                if (cboChooseOrder.SelectedIndex == 0)
                {
                    cboListBox.Items.Clear();
                    cboListBox.Items.Add("Jameson,    Whiskey,        35");
                    cboListBox.Items.Add("Smirnoff,   Fruity Passion, 21");
                    cboListBox.Items.Add("Hennessey,  Cognak,         21");
                    cboListBox.Items.Add("Red Breast, Whiskey,        69");
                    cboListBox.Items.Add("Grey Goose, Original        10");
                    cboTotal.Text = "£6969.00";
                }

                if (cboChooseOrder.SelectedIndex == 1)
                {
                    cboListBox.Items.Clear();
                    cboListBox.Items.Add("Jameson,    Whiskey,        35");
                    cboListBox.Items.Add("Smirnoff,   Fruity Passion, 21");
                    cboListBox.Items.Add("Hennessey,  Cognak,         21");
                    cboListBox.Items.Add("Bailey's,   Original,       69");
                    cboListBox.Items.Add("Grey Goose, Original        10");
                    cboTotal.Text = "£999.00";
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

            else
            {
                if (cboChooseOrder.SelectedIndex == 0)
                {
                    cboListBox.Items.Clear();
                    cboListBox.Items.Add("Jameson,    Whiskey,        35");
                    cboListBox.Items.Add("Smirnoff,   Fruity Passion, 21");
                    cboListBox.Items.Add("Hennessey,  Cognak,         21");
                    cboListBox.Items.Add("Red Breast, Whiskey,        69");
                    cboListBox.Items.Add("Grey Goose, Original        10");
                    cboTotal.Text = "£6969.00";
                }

                if (cboChooseOrder.SelectedIndex == 1)
                {
                    cboListBox.Items.Clear();
                    cboListBox.Items.Add("Jameson,    Whiskey,        35");
                    cboListBox.Items.Add("Smirnoff,   Fruity Passion, 21");
                    cboListBox.Items.Add("Hennessey,  Cognak,         21");
                    cboListBox.Items.Add("Red Breast, Whiskey,        69");
                    cboListBox.Items.Add("Grey Goose, Original        10");
                    cboTotal.Text = "£6969.00";
                }

                if (cboChooseOrder.SelectedIndex == 2)
                {
                    cboListBox.Items.Clear();
                    cboListBox.Items.Add("Jameson,    Whiskey,        35");
                    cboListBox.Items.Add("Smirnoff,   Fruity Passion, 21");
                    cboListBox.Items.Add("Hennessey,  Cognak,         21");
                    cboListBox.Items.Add("Bailey's,   Original,       69");
                    cboListBox.Items.Add("Grey Goose, Original        10");
                    cboTotal.Text = "£999.00";
                }
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

        private void mnuOrder_Click(object sender, EventArgs e)
        {
            this.Close();
            frmOrderMenuWorker frm = (frmOrderMenuWorker)Application.OpenForms["frmOrderMenuWorker"];
            if (frm != null)
            {
                // The form is already open, so just bring it to the front
                frm.BringToFront();
            }
            else
            {
                // The form is not open, create a new instance and show it
                frm = new frmOrderMenuWorker(this);
                frm.Show();
            }
        }

        private void mnuMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMainMenuWorker frm = (frmMainMenuWorker)Application.OpenForms["frmMainMenuWorker"];
            if (frm != null)
            {
                // The form is already open, so just bring it to the front
                frm.BringToFront();
            }
            else
            {
                // The form is not open, create a new instance and show it
                frm = new frmMainMenuWorker(this);
                frm.Show();
            }
        }

        private void frmCollectOrder_Load(object sender, EventArgs e)
        {

        }

        private void cboCustID_TextChanged(object sender, EventArgs e)
        {
            if (cboCustID.Text == "")
            {
                lblChoose_Order.Visible = false;
                cboChooseOrder.Visible = false;
            }
            else 
            {
                lblChoose_Order.Visible = true;
                cboChooseOrder.Visible = true;

                if (cboCustID.Text == "1234")
                {
                    cboChooseOrder.Items.Clear();
                    cboChooseOrder.Items.Add("50314");
                    cboChooseOrder.Items.Add("32145");
                    cboChooseOrder.Items.Add("22222");
                }

                else if (cboCustID.Text == "1111")
                {
                    cboChooseOrder.Items.Clear();
                    cboChooseOrder.Items.Add("12345");
                    cboChooseOrder.Items.Add("54321");
                    cboChooseOrder.Items.Add("11111");
                }

                else
                {
                    cboChooseOrder.Items.Clear();
                    cboChooseOrder.Items.Add("11112");
                    cboChooseOrder.Items.Add("22223");
                    cboChooseOrder.Items.Add("33334");
                }
            }
            
        }

        private void btnCollectOrder_Click(object sender, EventArgs e)
        {
            DialogResult Result = (MessageBox.Show("Has this Order been collected?", "Collect Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (Result == DialogResult.Yes)
            {

                MessageBox.Show("Your order has been collected."
                                , "Order Collected", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblChoose_Order.Visible = false;
                cboChooseOrder.SelectedIndex = -1;
                cboChooseOrder.Visible = false;
                lblShopping_Cart.Visible = false;
                cboListBox.Visible = false;
                btnCollectOrder.Visible = false;
                cboTotal.Visible = false;
                lblTotal.Visible = false;
                cboCustID.Clear();

            }

            if (Result == DialogResult.No)
            {
                MessageBox.Show("The order has not been collected", "Order Not Collected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                lblChoose_Order.Visible = false;
                cboChooseOrder.SelectedIndex = -1;
                cboChooseOrder.Visible = false;
                lblShopping_Cart.Visible = false;
                cboListBox.Visible = false;
                btnCollectOrder.Visible = false;
                cboTotal.Visible = false;
                lblTotal.Visible = false;
                cboCustID.Clear();
            }
        }
    }
}
