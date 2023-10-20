using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text.Decorator
{
    public abstract class Decorator : Container
    {
        protected Container objectToDecorate;

        //constructeur avec un container en paramètre
        public Decorator(Container _objectToDecorate)
        {
            //On ajoute affecte le container envoyé en paramètre à l'objet container de la classe
            this.objectToDecorate = _objectToDecorate;
        }

        //renvoi le texte de l'objet à décorer
        public override string SetText()
        {
            return objectToDecorate.SetText();
        }
    }
}
