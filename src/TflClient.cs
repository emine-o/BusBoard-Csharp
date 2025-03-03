
using RestSharp;

namespace BusBoardApp
{
    class TflClient
    {
        private static readonly RestClientOptions options = new RestClientOptions("https://api.tfl.gov.uk/StopPoint");
        private static readonly RestClient arrivalBusClient = new RestClient(options);
        public static async Task<List<ArrivalBus>> GetStopPointArrivals()
        {
            var request = new RestRequest("/490008660N/Arrivals");
            var response = await arrivalBusClient.GetAsync<List<ArrivalBus>>(request);
            if (response == null) {
                throw new Exception("Tfl API error");
            }
            return response;
        }
    }
}
