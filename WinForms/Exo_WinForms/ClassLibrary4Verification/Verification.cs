using System.Text.RegularExpressions;

namespace ClassLibrary4Verification
{
    public static class Verification
    {
        public static bool ElementValide(string element)
        {
            System.Text.RegularExpressions.Regex maRegex = new Regex(@"^[A-Za-z0-9]{1,29}(\-[A-Za-z0-9]{1,29})?");
            return maRegex.IsMatch(element);
        }
    }
}