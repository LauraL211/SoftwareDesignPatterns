using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RE_Laura_Looney_SD
{
    public partial class frmUpdateStock : Form
    {
        int Stock_ID;
        public frmUpdateStock(frmStockMenu frmStockMenu)
        {
            InitializeComponent();

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

        private void mnuStock_Click(object sender, EventArgs e)
        {
            this.Close();
            frmStockMenu frm = (frmStockMenu)Application.OpenForms["frmStockMenu"];
            if (frm != null)
            {
                frm.BringToFront();
            }
            else
            {
                frm = new frmStockMenu(this);
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

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            bool Name = false;
            bool Desc = false;
            bool Type = false;
            bool Price = false;
            bool Quantity = false;
            bool ReorderLVL = false;

            if (!(cboName.Text.Equals("")))
            {
                Name = true;
            }

            if (!(cboDescription.Text.Equals("")))
            {
                Desc = true;
            }

            if (!(cboType.Text.Equals("")))
            {
                Type = true;
            }

            if (!(cboPrice.Text.Equals("")) && (double.TryParse(cboPrice.Text, out double a)))
            {
                Price = true;
            }

            if (!(cboQuantity.Text.Equals("")) && (int.TryParse(cboQuantity.Text, out int b)))
            {
                Quantity = true;
            }

            if (!(cboReorderLVL.Text.Equals("")) && (int.TryParse(cboReorderLVL.Text, out int c)))
            {
                ReorderLVL = true;
            }


            if (Name && Desc && Type && Price && Quantity && ReorderLVL)
            {
                DialogResult Result = (MessageBox.Show("Are you sure you want to update this Stock Item?", "Update Stock Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

                if (Result == DialogResult.Yes)
                {

                    MessageBox.Show("The following Stock Item has been updated in the system " +
                                    "\n\nStock ID: " + Stock_ID +
                                    "\nStock Name: " + cboName.Text +
                                    "\nStock Description: " + cboDescription.Text +
                                    "\nStock Type: " + cboType.Text +
                                    "\nStock Price: " + cboPrice.Text +
                                    "\nStock Quantity: " + cboQuantity.Text +
                                    "\nStock Reorder Level: " + cboReorderLVL.Text
                                    , "Stock Item Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    cboName.Clear();
                    cboDescription.Clear();
                    cboType.SelectedIndex = -1;
                    cboPrice.Clear();
                    cboQuantity.Clear();
                    cboReorderLVL.Clear();
                    Stock_ID++;
                }

                if (Result == DialogResult.No)
                {
                    MessageBox.Show("The Stock Item has not been updated in the system", "Update Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cboName.Clear();
                    cboDescription.Clear();
                    cboType.SelectedIndex = -1;
                    cboPrice.Clear();
                    cboQuantity.Clear();
                    cboReorderLVL.Clear();
                }
            }

            else if (!Name)
            {
                MessageBox.Show("The Stock Name entered cannot be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboName.Focus();
                cboName.Clear();
            }

            else if (!Desc)
            {
                MessageBox.Show("The Stock Description entered cannot be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDescription.Focus();
                cboDescription.Clear();
            }

            else if (!Type)
            {
                MessageBox.Show("The Stock Type entered cannot be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboType.Focus();
                cboType.SelectedIndex = -1;
            }

            else if (!Price)
            {

                if (cboPrice.Text.Equals(""))
                {
                    MessageBox.Show("The Stock Price entered cannot be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboPrice.Focus();
                    cboPrice.Clear();
                }

                else if (!(double.TryParse(cboPrice.Text, out double f)))
                {
                    MessageBox.Show("The Stock Price entered must be an integer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboPrice.Focus();
                    cboPrice.Clear();
                }

                else
                {
                    MessageBox.Show("The Stock Price entered is incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboPrice.Focus();
                    cboPrice.Clear();
                }
            }

            else if (!Quantity)
            {
                if (cboQuantity.Text.Equals(""))
                {
                    MessageBox.Show("The Stock Quantity entered cannot be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboQuantity.Focus();
                    cboQuantity.Clear();
                }

                else if (!(double.TryParse(cboQuantity.Text, out double f)))
                {
                    MessageBox.Show("The Stock Quantity entered must be an integer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboQuantity.Focus();
                    cboQuantity.Clear();
                }

                else
                {
                    MessageBox.Show("The Stock Quantity entered is incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboQuantity.Focus();
                    cboQuantity.Clear();
                }
            }

            else if (!ReorderLVL)
            {
                if (cboReorderLVL.Text.Equals(""))
                {
                    MessageBox.Show("The Stock Reorder Level entered cannot be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboReorderLVL.Focus();
                    cboReorderLVL.Clear();
                }

                else if (!(double.TryParse(cboReorderLVL.Text, out double f)))
                {
                    MessageBox.Show("The Stock Reorder Level entered must be an integer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboReorderLVL.Focus();
                    cboReorderLVL.Clear();
                }

                else
                {
                    MessageBox.Show("The Stock Reorder Level entered is incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboReorderLVL.Focus();
                    cboReorderLVL.Clear();
                }

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

                Stock stock = new Stock();
                stock.getStock(stockId);
                cboStockID.Text = stockId.ToString();
                cboName.Text = stock.getName();
                cboDescription.Text = stock.getDescription();
                cboType.Text = stock.getType();
                cboPrice.Text = stock.getPrice().ToString();
                cboQuantity.Text = stock.getQuantity().ToString();
                cboReorderLVL.Text = stock.getReorderLvl().ToString();
                lblStatus.Text = stock.getStatus();

        }

        private void frmUpdateStock_Load(object sender, EventArgs e)
        {
            OracleConnection conn = DBManager.Instance.GetConnection();
            OracleCommand cmd = new OracleCommand("SELECT DESCRIPTION FROM TYPES", conn);
            OracleDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {

                String Type = Reader.GetString(0);
                cboType.Items.Add(Type);
            }
            DBManager.Instance.CloseConnection();
        }

        private void btnUpdateStock_Click_1(object sender, EventArgs e)
        {
            bool Name = false;
            bool Desc = false;
            bool Type = false;
            bool Price = false;
            bool Quantity = false;
            bool ReorderLVL = false;

            if (!(cboName.Text.Equals("")))
            {
                Name = true;
            }

            if (!(cboDescription.Text.Equals("")))
            {
                Desc = true;
            }

            if (!(cboType.Text.Equals("")))
            {
                Type = true;
            }

            if (!(cboPrice.Text.Equals("")) && (double.TryParse(cboPrice.Text, out double a)))
            {
                Price = true;
            }

            if (!(cboQuantity.Text.Equals("")) && (int.TryParse(cboQuantity.Text, out int b)))
            {
                Quantity = true;
            }

            if (!(cboReorderLVL.Text.Equals("")) && (int.TryParse(cboReorderLVL.Text, out int c)))
            {
                ReorderLVL = true;
            }


            if (Name && Desc && Type && Price && Quantity && ReorderLVL)
            {
                DialogResult Result = (MessageBox.Show("Are you sure you want to update this Stock Item?", "Update Stock Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

                if (Result == DialogResult.Yes)
                {
                    Stock stock = new Stock();
                    stock.setStockID(int.Parse(cboStockID.Text));
                    stock.setName(cboName.Text);
                    stock.setDescription(cboDescription.Text);
                    stock.setType(cboType.Text);
                    stock.setPrice(decimal.Parse(cboPrice.Text));
                    stock.setQuantity(int.Parse(cboQuantity.Text));
                    stock.setReorderLvl(int.Parse(cboReorderLVL.Text)); 
                    stock.setStatus("A");
                    stock.updateStock();

                    MessageBox.Show("Stock " + cboStockID.Text + " updated successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cboStockID.Clear();
                    cboName.Clear();
                    cboDescription.Clear();
                    cboType.SelectedIndex = -1;
                    cboPrice.Clear();
                    cboQuantity.Clear();
                    cboReorderLVL.Clear();
                    DGVStock.Rows.Clear();
                    cboSearch.Focus();

                }

                if (Result == DialogResult.No)
                {
                    MessageBox.Show("The Stock Item has not been updated to the system", "Stock Item Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cboName.Clear();
                    cboDescription.Clear();
                    cboType.SelectedIndex = -1;
                    cboPrice.Clear();
                    cboQuantity.Clear();
                    cboReorderLVL.Clear();
                }
            }

            else if (!Name)
            {
                MessageBox.Show("The Stock Name entered cannot be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboName.Focus();
                cboName.Clear();
            }

            else if (!Desc)
            {
                MessageBox.Show("The Stock Description entered cannot be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDescription.Focus();
                cboDescription.Clear();
            }

            else if (!Type)
            {
                MessageBox.Show("The Stock Type entered cannot be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboType.Focus();
                cboType.SelectedIndex = -1;
            }

            else if (!Price)
            {

                if (cboPrice.Text.Equals(""))
                {
                    MessageBox.Show("The Stock Price entered cannot be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboPrice.Focus();
                    cboPrice.Clear();
                }

                else if (!(double.TryParse(cboPrice.Text, out double f)))
                {
                    MessageBox.Show("The Stock Price entered must be an integer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboPrice.Focus();
                    cboPrice.Clear();
                }

                else
                {
                    MessageBox.Show("The Stock Price entered is incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboPrice.Focus();
                    cboPrice.Clear();
                }
            }

            else if (!Quantity)
            {
                if (cboQuantity.Text.Equals(""))
                {
                    MessageBox.Show("The Stock Quantity entered cannot be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboQuantity.Focus();
                    cboQuantity.Clear();
                }

                else if (!(double.TryParse(cboQuantity.Text, out double f)))
                {
                    MessageBox.Show("The Stock Quantity entered must be an integer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboQuantity.Focus();
                    cboQuantity.Clear();
                }

                else
                {
                    MessageBox.Show("The Stock Quantity entered is incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboQuantity.Focus();
                    cboQuantity.Clear();
                }
            }

            else if (!ReorderLVL)
            {
                if (cboReorderLVL.Text.Equals(""))
                {
                    MessageBox.Show("The Stock Reorder Level entered cannot be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboReorderLVL.Focus();
                    cboReorderLVL.Clear();
                }

                else if (!(double.TryParse(cboReorderLVL.Text, out double f)))
                {
                    MessageBox.Show("The Stock Reorder Level entered must be an integer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboReorderLVL.Focus();
                    cboReorderLVL.Clear();
                }

                else
                {
                    MessageBox.Show("The Stock Reorder Level entered is incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboReorderLVL.Focus();
                    cboReorderLVL.Clear();
                }

            }
        }

        private void cboSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboStockID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
