using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClassFigure
{
    public class Rectangle : Figure
    {
        private double width;
        private double length;

        public Rectangle(double width, double length, double x, double y) : base(x, y)
        {
            this.width = width;
            this.length = length;
        }
        public override string ToString()
        {
            return base.ToString() + " largeur" + width + " longeur" + length + "\n";

        }

        public override void Draw()
        {
            Console.WriteLine("Le rectangle a une largeur de " + this.width + " et une longueur de " + this.length);
        }
    }
}
