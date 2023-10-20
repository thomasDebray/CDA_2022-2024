using ExempleCommand;
using ExempleCommand.Cartes;

namespace TestUnitaires
{
    [TestClass]
    public class TestUnitairePersonnage
    {
        [TestMethod]
        public void Personnage_Instanciation()
        {
            Personnage p = new Personnage(10, 15, new Carte(8, 8)); ;
            Assert.IsTrue(p.X == 10, "Mauvaise position x");
            Assert.IsTrue(p.Y == 15, "Mauvaise position y");
        }

        [TestMethod]
        public void Personnage_X2_DeplacerAGauche2_RetourOK_ChangementPosition()
        {
            Personnage p = new Personnage(2, 0, new Carte(8,8));
            bool rt = p.DeplacerAGauche(2);
            Assert.IsTrue(rt, "Mauvais retour");
            Assert.IsTrue(p.X==0, "Mauvaise position finale");
        }

        [TestMethod]
        public void Personnage_X2_DeplacerAGauche3_RetourFalse_PasDeChangement()
        {
            Personnage p = new Personnage(2, 0, new Carte(8,8));
            bool rt = p.DeplacerAGauche(3);
            Assert.IsFalse(rt, "Mauvais retour");
            Assert.IsTrue(p.X == 2, "Mauvaise position finale");
        }





    }
}