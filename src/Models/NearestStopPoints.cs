namespace BusBoardApp
{
    class NearestStopPoints
    {
        public string NaptanId { get; set; }
        public string CommonName { get; set; }
    }

    class LonLatResult
    {
        public List<NearestStopPoints> StopPoints { get; set; }
    }
}