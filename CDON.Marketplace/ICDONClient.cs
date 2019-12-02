using System.Threading.Tasks;

namespace CDON.Marketplace
{
    public interface ICDONClient
    {
        Task<Receipt> UploadProduct(CDON.Marketplace.Product.marketplace products);
        Task<Receipt> UploadPrice(CDON.Marketplace.Price.marketplace prices);
        Task<Receipt> UploadMedia(CDON.Marketplace.Media.marketplace media);
        Task<Receipt> UploadAvailability(CDON.Marketplace.Availability.marketplace availability);
    }
}