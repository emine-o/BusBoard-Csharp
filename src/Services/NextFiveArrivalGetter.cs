namespace BusBoardApp
{
    class NextFiveArrivalGetter
    {
        public static async Task<List<ArrivingBus>> GetNextFiveArrivingBuses(string stopId)
        {
            List<ArrivingBus> allArrivingBuses = await TflClient.GetStopPointArrivals(stopId);
            allArrivingBuses.Sort((x, y) => x.TimeToStation.CompareTo(y.TimeToStation));
            return allArrivingBuses.Take(5).ToList();
        }
    }
}