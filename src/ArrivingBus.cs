using RestSharp;

namespace BusBoardApp
{
    class ArrivingBus
    {
        public string LineId { get; set; }
        public int TimeToStation { get; set; }

        public ArrivingBus(string lineId, int timeToStation)
        {
            LineId = lineId;
            TimeToStation = timeToStation;
        }
    }
}