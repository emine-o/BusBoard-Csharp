namespace BusBoardApp
{
    class LonLatGetter
    {
        public static async Task<PostCodeInfo> GetLonLatValues(string postCode)
        {
            PostCodeResult postCodeResult = await PostCodeClient.GetPostCodeInformation(postCode);
            PostCodeInfo postCodeLonLat = new PostCodeInfo(postCodeResult.Result.Latitude, postCodeResult.Result.Longitude);
            return postCodeLonLat;
        }
    }
}