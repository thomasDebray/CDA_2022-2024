using Bouteilles;

namespace TestProjectBouteille
{
	[TestClass]
	public class UnitTestBouteille
	{
		[TestMethod]
		[ExpectedException (typeof (ArgumentException))]
		public void VerifieInstanciationObjetBouteilleTropRemplie()
		{
			bool ouvert = false;
			float remplissageEnPourcentage = 105;
			float capaciteeEnL = 1;

			Bouteille bouteille = new Bouteille(ouvert,remplissageEnPourcentage,capaciteeEnL);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void VerifieInstanciationObjetBouteilleRemplissageNegatif()
		{
			bool ouvert = false;
			float remplissageEnPourcentage = -5;
			float capaciteeEnL = 1;

			Bouteille bouteille = new Bouteille(ouvert, remplissageEnPourcentage, capaciteeEnL);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void VerifieInstanciationObjetBouteilleCapacite()
		{
			bool ouvert = false;
			float remplissageEnPourcentage = 100;
			float capaciteeEnL = -1;

			Bouteille bouteille = new Bouteille(ouvert, remplissageEnPourcentage, capaciteeEnL);
		}
	}
}