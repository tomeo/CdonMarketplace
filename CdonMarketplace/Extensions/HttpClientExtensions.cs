using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CdonMarketplace.Extensions
{
    public static class HttpClientExtensions
    {
        public static async Task<HttpResponseMessage> PostJson(
            this HttpClient client,
            string path,
            object data) => await client.PostAsync(
                path,
                new StringContent(
                    JsonConvert.SerializeObject(data),
                    System.Text.Encoding.UTF8,
                    "application/json"));
    }
}
