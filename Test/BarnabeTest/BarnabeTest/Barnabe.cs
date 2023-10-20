using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarnabeTest
{
	public class Barnabe
	{
		public static int NombreDeMagasin(double _sous)
		{
			bool course = true;
			int nombreDeMagasin = 0;
			double depense;

			while (course == true)
			{
				depense = (_sous / 2) + 1;
				if (_sous - depense >= 0)
				{
					nombreDeMagasin++;
					_sous = _sous - depense;
				}
				else if (_sous >= 1)
				{
					nombreDeMagasin++;
					_sous = _sous - _sous;
					course = false;
				}
				else
					course = false;

			}
			return nombreDeMagasin;
		}
	}
}
