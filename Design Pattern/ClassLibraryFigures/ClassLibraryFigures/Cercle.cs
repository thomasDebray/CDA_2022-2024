using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFigures
{
	public class Cercle : Figure
	{
		private double rayon;

		public double Rayon { get => rayon; /*set => rayon = value;*/ }

		public Cercle(double _rayon,double _x,double _y) : base(_x,_y)
		{
			this.rayon = _rayon;
		}
		public override void Accept(IVisiteurDeFigure visiteur)
		{
			visiteur.Visit(this);
		}
		public override T Accept<T>(IVisiteurDeFigureGenerique<T> v)
		{
			return v.Visit(this);
		}

		public override string Accept(IVisiteurDeFigureGenerique<string> v)
		{
			return v.Visit(this);
		}

	}
}
