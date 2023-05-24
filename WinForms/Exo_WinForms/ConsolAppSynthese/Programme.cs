using ClassLibraryEmprunt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolAppSynthese
{

    public class Programme
    {
        public static void Main(string[] args)
        {
            Emprunt monEmprunt;
            monEmprunt = new Emprunt();

            Console.WriteLine(monEmprunt.CalculerNombreRembousement());
        }
    }
}
