using System.Threading.Tasks;
using RestSharp;

namespace BusBoardApp
{
    class Program
    {
        public static async Task Main()
        {
            string userPostCode = UserInput.GetUsersPostCodeInput();
            await Printer.PrintNextFiveBusesForNearestStops(userPostCode);
        }
    }
}
