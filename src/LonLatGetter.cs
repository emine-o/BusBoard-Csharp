namespace BusBoardApp
{
    class LonLatGetter
    {
        public static async Task<PostCodeInfo> GetLonLatValues()
        {
            PostCodeResult postCodeResult = await PostCodeClient.GetPostCodeInformation();
            PostCodeInfo postCodeLonLat = new PostCodeInfo(postCodeResult.Result.Longitude, postCodeResult.Result.Latitude);
            return postCodeLonLat;
        }
    }
}