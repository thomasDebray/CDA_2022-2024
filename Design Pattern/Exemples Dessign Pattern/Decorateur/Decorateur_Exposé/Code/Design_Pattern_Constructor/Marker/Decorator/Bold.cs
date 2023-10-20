using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text.Decorator
{
    public class Bold : Decorator
    {

        public Bold(Container objectToDecorate) : base(objectToDecorate)
        {

        }

        //ajoute la balise b au texte
        public override string SetText()
        {
            return "<b>" + base.SetText() + "</b>";
        }

    }
}
