using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFigures
{
	public interface IVisiteurDeFigure
	{
		public abstract void Visit(Cercle cercle);

		public abstract void Visit(Rectangle rectangle);

		public abstract void Visit(Figures figures);
	
	}
}
