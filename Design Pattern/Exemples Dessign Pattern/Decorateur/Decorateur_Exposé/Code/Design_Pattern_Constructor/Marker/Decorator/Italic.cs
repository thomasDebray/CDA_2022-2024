using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text.Decorator
{
    public class Italic : Decorator
    {
        public Italic(Container objectToDecorate) : base(objectToDecorate)
        {

        }

        //ajoute la balise i au texte

        public override string SetText()
        {
            return "<i>"+base.SetText()+"</i>";
        }

        //ajoute une fonction dynamiquement
        public void DoItalicThings()
        {
            Console.WriteLine("Je suis Italic !");
        }
    }
}
