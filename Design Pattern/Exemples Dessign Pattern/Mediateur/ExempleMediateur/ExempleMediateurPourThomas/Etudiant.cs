using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleMediateurPourThomas
{
    public class Etudiant : Personne
    {
        public Etudiant(Mediator mediator, string name) : base(mediator, name)
        {
        }

        public  void RepondreBonjour(Formateur f)
        {
            Console.WriteLine("Etudiant " + name + " dis bonjour a " + f.Name);
        }
    }
}
