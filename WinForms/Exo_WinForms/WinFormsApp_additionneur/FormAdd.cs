using ClassLibrary_additionneur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_additionneur
{
    public partial class FormAdd : Form
    {
        public string Titre { set => this.Text = value; }

        Addition addition = new Addition();
        public FormAdd()
        {
            InitializeComponent();
        }

        private void buttonChiffre_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBoxAfficheur.Text += btn.Tag + "+";
            addition.AjouterChiffre(int.Parse((string)btn.Tag));
        }

        private void buttonVider_Click(object sender, EventArgs e)
        {
            textBoxAfficheur.Clear();
            addition = new Addition();
        }

        private void buttonCalculer_Click(object sender, EventArgs e)
        {
            textBoxAfficheur.Text += " = " + addition.Evaluer() + "+";
        }
    }
}
