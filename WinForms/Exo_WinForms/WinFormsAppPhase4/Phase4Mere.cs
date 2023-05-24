using ClassLibrary8Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_additionneur;
using WinFormsAppCheckBoxEtRadioButton;
using WinFormsAppComposantsDeDefilement;
using WinFormsAppControlesDeSaisie;
using WinFormsAppListBox;
using WinFormsAppListBoxEtComboBox;
using WinFormsAppSynthese;

namespace WinFormsAppPhase4
{
	public partial class Phase4Mere : Form
	{
		int numAdd = 0;
		int numCont = 0;
		int numCheckBox = 0;
		int numListBox = 0;
		int numComboBox = 0;
		int numDefil = 0;
		int numSynthese = 0;
		public Phase4Mere()
		{
			
			InitializeComponent();
			toolStripStatusLabelDate.Text = DateTime.Today.ToShortDateString();
			toolStripStatusLabelOperation.Text = "";
			Accueil();
		}

		public void Activation()
		{
			phase1ToolStripMenuItem.Enabled = true;
			phase2ToolStripMenuItem.Enabled = true;
			phase3ToolStripMenuItem.Enabled = true;
			fenêtresToolStripMenuItem.Enabled = true;
			toolStripSplitButtonPhase3.Enabled = true;
		}

		private void sidentifierToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Accueil();
		}

		private void toolStripButtonIdentifier_Click(object sender, EventArgs e)
		{
			Accueil();
		}

		private void additionneurToolStripMenuItem_Click(object sender, EventArgs e)
		{
			numAdd++;
			FormAdd newFeuille = new FormAdd();
			newFeuille.MdiParent = this;
			newFeuille.Titre = "L'additionneur N°" + numAdd;
			newFeuille.Show();
			toolStripStatusLabelOperation.Text = "Additionneur";
		}

		private void contrôlesDeSaisieToolStripMenuItem_Click(object sender, EventArgs e)
		{
			numCont++;
			FormControlesDeSaisie newFeuille = new FormControlesDeSaisie();
			newFeuille.MdiParent = this;
			newFeuille.Titre = "Les contrôles N°"+numCont;
			newFeuille.Show();
			toolStripStatusLabelOperation.Text = "Contrôle de saisie";
		}
		private void CheckBox()
		{
			FormSaisie newFeuille = new FormSaisie();
			newFeuille.FormClosed += NewFeuille_FormClosed;
			newFeuille.MdiParent = this;
			newFeuille.Show();

			toolStripStatusLabelOperation.Text = "Check box";
		}

		private void NewFeuille_FormClosed(object? sender, FormClosedEventArgs e)
		{
			numCheckBox++;
			FormSaisie formSaisie = sender as FormSaisie;
			WindowApp newFeuille = new WindowApp();
			newFeuille.MdiParent = this;
			newFeuille.Textbox = formSaisie.Texte;
			newFeuille.Titre = "CheckBox et RadioButton N°"+numCheckBox;
			newFeuille.Show();
		}
		private void Accueil()
		{
			FormLogin login = new FormLogin();
			//login.MdiParent = this;
			login.FormClosed += Login_FormClosed;
			login.ShowDialog();
		}

		private void Login_FormClosed(object? sender, FormClosedEventArgs e)
		{
			FormLogin login = sender as FormLogin;
			if (Validation.LoginOk(login.Login,login.Password))
			{
				
				Activation();
			}
		}

		private void ListBox()
		{
			numListBox++;
			FormListBox newFeuille = new FormListBox();
			newFeuille.MdiParent = this;
			newFeuille.Titre = "Les listes et leurs propriétés N°" + numListBox;
			newFeuille.Show();
			toolStripStatusLabelOperation.Text = "ListBox";
		}
		private void ComboBox()
		{
			numComboBox++;
			FormListBoxEtComboBox newFeuille = new FormListBoxEtComboBox();
			newFeuille.MdiParent = this;
			newFeuille.Titre = "Les listes N°"+numComboBox;
			newFeuille.Show();
			toolStripStatusLabelOperation.Text = "ComboBox";
		}
		private void Defilement()
		{
			numDefil++;
			FormComposantsDeDefilement newFeuille = new FormComposantsDeDefilement();
			newFeuille.MdiParent = this;
			newFeuille.Titre = "Défilement N°" + numDefil;
			newFeuille.Show();
			toolStripStatusLabelOperation.Text = "Défilement";
		}
		private void SyntheseFin()
		{
			numSynthese++;
			Synthese newFeuille = new Synthese();
			newFeuille.MdiParent = this;
			newFeuille.Titre = "Emprunts N°"+numSynthese;
			newFeuille.Show();
			toolStripStatusLabelOperation.Text = "Synthèse";
		}

		private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CheckBox();
		}

		private void listboxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ListBox();
		}

		private void comboboxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ComboBox();
		}

		private void défilementToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Defilement();
		}

		private void synthèseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SyntheseFin();
		}

		private void checkBoxToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			CheckBox();
		}

		private void listboxToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			ListBox();
		}

		private void comboboxToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			ComboBox();
		}

		private void défilementToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Defilement();
		}

		private void synthèseToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			SyntheseFin();
		}

		private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}

		private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}
		
		private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Phase4Mere_FormClosing(object sender, FormClosingEventArgs e)
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
