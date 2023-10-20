using ClassLibraryFigures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppFigure
{
	public class ClassVisiteurDeFigurePourWinform : IVisiteurDeFigure
	{
		private Graphics graphics;

		public ClassVisiteurDeFigurePourWinform(Graphics graphics)
		{
			this.graphics = graphics;
		}

		public void Visit(Cercle cercle)
		{
			graphics.DrawEllipse(new Pen(Brushes.DeepSkyBlue),(float)cercle.X,(float)cercle.Y,(float)cercle.Rayon,(float)cercle.Rayon);
		}

		public void Visit(ClassLibraryFigures.Rectangle rectangle)
		{
			graphics.DrawRectangle(new Pen(Brushes.DeepSkyBlue),(float)rectangle.X,(float)rectangle.Y,(float)rectangle.Largeur,(float)rectangle.Longueur);
		}

		public void Visit(Figures figures)
		{
			
		}
	}
}
