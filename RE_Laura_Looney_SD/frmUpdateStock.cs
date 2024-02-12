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
    public partial class frmUpdateStock : Form
    {
        int Stock_ID;
        public frmUpdateStock(frmStockMenu frmStockMenu)
        {
            InitializeComponent();

            lblName.Visible = false;
            cboName.Visible = false;

            lblDescription.Visible = false;
            cboDescription.Visible = false;

            lblType.Visible = false;
            cboType.Visible = false;

            lblPrice.Visible = false;
            cboPrice.Visible = false;

            lblQuantity.Visible = false;
            cboQuantity.Visible = false;

            lblReorderLevel.Visible = false;
            cboReorderLVL.Visible = false;

            btnUpdateStock.Visible = false;
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


                    //Refreshing the page
                    cboName.Clear();
                    cboDescription.Clear();
                    cboType.SelectedIndex = -1;
                    cboPrice.Clear();
                    cboQuantity.Clear();
                    cboReorderLVL.Clear();
                    cboStock_List.SelectedIndex = -1;
                    Stock_ID++;
                }

                if (Result == DialogResult.No)
                {
                    MessageBox.Show("The Stock Item has not been updated in the system", "Update Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void cboStock_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cboSearch.Text.Contains(""))
            {
                if (cboStock_List.SelectedIndex == 0)
                {
                    Stock_ID = 1;
                    cboName.Text = "Jameson";
                    cboDescription.Text = "Black Barrell";
                    cboType.Text = "Whiskey";
                    cboPrice.Text = "69.69";
                    cboQuantity.Text = "100";
                    cboReorderLVL.Text = "20";
                }

                if (cboStock_List.SelectedIndex == 1)
                {
                    Stock_ID = 2;
                    cboName.Text = "Smirnoff";
                    cboDescription.Text = "Original";
                    cboType.Text = "Vodka";
                    cboPrice.Text = "30.00";
                    cboQuantity.Text = "100";
                    cboReorderLVL.Text = "30";
                }

                if (cboStock_List.SelectedIndex == 2)
                {
                    Stock_ID = 3;
                    cboName.Text = "Cognak";
                    cboDescription.Text = "Original";
                    cboType.Text = "Brandy";
                    cboPrice.Text = "40.00";
                    cboQuantity.Text = "50";
                    cboReorderLVL.Text = "10";
                }

                if (cboStock_List.SelectedIndex == 3)
                {
                    Stock_ID = 4;
                    cboName.Text = "Baileys";
                    cboDescription.Text = "Cream";
                    cboType.Text = "Liquer";
                    cboPrice.Text = "20.00";
                    cboQuantity.Text = "69";
                    cboReorderLVL.Text = "15";
                }

                if (cboStock_List.SelectedIndex == 4)
                {
                    Stock_ID = 5;
                    cboName.Text = "Grey Goose";
                    cboDescription.Text = "Original";
                    cboType.Text = "Vodka";
                    cboPrice.Text = "35.00";
                    cboQuantity.Text = "40";
                    cboReorderLVL.Text = "10";
                }
            }

            if (cboSearch.Text.Contains("A") || cboSearch.Text.Contains("a"))
            {
                if (cboStock_List.SelectedIndex == 0)
                {
                    Stock_ID = 1;
                    cboName.Text = "Aperol";
                    cboDescription.Text = "Spritz";
                    cboType.Text = "IDK";
                    cboPrice.Text = "69.69";
                    cboQuantity.Text = "100";
                    cboReorderLVL.Text = "20";
                }

                if (cboStock_List.SelectedIndex == 1)
                {
                    Stock_ID = 2;
                    cboName.Text = "Apple Sourz";
                    cboDescription.Text = "Original";
                    cboType.Text = "IDK";
                    cboPrice.Text = "30.00";
                    cboQuantity.Text = "100";
                    cboReorderLVL.Text = "30";
                }

                if (cboStock_List.SelectedIndex == 2)
                {
                    Stock_ID = 3;
                    cboName.Text = "Angellica";
                    cboDescription.Text = "Spritzer";
                    cboType.Text = "Vodka";
                    cboPrice.Text = "40.00";
                    cboQuantity.Text = "50";
                    cboReorderLVL.Text = "10";
                }

            }

            if (cboSearch.Text.Contains("B") || cboSearch.Text.Contains("b"))
            {
                if (cboStock_List.SelectedIndex == 0)
                {
                    Stock_ID = 1;
                    cboName.Text = "Baileys";
                    cboDescription.Text = "Original";
                    cboType.Text = "Liquer";
                    cboPrice.Text = "69.69";
                    cboQuantity.Text = "100";
                    cboReorderLVL.Text = "20";
                }

                if (cboStock_List.SelectedIndex == 1)
                {
                    Stock_ID = 2;
                    cboName.Text = "Bushmills";
                    cboDescription.Text = "Original";
                    cboType.Text = "Whiskey";
                    cboPrice.Text = "30.00";
                    cboQuantity.Text = "100";
                    cboReorderLVL.Text = "30";
                }

                if (cboStock_List.SelectedIndex == 2)
                {
                    Stock_ID = 3;
                    cboName.Text = "BJ";
                    cboDescription.Text = "Sprits";
                    cboType.Text = "Vodka";
                    cboPrice.Text = "40.00";
                    cboQuantity.Text = "50";
                    cboReorderLVL.Text = "10";
                }

            }

            if (cboSearch.Text.Contains("C") || cboSearch.Text.Contains("c"))
            {
                if (cboStock_List.SelectedIndex == 0)
                {
                    Stock_ID = 1;
                    cboName.Text = "Cognak";
                    cboDescription.Text = "Original";
                    cboType.Text = "Brandy";
                    cboPrice.Text = "69.69";
                    cboQuantity.Text = "100";
                    cboReorderLVL.Text = "20";
                }

                if (cboStock_List.SelectedIndex == 1)
                {
                    Stock_ID = 2;
                    cboName.Text = "Coors";
                    cboDescription.Text = "Original";
                    cboType.Text = "Beer";
                    cboPrice.Text = "30.00";
                    cboQuantity.Text = "100";
                    cboReorderLVL.Text = "30";
                }

                if (cboStock_List.SelectedIndex == 2)
                {
                    Stock_ID = 3;
                    cboName.Text = "Cashmans";
                    cboDescription.Text = "Sprits";
                    cboType.Text = "Vodka";
                    cboPrice.Text = "40.00";
                    cboQuantity.Text = "50";
                    cboReorderLVL.Text = "10";
                }

            }

            if (cboSearch.Text.Contains("G") || cboSearch.Text.Contains("g"))
            {
                if (cboStock_List.SelectedIndex == 0)
                {
                    Stock_ID = 1;
                    cboName.Text = "Grey Goose";
                    cboDescription.Text = "Original";
                    cboType.Text = "Vodka";
                    cboPrice.Text = "69.69";
                    cboQuantity.Text = "100";
                    cboReorderLVL.Text = "20";
                }

                if (cboStock_List.SelectedIndex == 1)
                {
                    Stock_ID = 2;
                    cboName.Text = "Gordon's";
                    cboDescription.Text = "Original";
                    cboType.Text = "Gin";
                    cboPrice.Text = "30.00";
                    cboQuantity.Text = "100";
                    cboReorderLVL.Text = "30";
                }

                if (cboStock_List.SelectedIndex == 2)
                {
                    Stock_ID = 3;
                    cboName.Text = "Gordon's";
                    cboDescription.Text = "Pink";
                    cboType.Text = "Gin";
                    cboPrice.Text = "40.00";
                    cboQuantity.Text = "50";
                    cboReorderLVL.Text = "10";
                }

            }

            if (cboSearch.Text.Contains("S") || cboSearch.Text.Contains("s"))
            {
                if (cboStock_List.SelectedIndex == 0)
                {
                    Stock_ID = 1;
                    cboName.Text = "Smirnoff";
                    cboDescription.Text = "Original";
                    cboType.Text = "Vodka";
                    cboPrice.Text = "69.69";
                    cboQuantity.Text = "100";
                    cboReorderLVL.Text = "20";
                }

                if (cboStock_List.SelectedIndex == 1)
                {
                    Stock_ID = 2;
                    cboName.Text = "Smithicks";
                    cboDescription.Text = "Red";
                    cboType.Text = "Ale";
                    cboPrice.Text = "30.00";
                    cboQuantity.Text = "100";
                    cboReorderLVL.Text = "30";
                }

                if (cboStock_List.SelectedIndex == 2)
                {
                    Stock_ID = 3;
                    cboName.Text = "Smirnoff";
                    cboDescription.Text = "Fruity Passion";
                    cboType.Text = "Vodka";
                    cboPrice.Text = "40.00";
                    cboQuantity.Text = "50";
                    cboReorderLVL.Text = "10";
                }

            }

            if (cboSearch.Text.Contains("J") || cboSearch.Text.Contains("j"))
            {
                if (cboStock_List.SelectedIndex == 0)
                {
                    Stock_ID = 1;
                    cboName.Text = "Jameson";
                    cboDescription.Text = "Black Barrel";
                    cboType.Text = "Whiskey";
                    cboPrice.Text = "69.69";
                    cboQuantity.Text = "100";
                    cboReorderLVL.Text = "20";
                }

                if (cboStock_List.SelectedIndex == 1)
                {
                    Stock_ID = 2;
                    cboName.Text = "Jameson";
                    cboDescription.Text = "Original";
                    cboType.Text = "Whiskey";
                    cboPrice.Text = "30.00";
                    cboQuantity.Text = "100";
                    cboReorderLVL.Text = "30";
                }

                if (cboStock_List.SelectedIndex == 2)
                {
                    Stock_ID = 3;
                    cboName.Text = "Jameson";
                    cboDescription.Text = "Golden";
                    cboType.Text = "WHiskey";
                    cboPrice.Text = "40.00";
                    cboQuantity.Text = "50";
                    cboReorderLVL.Text = "10";
                }

            }

            lblName.Visible = true;
            cboName.Visible = true;

            lblDescription.Visible = true;
            cboDescription.Visible = true;

            lblType.Visible = true;
            cboType.Visible = true;

            lblPrice.Visible = true;
            cboPrice.Visible = true;

            lblQuantity.Visible = true;
            cboQuantity.Visible = true;

            lblReorderLevel.Visible = true;
            cboReorderLVL.Visible = true;

            btnUpdateStock.Visible = true; 
        }

        private void cboSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblStock_List_Click(object sender, EventArgs e)
        {

        }

        private void lblUpdateStock_Click(object sender, EventArgs e)
        {

        }
    }
}
