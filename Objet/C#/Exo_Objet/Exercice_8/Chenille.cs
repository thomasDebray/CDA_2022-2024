using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_8
{
    public class Chenille : StadeEvolution
    {
        public Chenille()
        {

        }
        public override string SeDeplacer()
        {
            return "je rampe";
        }
        public override StadeEvolution SeMetamorphoser()
        {
            return new Chrysalide();
        }
    }
}
