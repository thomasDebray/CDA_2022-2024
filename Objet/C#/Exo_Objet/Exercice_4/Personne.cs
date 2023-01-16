using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_4
{
    public abstract class Personne
    {
        public int age;

        public void DanserDisco()
        {
        }

        public abstract void DanserSalon();

        public virtual void Marcher()
        {
        }
    }
}
