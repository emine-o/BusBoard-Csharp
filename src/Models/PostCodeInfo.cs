namespace BusBoardApp
{
    class PostCodeInfo
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public PostCodeInfo(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }

    class PostCodeResult
    {
        public PostCodeInfo Result { get; set; }
    }
}
