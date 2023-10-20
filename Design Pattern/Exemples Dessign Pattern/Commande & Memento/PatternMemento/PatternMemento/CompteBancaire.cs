using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMemento
{
    public class CompteBancaire : ICloneable
    {

        private double solde;
        private double decouvertAutorise; // DOIT ETRE NEGATIF
        private bool estUnLivretA;
        private static double MAX_LIVRET_A = 22950;
        public CompteBancaire(double solde, double decouvertAutorise, bool estUnLivretA)
        {
            if (decouvertAutorise > 0)
            {
                throw new Exception("Le decouvret autorisé ne peut pas être positif");
            }
            this.solde = solde;
            this.decouvertAutorise = decouvertAutorise;
            this.estUnLivretA = estUnLivretA;
        }

        public CompteBancaire(CompteBancaire from) : this(from.solde, from.decouvertAutorise, from.estUnLivretA) { }

        public CompteBancaire(double solde) : this(solde,0, false) { }

        public bool Debiter(double montant)
        {
            if (montant < 0)
            {
                throw new Exception("On ne peut pas retirer un montant négatif");
            }
            if(solde - montant >= decouvertAutorise)
            {
                solde -= montant;
                return true;
            }
            return false;
        }

        public bool Crediter(double montant)
        {
            if (montant < 0)
            {
                throw new Exception("Impossible de créditer un montant négatif");
            }
            if (estUnLivretA && solde + montant > MAX_LIVRET_A)
            {
                return false;
            }
            solde += montant;
            return true;
        }

        public object Clone()
        {
            return new CompteBancaire(this);
        }
    }
}
