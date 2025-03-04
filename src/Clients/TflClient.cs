
using RestSharp;

namespace BusBoardApp
{
    class TflClient
    {
        private static readonly RestClientOptions options = new RestClientOptions("https://api.tfl.gov.uk/StopPoint");
        private static readonly RestClient stopPointClient = new RestClient(options);

        public static async Task<List<ArrivingBus>> GetStopPointArrivals(string stopCode)
        {
            var request = new RestRequest($"/{stopCode}/Arrivals");
            var response = await stopPointClient.GetAsync<List<ArrivingBus>>(request);
            if (response == null) {
                throw new Exception("Tfl API error");
            }
            return response;
        }

        public static async Task<LonLatResult> GetNearestStopPointsResult(double lat, double lon)
        {
            var request = new RestRequest($"/?lat={lat}&lon={lon}&stopTypes=NaptanPublicBusCoachTram");
            var response = await stopPointClient.GetAsync<LonLatResult>(request);
            if (response == null) {
                throw new Exception("Tfl API error");
            }
            return response;
        }

    }
}
