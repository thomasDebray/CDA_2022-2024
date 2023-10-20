using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu1
{
	public class De
	{
		private Random random;

		public De()
		{
			random = new Random();
		}

		public int Lance()
		{
			return random.Next(1, 7);
		}
	}
}
