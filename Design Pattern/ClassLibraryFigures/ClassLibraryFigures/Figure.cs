namespace ClassLibraryFigures
{
	public abstract class Figure 
	{
		protected double x;
		protected double y;

		public double X { get => x; /*set => x = value;*/ }
		public double Y { get => y; /*set => y = value;*/ }

		public Figure(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		public abstract void Accept(IVisiteurDeFigure visiteur);

		public abstract T Accept<T>(IVisiteurDeFigureGenerique<T> v);

		public abstract string Accept(IVisiteurDeFigureGenerique<string> v);

	}
}