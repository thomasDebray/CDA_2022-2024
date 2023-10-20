using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    public abstract class Container
    {
        private string text = "";

        public string Text { get { return text; } set { text = value; } }

        //renvoi le texte
        public virtual string SetText()
        {
            return text;
        }

    }
}
