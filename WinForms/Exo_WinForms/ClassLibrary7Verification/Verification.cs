using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary7Verification
{
    public static class Verification
    {
        public static bool NomValide(string nom)
        {
            Regex maRegex = new Regex(@"^[A-Za-z]{1,29}$");
            return maRegex.IsMatch(nom);
        }
        public static bool MontantValide(string montant)
        {
            Regex maRegex = new Regex(@"^[0-9]{1,10}$");
            return maRegex.IsMatch (montant);
        }
    }
}
