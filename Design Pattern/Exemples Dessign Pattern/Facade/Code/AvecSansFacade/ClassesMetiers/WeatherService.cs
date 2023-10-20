using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetiers
{
    /// <summary>
    /// Classe offrant un service de météorologie
    /// </summary>
    public class WeatherService
    {
        /// <summary>
        /// Méthode qui à partir d'une localisation donne la température de ce lieu en degré fahrenheit (aléatoire)
        /// </summary>
        /// <param name="_location"></param>
        /// <returns>Une température en degré fahrenheit</returns>
        public double GetCurrentTemperatureF(Location _location) 
        {
            double r = new Random().NextDouble();
            return r * (131 - 5) + 5;
        } 
    }
}
