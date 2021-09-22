using System.Collections.Generic;
using System.Threading.Tasks;
using CdonMarketplace.Contracts.Product;

namespace CdonMarketplace.Clients
{
    public interface IProductApiClient
    {
        Task<Receipt> UploadProduct(Product.Marketplace products);
        Task<Receipt> UploadPrice(Price.Marketplace prices);
        Task<Receipt> UploadMedia(Media.Marketplace media);
        Task<Receipt> UploadAvailability(Availability.Marketplace availability);
        Task<IEnumerable<Delivery>> GetDeliveries(int take = 100);
        Task<Delivery> GetDelivery(string receiptId);
        Task<IEnumerable<DeliveryFailure>> GetDeliveryFailures(string receiptId);
    }
}