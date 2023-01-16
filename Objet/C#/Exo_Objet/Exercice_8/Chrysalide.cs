using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_8
{
    public class Chrysalide : StadeEvolution
    {
        public Chrysalide()
        {

        }
        public override string SeDeplacer()
        {
            return "je ne me déplace pas";
        }
        public override StadeEvolution SeMetamorphoser()
        {
            return new Papillon();
        }
    }
}
