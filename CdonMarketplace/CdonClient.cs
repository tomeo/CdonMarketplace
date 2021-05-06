using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using CDONMarketplace;

namespace CdonMarketplace
{
    public class Receipt
    {
        public string ReceiptId { get; set; }
        public string StatusUrl { get; set; }
    }

    public class CdonClient : ICdonClient
    {
        private readonly HttpClient _client;
        private static readonly JsonSerializerOptions DeserializeOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = false
        };

        public CdonClient(string baseUrl, string apiKey)
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

    public class FileSystemClient : ICdonClient
    {
        private readonly string _path;

        public FileSystemClient(string path)
        {
            _path = path;
        }

        public async Task<Receipt> UploadProduct(Product.Marketplace products) => await DoRequest(products, "product");
        public async Task<Receipt> UploadPrice(Price.Marketplace prices) => await DoRequest(prices, "price");
        public async Task<Receipt> UploadMedia(Media.Marketplace media) => await DoRequest(media, "media");
        public async Task<Receipt> UploadAvailability(Availability.Marketplace availability) => await DoRequest(availability, "availability");

        private async Task<Receipt> DoRequest<T>(T content, string filename)
        {
            var xml = XmlUtils.SerializeXml(content);
            var fullPath = System.IO.Path.Combine(_path, $"{filename}.xml");

            using var outputFile = new System.IO.StreamWriter(fullPath, false, Encoding.UTF8);
            await outputFile.WriteAsync(xml);
            return new Receipt
            {
                ReceiptId = fullPath,
                StatusUrl = fullPath
            };
        }
    }
}