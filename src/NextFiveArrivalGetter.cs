namespace BusBoardApp
{
    class NextFiveArrivalGetter
    {
        public static async Task GetNextFiveArrivingBuses()
        {
            List<ArrivingBus> allArrivingBuses = await TflClient.GetStopPointArrivals();
            allArrivingBuses.Sort((x, y) => x.TimeToStation.CompareTo(y.TimeToStation));
            if (allArrivingBuses.Count < 5)
            {
                foreach (ArrivingBus arrivingBus in allArrivingBuses)
                {
                    Console.WriteLine($"Line Id: {arrivingBus.LineId}");
                    Console.WriteLine($"Time to station: {arrivingBus.TimeToStation / 60} min");
                }
            }
            else 
            {
                foreach (ArrivingBus arrivingBus in allArrivingBuses.Take(5))
                {
                    Console.WriteLine($"Line Id: {arrivingBus.LineId}");
                    Console.WriteLine($"Time to station: {arrivingBus.TimeToStation / 60} min");
                }
            }
        }
    }
}