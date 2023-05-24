using ClassLibraryOutils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryToutEmbal
{
	public class Production
	{
		//private int nbCaisseProd;
		//private int nbCaisseAvecDefaut;
		private string nomProd;
		private int nbCaisseAProd;
		private int prodHoraire;
		private List<bool> listConforme;
		private Thread t;
		private EtatProduction sonEtatCourant;
		private bool productionDebute;
		private bool enCours;

		public enum EtatProduction
		{
			PasEncoreDemarre,
			EnCours,
			EnPause,
			Termine
		}


		public Production(int nbCaisse, int prodHoraire)
		{
			this.nbCaisseAProd = nbCaisse;
			this.prodHoraire = prodHoraire;
			//this.nbCaisseProd = 0;
			//this.nbCaisseAvecDefaut = 0;
			this.listConforme = new List<bool>();
			this.t = new Thread(ExecuterEnFond);
			this.sonEtatCourant = EtatProduction.PasEncoreDemarre;
			this.enCours = true;
			this.productionDebute = false;
		}
		public delegate void DegNouvelleCaisseProduite(Production sender);
		public event DegNouvelleCaisseProduite CaisseProduite;

		public delegate void DegEtatProductionChange(Production sender,EtatProduction nouvelleEtat);
		public event DegEtatProductionChange EtatProductionChange;
		public bool Demarrer()
		{
			if (this.sonEtatCourant == EtatProduction.PasEncoreDemarre)
			{
				this.sonEtatCourant = EtatProduction.EnCours;
				this.productionDebute = true;
				if (EtatProductionChange != null)
				{
					EtatProductionChange(this, this.sonEtatCourant);
				}
				this.t.Start();
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool MettreEnPause()
		{
			if (this.sonEtatCourant == EtatProduction.EnCours)
			{
				this.sonEtatCourant = EtatProduction.EnPause;
				if (EtatProductionChange != null)
				{
					EtatProductionChange(this, this.sonEtatCourant);
				}
				this.enCours = false;
				return true;
			}
			else
			{
				return false;
			}
			
		}
		public bool ReprendreLaProduction()
		{
			if (this.sonEtatCourant == EtatProduction.EnPause)
			{
				this.sonEtatCourant = EtatProduction.EnCours;
				if (EtatProductionChange != null)
				{
					EtatProductionChange(this, this.sonEtatCourant);
				}
				this.enCours = true;
				return true;
			}
			else
			{
				return false;
			}
			
		}
		public void ProductionCaisse()
		{
			if (Outils.PileOuFace()==1)
			{
				//this.nbCaisseProd++;
				this.listConforme.Add(true);
			}
			else
			{
				//this.nbCaisseAvecDefaut++;
				this.listConforme.Add(false);

			}
			if (CaisseProduite != null)
			{
				CaisseProduite(this);
			}
			
		}
		public void ExecuterEnFond()
		{
			while (DonneLeNbDeValide()<this.nbCaisseAProd&&this.productionDebute)
			{
				Thread.Sleep(Outils.Interval(this.prodHoraire));
				if (this.enCours)
				{
					ProductionCaisse();
				}
			}
			if (DonneLeNbDeValide()==this.nbCaisseAProd)
			{
				this.sonEtatCourant = EtatProduction.Termine;
				if (EtatProductionChange != null)
				{
					EtatProductionChange(this, this.sonEtatCourant);
					
				}
				this.productionDebute = false;

			}
			
		}
		public void ArreterProduction()
		{
			this.enCours = false;
			this.productionDebute = false;
		}
		public int DonneLeNbDeValide()
		{
			int nbCaisseValide = 0;
			for (int i = 0; i < this.listConforme.Count-1; i++)
			{
				if (this.listConforme[i]==true)
				{
					nbCaisseValide++;
				}
			}
			return nbCaisseValide;
		}

		public double DonneLeTauxDefautGlobal()
		{
			int nbCaisseAvecDefaut = 0;
			for (int i = 0; i < this.listConforme.Count-1; i++)
			{
				if (this.listConforme[i]==false)
				{
					nbCaisseAvecDefaut++;
				}
			}
			if (nbCaisseAvecDefaut==0)
			{
				return 0;
			}
			else
			{
				return Math.Round((double)nbCaisseAvecDefaut / listConforme.Count, 4);
			}
		}
		public double DonneLeTauxDefautHoraireActuel()
		{
			if (this.listConforme.Count-this.prodHoraire<0)
			{
				return DonneLeTauxDefautGlobal();
			}
			else
			{
				int nbCaisseAvecDefaut = 0;
				for (int i = this.listConforme.Count -this.prodHoraire; i < this.listConforme.Count - 1; i++)
				{
					if (this.listConforme[i]==false)
					{
						nbCaisseAvecDefaut++;
					}
				}
				return Math.Round((double)nbCaisseAvecDefaut /this.prodHoraire, 4);
			}
		}
		public int NbCaisseAProd { get => nbCaisseAProd; /*set => nbCaisseAProd = value;*/ }
		public int ProdHoraire { get => prodHoraire; /*set => prodHoraire = value;*/ }
		//public int NbCaisseProd { get => nbCaisseProd; /* set => nbCaisseProd = value;*/ }
		//public int NbCaisseAvecDefaut { get => nbCaisseAvecDefaut; /*set => nbCaisseAvecDefaut = value;*/ }
		public List<bool> ListConforme { get => listConforme; /*set => listConforme = value;*/ }
		public EtatProduction SonEtatCourant { get => sonEtatCourant; /*set => sonEtatCourant = value;*/ }
		public bool ProductionDebute { get => productionDebute; /*set => productionDebute = value;*/ }
		public string NomProd { get => nomProd; set => nomProd = value; }
	}
}
