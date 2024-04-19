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
    public partial class frmAddType : Form
    {
        public frmAddType(frmTypeMenu frmTypeMenu)
        {
            InitializeComponent();
        }

        private void mnubtnExit_Click(object sender, EventArgs e)
        {
            DialogResult Result = (MessageBox.Show("Are you sure you want to exit?", "Exit Looney's Liquer", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (Result == DialogResult.Yes)
            {

                MessageBox.Show("Goodbye!", "Exit Looney's Liquer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void mnuStockmnu_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void btnAddStockType_Click(object sender, EventArgs e)
        {
            bool TypeCode = false;
            bool Desc = false;

            if (!(cboTypeCode.Text.Equals("")))
            {
                TypeCode = true;
            }

            if (!(cboDescription.Text.Equals("")))
            {
                Desc = true;
            }

            if (TypeCode && Desc)
            {
                DialogResult Result = (MessageBox.Show("Are you sure you want to add this Stock Type?", "Add Stock Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

                if (Result == DialogResult.Yes)
                {
                    Type aType = new Type(cboTypeCode.Text, cboDescription.Text, cboStatus.Text);

                    aType.addType();

                    MessageBox.Show("Stock Type added successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cboTypeCode.Clear();
                    cboDescription.Clear();
                    cboTypeCode.Focus();
                }

                if (Result == DialogResult.No)
                {
                    MessageBox.Show("The Stock Type has not been added to the system", "Stock Type Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cboTypeCode.Clear();
                    cboDescription.Clear();
                    cboTypeCode.Focus();
                }
            }

            else if (!TypeCode)
            {
                MessageBox.Show("The Stock TypeCode entered cannot be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTypeCode.Focus();
                cboTypeCode.Clear();
            }

            else if (!Desc)
            {
                MessageBox.Show("The Stock Type Description entered cannot be Null. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDescription.Focus();
                cboDescription.Clear();
            }
        }

        private void frmAddType_Load(object sender, EventArgs e)
        {

        }
    }
}
