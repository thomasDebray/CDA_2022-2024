using ClassLibrary5Verification;
using ClassLibraryListeDeStringSelectionne;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppListBoxEtComboBox
{
    public partial class FormListBoxEtComboBox : Form
    {
		public string Titre { set => this.Text = value; }

		int indexSource = -1;
        int indexCible = -1;
        int indexSelection = 0;

        ClassLibraryListeDeStringSelectionne.ClassListeDeStringSelectionne listeDePays;
        public FormListBoxEtComboBox()
        {
            InitializeComponent();

            listeDePays = new ClassLibraryListeDeStringSelectionne.ClassListeDeStringSelectionne();

            listeDePays.AjouterElement("France");
            listeDePays.AjouterElement("Belgique");
            listeDePays.AjouterElement("Allemagne");
            listeDePays.AjouterElement("Japon");
            listeDePays.AjouterElement("Portugal");
            listeDePays.AjouterElement("Grece");
            listeDePays.AjouterElement("Bulgarie");
            listeDePays.AjouterElement("Espagne");

            //listeDePays.ListDeStringSelectionne.Add("France");
            //listeDePays.ListDeStringSelectionne.Add("Belgique");
            //listeDePays.ListDeStringSelectionne.Add("Allemagne");
            //listeDePays.ListDeStringSelectionne.Add("Japon");
            //listeDePays.ListDeStringSelectionne.Add("Portugal");
            //listeDePays.ListDeStringSelectionne.Add("Grece");
            //listeDePays.ListDeStringSelectionne.Add("Bulgarie");
            //listeDePays.ListDeStringSelectionne.Add("Espagne");

            //comboBoxSource.Items.Add("France");
            //comboBoxSource.Items.Add("Belgique");
            //comboBoxSource.Items.Add("Allemagne");
            //comboBoxSource.Items.Add("Japon");
            //comboBoxSource.Items.Add("Portugal");
            //comboBoxSource.Items.Add("Grece");
            //comboBoxSource.Items.Add("Bulgarie");
            //comboBoxSource.Items.Add("Espagne");

            for (int i = 0; i < listeDePays.MesElements.Count; i++)
            {
                comboBoxSource.Items.Add(listeDePays.MesElements.ElementAt(i).Key);
            }
        }

        private void buttonAjouterTout_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < comboBoxSource.Items.Count; i++)
            {
                listBoxCible.Items.Add(comboBoxSource.Items[i]);
                listeDePays.SelectionnerElement(comboBoxSource.Items[i].ToString());
            }
            comboBoxSource.Items.Clear();
            SelectedIndexChangedDeLAliste();
            SelectedIndexChangedDeLaComboBox();
            comboBoxSource.ResetText();

        }

        private void buttonEnleverTout_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxCible.Items.Count; i++)
            {
                comboBoxSource.Items.Add(listBoxCible.Items[i]);
                listeDePays.DeselectionnerElement(listBoxCible.Items[i].ToString());
            }
            listBoxCible.Items.Clear();
            SelectedIndexChangedDeLaComboBox();
            SelectedIndexChangedDeLAliste();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (indexSource!=-1)
            {
                listBoxCible.Items.Add(comboBoxSource.Items[indexSource]);
                listeDePays.SelectionnerElement(comboBoxSource.Items[indexSource].ToString());
                comboBoxSource.Items.Remove(comboBoxSource.Items[indexSource]);
            }
            SelectedIndexChangedDeLaComboBox();
            SelectedIndexChangedDeLAliste();
            comboBoxSource.ResetText();
        }

        private void comboBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndexChangedDeLaComboBox();
        }

        private void SelectedIndexChangedDeLaComboBox()
        {
            indexSource = comboBoxSource.SelectedIndex;

            //if (indexSource != -1)
            //{
            //    buttonAjouter.Enabled = true;
            //}
            //else
            //    buttonAjouter.Enabled = false;

            buttonAjouter.Enabled = (indexSource != -1);

            //if (comboBoxSource.Items.Count == 0)
            //{
            //    buttonAjouterTout.Enabled = false;
            //}
            //else
            //    buttonAjouterTout.Enabled = true;

            buttonAjouterTout.Enabled = !(comboBoxSource.Items.Count == 0);
        }

        private void listBoxCible_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndexChangedDeLAliste();
        }

        private void SelectedIndexChangedDeLAliste()
        {
            indexCible = listBoxCible.SelectedIndex;

            //if (indexCible != -1)
            //{
            //    buttonEnlever.Enabled = true;
            //}
            //else
            //    buttonEnlever.Enabled = false;

            buttonEnlever.Enabled = (indexCible != -1);

            //if (listBoxCible.Items.Count == 0)
            //{
            //    buttonEnleverTout.Enabled = false;
            //}
            //else
            //    buttonEnleverTout.Enabled = true;


            buttonEnleverTout.Enabled = (listBoxCible.Items.Count != 0);


            //if (listBoxCible.SelectedIndex <= 0)
            //{
            //    buttonHaut.Enabled = false;
            //}
            //else
            //    buttonHaut.Enabled = true;

            buttonHaut.Enabled = (listBoxCible.SelectedIndex > 0);

            //if (listBoxCible.SelectedIndex == listBoxCible.Items.Count - 1 || listBoxCible.SelectedIndex == -1)
            //{
            //    buttonBas.Enabled = false;
            //}
            //else
            //    buttonBas.Enabled = true;

            buttonBas.Enabled = !(listBoxCible.SelectedIndex == listBoxCible.Items.Count - 1 || listBoxCible.SelectedIndex == -1);
        }

        private void buttonEnlever_Click(object sender, EventArgs e)
        {
            indexSelection = listBoxCible.SelectedIndex;

            if (indexCible!=-1)
            {
                comboBoxSource.Items.Add(listBoxCible.Items[indexCible]);
                listeDePays.DeselectionnerElement(listBoxCible.Items[indexCible].ToString());
                listBoxCible.Items.Remove(listBoxCible.Items[indexCible]);
            }

            SelectedIndexChangedDeLaComboBox();
            SelectedIndexChangedDeLAliste();

            if (indexSelection>=0&&indexSelection<=listBoxCible.Items.Count-1)
            {
                listBoxCible.SelectedIndex = indexSelection;
            }
        }

        private void buttonBas_Click(object sender, EventArgs e)
        {
            if (indexCible!=-1 && (indexCible != listBoxCible.Items.Count-1))
            {
                listBoxCible.Items.Insert(indexCible + 2, listBoxCible.Items[listBoxCible.SelectedIndex]);
                indexSelection = indexCible+1;
                listBoxCible.Items.RemoveAt(indexCible);
            }
            listBoxCible.SelectedIndex = indexSelection;
        }

        private void buttonHaut_Click(object sender, EventArgs e)
        {
            if (indexCible != -1 && indexCible != 0)
            {
                
                listBoxCible.Items.Insert(indexCible - 1, listBoxCible.Items[listBoxCible.SelectedIndex]);
                indexSelection = indexCible-1;
                listBoxCible.Items.RemoveAt(indexCible+1);
            }
            listBoxCible.SelectedIndex = indexSelection;
        }


        private void comboBoxSource_DropDown(object sender, EventArgs e)
        {
            if (Verification.ElementValide(comboBoxSource.Text.Length, comboBoxSource.FindStringExact(comboBoxSource.Text), listBoxCible.FindStringExact(comboBoxSource.Text)))
            {
                comboBoxSource.Items.Add(comboBoxSource.Text);
                listeDePays.AjouterElement(comboBoxSource.Text);
            }
        }

        private void FormListBoxEtComboBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClassListeDeStringSelectionne l = listeDePays;
        }
    }
}
