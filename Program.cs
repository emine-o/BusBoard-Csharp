using System.Threading.Tasks;
using RestSharp;

namespace BusBoardApp
{
    class Program
    {
        public static async Task Main()
        {
            await NextFiveArrivalGetter.GetNextFiveArrivingBuses();
        }
    }
}
