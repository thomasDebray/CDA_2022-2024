using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text.Decorator
{
    public class Emphasize : Decorator
    {
        public Emphasize(Container objectToDecorate) : base(objectToDecorate)
        {

        }

        //ajoute la balise EM au texte
        public override string SetText()
        {
            return "<em>" + base.SetText() + "</em>";
        }
    }
}
