namespace BusBoardApp
{
    class NextFiveArrivalGetter
    {
        public static async Task<List<ArrivingBus>> GetNextFiveArrivingBuses()
        {
            List<ArrivingBus> allArrivingBuses = await TflClient.GetStopPointArrivals();
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