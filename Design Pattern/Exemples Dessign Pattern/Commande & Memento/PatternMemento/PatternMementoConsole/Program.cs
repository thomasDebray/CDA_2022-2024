using CoucheMemento;
using PatternMemento;


namespace PatternMementoConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire compteADebite = new CompteBancaire(2000, 0, false);
            CompteBancaire compteACredite = new CompteBancaire(22900, 0, true);
            Transaction t = new Transaction(compteADebite, compteACredite, 200.0d);
            ConcreteOriginator ot = new ConcreteOriginator(t);
            Guardian<Transaction> guardian = new Guardian<Transaction>();
            guardian.AjouterMemento(ot.Save());
            if (!t.ExecuterTransaction())
            {
                /* ICI LE COMTE A DEBITE A PERDU DE L'ARGENT MAIS LE COMPTE A CREDITE N'EN A PAS RECU
                 * (Observer le changement en mettant espion sur ot.saTransaction) avant et après Undo */
                guardian.Undo();
            }
        }
    }
}