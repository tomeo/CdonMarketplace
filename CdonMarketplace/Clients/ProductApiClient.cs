using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CdonMarketplace.Contracts.Product;
using CdonMarketplace.Utils;
using CdonMarketplace.Extensions;

namespace CdonMarketplace.Clients
{
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
            _client.DefaultRequestHeaders.UserAgent.Add(GetProductInfoHeader());
        }

        private static ProductInfoHeaderValue GetProductInfoHeader()
        {
            var assemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName();
            return new ProductInfoHeaderValue(assemblyName.Name, assemblyName.Version.ToString());
        }

        public async Task<Receipt> UploadProduct(Product.Marketplace products) => await DoRequest(products, "product");
        public async Task<Receipt> UploadPrice(Price.Marketplace prices) => await DoRequest(prices, "price");
        public async Task<Receipt> UploadMedia(Media.Marketplace media) => await DoRequest(media, "media");
        public async Task<Receipt> UploadAvailability(Availability.Marketplace availability) => await DoRequest(availability, "availability");

        private async Task<Receipt> DoRequest<T>(T content, string endpoint)
        {
            using var body =
                new PushStreamContent(
                    (stream, httpContent, transportContext) => XmlUtils.SerializeXmlToStream(content, stream),
                    "application/xml");

            var response = await _client.PostAsync($"/{endpoint}", body).ConfigureAwait(false);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApiException
                (
                    (int)response.StatusCode,
                    responseContent,
                    $"{_client.BaseAddress}/{endpoint}"
                );
            }

            return JsonSerializer.Deserialize<Receipt>(responseContent, DeserializeOptions);
        }

        public async Task<IEnumerable<Delivery>> GetDeliveries(int take = 100)
        {
            return await _client.GetAsync<Delivery[]>($"/deliveries?take={take}");
        }

        public async Task<Delivery> GetDelivery(string receiptId)
        {
            return await _client.GetAsync<Delivery>($"/deliveries/{receiptId}");
        }

        public async Task<IEnumerable<DeliveryFailure>> GetDeliveryFailures(string receiptId)
        {
            return await _client.GetAsync<DeliveryFailure[]>($"/deliveries/{receiptId}/failures");
        }
    }
}