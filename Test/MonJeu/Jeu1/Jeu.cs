﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu1
{
	public class Jeu
	{
		public Heros Heros { get; }

		public Jeu()
		{
			Heros = new Heros(15);
		}

		public Resultat Tour(int deHeros, int deMonstre)
		{
			if (GagneLeCombat(deHeros, deMonstre))
			{
				Heros.GagneUnCombat();
				return Resultat.Gagne;
			}
			else
			{
				Heros.PerdsUnCombat(deMonstre - deHeros);
				return Resultat.Perdu;
			}
		}

		private bool GagneLeCombat(int de1, int de2)
		{
			return de1 >= de2;
		}
	}
}
