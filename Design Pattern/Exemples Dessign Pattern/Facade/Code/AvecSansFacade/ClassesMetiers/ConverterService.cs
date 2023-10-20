using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetiers
{
    /// <summary>
    /// Classe offrant un service de conversion de température
    /// </summary>
    public class ConverterService
    {
        /// <summary>
        /// Méthode convertissant une température d'unité fahrenheit en degré celcius arrondie au dixième
        /// </summary>
        /// <param name="_f"></param>
        /// <returns>La température en degré celcius</returns>
        public double ConvertFtoC(double _f) => Math.Round((_f - 32) * 5 / 9,1);
    }
}
