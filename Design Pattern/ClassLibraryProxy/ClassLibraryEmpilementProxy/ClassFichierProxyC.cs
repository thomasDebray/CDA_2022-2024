using ClassLibraryProxy;

namespace ClassLibraryEmpilementProxy
{
	public class ClassFichierProxyC : IFichier

	{
		private IFichier iObjet;

		public ClassFichierProxyC(IFichier _iObjet)
		{
			this.iObjet = _iObjet;
		}

		public void ecrire()
		{
			this.iObjet.ecrire();
		}

		public void lire()
		{
			this.iObjet.lire();
		}
	}
}