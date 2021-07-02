using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CdonMarketplace.Extensions
{
    public static class HttpClientExtensions
    {
        public static async Task<HttpResponseMessage> PostJsonAsync(
            this HttpClient client,
            string path,
            object data) => await client.PostAsync(
                path,
                new StringContent(
                    JsonConvert.SerializeObject(data),
                    System.Text.Encoding.UTF8,
                    "application/json"));

        public static async Task<T> PostAsync<T>(
            this HttpClient client,
            string path,
            object data)
        {
            var response = await client.PostJsonAsync(path, data);
            response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<T>(
                await response.Content.ReadAsStringAsync());
        }

        public static async Task<T> GetAsync<T>(
            this HttpClient client,
            string path)
        {
            var response = await client.GetAsync(path);
            response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<T>(
                await response.Content.ReadAsStringAsync());
        }
    }
}
