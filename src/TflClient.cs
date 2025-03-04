
using RestSharp;

namespace BusBoardApp
{
    class TflClient
    {
        private static readonly RestClientOptions options = new RestClientOptions("https://api.tfl.gov.uk/StopPoint");
        private static readonly RestClient arrivingBusClient = new RestClient(options);
        public static async Task<List<ArrivingBus>> GetStopPointArrivals(string stopCode)
        {
            var request = new RestRequest($"/{stopCode}/Arrivals");
            var response = await arrivingBusClient.GetAsync<List<ArrivingBus>>(request);
            if (response == null) {
                throw new Exception("Tfl API error");
            }
            return response;
        }
    }
}
