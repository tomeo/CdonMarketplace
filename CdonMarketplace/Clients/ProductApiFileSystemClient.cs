using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CdonMarketplace.Contracts.Product;
using CdonMarketplace.Utils;

namespace CdonMarketplace.Clients
{
    public class ProductApiFileSystemClient : IProductApiClient
    {
        private readonly string _path;

        public ProductApiFileSystemClient(string path)
        {
            _path = path;
        }

        public async Task<Receipt> UploadProduct(Product.Marketplace products) => await DoRequest(products, "product");
        public async Task<Receipt> UploadPrice(Price.Marketplace prices) => await DoRequest(prices, "price");
        public async Task<Receipt> UploadMedia(Media.Marketplace media) => await DoRequest(media, "media");
        public async Task<Receipt> UploadAvailability(Availability.Marketplace availability) => await DoRequest(availability, "availability");
        public Task<IEnumerable<Delivery>> GetDeliveries(int take = 100)
        {
            throw new System.NotImplementedException();
        }

        public Task<Delivery> GetDelivery(string receiptId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<DeliveryFailure>> GetDeliveryFailures(string receiptId)
        {
            throw new System.NotImplementedException();
        }

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