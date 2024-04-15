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
    public partial class frmUpdateType : Form
    {
        public frmUpdateType(frmTypeMenu frmTypeMenu)
        {
            InitializeComponent();
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

        private void btnUpdateStockType_Click(object sender, EventArgs e)
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
                DialogResult Result = (MessageBox.Show("Are you sure you want to update this Stock Type?", "Update Stock Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

                if (Result == DialogResult.Yes)
                {
                    Type type = new Type();
                    type.setTypecode(cboTypeCode.Text);
                    type.setDescription(cboDescription.Text);
                    type.setStatus(cboStatus.Text);
                    type.updateType();

                    //display confirmation message
                    MessageBox.Show("Stock Type updated successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //reset UI
                    cboTypeCode.Clear();
                    cboDescription.Clear();
                    cboTypeCode.Focus();
                }

                if (Result == DialogResult.No)
                {
                    MessageBox.Show("The Stock Type has not been updated in the system", "Stock Type Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Refreshing the page
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
                DGVStockType.Rows.Clear();
                {

                    DataSet ItemType = Type.GetStockType(cboSearch.Text.ToUpper());

                    for (int i = 0; i < ItemType.Tables[0].Rows.Count; i++)
                    {
                        DGVStockType.Rows.Add(
                            ItemType.Tables[0].Rows[i][0],
                            ItemType.Tables[0].Rows[i][1],
                            ItemType.Tables[0].Rows[i][2]
                            );
                    }
                }
            
        }

        private void DGVStockType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String TypeCode = Convert.ToString(DGVStockType.Rows[e.RowIndex].Cells["TypeCode"].Value);

            Type type = new Type();
            type.GetType(TypeCode);

            cboTypeCode.Text = type.getTypecode();
            cboDescription.Text = type.getDescription();
            cboStatus.Text = type.getStatus();
        }

        private void cboTypeCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
