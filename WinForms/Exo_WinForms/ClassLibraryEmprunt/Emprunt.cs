using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEmprunt
{
    public class Emprunt
    {
        private string nom;
        private int capitalEmprunte;
        private int dureeMoisRemboursement;
        //private int nombreRemboursement;
        //private double montantRemboursement;
        private Dictionary<int, bool> periodiciteRemboursement;
        private Dictionary<int, bool> tauxInteret;

        public Emprunt()
        {
            this.nom = "";

            this.periodiciteRemboursement = new Dictionary<int, bool>();
            this.periodiciteRemboursement.Add(12, true);
            this.periodiciteRemboursement.Add(6, false);
            this.periodiciteRemboursement.Add(4, false);
            this.periodiciteRemboursement.Add(2, false);
            this.periodiciteRemboursement.Add(1, false);

            this.tauxInteret = new Dictionary<int, bool>();
            this.tauxInteret.Add(7, true);
            this.tauxInteret.Add(8, false);
            this.tauxInteret.Add(9, false);

            this.dureeMoisRemboursement = 1;

            //this.nombreRemboursement = 1;
            
        }

        public string Nom { get { return this.nom; } set { this.nom = value; } }
        public int CapitalEmprunte { get { return this.capitalEmprunte; } set { this.capitalEmprunte = value; } }
        public int DureeMoisRemboursement { get { return this.dureeMoisRemboursement; } set { this.dureeMoisRemboursement = value; } }
        //public int NombreRemboursement { get { return this.nombreRemboursement; } set { this.nombreRemboursement = value; } }
        //public double MontantRemboursement { get { return this.montantRemboursement; } /*set { this.montantRemboursement = value; }*/ }
        public Dictionary<int, bool> PeriodiciteRemboursement { get { return this.periodiciteRemboursement; } set { this.periodiciteRemboursement = value; } }
        public Dictionary<int, bool> TauxInteret { get { return this.tauxInteret; } set { this.tauxInteret = value; } }
        public void SelectionPeriodicite(int index)
        {
            this.periodiciteRemboursement[this.periodiciteRemboursement.FirstOrDefault(x => x.Value).Key] = false;
            this.PeriodiciteRemboursement[this.periodiciteRemboursement.ElementAt(index).Key] = true;
        }
        public void SelectionTaux(int index)
        {
            this.tauxInteret[this.tauxInteret.FirstOrDefault(x => x.Value).Key] = false;
            this.tauxInteret[this.tauxInteret.ElementAt(index).Key] = true;
        }

        public int CalculerNombreRemboursement()
        {
            return this.dureeMoisRemboursement / (12 / this.periodiciteRemboursement.FirstOrDefault(x => x.Value).Key);
        }
        public double CalculerMontantRemboursement()
        {
            double taux = (double)this.tauxInteret.FirstOrDefault(x => x.Value).Key/100;
            double frequenceAnnuelle = this.periodiciteRemboursement.FirstOrDefault(x => x.Value).Key;

			return (double)Math.Round((double)this.capitalEmprunte * ((taux / frequenceAnnuelle) / 
                (1d - (double)(1f/Math.Pow(1d + (taux /frequenceAnnuelle),CalculerNombreRemboursement())))),2);
        }
        
    }
}
