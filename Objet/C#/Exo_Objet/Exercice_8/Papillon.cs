using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_8
{
    public class Papillon : StadeEvolution
    {
        public Papillon()
        {

        }
        public override string SeDeplacer()
        {
            return "je vole ou je marche";
        }
        public override StadeEvolution SeMetamorphoser()
        {
            return this;
        }
    }
}
