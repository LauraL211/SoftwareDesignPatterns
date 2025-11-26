using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace RE_Laura_Looney_SD
{
    public partial class frmReplenishStock : Form
    {
        private readonly StockFacade _stockFacade = new StockFacade();
        public frmReplenishStock(frmStockMenu frmStockMenu)
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


        private void cboLowStock_CheckedChanged(object sender, EventArgs e)
        {
            if (cboLowStock.Checked == true )
            {
                
            }

            else
            {

            }
        }

        private void btnOrder_Items_Click(object sender, EventArgs e)
        {
            DialogResult Result = (MessageBox.Show("Are you sure you want to replenish these Stock Items?", "Replenish Stock Items", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (Result == DialogResult.Yes)
            {

                foreach (DataGridViewRow row in DGVReplenish.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        int stockId = Convert.ToInt32(row.Cells["ID"].Value);
                        int quantity = Convert.ToInt32(row.Cells["SQuantity"].Value);

                        _stockFacade.ReplenishStock(stockId, quantity);
                    }
                }



                MessageBox.Show("The Stock Items have been Replenished "
                                , "Stock Items Replenished", MessageBoxButtons.OK, MessageBoxIcon.Information); ;


          
                cboSearch.Clear();
                DGVReplenish.Rows.Clear();
                DGVStock.Rows.Clear();
                cboLowStock.Checked = false;
            }

            if (Result == DialogResult.No)
            {
                MessageBox.Show("The Stock Items have not been replenished", "Replenish Stock Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                cboSearch.Clear();
                DGVReplenish.Rows.Clear();
                DGVStock.Rows.Clear();
                cboLowStock.Checked = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cboLowStock.Checked == true)
            {
                cboSearch.Text.ToLower();
                {
                    DGVStock.Rows.Clear();
                    {

                        DataSet StockItem = _stockFacade.GetLowStockItems(cboSearch.Text.ToLower());

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

            else
            {
                cboSearch.Text.ToLower();
                {
                    DGVStock.Rows.Clear();
                    {

                        DataSet StockItem = _stockFacade.GetStock(cboSearch.Text.ToLower());

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
        }

        private void DGVStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int stockId = Convert.ToInt32(DGVStock.Rows[e.RowIndex].Cells["StockID"].Value);
            int quantity = 0;
            bool valid=false;

            Stock stock = new Stock();
            stock.replenishStock(stockId);


            string QuantityString = Interaction.InputBox("Enter order quantity", "", "");
            int inputQuantity;

            if (int.TryParse(QuantityString, out inputQuantity))
            {
                quantity = Convert.ToInt32(QuantityString);

                int currentquantity = stock.getQuantity();
                int orderquantity = currentquantity + quantity;

                int rowIndex = DGVReplenish.Rows.Add();
                DGVReplenish.Rows[rowIndex].Cells["ID"].Value = stockId;
                DGVReplenish.Rows[rowIndex].Cells["SName"].Value = stock.getName();
                DGVReplenish.Rows[rowIndex].Cells["SDescription"].Value = stock.getDescription();
                DGVReplenish.Rows[rowIndex].Cells["SQuantity"].Value = orderquantity;
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVReplenish_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult Result = (MessageBox.Show("Do you wish to remove this stock item?", "Replenish Stock", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (Result == DialogResult.Yes)
            {
                if (e.RowIndex >= 0 && e.RowIndex < DGVReplenish.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < DGVReplenish.Columns.Count)
                {
                    DGVReplenish.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}

