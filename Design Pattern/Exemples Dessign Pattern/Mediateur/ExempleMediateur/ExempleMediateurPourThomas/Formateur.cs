using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleMediateurPourThomas
{
    public class Formateur : Personne
    {



        public Formateur(Mediator mediator, string name) : base(mediator, name)
        {
        }

        public void DireBonjour()
        {
            Console.WriteLine("Formateur " + name + " dis bonjour a sa classe");
            sonMediator.SaluerEleve(this);
        }

    }
}
