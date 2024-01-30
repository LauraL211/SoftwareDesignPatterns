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
    public partial class frmAddStockTrial : Form
    {
        public frmAddStockTrial()
        {
            InitializeComponent();
        }

        private void frmAddStockTrial_Load(object sender, EventArgs e)
        {
            //get next Stock ID
            cboStockID.Text = Stock.getNextStockID().ToString("0000");

            //Load Type into ComboBox
            DataSet ds = Type.getType();
            cboType.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboType.Items.Add(ds.Tables[0].Rows[i][0] + " - " + ds.Tables[0].Rows[i][1]);
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            // Validate ALL the input data

            //Create an instance of Stock and instantiate with values from form controls
            Stock aStock = new Stock(Convert.ToInt32(cboStockID.Text), cboName.Text, cboDescription.Text,
                cboType.Text,Convert.ToDecimal(cboPrice.Text), Convert.ToInt32(cboQuantity.Text), Convert.ToInt32(cboReorderLVL.Text)
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
            cboPrice.Text = "0.00";
            cboQuantity.Text = "000";
            cboReorderLVL.Text = "000";
            cboName.Focus();
        }
    }
}
