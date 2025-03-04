using RestSharp;

namespace BusBoardApp
{
    class PostCodeClient
    {
        private static readonly RestClientOptions options = new RestClientOptions("https://api.postcodes.io/postcodes");
        private static readonly RestClient postCodeClient = new RestClient(options);
        public static async Task GetPostCodeInformation()
        {
            var request = new RestRequest("NW51TL");
            var response = await postCodeClient.GetAsync(request);
            if (response == null) {
                throw new Exception("Tfl API error");
            }
            Console.WriteLine(response.Content);
        }
    }
}
