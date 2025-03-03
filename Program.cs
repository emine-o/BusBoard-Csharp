using System.Threading.Tasks;
using RestSharp;

namespace BusBoardApp
{
    class Program
    {
        public static async Task Main()
        {
            List<ArrivingBus> nextFiveBuses = await NextFiveArrivalGetter.GetNextFiveArrivingBuses();
            foreach (ArrivingBus bus in nextFiveBuses)
            {
                Console.WriteLine($"Line Id: {bus.LineId}");
                Console.WriteLine($"Time to station: {bus.TimeToStation / 60} min");
            }
        }
    }
}
