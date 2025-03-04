namespace BusBoardApp
{
    class NextFiveArrivalGetter
    {
        public static async Task<List<ArrivingBus>> GetNextFiveArrivingBuses(string stopCode)
        {
            List<ArrivingBus> allArrivingBuses = await TflClient.GetStopPointArrivals(stopCode);
            allArrivingBuses.Sort((x, y) => x.TimeToStation.CompareTo(y.TimeToStation));
            return allArrivingBuses.Take(5).ToList();
        }
    }
}