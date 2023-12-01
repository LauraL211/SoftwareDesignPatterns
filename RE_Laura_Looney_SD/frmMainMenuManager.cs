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
    public partial class frmMainMenuManager : Form
    {
        public frmMainMenuManager(frmLoginPage frmLoginPage)
        {
            InitializeComponent();
        }

        private void mnuHomePage_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHomePage frm = (frmHomePage)Application.OpenForms["frmHomePage"];
            frm.Show();
        }
    }
}
