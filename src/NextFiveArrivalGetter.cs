namespace BusBoardApp
{
    class NextFiveArrivalGetter
    {
        public static async Task<List<ArrivingBus>> GetNextFiveArrivingBuses(string stopCode)
        {
            List<ArrivingBus> allArrivingBuses = await TflClient.GetStopPointArrivals(stopCode);
            allArrivingBuses.Sort((x, y) => x.TimeToStation.CompareTo(y.TimeToStation));
            List<ArrivingBus> nextFiveBusList = new List<ArrivingBus>{};

            foreach (ArrivingBus arrivingBus in allArrivingBuses.Take(5))
            {
                nextFiveBusList.Add(new ArrivingBus(arrivingBus.LineId, arrivingBus.TimeToStation));
            }
            return nextFiveBusList;
        }
    }
}