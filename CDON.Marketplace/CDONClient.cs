using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace CDON.Marketplace
{
    public class Receipt
    {
        public string ReceiptId { get; set; }
        public string StatusUrl { get; set; }
    }

    public class CDONClient : ICDONClient
    {
        private readonly HttpClient _client;
        private static readonly JsonSerializerOptions DeserializeOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = false
        };

        public CDONClient(string baseUrl, string apiKey)
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

        public async Task<Receipt> UploadProduct(CDON.Marketplace.Product.marketplace products) => await DoRequest(products, "product");
        public async Task<Receipt> UploadPrice(CDON.Marketplace.Price.marketplace prices) => await DoRequest(prices, "price");
        public async Task<Receipt> UploadMedia(CDON.Marketplace.Media.marketplace media) => await DoRequest(media, "media");
        public async Task<Receipt> UploadAvailability(CDON.Marketplace.Availability.marketplace availability) => await DoRequest(availability, "availability");

        private async Task<Receipt> DoRequest<T>(T content, string endpoint)
        {
            var xml = XMLUtils.SerializeXML(content);
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

    public class FileSystemClient : ICDONClient
    {
        private readonly string _path;

        public FileSystemClient(string path)
        {
            _path = path;
        }

        public async Task<Receipt> UploadProduct(CDON.Marketplace.Product.marketplace products) => await DoRequest(products, "product");
        public async Task<Receipt> UploadPrice(CDON.Marketplace.Price.marketplace prices) => await DoRequest(prices, "price");
        public async Task<Receipt> UploadMedia(CDON.Marketplace.Media.marketplace media) => await DoRequest(media, "media");
        public async Task<Receipt> UploadAvailability(CDON.Marketplace.Availability.marketplace availability) => await DoRequest(availability, "availability");

        private async Task<Receipt> DoRequest<T>(T content, string filename)
        {
            var xml = XMLUtils.SerializeXML(content);
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
