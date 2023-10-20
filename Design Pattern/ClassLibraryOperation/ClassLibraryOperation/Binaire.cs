using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOperation
{
	public abstract class Binaire:Expression
	{
		protected Expression sonExpressionDeGauche;

		protected Expression sonExpressionDeDroite;
		public Binaire(Expression operant1,Expression operant2)
		{
			this.sonExpressionDeGauche = operant1;
			this.sonExpressionDeDroite = operant2;
		}
	}
}
