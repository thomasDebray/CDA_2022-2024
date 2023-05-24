namespace ClassLibraryTransaction
{
    public class Transaction
    {
        private string nom;
        private string date;
        private string montant;
        private string cp;

        public Transaction(string _nom, string _date,string _montant,string _cp)
        {
            this.nom = _nom;
            this.date = _date;
            this.montant = _montant;
            this.cp = _cp;
        }

        public string Nom { get { return nom; } }
        public string Date { get { return this.date; } }
        public string Montant { get { return this.montant; } }
        public string Cp { get { return this.cp; } }
    }
}