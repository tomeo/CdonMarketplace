using System;
using System.Net.Http;
using System.Threading.Tasks;
using CdonMarketplace.Utils;
using Newtonsoft.Json;

namespace CdonMarketplace.Extensions
{
    public static class HttpClientExtensions
    {
        public static async Task<HttpResponseMessage> PostAsync(
            this HttpClient client,
            string requestUri,
            string contentType,
            string data) => await client.PostAsync(
            requestUri,
            new StringContent(
                data,
                System.Text.Encoding.UTF8,
                contentType));

        public static async Task<HttpResponseMessage> PostJsonAsync(
            this HttpClient client,
            string requestUri,
            object data) => 
                await client.PostAsync(requestUri, "application/json", JsonConvert.SerializeObject(data));

        public static async Task<HttpResponseMessage> PostXmlAsync(
            this HttpClient client,
            string requestUri,
            object data) =>
                await client.PostAsync(requestUri, "application/xml", XmlUtils.SerializeXml(data));

        public static async Task<T> PostAsync<T>(
            this HttpClient client,
            string requestUri,
            object data)
        {
            var response = await client.PostJsonAsync(requestUri, data);
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApiException
                (
                    (int)response.StatusCode,
                    content,
                    $"{client.BaseAddress}/{requestUri}"
                );
            }

            return JsonConvert.DeserializeObject<T>(content);
        }

        public static async Task<T> GetAsync<T>(
            this HttpClient client,
            string requestUri)
        {
            var response = await client.GetAsync(requestUri);
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApiException
                (
                    (int)response.StatusCode,
                    content,
                    $"{client.BaseAddress}/{requestUri}"
                );
            }

            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}
