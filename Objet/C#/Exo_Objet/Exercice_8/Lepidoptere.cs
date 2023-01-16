using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_8
{
    public class Lepidoptere
    {
        public StadeEvolution stadeCourant;

        public Lepidoptere()
        {
            stadeCourant = new Oeuf();
        }
     
        public string SeDeplacer()
        {
            return stadeCourant.SeDeplacer();
        }
        public void SeMetamorphoser()
        {
            stadeCourant = stadeCourant.SeMetamorphoser();
        }
    }
}
