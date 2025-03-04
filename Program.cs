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

            LonLatResult lonLatResult = await TflClient.GetNearestStopPoints(51.553935, -0.144754);
            List<NearestStopPoints> stopPointList = lonLatResult.StopPoints;

            foreach (NearestStopPoints item in stopPointList)
            {
                Console.WriteLine($"Stop id: {item.NaptanId}, Stop name: {item.CommonName}");
            }
        }
    }
}
