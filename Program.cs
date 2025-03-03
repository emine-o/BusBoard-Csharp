using RestSharp;

namespace BusBoardApp
{
    class Program
    {
        public static async Task Main()
        {
            List<ArrivingBus> allArrivingBuses = await TflClient.GetStopPointArrivals();
            allArrivingBuses.Sort((x, y) => x.TimeToStation.CompareTo(y.TimeToStation));
            foreach (ArrivingBus arrivingBus in allArrivingBuses.Take(5)) {
                Console.WriteLine($"Line Id: {arrivingBus.LineId}");
                Console.WriteLine($"Time to station: {arrivingBus.TimeToStation}");
            }
        }
    }
}
