using System.Collections.Generic;
using System.IO;
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

        private Task<Receipt> DoRequest<T>(T content, string filename)
        {
            var fullPath = Path.Combine(_path, $"{filename}.xml");
            using var stream = File.Create(fullPath);
            XmlUtils.SerializeXmlToStream(content, stream);

            return Task.FromResult(new Receipt
            {
                ReceiptId = fullPath,
                StatusUrl = fullPath
            });
        }
    }
}