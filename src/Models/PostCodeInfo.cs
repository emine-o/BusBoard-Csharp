namespace BusBoardApp
{
    class PostCodeInfo
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public PostCodeInfo(double longitude, double latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }
    }

    class PostCodeResult
    {
        public PostCodeInfo Result { get; set; }
    }
}
