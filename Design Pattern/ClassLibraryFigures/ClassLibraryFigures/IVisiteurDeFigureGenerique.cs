using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFigures
{
	public interface IVisiteurDeFigureGenerique<T>
	{
		public abstract T Visit(Cercle cercle);

		public abstract T Visit(Rectangle rectangle);

		public abstract T Visit(Figures figures);
	}
}
