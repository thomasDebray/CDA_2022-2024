using ClassLibraryOutils;
using ClassLibraryToutEmbal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppToutEmbal
{
	public partial class FormToutEmbal : Form
	{
		Production productionA;
		Production productionB;
		Production productionC;
		public FormToutEmbal()
		{
			productionA = new Production(500, 1000);
			productionB = new Production(12500, 5000);
			productionC = new Production(60000, 10000);

			InitializeComponent();

			timerProductionA.Interval = Outils.Interval(productionA.ProdHoraire);
			timerProductionB.Interval = Outils.Interval(productionB.ProdHoraire);
			timerProductionC.Interval = Outils.Interval(productionC.ProdHoraire);

			progressBarProductionA.Maximum = productionA.NbCaisseAProd;
			progressBarProductionB.Maximum = productionB.NbCaisseAProd;
			progressBarProductionC.Maximum = productionC.NbCaisseAProd;

			productionA.CaisseProduite += Production_CaisseProduite;
			productionB.CaisseProduite += Production_CaisseProduite;
			productionC.CaisseProduite += Production_CaisseProduite;

			productionA.EtatProductionChange += Production_EtatProductionChange;
			productionB.EtatProductionChange += Production_EtatProductionChange;
			productionC.EtatProductionChange += Production_EtatProductionChange;

			toolStripStatusLabelHeure.Text = DateTime.Now.ToShortTimeString();
		}

		private void Production_EtatProductionChange(Production sender, Production.EtatProduction nouvelleEtat)
		{
			Affichage();
			if (productionA.SonEtatCourant==Production.EtatProduction.Termine)
			{
				MessageBox.Show("La production A est terminée", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			if (productionB.SonEtatCourant==Production.EtatProduction.Termine)
			{
				MessageBox.Show("La production B est terminée", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			if (productionC.SonEtatCourant==Production.EtatProduction.Termine)
			{
				MessageBox.Show("La production C est terminée", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void Production_CaisseProduite(Production sender)
		{
			Affichage();
		}

		
		private void Affichage()
		{
			try
			{
				this.Invoke(new DegAffichageWithoutInvoke(AffichageWithoutInvoke));
			}
			catch (System.ObjectDisposedException) { }
		}
	
		
		private delegate void DegAffichageWithoutInvoke();
		private void AffichageWithoutInvoke()
		{ 
			progressBarProductionA.Value = productionA.DonneLeNbDeValide();
			progressBarProductionB.Value = productionB.DonneLeNbDeValide();
			progressBarProductionC.Value = productionC.DonneLeNbDeValide();

			textBoxNbCaisseA.Text = productionA.DonneLeNbDeValide().ToString();
			textBoxTauxDefautHeureA.Text = productionA.DonneLeTauxDefautHoraireActuel().ToString();
			textBoxTauxDefautGlobalA.Text = productionA.DonneLeTauxDefautGlobal().ToString();

			textBoxNbCaisseB.Text = productionB.DonneLeNbDeValide().ToString();
			textBoxTauxDefautHeureB.Text = productionB.DonneLeTauxDefautHoraireActuel().ToString();
			textBoxTauxDefautGlobalB.Text = productionB.DonneLeTauxDefautGlobal().ToString();

			textBoxNbCaisseC.Text = productionC.DonneLeNbDeValide().ToString();
			textBoxTauxDefautHeureC.Text = productionC.DonneLeTauxDefautHoraireActuel().ToString();
			textBoxTauxDefautGlobalC.Text = productionC.DonneLeTauxDefautGlobal().ToString();

			if (productionA.SonEtatCourant==Production.EtatProduction.EnCours)
			{
				aDemarrerToolStripMenuItem.Enabled = false;
				toolStripButtonAVert.Enabled = false;

				aArreterToolStripMenuItem.Enabled = true;
				toolStripButtonARouge.Enabled = true;

				aContinuerToolStripMenuItem2.Enabled = false;
				toolStripButtonAOrange.Enabled = false;

			}
			if (productionB.SonEtatCourant==Production.EtatProduction.EnCours)
			{
				bDemarrerToolStripMenuItem.Enabled = false;
				toolStripButtonBVert.Enabled = false;
				bArreterToolStripMenuItem.Enabled = true;
				toolStripButtonBRouge.Enabled = true;
				bContinuerToolStripMenuItem.Enabled = false;
				toolStripButtonBOrange.Enabled = false;
			}
			if (productionC.SonEtatCourant==Production.EtatProduction.EnCours)
			{
				cDemarrerToolStripMenuItem.Enabled = false;
				toolStripButtonCVert.Enabled = false;
				cArreterToolStripMenuItem.Enabled = true;
				toolStripButtonCRouge.Enabled = true;
				cContinuerToolStripMenuItem.Enabled=false;
				toolStripButtonCOrange.Enabled = false;
			}
			if (productionA.SonEtatCourant==Production.EtatProduction.EnPause)
			{
				aContinuerToolStripMenuItem2.Enabled = true;
				toolStripButtonAOrange.Enabled=true;
				aArreterToolStripMenuItem.Enabled = false;
				toolStripButtonARouge.Enabled = false;
				toolStripStatusLabelCaisseA.Text = "Caisses A : Suspendu";
			}
			if (productionB.SonEtatCourant==Production.EtatProduction.EnPause)
			{
				bContinuerToolStripMenuItem.Enabled = true;
				toolStripButtonBOrange.Enabled = true;
				bArreterToolStripMenuItem.Enabled=false;
				toolStripButtonBRouge.Enabled = false;
				toolStripStatusLabelCaisseB.Text = "Caisses B : Suspendu";
			}
			if (productionC.SonEtatCourant==Production.EtatProduction.EnPause)
			{
				cContinuerToolStripMenuItem.Enabled = true;
				toolStripButtonCOrange.Enabled = true;
				cArreterToolStripMenuItem.Enabled = false;
				toolStripButtonCRouge.Enabled=false;
				toolStripStatusLabelCaisseC.Text = "Caisses C : Suspendu";
			}
			if (productionA.ProductionDebute&&productionA.SonEtatCourant==Production.EtatProduction.Termine)
			{
				aArreterToolStripMenuItem.Enabled = false;
				toolStripButtonARouge.Enabled = false;
				toolStripStatusLabelCaisseA.Text = "Caisses A : Terminé";
			}
			if (productionB.ProductionDebute&&productionB.SonEtatCourant==Production.EtatProduction.Termine)
			{
				bArreterToolStripMenuItem.Enabled = false;
				toolStripButtonBRouge.Enabled = false;
				toolStripStatusLabelCaisseB.Text = "Caisses B : Terminé";
			}
			if (productionC.ProductionDebute&&productionC.SonEtatCourant==Production.EtatProduction.Termine)
			{
				cArreterToolStripMenuItem.Enabled = false;
				toolStripButtonCRouge.Enabled = false;
				toolStripStatusLabelCaisseC.Text = "Caisses C : Terminé";
			}
		}

		//private void timerProductionA_Tick(object sender, EventArgs e)
		//{
		//	productionA.ProductionCaisse();
		//	//Affichage();
		//}

		//private void timerProductionB_Tick(object sender, EventArgs e)
		//{
		//	productionB.ProductionCaisse();
		//	//Affichage();
		//}

		//private void timerProductionC_Tick(object sender, EventArgs e)
		//{
		//	productionC.ProductionCaisse();
		//	//Affichage();
		//}

		private void aToolStripMenuItem_Click(object sender, EventArgs e)
		{
			productionA.Demarrer();
			toolStripStatusLabelCaisseA.Text = "Caisses A : Démarré";
			//timerProductionA.Enabled = true;
			//aDemarrerToolStripMenuItem.Enabled = false;
			//aArreterToolStripMenuItem.Enabled = true;
		}

		private void aArreterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			productionA.MettreEnPause();
			//timerProductionA.Enabled = false;
			//aContinuerToolStripMenuItem2.Enabled = true;
			//aArreterToolStripMenuItem.Enabled = false;
		}

		private void aContinuerToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			productionA.ReprendreLaProduction();
			toolStripStatusLabelCaisseA.Text = "Caisses A : Redémarré";
			//timerProductionA.Enabled = true;
			//aArreterToolStripMenuItem.Enabled = true;
			//aContinuerToolStripMenuItem2.Enabled = false;
		}

		private void bDemarrerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			productionB.Demarrer();
			toolStripStatusLabelCaisseB.Text = "Caisses B : Démarré";
			//timerProductionB.Enabled = true;
			//bDemarrerToolStripMenuItem.Enabled = false;
			//bArreterToolStripMenuItem.Enabled = true;
		}

		private void bArreterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			productionB.MettreEnPause();
			//timerProductionB.Enabled=false;
			//bContinuerToolStripMenuItem.Enabled = true;
			//bArreterToolStripMenuItem.Enabled=false;
		}

		private void cArreterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			productionC.MettreEnPause();
			//timerProductionC.Enabled = false;
			//cContinuerToolStripMenuItem.Enabled = true;
			//cArreterToolStripMenuItem.Enabled = false;
		}

		private void bContinuerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			productionB.ReprendreLaProduction();
			toolStripStatusLabelCaisseB.Text = "Caisses B : Redémarré";
			//timerProductionC.Enabled = true;
			//bArreterToolStripMenuItem.Enabled=true;
			//bContinuerToolStripMenuItem.Enabled=false;
		}

		private void cDemarrerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			productionC.Demarrer();
			toolStripStatusLabelCaisseC.Text = "Caisses C : Démarré";
			//timerProductionC.Enabled = true;
			//cDemarrerToolStripMenuItem.Enabled = false;
			//cArreterToolStripMenuItem.Enabled = true;
		}

		private void cContinuerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			productionC.ReprendreLaProduction();
			toolStripStatusLabelCaisseC.Text = "Caisses C : Redémarré";
			//timerProductionC.Enabled = true;
			//cContinuerToolStripMenuItem.Enabled = false;
			//cArreterToolStripMenuItem.Enabled = true;
		}

		private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormToutEmbal_FormClosing(object sender, FormClosingEventArgs e)
		{
			productionA.ArreterProduction();
			productionB.ArreterProduction();
			productionC.ArreterProduction();
			//Thread.Sleep(2000);
		}

		private void toolStripButtonAVert_Click(object sender, EventArgs e)
		{
			productionA.Demarrer();
			toolStripStatusLabelCaisseA.Text = "Caisses A : Démarré";
		}

		private void toolStripButtonARouge_Click(object sender, EventArgs e)
		{
			productionA.MettreEnPause();
		}

		private void toolStripButtonAOrange_Click(object sender, EventArgs e)
		{
			productionA.ReprendreLaProduction();
			toolStripStatusLabelCaisseA.Text = "Caisses A : Redémarré";
		}

		private void toolStripButtonBVert_Click(object sender, EventArgs e)
		{
			productionB.Demarrer();
			toolStripStatusLabelCaisseB.Text = "Caisses B : Démarré";
		}

		private void toolStripButtonBRouge_Click(object sender, EventArgs e)
		{
			productionB.MettreEnPause();
		}

		private void toolStripButtonBOrange_Click(object sender, EventArgs e)
		{
			productionB.ReprendreLaProduction();
			toolStripStatusLabelCaisseB.Text = "Caisses B : Redémarré";
		}

		private void toolStripButtonCVert_Click(object sender, EventArgs e)
		{
			productionC.Demarrer();
			toolStripStatusLabelCaisseC.Text = "Caisses C : Démarré";
		}

		private void toolStripButtonCRouge_Click(object sender, EventArgs e)
		{
			productionC.MettreEnPause();
		}

		private void toolStripButtonCOrange_Click(object sender, EventArgs e)
		{
			productionC.ReprendreLaProduction();
			toolStripStatusLabelCaisseC.Text = "Caisses C : Redémarré";
		}

		private void timerHeure_Tick(object sender, EventArgs e)
		{
			toolStripStatusLabelHeure.Text = DateTime.Now.ToShortTimeString();
		}



		//private void textBoxNbCaisseA_TextChanged(object sender, EventArgs e)
		//{
		//	if (productionA.NbCaisseProd==productionA.NbCaisseAProd)
		//	{
		//		timerProductionA.Enabled = false;
		//		aArreterToolStripMenuItem.Enabled = false;
		//		//Affichage();
		//		MessageBox.Show("La production A est terminée", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		//	}
		//}

		//private void textBoxNbCaisseB_TextChanged(object sender, EventArgs e)
		//{
		//	if (productionB.NbCaisseProd==productionB.NbCaisseAProd)
		//	{
		//		timerProductionB.Enabled = false;
		//		bArreterToolStripMenuItem.Enabled = false;
		//		//Affichage();
		//		MessageBox.Show("La production B est terminée", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		//	}
		//}

		//private void textBoxNbCaisseC_TextChanged(object sender, EventArgs e)
		//{
		//	if (productionC.NbCaisseProd==productionC.NbCaisseAProd)
		//	{
		//		timerProductionC.Enabled = false;
		//		cArreterToolStripMenuItem.Enabled = false;
		//		//Affichage();
		//		MessageBox.Show("La production C est terminée", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		//	}
		//}
		//private double TauxDefautHeure(List<bool> listConforme,int interval)
		//{
		//	if ((listConforme.Count - Outils.NbIntervalHeure(interval))<0)
		//	{
		//		int nbDefaut = 0;
		//		for (int i = 0; i < listConforme.Count-1; i++)
		//		{
		//			if (listConforme[i] == false)
		//			{
		//				nbDefaut++;
		//			}
		//		}
		//		return Math.Round(Outils.Taux(nbDefaut, listConforme.Count)/100,4);
		//	}
		//	else
		//	{
		//		int nbDefaut = 0;
		//		for (int i = listConforme.Count - Outils.NbIntervalHeure(interval); i < listConforme.Count; i++)
		//		{
		//			if (listConforme[i] == false)
		//			{
		//				nbDefaut++;
		//			}
		//		}
		//		return Math.Round(Outils.Taux(nbDefaut, Outils.NbIntervalHeure(interval)),4);
		//	}
		//}
		//private double TauxDefautGlobal(List<bool> listConforme)
		//{
		//	int nbDefaut = 0;
		//	for (int i = 0; i < listConforme.Count - 1; i++)
		//	{
		//		if (listConforme[i] == false)
		//		{
		//			nbDefaut++;
		//		}
		//	}
		//	return Math.Round(Outils.Taux(nbDefaut,listConforme.Count)/100,4);
		//}
	}
}
