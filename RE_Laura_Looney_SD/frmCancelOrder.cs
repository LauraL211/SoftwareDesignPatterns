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

        private void mnuOrder_Click(object sender, EventArgs e)
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

        private void mnuExxit_Click(object sender, EventArgs e)
        {
            DialogResult Result = (MessageBox.Show("Are you sure you want to exit?", "Exit Looney's Liquer", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (Result == DialogResult.Yes)
            {

                MessageBox.Show("Goodbye!", "Exit Looney's Liquer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
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

            DGVStock.Rows.Clear();
            {

                DataSet orderitems = OrderItem.GetOrder(cboSearch.Text);

                for (int i = 0; i < orderitems.Tables[0].Rows.Count; i++)
                {
                    DGVCart.Rows.Add(
                        orderitems.Tables[0].Rows[i][0],
                        orderitems.Tables[0].Rows[i][1],
                        orderitems.Tables[0].Rows[i][2]
                        );
                }
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            DialogResult Result = (MessageBox.Show("Are you sure you want to cancel this order?", "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (Result == DialogResult.Yes)
            {
                //update order status
                Order order = new Order();
                order.setOrderID(int.Parse(cboSearch.Text));
                order.setStatus("C");
                order.updateStatus();

                //update stock
                foreach (DataGridViewRow row in DGVCart.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        int stockId = Convert.ToInt32(row.Cells["SID"].Value);

                        int quantity = Convert.ToInt32(row.Cells["SQuantity"].Value);
                        int price = Convert.ToInt32(row.Cells["Price"].Value);

                        //Update stock quantity
                        Stock stock = new Stock();
                        stock.setStockID(stockId);
                        stock.updateCancelOrder(quantity);

                    }
                }

                //display confirmation message
                MessageBox.Show("Order Cancelled", "Order Cancelation",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //reset UI
                cboPrice.Clear();
                cboFName.Clear();
                cboLName.Clear();
                cboSearch.Clear();
                cboCustID.Clear();
                DGVStock.Rows.Clear();
                DGVCart.Rows.Clear();
                cboSearch.Focus();

            }

            if (Result == DialogResult.No)
            {
                MessageBox.Show("The order has not been cancelled", "Order Cancelation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cboPrice.Clear();
                cboFName.Clear();
                cboLName.Clear();
                cboSearch.Clear();
                cboCustID.Clear();
                DGVStock.Rows.Clear();
                DGVCart.Rows.Clear();
                cboSearch.Focus();
            }
        }
    }
}
