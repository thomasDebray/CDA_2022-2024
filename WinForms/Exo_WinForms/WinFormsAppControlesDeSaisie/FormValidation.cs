using ClassLibraryTransaction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsAppControlesDeSaisie
{
    public partial class FormValidation : Form
    {
        /*private string nom;
        private string date;
        private string montant;
        private string cp;*/
        Transaction transaction;

        public FormValidation(Transaction transaction)
        {
            InitializeComponent();

            /*this.nom = transaction.Nom;
            this.date = transaction.Date;
            this.montant = transaction.Montant;
            this.cp = transaction.Cp;*/
            this.transaction = transaction;

            this.labelValidation.Text = this.labelValidation.Text + this.transaction.Nom + "\r\nDate : " + this.transaction.Date + "\r\nMontant : " + this.transaction.Montant+ "\r\nCode postal : " + this.transaction.Cp;
            
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
