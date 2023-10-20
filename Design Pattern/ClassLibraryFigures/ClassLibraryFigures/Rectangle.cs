using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFigures
{
	public class Rectangle : Figure
	{
		private double largeur;
		private double longueur;

		public Rectangle(double largeur, double longueur, double x,double y) : base (x,y)
		{
			this.largeur = largeur;
			this.longueur = longueur;
		}

		public double Largeur { get => largeur; /*set => largeur = value;*/ }
		public double Longueur { get => longueur; /*set => longueur = value;*/ }

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
