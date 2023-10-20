using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFigures
{
	public class VisiteurDeFigurePourConcatenation : IVisiteurDeFigureGenerique<string>
	{
		public string Visit(Cercle cercle)
		{
			return "cercle";
		}

		public string Visit(Rectangle rectangle)
		{
			return "rectangle";
		}

		public string Visit(Figures figures)
		{
			return "figures";
		}
	}
}
