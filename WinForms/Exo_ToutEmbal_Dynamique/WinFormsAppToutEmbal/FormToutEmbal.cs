using ClassLibraryToutEmbal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsControlLibraryToutEmbal;

namespace WinFormsAppToutEmbal
{
	public partial class FormToutEmbal : Form
	{
		private int nbProdA = 0;
		private int nbProdB = 0;
		private int nbProdC = 0;

		private Production maProduction;

		private Dictionary<string,Production> listeDeProduction;
		public FormToutEmbal()
		{
			InitializeComponent();
			listeDeProduction = new Dictionary<string,Production>();

			//UserControlEtat ucMonEtat = (UserControlEtat)panelEtat.Controls[]
			
		}
		private void AjouterProductionA()
		{
			nbProdA++;

			maProduction = new Production(500, 1000);

			maProduction.NomProd = "A" + nbProdA.ToString();
			listeDeProduction.Add("A" + nbProdA.ToString(), maProduction);

			maProduction.CaisseProduite += MaProduction_CaisseProduite;

			UserControlEtat monEtat = new UserControlEtat();
			panelEtat.Controls.Add(monEtat);
			monEtat.Dock = DockStyle.Left;
			monEtat.BringToFront();
			monEtat.Name = "A" + nbProdA.ToString();
			monEtat.NomBoutonVert = "A" + nbProdA.ToString();
			monEtat.NomBoutonRouge = "A" +nbProdA.ToString();
			monEtat.NomBoutonOrange = "A" +nbProdA.ToString();
			monEtat.ClickBoutonVert += MonEtat_ClickBoutonVert;
			monEtat.ClickBoutonRouge += MonEtat_ClickBoutonRouge;
			monEtat.ClickBoutonOrange += MonEtat_ClickBoutonOrange;

			UserControlStats mesStats = new UserControlStats();
			panelStats.Controls.Add(mesStats);
			mesStats.Dock = DockStyle.Left;
			mesStats.BringToFront();
			mesStats.Name = "A" + nbProdA.ToString();
			mesStats.Nom = "A" + nbProdA.ToString();

			//UserControlEtat uc = (UserControlEtat)panelStats.Controls["A" + nbProdA.ToString()];

			UserControlProgression maProgression = new UserControlProgression();
			panelProgression.Controls.Add(maProgression);
			maProgression.Dock = DockStyle.Top;
			maProgression.BringToFront();
			maProgression.Name = "A" + nbProdA.ToString();
			maProgression.LabelProdNom = "A" + nbProdA.ToString();
			maProgression.ProgressionMax = maProduction.NbCaisseAProd;

			démarrerToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("A" + nbProdA.ToString(), null, null, "a" + nbProdA.ToString() + "DemarrerToolStripMenuItem"));
			arrêterToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("A" + nbProdA.ToString(), null, null, "a" + nbProdA.ToString() + "ArreterToolStripMenuItem"));
			continuerToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("A" + nbProdA.ToString(), null, null, "a" + nbProdA.ToString() + "ContinuerToolStripMenuItem"));

			

		}
		private void AffichageWithoutInvoke(Production maProduction)
		{
			try
			{
				if (this.InvokeRequired)
				{
					this.Invoke(() =>
					{
						UserControlStats maStat = (UserControlStats)panelStats.Controls[maProduction.NomProd];
						maStat.ValeurNbCaisse = maProduction.DonneLeNbDeValide().ToString();
						maStat.ValeurDefautGlobal = maProduction.DonneLeTauxDefautGlobal().ToString();
						maStat.ValeurDefautHoraire = maProduction.DonneLeTauxDefautHoraireActuel().ToString();

						UserControlProgression maProgression = (UserControlProgression)panelProgression.Controls[maProduction.NomProd];
						maProgression.Valeur = maProduction.DonneLeNbDeValide();
					});
				}
				
			}
			catch (System.ObjectDisposedException) { }

			//UserControlStats maStat = (UserControlStats)panelStats.Controls[maProduction.NomProd];
			//maStat.ValeurNbCaisse = maProduction.DonneLeNbDeValide().ToString();
		}
		private void MaProduction_CaisseProduite(Production sender)
		{
			AffichageWithoutInvoke(sender);
		}

		//private void Affichage(Production maProduction)
		//{
		//		this.Invoke(new DegAffichageWithoutInvoke(AffichageWithoutInvoke(maProduction))); 
		//}
		//private delegate void DegAffichageWithoutInvoke();
		private void MonEtat_ClickBoutonOrange(object? sender, EventArgs e)
		{
			UserControlEtat monEtat = (UserControlEtat)sender;
			monEtat.ActifBoutonRouge = true;
			monEtat.ActifBoutonOrange = false;

			listeDeProduction[monEtat.Name].ReprendreLaProduction();

		}

		//if (this.InvokeRequired)


		//						   {

		//	this.Invoke(() => { uc.ValeurProgressBar = p.DonneLeNbDeValide(); });

		//}

  //                                 else

		//						   {

		//	uc.ValeurProgressBar = p.DonneLeNbDeValide();

		//}
		
		private void MonEtat_ClickBoutonRouge(object? sender, EventArgs e)
		{
			UserControlEtat monEtat = (UserControlEtat)sender;
			monEtat.ActifBoutonOrange = true;
			monEtat.ActifBoutonRouge = false;

			listeDeProduction[monEtat.Name].MettreEnPause();
		}

		private void MonEtat_ClickBoutonVert(object? sender, EventArgs e)
		{
			UserControlEtat monEtat = (UserControlEtat)sender;
			monEtat.ActifBoutonVert = false;
			monEtat.ActifBoutonRouge = true;

			listeDeProduction[monEtat.Name].Demarrer();
		}

		private void AjouterProductionB()
		{
			nbProdB++;
			maProduction = new Production(12500, 5000);
			maProduction.NomProd = "B" + nbProdB.ToString();
			listeDeProduction.Add("B" + nbProdB.ToString(), maProduction);

			maProduction.CaisseProduite += MaProduction_CaisseProduite;


			UserControlEtat monEtat = new UserControlEtat();
			panelEtat.Controls.Add(monEtat);
			monEtat.Dock = DockStyle.Left;
			monEtat.BringToFront();
			monEtat.Name = "B" + nbProdB.ToString();
			monEtat.NomBoutonVert = "B" + nbProdB.ToString();
			monEtat.NomBoutonRouge= "B" + nbProdB.ToString();
			monEtat.NomBoutonOrange= "B" + nbProdB.ToString();
			monEtat.ClickBoutonVert += MonEtat_ClickBoutonVert;
			monEtat.ClickBoutonRouge += MonEtat_ClickBoutonRouge;
			monEtat.ClickBoutonOrange += MonEtat_ClickBoutonOrange;

			UserControlStats mesStats = new UserControlStats();
			panelStats.Controls.Add(mesStats);
			mesStats.Dock = DockStyle.Left;
			mesStats.BringToFront();
			mesStats.Name = "B" + nbProdB.ToString();
			mesStats.Nom = "B" + nbProdB.ToString();

			UserControlProgression maProgression = new UserControlProgression();
			panelProgression.Controls.Add(maProgression);
			maProgression.Dock = DockStyle.Top;
			maProgression.BringToFront();
			maProgression.Name = "B" + nbProdB.ToString();
			maProgression.LabelProdNom = "B" + nbProdB.ToString();
			maProgression.ProgressionMax = maProduction.NbCaisseAProd;


			démarrerToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("B"+nbProdB.ToString(),null,null,"b"+nbProdB.ToString()+"DemarrerToolStripMenuItem"));
			arrêterToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("B" + nbProdB.ToString(), null, null, "b" + nbProdB.ToString() + "ArreterToolStripMenuItem"));
			continuerToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("B" + nbProdB.ToString(), null, null, "b" + nbProdB.ToString() + "ContinuerToolStripMenuItem"));


		}
		private void AjouterProductionC()
		{
			nbProdC++;
			maProduction = new Production(60000, 10000);
			maProduction.NomProd = "C" + nbProdC.ToString();
			listeDeProduction.Add("C" + nbProdC.ToString(), maProduction);

			maProduction.CaisseProduite += MaProduction_CaisseProduite;

			UserControlEtat monEtat = new UserControlEtat();
			panelEtat.Controls.Add(monEtat);
			monEtat.Dock = DockStyle.Left;
			monEtat.BringToFront();
			monEtat.Name = "C" + nbProdC.ToString();
			monEtat.NomBoutonVert = "C" + nbProdC.ToString();
			monEtat.NomBoutonRouge = "C" + nbProdC.ToString();
			monEtat.NomBoutonOrange = "C" + nbProdC.ToString();
			monEtat.ClickBoutonVert += MonEtat_ClickBoutonVert;
			monEtat.ClickBoutonRouge += MonEtat_ClickBoutonRouge;
			monEtat.ClickBoutonOrange += MonEtat_ClickBoutonOrange;

			UserControlStats mesStats = new UserControlStats();
			panelStats.Controls.Add(mesStats);
			mesStats.Dock = DockStyle.Left;
			mesStats.BringToFront();
			mesStats.Name = "C" + nbProdC.ToString();
			mesStats.Nom = "C" + nbProdC.ToString();

			UserControlProgression maProgression = new UserControlProgression();
			panelProgression.Controls.Add(maProgression);
			maProgression.Dock = DockStyle.Top;
			maProgression.BringToFront();
			maProgression.Name = "C" + nbProdC.ToString();
			maProgression.LabelProdNom = "C" + nbProdC.ToString();
			maProgression.ProgressionMax = maProduction.NbCaisseAProd;


			démarrerToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("C" + nbProdC.ToString(), null, null, "c" + nbProdC.ToString() + "DemarrerToolStripMenuItem"));
			arrêterToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("C" + nbProdC.ToString(), null, null, "c" + nbProdC.ToString() + "ArreterToolStripMenuItem"));
			continuerToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("C" + nbProdC.ToString(), null, null, "c" + nbProdC.ToString() + "ContinerToolStripMenuItem"));
		}
		
		private void aToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AjouterProductionA();
		}

		private void bToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AjouterProductionB();
		}

		private void cToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AjouterProductionC();
		}

		private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
			this.Close();
		}

		private void FormToutEmbal_FormClosing(object sender, FormClosingEventArgs e)
		{
			for (int i = 0; i < listeDeProduction.Count - 1; i++)
			{
				listeDeProduction.ElementAt(i).Value.ArreterProduction();
			}
		}
	}
}
