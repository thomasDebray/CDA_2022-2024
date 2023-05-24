using System.Globalization;
using System.Text.RegularExpressions;
namespace ClassLibraryControlesDeSaisie
{
    public class Verification
    {
        public static bool NomValide (string nom)
        {
            System.Text.RegularExpressions.Regex maRegex = new Regex(@"^[A-Z][a-z]{0,29}");
            return maRegex.IsMatch(nom);
        }
        public static bool DateValide (string date)
        {
            DateTime resultat;
            var french = CultureInfo.GetCultureInfo("fr-FR");
            if (DateTime.TryParseExact(date,"dd/MM/yyyy",french,System.Globalization.DateTimeStyles.None,out resultat))
            {
                if (resultat>DateTime.Now)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public static bool MontantValide (string montant)
        {
            System.Text.RegularExpressions.Regex maRegex = new Regex(@"^[0-9]{0,}(\.|\,){0,1}[0-9]{1,}$");
            return maRegex.IsMatch(montant);
        }
        public static bool CPValide (string cp)
        {
            System.Text.RegularExpressions.Regex maRegex = new Regex(@"[0-9]{5}");
            return maRegex.IsMatch(cp);
        }
    }
}