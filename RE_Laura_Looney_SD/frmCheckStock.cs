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

            cboItemList.Items.Add("StockID:  Name:         Description:     Type:      Price:    Quantity: ReorderLVL:");
            cboItemList.Items.Add("   1,     Jameson,      Black Barrell,   Whiskey,   $33.33,    2,       10");
            cboItemList.Items.Add("   2,     Smirnoff,     Original,        Vodka,     $33.33,    4,       10");
            cboItemList.Items.Add("   3,     Cognak,       Original,        Brandy,    $33.33,    7,       10");
            cboItemList.Items.Add("   4,     Baileys,      Original,        Liquer,    $33.33,    3,       10");
            cboItemList.Items.Add("   5,     Apple Sourz,  Original,        IDK,       $33.33,    1,       10");
            cboItemList.Items.Add("   6,     BushMills,    Original,        Whiskey,   $33.33,    0,       10");
            cboItemList.Items.Add("   7,     Coors,        Original,        Beer,      $33.33,    9,       10");
            cboItemList.Items.Add("   8,     Grey Goose,   Original,        Vodka,     $33.33,    9,       10");
            cboItemList.Items.Add("   9,     Smithick's,   Red,             Ale,       $33.33,    6,       10");
            cboItemList.Items.Add("   10,    Smirnoff,     Fruity Passion,  Vodka,     $33.33,    2,       10");
            cboItemList.Items.Add("   11,    Gordon's,     Original,        Gin,       $33.33,    2,       10");
            cboItemList.Items.Add("   12,    Gordon's,     Pink,            Gin,       $33.33,    8,       10");
            cboItemList.Items.Add("   13,    Cornona,      Original,        Beer,      $33.33,    5,       10");
            cboItemList.Items.Add("   14,    Jameson,      Original,        Whiskey,   $33.33,    3,       10");
            cboItemList.Items.Add("   15,    Jameson,      Golden,          Whiskey,   $33.33,    4,       10");

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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The following stock list is being printed ", "Low Stock List", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
