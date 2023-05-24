using ClassLibrary4Verification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppListBox
{
    public partial class FormListBox : Form
    {
		public string Titre { set => this.Text = value; }
		public FormListBox()
        {
            InitializeComponent(); 
        }

        private void buttonViderListe_Click(object sender, EventArgs e)
        {
            listBoxListe.Items.Clear();
            textBoxSelectedIndex.Clear();
            textBoxText.Clear();
            textBoxItemsCount.Text = listBoxListe.Items.Count.ToString();
        }

        private void buttonSelectionner_Click(object sender, EventArgs e)
        {
            int index = 0;
            if (listBoxListe.Items.Count != 0 && int.TryParse(textBoxIndexElement.Text, out index) && index >= 0 && index < listBoxListe.Items.Count)
            {
                listBoxListe.SelectedIndex = index;
            }
            else
                textBoxIndexElement.Clear();
            
        }

        private void buttonAjoutListe_Click(object sender, EventArgs e)
        {
            if (Verification.ElementValide(textBoxNvlElement.Text))
            {
                if (listBoxListe.FindStringExact(textBoxNvlElement.Text) == -1)
                {
                    listBoxListe.Items.Add(textBoxNvlElement.Text);
                    textBoxItemsCount.Text = listBoxListe.Items.Count.ToString();
                    textBoxNvlElement.Focus();
                }
                else
                {
                    textBoxNvlElement.Focus();
                    errorProviderElmIncorrect.SetError(textBoxNvlElement, "Elément existant déjà");
                }
            }
            else
            {
                textBoxNvlElement.Clear();
                textBoxNvlElement.Focus();
                errorProviderElmIncorrect.SetError(textBoxNvlElement, "Elément incorrect");
            } 
        }

        private void textBoxNvlElement_TextChanged(object sender, EventArgs e)
        {
            if (Verification.ElementValide(textBoxNvlElement.Text))
            {
                if (listBoxListe.FindStringExact(textBoxNvlElement.Text) == -1)
                {
                    errorProviderElmIncorrect.SetError(textBoxNvlElement, "");
                }
                else
                {
                    errorProviderElmIncorrect.SetError(textBoxNvlElement, "Elément existant déjà");
                }
            }
            else
            {
                errorProviderElmIncorrect.SetError(textBoxNvlElement, "Elément incorrect");
            }
        }

        private void textBoxIndexElement_TextChanged(object sender, EventArgs e)
        {
            int index = 0;
            if (listBoxListe.Items.Count != 0 && int.TryParse(textBoxIndexElement.Text, out index) && index >= 0 && index < listBoxListe.Items.Count)
            {
                errorProviderIndexIncorrect.SetError(textBoxIndexElement, "");
            }
            else if (listBoxListe.Items.Count == 0)
            {
                errorProviderIndexIncorrect.SetError(textBoxIndexElement, "Veuillez ajouter au moins un élément.");
            }
            else if (listBoxListe.Items.Count == 1)
            {
                errorProviderIndexIncorrect.SetError(textBoxIndexElement, "Veuillez entrer la valeur 0.");
            }
            else
                errorProviderIndexIncorrect.SetError(textBoxIndexElement, "Veuillez entrer une valeur entre 0 et " + (listBoxListe.Items.Count - 1).ToString() + ".");
        }

        private void listBoxListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSelectedIndex.Text=listBoxListe.SelectedIndex.ToString();
            textBoxText.Text = listBoxListe.Items[listBoxListe.SelectedIndex].ToString();
        }
    }
}
