using System.Threading.Tasks;

namespace CdonMarketplace
{
    public interface ICdonClient
    {
        Task<Receipt> UploadProduct(Product.Marketplace products);
        Task<Receipt> UploadPrice(Price.Marketplace prices);
        Task<Receipt> UploadMedia(Media.Marketplace media);
        Task<Receipt> UploadAvailability(Availability.Marketplace availability);
    }
}