using ExempleMediateurPourThomas;

namespace ExempleSalleDeClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mediator m = new Mediator();
            Formateur f = new Formateur(m, "Sophie");
            Etudiant e1 = new Etudiant(m, "Thomas");
            Etudiant e2 = new Etudiant(m, "Angelo");
            Etudiant e3 = new Etudiant(m, "Gerard");
            m.AddFormateur(f);
            m.AddEtudiant(e1);
            m.AddEtudiant(e2);
            m.AddEtudiant(e3);
            f.DireBonjour();
        }
    }
}