using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProxy
{
	// Classe représentant l'objet original - fichier source
	public class FichierSource : IFichier
	{
		private string utilisateur;
		public FichierSource(string _utilisateur) 
		{
			this.utilisateur = _utilisateur;
		}

		public string Utilisateur { get => utilisateur; set => utilisateur = value; }

		public void Ecrire()
		{
			// Implémentation spécifique pour la lecture de fichier source
			Console.WriteLine("l'écriture du fichier est réalisée");
		}

		public void Lire()
		{
			// Implémentation spécifique pour l'écriture de fichier source
			Console.WriteLine("la lecture du fichier est réalisée");
		}
	}
}
