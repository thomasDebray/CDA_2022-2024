using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppCheckBoxEtRadioButton
{
    public partial class WindowApp : Form
    {
		public string Titre { set => this.Text = value; }
		public string Textbox { set => textBoxTexteOriginal.Text = value; }
        public WindowApp()
        {
            InitializeComponent();

        }

        private void checkBoxCouleurFond_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCouleurFond.Checked)
            {
                groupBoxFond.Visible = true;
            }
            else
            {
                groupBoxFond.Visible = false;
                radioButtonFondRouge.Checked = false;
                radioButtonFondVert.Checked = false;
                radioButtonFondBleu.Checked = false;
            }
                
        }

        private void checkBoxCouleurCaracteres_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCouleurCaracteres.Checked)
            {
                groupBoxCaracteres.Visible = true;
            }
            else
            {
                groupBoxCaracteres.Visible = false;
                radioButtonCaractereRouge.Checked = false;
                radioButtonCaractereBlanc.Checked = false;
                radioButtonCaractereNoir.Checked = false;
            }
                
        }

        private void checkBoxCasse_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCasse.Checked)
            {
                groupBoxCasse.Visible = true;
            }
            else
            {
                groupBoxCasse.Visible = false;
                radioButtonCasseMin.Checked = false;
                radioButtonCasseMaj.Checked = false;
            }
                
        }

        private void textBoxTexteOriginal_TextChanged(object sender, EventArgs e)
        {
            if (!radioButtonCasseMaj.Checked&&!radioButtonCasseMin.Checked)
            {
                textBoxTexteModif.Text = textBoxTexteOriginal.Text;
            }
            if (radioButtonCasseMaj.Checked)
            {
                radioButtonCasseMaj_CheckedChanged(sender,e);
            }
            if (radioButtonCasseMin.Checked)
            {
                radioButtonCasseMin_CheckedChanged(sender,e);
            }
            if (textBoxTexteOriginal.TextLength>0)
            {
                groupBoxChoix.Enabled = true;
            }
            else
            {
                groupBoxChoix.Enabled = false;
                checkBoxCouleurFond.Checked = false;
                checkBoxCouleurCaracteres.Checked = false;
                checkBoxCasse.Checked = false;
            }
                
        }

        private void radioButtonFondRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFondRouge.Checked)
            {
                textBoxTexteModif.BackColor = Color.Red;
            }
            else
                textBoxTexteModif.BackColor = Color.White;
        }

        private void radioButtonFondVert_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFondVert.Checked)
            {
                textBoxTexteModif.BackColor = Color.Green;
            }
            else
                textBoxTexteModif.BackColor = Color.White;
        }

        private void radioButtonFondBleu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFondBleu.Checked)
            {
                textBoxTexteModif.BackColor = Color.Blue;
            }
            else
                textBoxTexteModif.BackColor = Color.White;
        }

        private void radioButtonCaractereRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCaractereRouge.Checked)
            {
                textBoxTexteModif.ForeColor = Color.Red;
            }
            else
                textBoxTexteModif.ForeColor = Color.Black;
        }

        private void radioButtonCaractereBlanc_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCaractereBlanc.Checked)
            {
                textBoxTexteModif.ForeColor = Color.White;
            }
            else
                textBoxTexteModif.ForeColor= Color.Black;
        }

        private void radioButtonCaractereNoir_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCaractereNoir.Checked)
            {
                textBoxTexteModif.ForeColor = Color.Black;
            }
            else
                textBoxTexteModif.ForeColor = Color.Black;
        }

        private void radioButtonCasseMin_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCasseMin.Checked)
            {
                textBoxTexteModif.Text = textBoxTexteOriginal.Text.ToLower();
            }
            else
                textBoxTexteModif.Text = textBoxTexteOriginal.Text;
        }

        private void radioButtonCasseMaj_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCasseMaj.Checked)
            {
                textBoxTexteModif.Text= textBoxTexteOriginal.Text.ToUpper();
            }
            else
                textBoxTexteModif.Text = textBoxTexteOriginal.Text;
        }
    }
}
