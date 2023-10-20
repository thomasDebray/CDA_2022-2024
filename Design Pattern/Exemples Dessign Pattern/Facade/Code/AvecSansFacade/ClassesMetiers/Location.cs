namespace ClassesMetiers
{
    /// <summary>
    /// Classe représentant un couple de coordonnées géographiques
    /// </summary>
    public class Location
    {
        private double longitude;
        private double latitude;
        public Location(double longitude, double latitude)
        {
            this.longitude = longitude;
            this.latitude = latitude;
        }
    }
}