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
    public partial class frmAdminStock : Form
    {
        public frmAdminStock(frmAdminMenu frmAdminMenu)
        {
            InitializeComponent();
            Pbx2018.Visible = false;
            Pbx2019.Visible = false;
            Pbx2020.Visible = false;
            Pbx2021.Visible = false;
            Pbx2022.Visible = false;
            Pbx2023.Visible = false;
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

        private void mnuExxit_Click(object sender, EventArgs e)
        {
            DialogResult Result = (MessageBox.Show("Are you sure you want to exit?", "Exit Looney's Liquer", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (Result == DialogResult.Yes)
            {

                MessageBox.Show("Goodbye!", "Exit Looney's Liquer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void mnuAdminMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdminMenu frm = (frmAdminMenu)Application.OpenForms["frmAdminMenu"];
            if (frm != null)
            {
                // The form is already open, so just bring it to the front
                frm.BringToFront();
            }
            else
            {
                // The form is not open, create a new instance and show it
                frm = new frmAdminMenu(this);
                frm.Show();
            }
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboYear.SelectedIndex == 0)
            {
                Pbx2018.Visible = false;
                Pbx2019.Visible = false;
                Pbx2020.Visible = false;
                Pbx2021.Visible = false;
                Pbx2022.Visible = false;
                Pbx2023.Visible = true;
            }

            if (cboYear.SelectedIndex == 1)
            {
                Pbx2018.Visible = false;
                Pbx2019.Visible = false;
                Pbx2020.Visible = false;
                Pbx2021.Visible = false;
                Pbx2023.Visible = false;
                Pbx2022.Visible = true;
            }

            if (cboYear.SelectedIndex == 2)
            {
                Pbx2018.Visible = false;
                Pbx2019.Visible = false;
                Pbx2020.Visible = false;
                Pbx2022.Visible = false;
                Pbx2023.Visible = false;
                Pbx2021.Visible = true;
            }

            if (cboYear.SelectedIndex == 3)
            {
                Pbx2018.Visible = false;
                Pbx2019.Visible = false;
                Pbx2021.Visible = false;
                Pbx2022.Visible = false;
                Pbx2023.Visible = false;
                Pbx2020.Visible = true;
            }

            if (cboYear.SelectedIndex == 4)
            {
                Pbx2018.Visible = false;
                Pbx2020.Visible = false;
                Pbx2021.Visible = false;
                Pbx2022.Visible = false;
                Pbx2023.Visible = false;
                Pbx2019.Visible = true;
            }

            if (cboYear.SelectedIndex == 5)
            {
                Pbx2019.Visible = false;
                Pbx2020.Visible = false;
                Pbx2021.Visible = false;
                Pbx2022.Visible = false;
                Pbx2023.Visible = false;
                Pbx2018.Visible = true;
            }
        }
    }
}
