using ClassLibraryFigures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFigure
{
	public class VisiteurDeFigurePourConsole : IVisiteurDeFigure
	{
		public VisiteurDeFigurePourConsole() { }
		public void Visit(Cercle cercle)
		{
			Console.WriteLine("Je suis un cercle à la position " + cercle.X + "," + cercle.Y + " et j'ai un rayon de " + cercle.Rayon);
		}

		public void Visit(Rectangle rectangle)
		{
			Console.WriteLine("Je suis un rectangle à la position " + rectangle.X + "," + rectangle.Y + " j'ai une largeur de " + rectangle.Largeur + " et une lougueur de " + rectangle.Longueur);
		}

		public void Visit(Figures figures)
		{
			Console.WriteLine("Je suis un ensemble de figures à la position " + figures.X + "," + figures.Y);
		}
	}
}
