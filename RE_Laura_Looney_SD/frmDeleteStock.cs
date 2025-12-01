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

namespace RE_Laura_Looney_SD
{
    public partial class frmDeleteStock : Form
    {
        private readonly StockFacade _stockFacade = new StockFacade();
        public frmDeleteStock(frmStockMenu frmStockMenu)
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


        private void btnSearch_Click(object sender, EventArgs e)
        {
            cboSearch.Text.ToLower();
            {
                DGVStock.Rows.Clear();
                {

                    DataSet StockItem = _stockFacade.GetAvailableStock(cboSearch.Text.ToLower());

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
            cboStatus.Text = stock.getStatus();
        }

        private void frmDeleteStock_Load(object sender, EventArgs e)
        {
            cboStockID.Text = Stock.getNextStockID().ToString("0000");

            cboType.Items.Clear();
            var types = _stockFacade.GetAllTypes();
            foreach (string type in types)
            {
                cboType.Items.Add(type);
            }
        }

        private void btnDeleteStock_Click_1(object sender, EventArgs e)
        {
            DialogResult Result = (MessageBox.Show("Are you sure you want to delete this Stock Item?", "Delete Stock Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

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
                stock.setStatus("U");
                stock.updateStock();

                MessageBox.Show("Stock " + cboStockID.Text + " deleted successfully", "Success",
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
                MessageBox.Show("The Stock Item has not been deleted from the system", "Stock Item Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cboName.Clear();
                cboDescription.Clear();
                cboType.SelectedIndex = -1;
                cboPrice.Clear();
                cboQuantity.Clear();
                cboReorderLVL.Clear();
            }
        }
    }
}
