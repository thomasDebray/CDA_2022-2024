using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleMediateurPourThomas
{
    public abstract class Personne
    {
        protected string name;
        public string Name { get => name; }

        protected Mediator sonMediator;
        public Personne(Mediator mediator, string name)
        {
            sonMediator = mediator;
            this.name = name;
            
        }

    }
}
