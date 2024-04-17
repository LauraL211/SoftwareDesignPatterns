using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RE_Laura_Looney_SD
{
    public partial class frmPlaceOrder : Form
    {
        int valueAsInt;
        public frmPlaceOrder()
        {
            InitializeComponent();

        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;

            buttonOk.Text = "Ok";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(30, 30, 366, 7);
            textBox.SetBounds(30, 80, 694, 14);
            buttonOk.SetBounds(222, 154, 154, 54);
            buttonCancel.SetBounds(394, 154, 154, 54);

            label.AutoSize = true;
            form.ClientSize = new Size(763, 295);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;

            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();

            value = textBox.Text;
            return dialogResult;
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

        public class ShoppingCart
        {
            private static double runningTotal = 0;

            public static void AddCost(int valueAsInt, double price, System.Windows.Forms.TextBox cboTotal_Cost)
            {
                double cost = valueAsInt * price;
                runningTotal += cost;
                cboTotal_Cost.Text = runningTotal.ToString("C");
            }

            public static void DeductCost(int valueAsInt, double price, TextBox cboTotal_Cost)
            {
                double cost = valueAsInt * price;
                runningTotal -= cost;
                cboTotal_Cost.Text = runningTotal.ToString("C");
                if (runningTotal < 0)
                {
                    runningTotal = 0;
                }
            }

            public static double GetRunningTotal()
            {
                return runningTotal;
            }
        }

        private void btnPlace_Order_Click(object sender, EventArgs e)
        {
            DialogResult Result = (MessageBox.Show("Are you sure you want to order these Stock Items?", "Place Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (Result == DialogResult.Yes)
            {
                MessageBox.Show("The Stock Items have been ordered "
                                , "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }

            if (Result == DialogResult.No)
            {
                MessageBox.Show("The Stock Items have not been ordered", "Order Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cboSearch.Text.ToLower();
            {
                DGVStock.Rows.Clear();
                {

                    DataSet StockItem = Stock.GetStock(cboSearch.Text.ToLower());

                    for (int i = 0; i < StockItem.Tables[0].Rows.Count; i++)
                    {
                        DGVStock.Rows.Add(
                            StockItem.Tables[0].Rows[i][0],
                            StockItem.Tables[0].Rows[i][1],
                            StockItem.Tables[0].Rows[i][2]
                            );
                    }
                }
            }
        }

        private void DGVStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int stockId = Convert.ToInt32(DGVStock.Rows[e.RowIndex].Cells["StockID"].Value);
            int quantity = 0;
            bool valid = false;
            int total = 0;

            Stock stock = new Stock();
            stock.replenishStock(stockId);


            string QuantityString = Interaction.InputBox("Enter order quantity", "", "");
            int inputQuantity;

            if (int.TryParse(QuantityString, out inputQuantity))
            {
                quantity = Convert.ToInt32(QuantityString);

                if(quantity > stock.getQuantity())
                {
                    MessageBox.Show("Unfortunately we do not have enough stock in store atm", "Low Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    int orderquantity = quantity;
                
                    decimal currentprice = stock.getPrice();
                    decimal sprice = currentprice * quantity;

                    int rowIndex = DGVCart.Rows.Add();
                    DGVCart.Rows[rowIndex].Cells["ID"].Value = stockId;
                    DGVCart.Rows[rowIndex].Cells["SName"].Value = stock.getName();
                    DGVCart.Rows[rowIndex].Cells["SDescription"].Value = stock.getDescription();
                    DGVCart.Rows[rowIndex].Cells["SQuantity"].Value = orderquantity;
                    DGVCart.Rows[rowIndex].Cells["Price"].Value = sprice;


                    foreach (DataGridViewRow row in DGVCart.Rows)
                    {
                        if (!row.IsNewRow && row.Cells["Price"].Value != null)
                        {
                            int value;
                            if (int.TryParse(row.Cells["Price"].Value.ToString(), out value))
                            {
                                total += value;
                            
                            }
                        }
                    }
                    cboTotal_Cost.Text = total.ToString();
                    }
                
                }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult Result = (MessageBox.Show("Do you wish to remove this stock item?", "Replenish Stock", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (Result == DialogResult.Yes)
            {
                if (e.RowIndex >= 0 && e.RowIndex < DGVCart.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < DGVCart.Columns.Count)
                {
                    int price = Convert.ToInt32(DGVCart.Rows[e.RowIndex].Cells["Price"].Value);
                    int total = Convert.ToInt32(cboTotal_Cost.Text);
                    int minus = total - price;

                    cboTotal_Cost.Text = minus.ToString();

                    DGVCart.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
