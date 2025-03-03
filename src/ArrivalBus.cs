using RestSharp;

namespace BusBoardApp
{
    class ArrivalBus
    {
        public required string lineId { get; set; }
        public required int timeToStation { get; set; }

    }
}