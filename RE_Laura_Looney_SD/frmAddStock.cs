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
    public partial class frmAddStock : Form
    {
        public frmAddStock(frmStockMenu frmStockMenu)
        {
            InitializeComponent();
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

        private void mnuStock_Click(object sender, EventArgs e)
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
        private void frmAddStock_Load(object sender, EventArgs e)
        {
            //get next Stock ID
            cboStockID.Text = Stock.getNextStockID().ToString("0000");

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            OracleCommand cmd = new OracleCommand("SELECT DESCRIPTION FROM TYPES", conn);
            conn.Open();
            OracleDataReader Reader = cmd.ExecuteReader();
            while(Reader.Read())
            {

                String Type = Reader.GetString(0);
                cboType.Items.Add(Type);
            }
            conn.Close();



        }

        private void mnubtnExit_Click(object sender, EventArgs e)
        {
            DialogResult Result = (MessageBox.Show("Are you sure you want to exit?", "Exit Looney's Liquer", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (Result == DialogResult.Yes)
            {

                MessageBox.Show("Goodbye!", "Exit Looney's Liquer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
                Application.Exit();
            }
        }

        private void mnuStockmnu_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void btnAddStock_Click_1(object sender, EventArgs e)
        {
            //// Validate ALL the input data
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
                DialogResult Result = (MessageBox.Show("Are you sure you want to add this Stock Item?", "Add Stock Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

                if (Result == DialogResult.Yes)
                {
                    //Create an instance of Stock and instantiate with values from form controls
                    Stock aStock = new Stock(Convert.ToInt32(cboStockID.Text), cboName.Text.ToLower(), cboDescription.Text,
                        cboType.Text, Convert.ToDecimal(cboPrice.Text), Convert.ToInt32(cboQuantity.Text), Convert.ToInt32(cboReorderLVL.Text),
                        cboStatus.Text
                        );

                    //invoke the method to add the data to the Stock table
                    aStock.addStock();

                    //display confirmation message
                    MessageBox.Show("Stock " + cboStockID.Text + " added successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //reset UI
                    cboStockID.Text = Stock.getNextStockID().ToString("0000");
                    cboName.Clear();
                    cboDescription.Clear();
                    cboType.SelectedIndex = -1;
                    cboPrice.Clear();
                    cboQuantity.Clear();
                    cboReorderLVL.Clear();
               
                    cboName.Focus();
                }

                if (Result == DialogResult.No)
                {
                    MessageBox.Show("The Stock Item has not been added to the system", "Stock Item Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Refreshing the page
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

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            DialogResult Result = (MessageBox.Show("Are you sure you want to exit?", "Exit Looney's Liquer", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (Result == DialogResult.Yes)
            {

                MessageBox.Show("Goodbye!", "Exit Looney's Liquer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
                Application.Exit();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
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
    }
    }
    

