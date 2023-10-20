using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOperation
{
	public class Soustraction : Binaire
	{
		public Soustraction(Expression operant1, Expression operant2) : base(operant1, operant2)
		{
		}

		public override double Evalue()
		{
			return sonExpressionDeGauche.Evalue() - sonExpressionDeDroite.Evalue();
		}
	}
}
