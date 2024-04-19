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
    public partial class frmCheckStock : Form
    {
        public frmCheckStock(frmStockMenu frmStockMenu)
        {
            InitializeComponent();

            dgvLowStock.Rows.Clear();
            {
                DataSet StockItem = Stock.CheckStock();

                for (int i = 0; i < StockItem.Tables[0].Rows.Count; i++)
                {
                    dgvLowStock.Rows.Add(
                        StockItem.Tables[0].Rows[i][0],
                        StockItem.Tables[0].Rows[i][1],
                        StockItem.Tables[0].Rows[i][2],
                        StockItem.Tables[0].Rows[i][3],
                        StockItem.Tables[0].Rows[i][4],
                        StockItem.Tables[0].Rows[i][5],
                        StockItem.Tables[0].Rows[i][6]
                        );
                }
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The following stock list is being printed ", "Low Stock List", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvLowStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
               

            }
        }

        private void dgvLowStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

