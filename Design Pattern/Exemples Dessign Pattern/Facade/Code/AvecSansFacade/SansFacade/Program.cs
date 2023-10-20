using ClassesMetiers;

namespace SansFacade
{
    /// <summary>
    /// Sans façade, le client doit lui-même géré les instanciations et les appels de méthode. 
    /// Il en résulte une complexité pour le client et à terme une maintenabilité difficile. 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //Le client instancie tous les services
            GeoLookupService geo = new GeoLookupService();
            WeatherService service = new WeatherService();
            ConverterService converter = new ConverterService();

            //Le client gère lui-même les appels de méthodes
            Location loc = geo.GetLocationByCity("Mulhouse");
            double f = service.GetCurrentTemperatureF(loc);
            double c = converter.ConvertFtoC(f);

            Console.WriteLine("Température : " + c + "°C");
        }
    }
}