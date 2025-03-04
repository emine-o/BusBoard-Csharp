using System.Threading.Tasks;
using RestSharp;

namespace BusBoardApp
{
    class Program
    {
        public static async Task Main()
        {
            // Console.WriteLine("Enter the stop code: ");
            // string userStopCode = Console.ReadLine();
            
            // List<ArrivingBus> nextFiveBuses = await NextFiveArrivalGetter.GetNextFiveArrivingBuses(userStopCode);
            // foreach (ArrivingBus bus in nextFiveBuses)
            // {
            //     Console.WriteLine($"Line Id: {bus.LineId}");
            //     Console.WriteLine($"Time to station: {bus.TimeToStation / 60} min");
            // }
            PostCodeResult response = await PostCodeClient.GetPostCodeInformation();
            Console.WriteLine($"Longitude: {response.Result.Longitude}, Latitude: {response.Result.Latitude}");
        }
    }
}
