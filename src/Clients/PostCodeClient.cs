using RestSharp;

namespace BusBoardApp
{
    class PostCodeClient
    {
        private static readonly RestClientOptions options = new RestClientOptions("https://api.postcodes.io");
        private static readonly RestClient postCodeClient = new RestClient(options);
        public static async Task<PostCodeResult> GetPostCodeInformation(string postCode)
        {
            var request = new RestRequest($"postcodes/{postCode}");
            var response = await postCodeClient.GetAsync<PostCodeResult>(request);
            if (response == null) {
                throw new Exception("Tfl API error");
            }
            return response;
        }
    }
}
