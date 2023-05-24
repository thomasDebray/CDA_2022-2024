using ClassLibraryControlesDeSaisie;
using ClassLibraryTransaction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace WinFormsAppControlesDeSaisie
{
    
    public partial class FormControlesDeSaisie : Form
    {
        ClassLibraryTransaction.Transaction transaction;

		public string Titre { set => this.Text = value; }
		public FormControlesDeSaisie()
        {
            InitializeComponent();
        }

        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            textBoxNom.Clear();
            errorProviderNom.SetError(textBoxNom, "");
            textBoxNom.BackColor = Color.White;

            textBoxDate.Clear();
            errorProviderDate.SetError(textBoxDate, "");
            textBoxDate.BackColor = Color.White;

            textBoxMontant.Clear();
            errorProviderMontant.SetError(textBoxMontant, "");
            textBoxMontant.BackColor = Color.White;

            textBoxCP.Clear();
            errorProviderCP.SetError(textBoxCP, "");
            textBoxCP.BackColor = Color.White;
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            FormValidation frmValidation;
            if (Verification.NomValide(textBoxNom.Text)
                && Verification.DateValide(textBoxDate.Text) 
                && Verification.MontantValide(textBoxMontant.Text)
                &&Verification.CPValide(textBoxCP.Text))
            {
                transaction = new ClassLibraryTransaction.Transaction(textBoxNom.Text,textBoxDate.Text,textBoxMontant.Text,textBoxCP.Text);
                frmValidation = new FormValidation(transaction);
                frmValidation.ShowDialog();

            }
            else
            {
                if (!Verification.NomValide(textBoxNom.Text))
                {
                    textBoxNom.BackColor = Color.IndianRed;
                }
                
                if (!Verification.DateValide(textBoxDate.Text))
                {
                    textBoxDate.BackColor = Color.IndianRed;
                }
                
                if (!Verification.MontantValide(textBoxMontant.Text))
                {
                    textBoxMontant.BackColor = Color.IndianRed;
                }
                
                if (!Verification.CPValide(textBoxCP.Text))
                {
                    textBoxCP.BackColor = Color.IndianRed;
                }
                
            }
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            if (!Verification.NomValide(textBoxNom.Text))
            {
                errorProviderNom.SetError(textBoxNom, "Nom incorrect");
                textBoxNom.BackColor = Color.IndianRed;
            }
            else
            {
                errorProviderNom.SetError(textBoxNom, "");
                textBoxNom.BackColor = Color.White;
            }
        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {
            if (!Verification.DateValide(textBoxDate.Text))
            {
                errorProviderDate.SetError(textBoxDate, "Date incorrect");
                textBoxDate.BackColor = Color.IndianRed;
            }
            else
            {
                errorProviderDate.SetError(textBoxDate, "");
                textBoxDate.BackColor = Color.White;
            }
        }

        private void textBoxMontant_TextChanged(object sender, EventArgs e)
        {
            if (!Verification.MontantValide(textBoxMontant.Text))
            {
                errorProviderMontant.SetError(textBoxMontant, "Montant incorrect");
                textBoxMontant.BackColor = Color.IndianRed;
            }
            else
            {
                errorProviderMontant.SetError(textBoxMontant, "");
                textBoxMontant.BackColor = Color.White;
            }
        }

        private void textBoxCP_TextChanged(object sender, EventArgs e)
        {
            if (!Verification.CPValide(textBoxCP.Text))
            {
                errorProviderCP.SetError(textBoxCP, "Code postal incorrect");
                textBoxCP.BackColor = Color.IndianRed;
            }
            else
            {
                errorProviderCP.SetError(textBoxCP, "");
                textBoxCP.BackColor = Color.White;
            }
        }

        private void FormControlesDeSaisie_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.MdiParent==null)
            {
				DialogResult dr = MessageBox.Show("Fin de l’application", "FIN",
			    MessageBoxButtons.YesNo,
			    MessageBoxIcon.Question,
			    MessageBoxDefaultButton.Button1);

				if (dr == DialogResult.No)
					e.Cancel = true;
			}
            
        }
    }
}
