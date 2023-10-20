using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetiers
{
    /// <summary>
    /// Classe représentant un service de localisation
    /// </summary>
    public class GeoLookupService
    {
        /// <summary>
        /// Méthode qui à partir d'un nom de ville renvoie ses coordonnées géographiques
        /// </summary>
        /// <param name="_city"></param>
        /// <returns>Les coordonnnées de la ville de Mulhouse</returns>
        public Location GetLocationByCity(string _city)
        {
            return new Location(7.335888,47.750839);
        }
    }
}
