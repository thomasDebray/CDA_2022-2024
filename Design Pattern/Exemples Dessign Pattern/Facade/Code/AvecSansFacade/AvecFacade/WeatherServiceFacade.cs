using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesMetiers;

namespace AvecFacade
{
    /// <summary>
    /// Façade du service météo
    /// </summary>
    internal class WeatherServiceFacade : IWeatherServiceFacade
    {
        /// <summary>
        /// Service de localisation
        /// </summary>
        private GeoLookupService geo;
        /// <summary>
        /// Service météo
        /// </summary>
        private WeatherService service;
        /// <summary>
        /// Service de conversion
        /// </summary>
        private ConverterService converter;
        /// <summary>
        /// Constructeur de la façade
        /// </summary>
        public WeatherServiceFacade()
        {
            this.geo = new GeoLookupService();
            this.service = new WeatherService();
            this.converter = new ConverterService();
        }
        /// <summary>
        /// Méthode qui à partir d'un nom de ville retourne sa température en degré celcius
        /// </summary>
        /// <param name="city"></param>
        /// <returns>La température en degré celcius</returns>
        public double GetCurrentTemperatureByCity(string city)
        {
            Location loc = this.geo.GetLocationByCity(city);
            double f = service.GetCurrentTemperatureF(loc);
            return converter.ConvertFtoC(f);
        }
    }
}
