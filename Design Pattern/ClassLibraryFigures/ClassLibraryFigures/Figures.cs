using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFigures
{
	public class Figures : Figure
	{
		private List<Figure> sesFigures;

		public Figures(List<Figure> sesFigures,double x,double y) : base (x,y)
		{
			this.sesFigures = sesFigures;
		}

		public Figures(double x, double y) : base(x, y)
		{
			this.sesFigures = new List<Figure>();
		}

		public override void Accept(IVisiteurDeFigure visiteur)
		{
			visiteur.Visit(this);

			foreach (Figure f in sesFigures) 
			{
				f.Accept(visiteur);
			}
		}

		public void Remove(Figure figure)
		{
			sesFigures.Remove(figure);
		}

		public void Add(Figure figure)
		{
			sesFigures.Add(figure);
		}

		public override T Accept<T>(IVisiteurDeFigureGenerique<T> v)
		{
			return v.Visit(this);
		}

		public override string Accept(IVisiteurDeFigureGenerique<string> v)
		{
			string concatenation = "";
			v.Visit(this);
			foreach (Figure f in sesFigures)
			{
				concatenation += f.Accept(v);
			}
			return concatenation;
		}
	}
}
