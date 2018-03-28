using System.Net.Http;

namespace BusinessLogic.Http
{
    public class MyHttpClient : IHttpClient
    {
        public string GetStringAsync(string url)
        {
            HttpClient client = new HttpClient();
            return client.GetStringAsync(url).GetAwaiter().GetResult();

        }
    }
}
