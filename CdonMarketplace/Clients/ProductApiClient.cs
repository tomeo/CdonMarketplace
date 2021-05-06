using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CdonMarketplace.Contracts;
using CdonMarketplace.Utils;

namespace CdonMarketplace.Clients
{
    public class Receipt
    {
        public string ReceiptId { get; set; }
        public string StatusUrl { get; set; }
    }

    public class ProductApiClient : IProductApiClient
    {
        private readonly HttpClient _client;
        private static readonly JsonSerializerOptions DeserializeOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = false
        };

        public ProductApiClient(string baseUrl, string apiKey)
        {
            _client = new HttpClient(new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip
            })
            {
                BaseAddress = new Uri(baseUrl)
            };
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("api", apiKey);
        }

        public async Task<Receipt> UploadProduct(Product.Marketplace products) => await DoRequest(products, "product");
        public async Task<Receipt> UploadPrice(Price.Marketplace prices) => await DoRequest(prices, "price");
        public async Task<Receipt> UploadMedia(Media.Marketplace media) => await DoRequest(media, "media");
        public async Task<Receipt> UploadAvailability(Availability.Marketplace availability) => await DoRequest(availability, "availability");

        private async Task<Receipt> DoRequest<T>(T content, string endpoint)
        {
            var xml = XmlUtils.SerializeXml(content);
            var body = new StringContent(xml, Encoding.UTF8, "application/xml");

            var response = await _client.PostAsync($"/{endpoint}", body).ConfigureAwait(false);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApiException
                (
                    (int)response.StatusCode,
                    responseContent,
                    $"/{endpoint}"
                );
            }

            return JsonSerializer.Deserialize<Receipt>(responseContent, DeserializeOptions);
        }
    }
}