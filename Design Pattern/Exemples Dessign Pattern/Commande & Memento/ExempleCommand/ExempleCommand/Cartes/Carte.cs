using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleCommand.Cartes
{
    public class Carte
    {

        private int w;
        private int h;

        public int H { get => h; set => h = value; }
        public int W { get => w; set => w = value; }

        public Carte(int w, int h)
        {
            this.w = w;
            this.h = h;
        }

        
    }
}
