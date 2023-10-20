using ClassLibraryProxy;

namespace ClassLibraryEmpilementProxy
{
	public class ClassFichierProxyA : IFichier

	{
		private IFichier iObjet; 

		public ClassFichierProxyA(IFichier _iObjet)
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