using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMemento
{
    public class Transaction : ICloneable
    {

        private CompteBancaire compteDebite;
        private CompteBancaire compteCredite;
        private double montant;
        

        public Transaction(CompteBancaire _compteDebite, CompteBancaire _compteCredite, double _montant)
        {
            this.compteDebite = _compteDebite;
            this.compteCredite = _compteCredite;
            this.montant = _montant;
        }

        public Transaction(Transaction from) : this((CompteBancaire)from.compteDebite.Clone(),
            (CompteBancaire)from.compteCredite.Clone(), 
            from.montant) { }

        public bool ExecuterTransaction()
        {
            return compteDebite.Debiter(montant) && compteCredite.Crediter(montant);
        }

        public object Clone()
        {
            return new Transaction(this);
        }
    }
}
