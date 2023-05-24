using ClassLibrary7Verification;
using ClassLibraryEmprunt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppSynthese
{
    public partial class Synthese : Form
    {
        Emprunt monEmprunt;
		public string Titre { set => this.Text = value; }
		public Synthese()
        {
            InitializeComponent();

            monEmprunt = new Emprunt();

			#region initilisationConfig
			listBoxPeriodicite.Items.Add("Mensuelle");
            listBoxPeriodicite.Items.Add("Bimestrielle");
            listBoxPeriodicite.Items.Add("Trimestrielle");
            listBoxPeriodicite.Items.Add("Semestrielle");
            listBoxPeriodicite.Items.Add("Annuelle");
            listBoxPeriodicite.SelectedIndex = 0;

            radioButtonTaux7.Checked = true;

            hScrollBarNombreMoisRemboursement.Minimum = 1;
            hScrollBarNombreMoisRemboursement.Maximum = 311;
			#endregion



		}
		public void Affichage()
        {
            for (int i = 0; i < monEmprunt.TauxInteret.Count-1; i++)
            {
                if (monEmprunt.TauxInteret.ElementAt(i).Value)
                {
                    if (i==0)
                    {
                        radioButtonTaux7.Checked = true;
                    }
                    if (i == 1)
                    {
                        radioButtonTaux8.Checked = true;
                    }
                    if (i == 2)
                    {
                        radioButtonTaux9.Checked = true;
                    }
                }
            }

            listBoxPeriodicite.SelectedIndex = monEmprunt.PeriodiciteRemboursement.Values.ToList().IndexOf(true);
            
            hScrollBarNombreMoisRemboursement.Value = monEmprunt.DureeMoisRemboursement;

            labelNombreMoisRemboursement.Text = monEmprunt.DureeMoisRemboursement.ToString();

            labelNombreRemboursement.Text = monEmprunt.CalculerNombreRemboursement().ToString();

            labelMontantRemboursement.Text = monEmprunt.CalculerMontantRemboursement().ToString();

            if (monEmprunt.CapitalEmprunte==0)
            {
                textBoxCapital.Clear();
            }
            else
            {
                textBoxCapital.Text = monEmprunt.CapitalEmprunte.ToString();
            }

            if (monEmprunt.Nom.Length == 0)
            {
                textBoxNom.Clear();
            }
            else
            {
				textBoxNom.Text = monEmprunt.Nom;
			}
            
        }

        private void listBoxPeriodicite_SelectedIndexChanged(object sender, EventArgs e)
        {
            monEmprunt.SelectionPeriodicite(listBoxPeriodicite.SelectedIndex);
            hScrollBarNombreMoisRemboursement.SmallChange = 12/monEmprunt.PeriodiciteRemboursement.ElementAt(listBoxPeriodicite.SelectedIndex).Key;
            hScrollBarNombreMoisRemboursement.Minimum = 12/ monEmprunt.PeriodiciteRemboursement.ElementAt(listBoxPeriodicite.SelectedIndex).Key;

            if (monEmprunt.DureeMoisRemboursement < hScrollBarNombreMoisRemboursement.Minimum)
            {
                monEmprunt.DureeMoisRemboursement = hScrollBarNombreMoisRemboursement.Minimum;
            }
            if (monEmprunt.DureeMoisRemboursement > hScrollBarNombreMoisRemboursement.Maximum)
            {
                monEmprunt.DureeMoisRemboursement = hScrollBarNombreMoisRemboursement.Maximum;
            }
            PasDeScroll(hScrollBarNombreMoisRemboursement.Value);
            //monEmprunt.CalculerMontantRemboursement();
            Affichage();
        }

        private void radioButtonTaux7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTaux7.Checked == true)
            {
                monEmprunt.SelectionTaux(0);
                //monEmprunt.CalculerMontantRemboursement();
                Affichage();
            }
            
        }

        private void radioButtonTaux8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTaux8.Checked == true)
            {
                monEmprunt.SelectionTaux(1);
                //monEmprunt.CalculerMontantRemboursement();
                Affichage();
            }
            
        }

        private void radioButtonTaux9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTaux9.Checked == true)
            {
                monEmprunt.SelectionTaux(2);
                //monEmprunt.CalculerMontantRemboursement();
                Affichage();
            }
            
        }
        public void PasDeScroll(int value)
        {
			int reste = value % (12 / monEmprunt.PeriodiciteRemboursement.FirstOrDefault(x => x.Value).Key);

			if (reste == 0)
			{
				monEmprunt.DureeMoisRemboursement = value;
			}
			else
			{
				int quotient = value / (12 / monEmprunt.PeriodiciteRemboursement.FirstOrDefault(x => x.Value).Key);
				monEmprunt.DureeMoisRemboursement = quotient * (12 / monEmprunt.PeriodiciteRemboursement.FirstOrDefault(x => x.Value).Key);
			}
		}
        private void hScrollBarNombreMoisRemboursement_ValueChanged(object sender, EventArgs e)
        {
            PasDeScroll(hScrollBarNombreMoisRemboursement.Value);
            
            //monEmprunt.CalculerMontantRemboursement();
            Affichage();
        }

        private void textBoxCapital_TextChanged(object sender, EventArgs e)
        {
            if (Verification.MontantValide(textBoxCapital.Text))
            {
                monEmprunt = new Emprunt();
                monEmprunt.CapitalEmprunte = int.Parse(textBoxCapital.Text);
                //monEmprunt.CalculerMontantRemboursement();
                Affichage();
            }
            else
            {
                monEmprunt = new Emprunt();
                monEmprunt.CapitalEmprunte = 0;
                //monEmprunt.CalculerMontantRemboursement();
                Affichage();
            }
            
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            if (Verification.NomValide(textBoxNom.Text))
            {
                monEmprunt.Nom = textBoxNom.Text;
                Affichage();
            }
            else
            {
                monEmprunt.Nom = "";
                Affichage();
            }
        }
    }
}
