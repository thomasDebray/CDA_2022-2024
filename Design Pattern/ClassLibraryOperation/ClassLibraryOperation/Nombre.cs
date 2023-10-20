using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOperation
{
	public class Nombre : Expression
	{
		double valeur;
		public Nombre(double _valeur)
		{
			this.valeur = _valeur;
		}

		public override double Evalue()
		{
			return this.valeur;
		}
	}
}
