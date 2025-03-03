using RestSharp;

namespace BusBoardApp
{
    class ArrivingBus
    {
        public required string LineId { get; set; }
        public required int TimeToStation { get; set; }
    }
}