using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClassFigure
{
    public class Circle : Figure
    {
        private double ray;

        public Circle(double ray, double x, double y) : base(x, y)
        {
            this.ray = ray;
        }

        public override string ToString()
        {
            return base.ToString() + " rayon="+ray +"\n";
        } 

        public override void Draw()
        {
            Console.WriteLine("le cercle a pour rayon " + this.ray);
        }
    }
}
