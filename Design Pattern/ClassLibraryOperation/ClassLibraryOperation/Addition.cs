using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOperation
{
	public class Addition : Binaire
	{
		public Addition(Expression operant1, Expression operant2) : base(operant1, operant2)
		{	
		}

		public override double Evalue()
		{
			return sonExpressionDeGauche.Evalue() + sonExpressionDeDroite.Evalue();
		}
	}
}
