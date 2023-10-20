using ClassLibraryProxy;

namespace ClassLibraryEmpilementProxy
{
	public class ClassFichierProxyB : IFichier

	{
		private IFichier iObjet;

		public ClassFichierProxyB(IFichier _iObjet)
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
