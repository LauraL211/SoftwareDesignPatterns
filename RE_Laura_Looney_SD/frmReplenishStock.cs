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
    public partial class frmReplenishStock : Form
    {
        public frmReplenishStock(frmStockMenu frmStockMenu)
        {
            InitializeComponent();

            if (cboLowStock.Checked == true && cboSearch.Text.Equals(""))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   1,     Jameson,      Black Barrell,  ");
                cboStock_List.Items.Add("   2,     Smirnoff,     Original,       ");
                cboStock_List.Items.Add("   3,     Cognak,       Original,       ");
                cboStock_List.Items.Add("   4,     Baileys,      Original,       ");
                cboStock_List.Items.Add("   5,     Apple Sourz,  Original,       ");
                cboStock_List.Items.Add("   6,     BushMills,    Original,       ");
                cboStock_List.Items.Add("   7,     Coors,        Original,       ");
                cboStock_List.Items.Add("   8,     Grey Goose,   Original,       ");
                cboStock_List.Items.Add("   9,     Smithick's,   Red,            ");
                cboStock_List.Items.Add("   10,    Smirnoff,     Fruity Passion, ");
                cboStock_List.Items.Add("   11,    Gordon's,     Original,       ");
                cboStock_List.Items.Add("   12,    Gordon's,     Pink,           ");
                cboStock_List.Items.Add("   13,    Cornona,      Original,       ");
                cboStock_List.Items.Add("   14,    Jameson,      Original,       ");
                cboStock_List.Items.Add("   15,    Jameson,      Golden,         ");
            }

            else if (cboLowStock.Checked == true && cboSearch.Text.Equals("A") || cboLowStock.Checked == true && cboSearch.Text.Equals("a"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   5,     Apple Sourz,  Original,       ");
            }

            else if (cboLowStock.Checked == true && cboSearch.Text.Equals("B") || cboLowStock.Checked == true && cboSearch.Text.Equals("b"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   4,     Baileys,      Original,       ");
                cboStock_List.Items.Add("   6,     BushMills,    Original,       ");
            }

            else if (cboLowStock.Checked == true && cboSearch.Text.Equals("C") || cboLowStock.Checked == true && cboSearch.Text.Equals("c"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   3,     Cognak,       Original,       ");
                cboStock_List.Items.Add("   7,     Coors,        Original,       ");
                cboStock_List.Items.Add("   13,    Cornona,      Original,       ");
            }

            else if (cboLowStock.Checked == true && cboSearch.Text.Equals("G") || cboLowStock.Checked == true && cboSearch.Text.Equals("g"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   8,     Grey Goose,   Original,       ");
                cboStock_List.Items.Add("   11,    Gordon's,     Original,       ");
                cboStock_List.Items.Add("   12,    Gordon's,     Pink,           ");
            }

            else if (cboLowStock.Checked == true && cboSearch.Text.Equals("S") || cboLowStock.Checked == true && cboSearch.Text.Equals("s"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   2,     Smirnoff,     Original,       ");
                cboStock_List.Items.Add("   9,     Smithick's,   Red,            ");
                cboStock_List.Items.Add("   10,    Smirnoff,     Fruity Passion, ");
            }

            else if (cboLowStock.Checked == true && cboSearch.Text.Equals("J") || cboLowStock.Checked == true && cboSearch.Text.Equals("j"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   1,     Jameson,      Black Barrell,  ");
                cboStock_List.Items.Add("   14,    Jameson,      Original,       ");
                cboStock_List.Items.Add("   15,    Jameson,      Golden,         ");
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals(""))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   1,     Jameson,      Black Barrell,  ");
                cboStock_List.Items.Add("   2,     Smirnoff,     Original,       ");
                cboStock_List.Items.Add("   3,     Cognak,       Original,       ");
                cboStock_List.Items.Add("   4,     Baileys,      Original,       ");
                cboStock_List.Items.Add("   5,     Apple Sourz,  Original,       ");
                cboStock_List.Items.Add("   6,     BushMills,    Original,       ");
                cboStock_List.Items.Add("   7,     Coors,        Original,       ");
                cboStock_List.Items.Add("   8,     Grey Goose,   Original,       ");
                cboStock_List.Items.Add("   9,     Smithick's,   Red,            ");
                cboStock_List.Items.Add("   10,    Smirnoff,     Fruity Passion, ");
                cboStock_List.Items.Add("   11,    Gordon's,     Original,       ");
                cboStock_List.Items.Add("   12,    Gordon's,     Pink,           ");
                cboStock_List.Items.Add("   13,    Cornona,      Original,       ");
                cboStock_List.Items.Add("   14,    Jameson,      Original,       ");
                cboStock_List.Items.Add("   15,    Jameson,      Golden,         ");
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals("A") || cboLowStock.Checked == true && cboSearch.Text.Equals("a"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   5,     Apple Sourz,  Original,       ");
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals("B") || cboLowStock.Checked == true && cboSearch.Text.Equals("b"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   4,     Baileys,      Original,       ");
                cboStock_List.Items.Add("   6,     BushMills,    Original,       ");
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals("C") || cboLowStock.Checked == true && cboSearch.Text.Equals("c"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   3,     Cognak,       Original,       ");
                cboStock_List.Items.Add("   7,     Coors,        Original,       ");
                cboStock_List.Items.Add("   13,    Cornona,      Original,       ");
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals("G") || cboLowStock.Checked == true && cboSearch.Text.Equals("g"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   8,     Grey Goose,   Original,       ");
                cboStock_List.Items.Add("   11,    Gordon's,     Original,       ");
                cboStock_List.Items.Add("   12,    Gordon's,     Pink,           ");
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals("S") || cboLowStock.Checked == true && cboSearch.Text.Equals("s"))
            {

                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   2,     Smirnoff,     Original,       ");
                cboStock_List.Items.Add("   9,     Smithick's,   Red,            ");
                cboStock_List.Items.Add("   10,    Smirnoff,     Fruity Passion, ");
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals("J") || cboLowStock.Checked == true && cboSearch.Text.Equals("j"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   1,     Jameson,      Black Barrell,  ");
                cboStock_List.Items.Add("   14,    Jameson,      Original,       ");
                cboStock_List.Items.Add("   15,    Jameson,      Golden,         ");
            }
            else if (cboSearch.Text.Equals("A") || cboSearch.Text.Equals("a"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   5,     Apple Sourz,  Original,       ");
            }

            else if (cboSearch.Text.Equals("B") || cboSearch.Text.Equals("b"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   4,     Baileys,      Original,       ");
                cboStock_List.Items.Add("   6,     BushMills,    Original,       ");
            }

            else if (cboSearch.Text.Equals("C") || cboSearch.Text.Equals("c"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   3,     Cognak,       Original,       ");
                cboStock_List.Items.Add("   7,     Coors,        Original,       ");
                cboStock_List.Items.Add("   13,    Cornona,      Original,       ");
            }

            else if (cboSearch.Text.Equals("G") || cboSearch.Text.Equals("g"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   8,     Grey Goose,   Original,       ");
                cboStock_List.Items.Add("   11,    Gordon's,     Original,       ");
                cboStock_List.Items.Add("   12,    Gordon's,     Pink,           ");
            }

            else if (cboSearch.Text.Equals("S") || cboSearch.Text.Equals("s"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   2,     Smirnoff,     Original,       ");
                cboStock_List.Items.Add("   9,     Smithick's,   Red,            ");
                cboStock_List.Items.Add("   10,    Smirnoff,     Fruity Passion, ");
            }

            else if (cboSearch.Text.Equals("J") || cboSearch.Text.Equals("j"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   1,     Jameson,      Black Barrell,  ");
                cboStock_List.Items.Add("   14,    Jameson,      Original,       ");
                cboStock_List.Items.Add("   15,    Jameson,      Golden,         ");
            }


            else
            {

                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   1,     Jameson,      Black Barrell,  ");
                cboStock_List.Items.Add("   2,     Smirnoff,     Original,       ");
                cboStock_List.Items.Add("   3,     Cognak,       Original,       ");
                cboStock_List.Items.Add("   4,     Baileys,      Original,       ");
                cboStock_List.Items.Add("   5,     Apple Sourz,  Original,       ");
                cboStock_List.Items.Add("   6,     BushMills,    Original,       ");
                cboStock_List.Items.Add("   7,     Coors,        Original,       ");
                cboStock_List.Items.Add("   8,     Grey Goose,   Original,       ");
                cboStock_List.Items.Add("   9,     Smithick's,   Red,            ");
                cboStock_List.Items.Add("   10,    Smirnoff,     Fruity Passion, ");
                cboStock_List.Items.Add("   11,    Gordon's,     Original,       ");
                cboStock_List.Items.Add("   12,    Gordon's,     Pink,           ");
                cboStock_List.Items.Add("   13,    Cornona,      Original,       ");
                cboStock_List.Items.Add("   14,    Jameson,      Original,       ");
                cboStock_List.Items.Add("   15,    Jameson,      Golden,         ");



            }
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

        private void cboSearch_TextChanged(object sender, EventArgs e)
        {
            if (cboLowStock.Checked == true && cboSearch.Text.Equals(""))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   1,     Jameson,      Black Barrell,  ");
                cboStock_List.Items.Add("   2,     Smirnoff,     Original,       ");
                cboStock_List.Items.Add("   3,     Cognak,       Original,       ");
                cboStock_List.Items.Add("   4,     Baileys,      Original,       ");
                cboStock_List.Items.Add("   5,     Apple Sourz,  Original,       ");
                cboStock_List.Items.Add("   6,     BushMills,    Original,       ");
                cboStock_List.Items.Add("   7,     Coors,        Original,       ");
                cboStock_List.Items.Add("   8,     Grey Goose,   Original,       ");
                cboStock_List.Items.Add("   9,     Smithick's,   Red,            ");
                cboStock_List.Items.Add("   10,    Smirnoff,     Fruity Passion, ");
                cboStock_List.Items.Add("   11,    Gordon's,     Original,       ");
                cboStock_List.Items.Add("   12,    Gordon's,     Pink,           ");
                cboStock_List.Items.Add("   13,    Cornona,      Original,       ");
                cboStock_List.Items.Add("   14,    Jameson,      Original,       ");
                cboStock_List.Items.Add("   15,    Jameson,      Golden,         ");
            }

            else if (cboLowStock.Checked == true && cboSearch.Text.Equals("A") || cboLowStock.Checked == true && cboSearch.Text.Equals("a"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   5,     Apple Sourz,  Original,       ");
            }

            else if (cboLowStock.Checked == true && cboSearch.Text.Equals("B") || cboLowStock.Checked == true && cboSearch.Text.Equals("b"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   4,     Baileys,      Original,       ");
                cboStock_List.Items.Add("   6,     BushMills,    Original,       ");
            }

            else if (cboLowStock.Checked == true && cboSearch.Text.Equals("C") || cboLowStock.Checked == true && cboSearch.Text.Equals("c"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   3,     Cognak,       Original,       ");
                cboStock_List.Items.Add("   7,     Coors,        Original,       ");
                cboStock_List.Items.Add("   13,    Cornona,      Original,       ");
            }

            else if (cboLowStock.Checked == true && cboSearch.Text.Equals("G") || cboLowStock.Checked == true && cboSearch.Text.Equals("g"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   8,     Grey Goose,   Original,       ");
                cboStock_List.Items.Add("   11,    Gordon's,     Original,       ");
                cboStock_List.Items.Add("   12,    Gordon's,     Pink,           ");
            }

            else if (cboLowStock.Checked == true && cboSearch.Text.Equals("S") || cboLowStock.Checked == true && cboSearch.Text.Equals("s"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   2,     Smirnoff,     Original,       ");
                cboStock_List.Items.Add("   9,     Smithick's,   Red,            ");
                cboStock_List.Items.Add("   10,    Smirnoff,     Fruity Passion, ");
            }

            else if (cboLowStock.Checked == true && cboSearch.Text.Equals("J") || cboLowStock.Checked == true && cboSearch.Text.Equals("j"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   1,     Jameson,      Black Barrell,  ");
                cboStock_List.Items.Add("   14,    Jameson,      Original,       ");
                cboStock_List.Items.Add("   15,    Jameson,      Golden,         ");
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals(""))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   1,     Jameson,      Black Barrell,  ");
                cboStock_List.Items.Add("   2,     Smirnoff,     Original,       ");
                cboStock_List.Items.Add("   3,     Cognak,       Original,       ");
                cboStock_List.Items.Add("   4,     Baileys,      Original,       ");
                cboStock_List.Items.Add("   5,     Apple Sourz,  Original,       ");
                cboStock_List.Items.Add("   6,     BushMills,    Original,       ");
                cboStock_List.Items.Add("   7,     Coors,        Original,       ");
                cboStock_List.Items.Add("   8,     Grey Goose,   Original,       ");
                cboStock_List.Items.Add("   9,     Smithick's,   Red,            ");
                cboStock_List.Items.Add("   10,    Smirnoff,     Fruity Passion, ");
                cboStock_List.Items.Add("   11,    Gordon's,     Original,       ");
                cboStock_List.Items.Add("   12,    Gordon's,     Pink,           ");
                cboStock_List.Items.Add("   13,    Cornona,      Original,       ");
                cboStock_List.Items.Add("   14,    Jameson,      Original,       ");
                cboStock_List.Items.Add("   15,    Jameson,      Golden,         ");
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals("A") || cboLowStock.Checked == true && cboSearch.Text.Equals("a"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   5,     Apple Sourz,  Original,       ");
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals("B") || cboLowStock.Checked == true && cboSearch.Text.Equals("b"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   4,     Baileys,      Original,       ");
                cboStock_List.Items.Add("   6,     BushMills,    Original,       ");
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals("C") || cboLowStock.Checked == true && cboSearch.Text.Equals("c"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   3,     Cognak,       Original,       ");
                cboStock_List.Items.Add("   7,     Coors,        Original,       ");
                cboStock_List.Items.Add("   13,    Cornona,      Original,       ");
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals("G") || cboLowStock.Checked == true && cboSearch.Text.Equals("g"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   8,     Grey Goose,   Original,       ");
                cboStock_List.Items.Add("   11,    Gordon's,     Original,       ");
                cboStock_List.Items.Add("   12,    Gordon's,     Pink,           ");
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals("S") || cboLowStock.Checked == true && cboSearch.Text.Equals("s"))
            {

                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   2,     Smirnoff,     Original,       ");
                cboStock_List.Items.Add("   9,     Smithick's,   Red,            ");
                cboStock_List.Items.Add("   10,    Smirnoff,     Fruity Passion, ");
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals("J") || cboLowStock.Checked == true && cboSearch.Text.Equals("j"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   1,     Jameson,      Black Barrell,  ");
                cboStock_List.Items.Add("   14,    Jameson,      Original,       ");
                cboStock_List.Items.Add("   15,    Jameson,      Golden,         ");
            }
            else if (cboSearch.Text.Equals("A") || cboSearch.Text.Equals("a"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   5,     Apple Sourz,  Original,       ");
            }

            else if (cboSearch.Text.Equals("B") || cboSearch.Text.Equals("b"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   4,     Baileys,      Original,       ");
                cboStock_List.Items.Add("   6,     BushMills,    Original,       ");
            }

            else if (cboSearch.Text.Equals("C") || cboSearch.Text.Equals("c"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   3,     Cognak,       Original,       ");
                cboStock_List.Items.Add("   7,     Coors,        Original,       ");
                cboStock_List.Items.Add("   13,    Cornona,      Original,       ");
            }

            else if (cboSearch.Text.Equals("G") || cboSearch.Text.Equals("g"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   8,     Grey Goose,   Original,       ");
                cboStock_List.Items.Add("   11,    Gordon's,     Original,       ");
                cboStock_List.Items.Add("   12,    Gordon's,     Pink,           ");
            }

            else if (cboSearch.Text.Equals("S") || cboSearch.Text.Equals("s"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   2,     Smirnoff,     Original,       ");
                cboStock_List.Items.Add("   9,     Smithick's,   Red,            ");
                cboStock_List.Items.Add("   10,    Smirnoff,     Fruity Passion, ");
            }

            else if (cboSearch.Text.Equals("J") || cboSearch.Text.Equals("j"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   1,     Jameson,      Black Barrell,  ");
                cboStock_List.Items.Add("   14,    Jameson,      Original,       ");
                cboStock_List.Items.Add("   15,    Jameson,      Golden,         ");
            }


            else
            {

                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   1,     Jameson,      Black Barrell,  ");
                cboStock_List.Items.Add("   2,     Smirnoff,     Original,       ");
                cboStock_List.Items.Add("   3,     Cognak,       Original,       ");
                cboStock_List.Items.Add("   4,     Baileys,      Original,       ");
                cboStock_List.Items.Add("   5,     Apple Sourz,  Original,       ");
                cboStock_List.Items.Add("   6,     BushMills,    Original,       ");
                cboStock_List.Items.Add("   7,     Coors,        Original,       ");
                cboStock_List.Items.Add("   8,     Grey Goose,   Original,       ");
                cboStock_List.Items.Add("   9,     Smithick's,   Red,            ");
                cboStock_List.Items.Add("   10,    Smirnoff,     Fruity Passion, ");
                cboStock_List.Items.Add("   11,    Gordon's,     Original,       ");
                cboStock_List.Items.Add("   12,    Gordon's,     Pink,           ");
                cboStock_List.Items.Add("   13,    Cornona,      Original,       ");
                cboStock_List.Items.Add("   14,    Jameson,      Original,       ");
                cboStock_List.Items.Add("   15,    Jameson,      Golden,         ");



            }
        }

        private void cboLowStock_CheckedChanged(object sender, EventArgs e)
        {
            if (cboLowStock.Checked == true && cboSearch.Text.Equals(""))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   1,     Jameson,      Black Barrell,  ");
                cboStock_List.Items.Add("   2,     Smirnoff,     Original,       ");
                cboStock_List.Items.Add("   3,     Cognak,       Original,       ");
                cboStock_List.Items.Add("   4,     Baileys,      Original,       ");
                cboStock_List.Items.Add("   5,     Apple Sourz,  Original,       ");
                cboStock_List.Items.Add("   6,     BushMills,    Original,       ");
                cboStock_List.Items.Add("   7,     Coors,        Original,       ");
                cboStock_List.Items.Add("   8,     Grey Goose,   Original,       ");
                cboStock_List.Items.Add("   9,     Smithick's,   Red,            ");
                cboStock_List.Items.Add("   10,    Smirnoff,     Fruity Passion, ");
                cboStock_List.Items.Add("   11,    Gordon's,     Original,       ");
                cboStock_List.Items.Add("   12,    Gordon's,     Pink,           ");
                cboStock_List.Items.Add("   13,    Cornona,      Original,       ");
                cboStock_List.Items.Add("   14,    Jameson,      Original,       ");
                cboStock_List.Items.Add("   15,    Jameson,      Golden,         ");
            }

            else if (cboLowStock.Checked == true && cboSearch.Text.Equals("A") || cboLowStock.Checked == true && cboSearch.Text.Equals("a"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   5,     Apple Sourz,  Original,       ");
            }

            else if (cboLowStock.Checked == true && cboSearch.Text.Equals("B") || cboLowStock.Checked == true && cboSearch.Text.Equals("b"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   4,     Baileys,      Original,       ");
                cboStock_List.Items.Add("   6,     BushMills,    Original,       ");
            }

            else if (cboLowStock.Checked == true && cboSearch.Text.Equals("C") || cboLowStock.Checked == true && cboSearch.Text.Equals("c"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   3,     Cognak,       Original,       ");
                cboStock_List.Items.Add("   7,     Coors,        Original,       ");
                cboStock_List.Items.Add("   13,    Cornona,      Original,       ");
            }

            else if (cboLowStock.Checked == true && cboSearch.Text.Equals("G") || cboLowStock.Checked == true && cboSearch.Text.Equals("g"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   8,     Grey Goose,   Original,       ");
                cboStock_List.Items.Add("   11,    Gordon's,     Original,       ");
                cboStock_List.Items.Add("   12,    Gordon's,     Pink,           ");
            }

            else if (cboLowStock.Checked == true && cboSearch.Text.Equals("S") || cboLowStock.Checked == true && cboSearch.Text.Equals("s"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   2,     Smirnoff,     Original,       ");
                cboStock_List.Items.Add("   9,     Smithick's,   Red,            ");
                cboStock_List.Items.Add("   10,    Smirnoff,     Fruity Passion, ");
            }

            else if (cboLowStock.Checked == true && cboSearch.Text.Equals("J") || cboLowStock.Checked == true && cboSearch.Text.Equals("j"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   1,     Jameson,      Black Barrell,  ");
                cboStock_List.Items.Add("   14,    Jameson,      Original,       ");
                cboStock_List.Items.Add("   15,    Jameson,      Golden,         ");
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals(""))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   1,     Jameson,      Black Barrell,  ");
                cboStock_List.Items.Add("   2,     Smirnoff,     Original,       ");
                cboStock_List.Items.Add("   3,     Cognak,       Original,       ");
                cboStock_List.Items.Add("   4,     Baileys,      Original,       ");
                cboStock_List.Items.Add("   5,     Apple Sourz,  Original,       ");
                cboStock_List.Items.Add("   6,     BushMills,    Original,       ");
                cboStock_List.Items.Add("   7,     Coors,        Original,       ");
                cboStock_List.Items.Add("   8,     Grey Goose,   Original,       ");
                cboStock_List.Items.Add("   9,     Smithick's,   Red,            ");
                cboStock_List.Items.Add("   10,    Smirnoff,     Fruity Passion, ");
                cboStock_List.Items.Add("   11,    Gordon's,     Original,       ");
                cboStock_List.Items.Add("   12,    Gordon's,     Pink,           ");
                cboStock_List.Items.Add("   13,    Cornona,      Original,       ");
                cboStock_List.Items.Add("   14,    Jameson,      Original,       ");
                cboStock_List.Items.Add("   15,    Jameson,      Golden,         ");
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals("A") || cboLowStock.Checked == true && cboSearch.Text.Equals("a"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   5,     Apple Sourz,  Original,       ");
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals("B") || cboLowStock.Checked == true && cboSearch.Text.Equals("b"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   4,     Baileys,      Original,       ");
                cboStock_List.Items.Add("   6,     BushMills,    Original,       ");
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals("C") || cboLowStock.Checked == true && cboSearch.Text.Equals("c"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   3,     Cognak,       Original,       ");
                cboStock_List.Items.Add("   7,     Coors,        Original,       ");
                cboStock_List.Items.Add("   13,    Cornona,      Original,       ");
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals("G") || cboLowStock.Checked == true && cboSearch.Text.Equals("g"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   8,     Grey Goose,   Original,       ");
                cboStock_List.Items.Add("   11,    Gordon's,     Original,       ");
                cboStock_List.Items.Add("   12,    Gordon's,     Pink,           ");
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals("S") || cboLowStock.Checked == true && cboSearch.Text.Equals("s"))
            {

                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   2,     Smirnoff,     Original,       ");
                cboStock_List.Items.Add("   9,     Smithick's,   Red,            ");
                cboStock_List.Items.Add("   10,    Smirnoff,     Fruity Passion, ");
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals("J") || cboLowStock.Checked == true && cboSearch.Text.Equals("j"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   1,     Jameson,      Black Barrell,  ");
                cboStock_List.Items.Add("   14,    Jameson,      Original,       ");
                cboStock_List.Items.Add("   15,    Jameson,      Golden,         ");
            }
            else if (cboSearch.Text.Equals("A") || cboSearch.Text.Equals("a"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   5,     Apple Sourz,  Original,       ");
            }

            else if (cboSearch.Text.Equals("B") || cboSearch.Text.Equals("b"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   4,     Baileys,      Original,       ");
                cboStock_List.Items.Add("   6,     BushMills,    Original,       ");
            }

            else if (cboSearch.Text.Equals("C") || cboSearch.Text.Equals("c"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   3,     Cognak,       Original,       ");
                cboStock_List.Items.Add("   7,     Coors,        Original,       ");
                cboStock_List.Items.Add("   13,    Cornona,      Original,       ");
            }

            else if (cboSearch.Text.Equals("G") || cboSearch.Text.Equals("g"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   8,     Grey Goose,   Original,       ");
                cboStock_List.Items.Add("   11,    Gordon's,     Original,       ");
                cboStock_List.Items.Add("   12,    Gordon's,     Pink,           ");
            }

            else if (cboSearch.Text.Equals("S") || cboSearch.Text.Equals("s"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   2,     Smirnoff,     Original,       ");
                cboStock_List.Items.Add("   9,     Smithick's,   Red,            ");
                cboStock_List.Items.Add("   10,    Smirnoff,     Fruity Passion, ");
            }

            else if (cboSearch.Text.Equals("J") || cboSearch.Text.Equals("j"))
            {
                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   1,     Jameson,      Black Barrell,  ");
                cboStock_List.Items.Add("   14,    Jameson,      Original,       ");
                cboStock_List.Items.Add("   15,    Jameson,      Golden,         ");
            }


            else
            {

                cboStock_List.Items.Clear();
                cboStock_List.Items.Add("   1,     Jameson,      Black Barrell,  ");
                cboStock_List.Items.Add("   2,     Smirnoff,     Original,       ");
                cboStock_List.Items.Add("   3,     Cognak,       Original,       ");
                cboStock_List.Items.Add("   4,     Baileys,      Original,       ");
                cboStock_List.Items.Add("   5,     Apple Sourz,  Original,       ");
                cboStock_List.Items.Add("   6,     BushMills,    Original,       ");
                cboStock_List.Items.Add("   7,     Coors,        Original,       ");
                cboStock_List.Items.Add("   8,     Grey Goose,   Original,       ");
                cboStock_List.Items.Add("   9,     Smithick's,   Red,            ");
                cboStock_List.Items.Add("   10,    Smirnoff,     Fruity Passion, ");
                cboStock_List.Items.Add("   11,    Gordon's,     Original,       ");
                cboStock_List.Items.Add("   12,    Gordon's,     Pink,           ");
                cboStock_List.Items.Add("   13,    Cornona,      Original,       ");
                cboStock_List.Items.Add("   14,    Jameson,      Original,       ");
                cboStock_List.Items.Add("   15,    Jameson,      Golden,         ");



            }
        }

        private void btnOrder_Items_Click(object sender, EventArgs e)
        {
            DialogResult Result = (MessageBox.Show("Are you sure you want to replenish these Stock Items?", "Replenish Stock Items", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (Result == DialogResult.Yes)
            {
                MessageBox.Show("The Stock Items have been Replenished "
                                , "Stock Items Replenished", MessageBoxButtons.OK, MessageBoxIcon.Information); ;


                //Refreshing the page
                cboItemList.Items.Clear();
                cboStock_List.Items.Clear();
                cboStock_List.SelectedIndex = -1;
                cboSearch.Clear();
                cboLowStock.Checked = false;
            }

            if (Result == DialogResult.No)
            {
                MessageBox.Show("The Stock Items have not been replenished", "Replenish Stock Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Refreshing the page
                cboItemList.Items.Clear();
                cboStock_List.Items.Clear();
                cboStock_List.SelectedIndex = -1;
                cboSearch.Clear();
                cboLowStock.Checked = false;
            }
        }

        private void cboStock_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = "";
            int valueAsInt;
            if (cboLowStock.Checked == true && cboSearch.Text.Equals(""))
            {
                if (cboStock_List.SelectedIndex == 0)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   1,     Jameson,      Black Barrell,  " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 1)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   2,     Smirnoff,     Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 2)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   3,     Cognak,       Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 3)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   4,     Baileys,      Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 4)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   5,     Apple Sourz,  Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 5)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   6,     BushMills,    Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 6)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   7,     Coors,        Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 7)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   8,     Grey Goose,   Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 8)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   9,     Smithick's,   Red,            " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 9)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   10,    Smirnoff,     Fruity Passion, " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 10)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   11,    Gordon's,     Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 11)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);
                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   12,    Gordon's,     Pink,           " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 12)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);
                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   13,    Cornona,      Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 13)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   14,    Jameson,      Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 14)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   15,    Jameson,      Golden,         " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            else if (cboLowStock.Checked == true && cboSearch.Text.Equals("A") || cboLowStock.Checked == true && cboSearch.Text.Equals("a"))
            {
                if (cboStock_List.SelectedIndex == 0)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   5,     Apple Sourz,  Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            else if (cboLowStock.Checked == true && cboSearch.Text.Equals("B") || cboLowStock.Checked == true && cboSearch.Text.Equals("b"))
            {

                if (cboStock_List.SelectedIndex == 0)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   4,     Baileys,      Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 1)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   6,     BushMills,    Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            else if (cboLowStock.Checked == true && cboSearch.Text.Equals("C") || cboLowStock.Checked == true && cboSearch.Text.Equals("c"))
            {
                if (cboStock_List.SelectedIndex == 0)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   3,     Cognak,       Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 1)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   7,     Coors,        Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 2)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   13,    Cornona,      Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            else if (cboLowStock.Checked == true && cboSearch.Text.Equals("G") || cboLowStock.Checked == true && cboSearch.Text.Equals("g"))
            {
                if (cboStock_List.SelectedIndex == 0)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   8,     Grey Goose,   Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 1)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   11,    Gordon's,     Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (cboStock_List.SelectedIndex == 2)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   12,    Gordon's,     Pink,           " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            else if (cboLowStock.Checked == true && cboSearch.Text.Equals("S") || cboLowStock.Checked == true && cboSearch.Text.Equals("s"))
            {
                if (cboStock_List.SelectedIndex == 0)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   2,     Smirnoff,     Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (cboStock_List.SelectedIndex == 1)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   9,     Smithick's,   Red,            " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 2)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   10,    Smirnoff,     Fruity Passion, " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            else if (cboLowStock.Checked == true && cboSearch.Text.Equals("J") || cboLowStock.Checked == true && cboSearch.Text.Equals("j"))
            {
                if (cboStock_List.SelectedIndex == 0)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   1,     Jameson,      Black Barrell,  " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 1)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   14,    Jameson,      Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 2)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   15,    Jameson,      Golden,         " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals(""))
            {
                if (cboStock_List.SelectedIndex == 0)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   1,     Jameson,      Black Barrell,  " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 1)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   2,     Smirnoff,     Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (cboStock_List.SelectedIndex == 2)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   3,     Cognak,       Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 3)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   4,     Baileys,      Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 4)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   5,     Apple Sourz,  Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 5)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   6,     BushMills,    Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 6)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   7,     Coors,        Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 7)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   8,     Grey Goose,   Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 8)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   9,     Smithick's,   Red,            " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 9)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   10,    Smirnoff,     Fruity Passion, " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 10)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   11,    Gordon's,     Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 11)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   12,    Gordon's,     Pink,           " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 12)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   13,    Cornona,      Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 13)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   14,    Jameson,      Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 14)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   15,    Jameson,      Golden,         " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals("A") || cboLowStock.Checked == false && cboSearch.Text.Equals("a"))
            {

                if (cboStock_List.SelectedIndex == 0)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   5,     Apple Sourz,  Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
            }
            else if (cboLowStock.Checked == false && cboSearch.Text.Equals("B") || cboLowStock.Checked == false && cboSearch.Text.Equals("b"))
            {

                if (cboStock_List.SelectedIndex == 0)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   4,     Baileys,      Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (cboStock_List.SelectedIndex == 1)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   6,     BushMills,    Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals("C") || cboLowStock.Checked == false && cboSearch.Text.Equals("c"))
            {

                if (cboStock_List.SelectedIndex == 0)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   3,     Cognak,       Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (cboStock_List.SelectedIndex == 1)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   7,     Coors,        Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (cboStock_List.SelectedIndex == 2)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   13,    Cornona,      Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals("G") || cboLowStock.Checked == false && cboSearch.Text.Equals("g"))
            {

                if (cboStock_List.SelectedIndex == 0)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   8,     Grey Goose,   Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (cboStock_List.SelectedIndex == 1)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   11,    Gordon's,     Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (cboStock_List.SelectedIndex == 2)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   12,    Gordon's,     Pink,           " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals("S") || cboLowStock.Checked == false && cboSearch.Text.Equals("s"))
            {

                if (cboStock_List.SelectedIndex == 0)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   2,     Smirnoff,     Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (cboStock_List.SelectedIndex == 1)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   9,     Smithick's,   Red,            " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (cboStock_List.SelectedIndex == 2)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   10,    Smirnoff,     Fruity Passion, " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            else if (cboLowStock.Checked == false && cboSearch.Text.Equals("J") || cboLowStock.Checked == false && cboSearch.Text.Equals("j"))
            {

                if (cboStock_List.SelectedIndex == 0)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   1,     Jameson,      Black Barrell,  " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (cboStock_List.SelectedIndex == 1)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   14,    Jameson,      Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (cboStock_List.SelectedIndex == 2)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   15,    Jameson,      Golden,         " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else if (cboSearch.Text.Equals("A") || cboSearch.Text.Equals("a"))
            {
                if (cboStock_List.SelectedIndex == 0)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   5,     Apple Sourz,  Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            else if (cboSearch.Text.Equals("B") || cboSearch.Text.Equals("b"))
            {
                if (cboStock_List.SelectedIndex == 0)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   4,     Baileys,      Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (cboStock_List.SelectedIndex == 1)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   6,     BushMills,    Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            else if (cboSearch.Text.Equals("C") || cboSearch.Text.Equals("c"))
            {
                if (cboStock_List.SelectedIndex == 0)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   3,     Cognak,       Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (cboStock_List.SelectedIndex == 1)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   7,     Coors,        Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (cboStock_List.SelectedIndex == 2)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   13,    Cornona,      Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            else if (cboSearch.Text.Equals("G") || cboSearch.Text.Equals("g"))
            {
                if (cboStock_List.SelectedIndex == 0)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   8,     Grey Goose,   Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 1)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   11,    Gordon's,     Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (cboStock_List.SelectedIndex == 2)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   12,    Gordon's,     Pink,           " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            else if (cboSearch.Text.Equals("S") || cboSearch.Text.Equals("s"))
            {
                if (cboStock_List.SelectedIndex == 0)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   2,     Smirnoff,     Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (cboStock_List.SelectedIndex == 1)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   9,     Smithick's,   Red,            " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (cboStock_List.SelectedIndex == 2)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   10,    Smirnoff,     Fruity Passion, " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            else if (cboSearch.Text.Equals("J") || cboSearch.Text.Equals("j"))
            {
                if (cboStock_List.SelectedIndex == 0)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   1,     Jameson,      Black Barrell,  " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (cboStock_List.SelectedIndex == 1)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   14,    Jameson,      Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (cboStock_List.SelectedIndex == 2)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   15,    Jameson,      Golden,         " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            else if (cboSearch.Text.Equals("A") || cboSearch.Text.Equals("a"))
            {

                if (cboStock_List.SelectedIndex == 0)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   5,     Apple Sourz,  Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }

            else if (cboSearch.Text.Equals("B") || cboSearch.Text.Equals("b"))
            {
                if (cboStock_List.SelectedIndex == 0)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   4,     Baileys,      Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }

                if (cboStock_List.SelectedIndex == 1)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   6,     BushMills,    Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }

            else if (cboSearch.Text.Equals("C") || cboSearch.Text.Equals("c"))
            {
                if (cboStock_List.SelectedIndex == 0)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   3,     Cognak,       Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }

                if (cboStock_List.SelectedIndex == 1)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   7,     Coors,        Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }

                if (cboStock_List.SelectedIndex == 2)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   13,    Cornona,      Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }

            else if (cboSearch.Text.Equals("G") || cboSearch.Text.Equals("g"))
            {
                if (cboStock_List.SelectedIndex == 0)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   8,     Grey Goose,   Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }

                if (cboStock_List.SelectedIndex == 1)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   11,    Gordon's,     Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }

                if (cboStock_List.SelectedIndex == 2)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   12,    Gordon's,     Pink,           " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }

            else if (cboSearch.Text.Equals("S") || cboSearch.Text.Equals("s"))
            {
                if (cboStock_List.SelectedIndex == 0)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   2,     Smirnoff,     Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 1)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   9,     Smithick's,   Red,            " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }

                if (cboStock_List.SelectedIndex == 2)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   10,    Smirnoff,     Fruity Passion, " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }

            else if (cboSearch.Text.Equals("J") || cboSearch.Text.Equals("j"))
            {
                if (cboStock_List.SelectedIndex == 0)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   1,     Jameson,      Black Barrell,  " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }

                if (cboStock_List.SelectedIndex == 1)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   14,    Jameson,      Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }

                if (cboStock_List.SelectedIndex == 2)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   15,    Jameson,      Golden,         " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }


            else
            {
                if (cboStock_List.SelectedIndex == 0)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   1,     Jameson,      Black Barrell,  " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }

                if (cboStock_List.SelectedIndex == 1)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   2,     Smirnoff,     Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 2)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   3,     Cognak,       Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 3)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   4,     Baileys,      Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 4)
                {
                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   5,     Apple Sourz,  Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 5)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   6,     BushMills,    Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }

                if (cboStock_List.SelectedIndex == 6)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   7,     Coors,        Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }

                if (cboStock_List.SelectedIndex == 7)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   8,     Grey Goose,   Original,      " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }

                if (cboStock_List.SelectedIndex == 8)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   9,     Smithick's,   Red,            " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }

                if (cboStock_List.SelectedIndex == 9)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   10,    Smirnoff,     Fruity Passion, " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 10)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   11,    Gordon's,     Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }

                if (cboStock_List.SelectedIndex == 11)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   12,    Gordon's,     Pink,           " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (cboStock_List.SelectedIndex == 12)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   13,    Cornona,      Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }

                if (cboStock_List.SelectedIndex == 13)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   14,    Jameson,      Original,       " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }

                if (cboStock_List.SelectedIndex == 14)
                {

                    if (InputBox("Order Quantity", "Please enter your order quantity: ", ref value) == DialogResult.OK)
                    {
                        bool Canconvert = int.TryParse(value, out _);
                        if (Canconvert)
                        {
                            valueAsInt = Convert.ToInt32(value);

                            if (valueAsInt > 0)
                            {
                                cboItemList.Items.Add("   15,    Jameson,      Golden,         " + valueAsInt);
                            }

                            else
                            {
                                MessageBox.Show("Value Muste Be  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (!Canconvert)
                        {
                            MessageBox.Show("Value Muste Be Numeric", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }
        }
    }
}

