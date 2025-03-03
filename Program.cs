using RestSharp;

namespace BusBoardApp
{
    class Program
    {
        public static async Task Main() {
            List<ArrivalBus> allArrivalBuses = await TflClient.GetStopPointArrivals();
            foreach (ArrivalBus arrivalBus in allArrivalBuses) {
                Console.WriteLine($"Line Id: {arrivalBus.lineId}");
                Console.WriteLine($"Time to station: {arrivalBus.timeToStation}");
            }
        }
    }
}
