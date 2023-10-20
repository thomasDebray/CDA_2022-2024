using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClassFigure
{
    public abstract class Figure
    {
        protected double x;
        protected double y;

        public Figure(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()=> " x"+x + " y"+y + "\n";

        public abstract void Draw();

        
    }
}
