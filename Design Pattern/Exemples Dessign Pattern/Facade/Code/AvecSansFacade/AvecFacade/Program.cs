namespace AvecFacade
{
    /// <summary>
    /// Avec façade, le client n'a qu'à instancier la façade qu'il souhaite. 
    /// Il en résulte une facilité dans l'utilisation et la maintenabilité. 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //Le client instancie de la façade
            WeatherServiceFacade facade = new WeatherServiceFacade();

            //La façade gère les appels nécessaires au renvoi de la température de la ville
            double c = facade.GetCurrentTemperatureByCity("Mulhouse");

            Console.WriteLine("Température : " + c + "°C");
        }
    }
}