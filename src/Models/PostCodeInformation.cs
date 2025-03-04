using System.Net.Http.Headers;
using Microsoft.VisualBasic;

namespace BusBoardApp
{
    class PostCodeInformation
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public PostCodeInformation(double longitude, double latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }
    }
}