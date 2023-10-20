using Bouteille.ExceptionsBouteille;
namespace Bouteilles
{
	public class Bouteille
	{
		private bool ouvert;
		private float remplissageDeLaBouteilleEnPourcentage;
		private float capaciteeEnL;

		public float RemplissageDeLaBouteilleEnPourcentage
		{
			get => remplissageDeLaBouteilleEnPourcentage;

			set { if (value < 0) { throw new ContenuNegatifImpossible(); } else remplissageDeLaBouteilleEnPourcentage = value; }
		}

		public Bouteille() : this(false, 100, 1)
		{
		}

		public Bouteille(bool ouvert, float remplissageEnPourcentage, float capaciteeEnL)
		{
			if(remplissageEnPourcentage>100)
			{
				throw new ArgumentOutOfRangeException("capacité dépassée");
			}
			if(remplissageEnPourcentage<0)
			{
				throw new ArgumentOutOfRangeException("remplissage négatif");
			}
			if(capaciteeEnL<0)
			{
				throw new ArgumentOutOfRangeException("capacité négative impossible");
			}
			this.ouvert = ouvert;
			this.RemplissageDeLaBouteilleEnPourcentage = remplissageEnPourcentage;
			this.capaciteeEnL = capaciteeEnL;
		}

		/*public Bouteille(Bouteille bouteilleACopier)
        {
            this.ouvert = bouteilleACopier.ouvert;
            this.remplissageDeLaBouteilleEnPourcentage = bouteilleACopier.remplissageDeLaBouteilleEnPourcentage;
            this.capaciteeEnL = bouteilleACopier.capaciteeEnL;
        }*/

		public Bouteille(Bouteille bouteilleACopier)
			: this(bouteilleACopier.ouvert, bouteilleACopier.RemplissageDeLaBouteilleEnPourcentage, bouteilleACopier.capaciteeEnL)
		{
		}
		/// <summary>
		/// Action de fermer la bouteille
		/// </summary>
		/// <returns>Action réalisée</returns>
		public bool Fermer()
		{
			if (ouvert == true)
			{
				ouvert = false;
				return true;
			}
			else
				return false;
		}
		/// <summary>
		/// Action d'ouvrir la bouteille
		/// </summary>
		/// <returns>Action réalisée</returns>
		public bool Ouvrir()
		{
			if (ouvert == false)
			{
				ouvert = true;
				return true;
			}
			else
				return false;
		}
		/// <summary>
		/// Remplissage de la bouteille avec un pourcentage de liquide
		/// </summary>
		/// <param name="pourcentageDuContenuAjouteOuRetire">Quantité en pourcentage à ajouter</param>
		/// <returns>Action réalisée</returns>
		public bool Remplir(float pourcentageDuContenuAjouteOuRetire)
		{
			if (ouvert == true && RemplissageDeLaBouteilleEnPourcentage < 100 && pourcentageDuContenuAjouteOuRetire > 0 && RemplissageDeLaBouteilleEnPourcentage + pourcentageDuContenuAjouteOuRetire <= 100)
			{
				RemplissageDeLaBouteilleEnPourcentage = RemplissageDeLaBouteilleEnPourcentage + pourcentageDuContenuAjouteOuRetire;
				return true;
			}
			else
				return false;
		}
		/// <summary>
		/// Vidage de la bouteille avec un pourcentage de liquide
		/// </summary>
		/// <param name="pourcentageDuContenuAjouteOuRetire">Quantité en pourcentage à vider</param>
		/// <returns>Action réalisée</returns>
		public bool Vider(float pourcentageDuContenuAjouteOuRetire)
		{
			if (ouvert == true && RemplissageDeLaBouteilleEnPourcentage > 0 && pourcentageDuContenuAjouteOuRetire > 0 && pourcentageDuContenuAjouteOuRetire <= remplissageDeLaBouteilleEnPourcentage)
			{
				RemplissageDeLaBouteilleEnPourcentage = RemplissageDeLaBouteilleEnPourcentage - pourcentageDuContenuAjouteOuRetire;
				return true;
			}
			else
				return false;
		}
		/*
        public bool ViderTout()
        {
            if (ouvert == true && remplissageDeLaBouteilleEnPourcentage > 0)
            {
                remplissageDeLaBouteilleEnPourcentage = 0;
                return true;
            }
            else
                return false;
        }
        */
		/// <summary>
		/// Vidage de la bouteille dans sa totalité
		/// </summary>
		/// <returns>Action réalisée</returns>
		public bool ViderTout()
		{
			return Vider(RemplissageDeLaBouteilleEnPourcentage);
		}
		/// <summary>
		/// Remplissage dans la totalité la bouteille
		/// </summary>
		/// <returns>Action réalisée</returns>
		public bool RemplirTout()
		{
			if (ouvert == true && RemplissageDeLaBouteilleEnPourcentage < 100)
			{
				RemplissageDeLaBouteilleEnPourcentage = 100;
				return true;
			}
			else
				return false;
		}
	}
}