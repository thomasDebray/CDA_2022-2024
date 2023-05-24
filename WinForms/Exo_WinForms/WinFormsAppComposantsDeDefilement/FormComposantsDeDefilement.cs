using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppComposantsDeDefilement
{
    public partial class FormComposantsDeDefilement : Form
    {
        System.Drawing.Color maCouleur;
		public string Titre { set => this.Text = value; }
		public FormComposantsDeDefilement()
        {
            InitializeComponent();

            maCouleur = new System.Drawing.Color();

			#region configScrollBar
			hScrollBarRouge.Minimum = 0;
            hScrollBarRouge.Maximum = 264;
            numericUpDownRouge.Minimum = 0;
            numericUpDownRouge.Maximum=255;

            hScrollBarVert.Minimum = 0;
            hScrollBarVert.Maximum = 264;
            numericUpDownVert.Minimum = 0;
            numericUpDownVert.Maximum = 255;

            hScrollBarBleu.Minimum = 0;
            hScrollBarBleu.Maximum = 264;
            numericUpDownBleu.Minimum = 0;
            numericUpDownBleu.Maximum = 255;
			#endregion

		}

		public FormComposantsDeDefilement(Color maCouleurAModifier)
        {
			InitializeComponent();
            this.maCouleur = maCouleurAModifier;
            Affichage();
			//maCouleur=maCouleurAModifier;
			//MettreAjourTouteLIHM();
		}

		private void hScrollBarRouge_ValueChanged(object sender, EventArgs e)
        {
            //metre a jour maCouleur
            // appeler une methode qui met à jour toute l'IHM

            //numericUpDownRouge.Value = hScrollBarRouge.Value;
            maCouleur = Color.FromArgb(hScrollBarRouge.Value,maCouleur.G,maCouleur.B);
            Affichage();
        }
        
        private void numericUpDownRouge_ValueChanged(object sender, EventArgs e)
        {
            maCouleur = Color.FromArgb((int)numericUpDownRouge.Value, maCouleur.G, maCouleur.B);
            //hScrollBarRouge.Value = (int)numericUpDownRouge.Value;
            //panelRouge.BackColor = Color.FromArgb((int)numericUpDownRouge.Value, 0, 0);
            //panelResultat.BackColor = Color.FromArgb((int)numericUpDownRouge.Value, (int)numericUpDownVert.Value, (int)numericUpDownBleu.Value);
            Affichage();
        }

        private void hScrollBarVert_ValueChanged(object sender, EventArgs e)
        {
            //numericUpDownVert.Value = hScrollBarVert.Value;
            maCouleur = Color.FromArgb(maCouleur.R, hScrollBarVert.Value, maCouleur.B);
            Affichage();
        }

        private void numericUpDownVert_ValueChanged(object sender, EventArgs e)
        {
            //hScrollBarVert.Value = (int)numericUpDownVert.Value;
            maCouleur = Color.FromArgb(maCouleur.R, (int)numericUpDownVert.Value, maCouleur.B);
            //panelVert.BackColor = Color.FromArgb( 0,(int)numericUpDownVert.Value, 0);
            //panelResultat.BackColor = Color.FromArgb((int)numericUpDownRouge.Value, (int)numericUpDownVert.Value, (int)numericUpDownBleu.Value);
            Affichage();
        }

        private void hScrollBarBleu_ValueChanged(object sender, EventArgs e)
        {
            //numericUpDownBleu.Value = hScrollBarBleu.Value;
            maCouleur = Color.FromArgb(maCouleur.R, maCouleur.G, hScrollBarBleu.Value);
            Affichage();
		}

        private void numericUpDownBleu_ValueChanged(object sender, EventArgs e)
        {
            maCouleur = Color.FromArgb(maCouleur.R, maCouleur.G, (int)numericUpDownBleu.Value);
            //panelBleu.BackColor = Color.FromArgb( 0, 0, (int)numericUpDownBleu.Value);
            //panelResultat.BackColor = Color.FromArgb((int)numericUpDownRouge.Value, (int)numericUpDownVert.Value, (int)numericUpDownBleu.Value);
            Affichage();
        }

        private void Affichage()
        {
            panelRouge.BackColor = Color.FromArgb(maCouleur.R, 0, 0);
            panelVert.BackColor = Color.FromArgb(0, maCouleur.G, 0);
            panelBleu.BackColor = Color.FromArgb(0, 0, maCouleur.B);
            panelResultat.BackColor = maCouleur;
            numericUpDownRouge.Value = maCouleur.R;
            numericUpDownVert.Value = maCouleur.G;
            numericUpDownBleu.Value = maCouleur.B;
            hScrollBarRouge.Value = maCouleur.R;
            hScrollBarVert.Value = maCouleur.G;
            hScrollBarBleu.Value = maCouleur.B;

		}
    }
}
