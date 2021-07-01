using System.Collections.Generic;
using System.Threading.Tasks;
using CdonMarketplace.Contracts.Order;

namespace CdonMarketplace.Clients
{
    public interface IOrderApiClient
    {
        Task<IEnumerable<Order>> GetPendingOrders(PendingOrdersOptions options = null);
        Task<IEnumerable<Order>> GetAllPendingOrders(PendingOrdersOptions options = null);
        Task<Order> GetOrder(string orderId);
        Task<Order> FulfillOrder(Fulfillment fulfillment);
    }
}