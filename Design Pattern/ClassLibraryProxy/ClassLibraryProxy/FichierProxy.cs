using System.ComponentModel.DataAnnotations;

namespace ClassLibraryProxy
{
	public class FichierProxy : IFichier
	{
		private FichierSource fichierSource;

		public FichierProxy(string utilisateur)
		{
			this.fichierSource = new FichierSource(utilisateur);
		}

		public void Ecrire()
		{
			bool autorisationsValides = VerifierAutorisations();

			// Vérifier les autorisations d'accès
			if (autorisationsValides)
			{
				// Déléguer l'appel à FichierSource pour l'écriture du fichier
				this.fichierSource.Ecrire();
			}
		}

		public void Lire()
		{
			bool autorisationsValides = VerifierAutorisations();

			// Vérifier les autorisations d'accès
			if (autorisationsValides)
			{
				// Déléguer l'appel à FichierSource pour la lecture du fichier
				this.fichierSource.Lire();
			}
		}

		/// <summary>
		/// Vérifier si l'utilisateur a les autorisations 
		/// nécessaires pour accéder au fichier source
		/// </summary>
		/// <returns>bool</returns>
		private bool VerifierAutorisations()
		{
			if (this.fichierSource.Utilisateur.Trim().Length>0)
			{
				return true;
			}
			else
			{
				Console.WriteLine("L'utilisateur n'est pas autorisé à réaliser l'opération");
				return false;
			}
				
		}
	}
}