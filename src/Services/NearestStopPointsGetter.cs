using System.ComponentModel;

namespace BusBoardApp
{
    class NearestStopPointsGetter
    {
        public static async Task<List<NearestStopPoints>> GetNearestStopPoints(string postCode)
        {
            PostCodeInfo postCodeLonLat = await LonLatGetter.GetLonLatValues(postCode);
            LonLatResult lonLatResult = await TflClient.GetNearestStopPointsResult(postCodeLonLat.Latitude, postCodeLonLat.Longitude);
            List<NearestStopPoints> stopPointList = lonLatResult.StopPoints;
            return stopPointList;
        }
    }
}