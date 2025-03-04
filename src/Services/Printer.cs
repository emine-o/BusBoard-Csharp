namespace BusBoardApp
{
    class Printer
    {
        public static async Task PrintNextFiveBuses(string stopId)
        {
            List<ArrivingBus> arrivingBuses = await NextFiveArrivalGetter.GetNextFiveArrivingBuses(stopId);
            foreach (ArrivingBus arrivingBus in arrivingBuses)
            {
                Console.WriteLine($"Bus: {arrivingBus.LineId}, ETA: {arrivingBus.TimeToStation/60} min");
            }
        }
        
        public static async Task PrintNextFiveBusesForNearestStops(string postCode)
        {
            List<NearestStopPoints> nearestStopPoints = await NearestStopPointsGetter.GetNearestStopPoints(postCode);
            foreach (NearestStopPoints stopPoint in nearestStopPoints)
            {
                Console.WriteLine($"\nStop Name: {stopPoint.CommonName}, ID: {stopPoint.NaptanId}");
                await PrintNextFiveBuses(stopPoint.NaptanId);
            }
        }
    }
}