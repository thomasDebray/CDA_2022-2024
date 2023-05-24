using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOutils
{
	public static class Outils
	{
		private static Random aleatoire = new Random();
		public  static int Interval(int cadence)
		{
			return (3600000 / cadence)/360;
		}
		public static int PileOuFace()
		{
			int pileOuFace = aleatoire.Next(2);
			return pileOuFace;
		}
		//public static int NbIntervalHeure(int interval)
		//{
		//	return 3600000 / interval;
		//}
		//public static double Taux(int NbDefaut,int NbTotal)
		//{
		//	if (NbDefaut==0)
		//	{
		//		return 0;
		//	}
		//	return (NbDefaut * 100d) / NbTotal;
		//}

	}
}
