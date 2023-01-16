using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_8
{
    public class Oeuf : StadeEvolution
    {
        public Oeuf()
        {
        }

        public override string SeDeplacer()
        {
            return "je reste sur place";
        }
        public override StadeEvolution SeMetamorphoser()
        {
            return new Chenille();
        }
    }
}
