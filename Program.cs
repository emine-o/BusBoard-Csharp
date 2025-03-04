using System.Threading.Tasks;
using RestSharp;

namespace BusBoardApp
{
    class Program
    {
        public static async Task Main()
        {
            string userPostCode = UserInput.GetUsersPostCodeInput();
            List<NearestStopPoints> nearestStopPoints = await NearestStopPointsGetter.GetNearestStopPoints(userPostCode);
            foreach (NearestStopPoints stopPoint in nearestStopPoints)
            {
                Console.WriteLine($"Stop name: {stopPoint.CommonName}, Stop id: {stopPoint.NaptanId}");
            }
        }
    }
}
