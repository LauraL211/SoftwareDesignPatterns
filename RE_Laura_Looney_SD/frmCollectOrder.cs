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

        private void mnuExxit_Click(object sender, EventArgs e)
        {

            DialogResult Result = (MessageBox.Show("Are you sure you want to exit?", "Exit Looney's Liquer", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (Result == DialogResult.Yes)
            {

                MessageBox.Show("Goodbye!", "Exit Looney's Liquer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }


        private void frmCollectOrder_Load(object sender, EventArgs e)
        {

        }

        private void btnCollectOrder_Click(object sender, EventArgs e)
        {
            DialogResult Result = (MessageBox.Show("Has this Order been collected?", "Collect Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (Result == DialogResult.Yes)
            {

                MessageBox.Show("Your order has been collected."
                                , "Order Collected", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
            }

            if (Result == DialogResult.No)
            {
                MessageBox.Show("The order has not been collected", "Order Not Collected", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DGVStock.Rows.Clear();
            {

                DataSet order = Order.GetAnOrder(cboSearch.Text);

                for (int i = 0; i < order.Tables[0].Rows.Count; i++)
                {
                    DGVStock.Rows.Add(
                        order.Tables[0].Rows[i][0],
                        order.Tables[0].Rows[i][1],
                        order.Tables[0].Rows[i][2]
                        );
                }
            }
        }

        private void DGVStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int custid = Convert.ToInt32(DGVStock.Rows[e.RowIndex].Cells["CustID"].Value);
            cboCustID.Text = custid.ToString();

            Customer cust = new Customer();
            cust.getCustomerID(custid);
            cboFName.Text = cust.getForename();
            cboLName.Text = cust.getSurname();

            Order order = new Order();
            order.GetOrder(cboSearch.Text);
            cboPrice.Text = order.getTotalPrice().ToString();
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

        private void btnCollectOrder_Click_1(object sender, EventArgs e)
        {
            DialogResult Result = (MessageBox.Show("Are you sure you want to collect this order?", "Collect Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (Result == DialogResult.Yes)
            {
                Order order = new Order();
                order.setOrderID(int.Parse(cboSearch.Text));
                order.setStatus("R");
                order.updateStatus();

                MessageBox.Show("Order Collected", "Order Collection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                cboPrice.Clear();
                cboFName.Clear();
                cboLName.Clear();
                cboSearch.Clear();
                cboCustID.Clear();
                DGVStock.Rows.Clear();
                cboSearch.Focus();

            }

            if (Result == DialogResult.No)
            {
                MessageBox.Show("The order has not been collected", "Order Collection", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cboPrice.Clear();
                cboFName.Clear();
                cboLName.Clear();
                cboSearch.Clear();
                cboCustID.Clear();
                DGVStock.Rows.Clear();
                cboSearch.Focus();
            }
        }
    }
}
