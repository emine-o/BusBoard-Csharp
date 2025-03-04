namespace BusBoardApp
{
    class NearestStopPoints
    {
        public string NaptanId { get; set; }
        public string CommonName { get; set; }
        public NearestStopPoints(string naptanid, string commonName)
        {
            NaptanId = naptanid;
            CommonName = commonName;
        }
    }

    class LonLatResult
    {
        public List<NearestStopPoints> StopPoint { get; set; }
    }
}