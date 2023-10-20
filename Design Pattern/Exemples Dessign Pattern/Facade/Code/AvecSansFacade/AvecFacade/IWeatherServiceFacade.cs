using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvecFacade
{
    /// <summary>
    /// Interface que toutes les façades de service météo se doivent de réaliser
    /// </summary>
    internal interface IWeatherServiceFacade
    {
        /// <summary>
        /// Méthode qui à partir d'un nom de ville retourne sa température en degré celcius
        /// </summary>
        /// <param name="city"></param>
        /// <returns>La température en degré celcius</returns>
        public double GetCurrentTemperatureByCity(string city);
    }
}
