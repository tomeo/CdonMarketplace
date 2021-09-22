using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using CdonMarketplace.Contracts.Order;

namespace CdonMarketplace.Clients
{
    public interface IOrderApiClient
    {
        Task<IEnumerable<Order>> GetPendingOrders(PendingOrdersOptions options = null);
        Task<IEnumerable<Order>> GetAllPendingOrders(PendingOrdersOptions options = null);
        Task<Order> GetOrder(int orderId);
        Task<Order> FulfillOrderRows(OrderFulfillment orderFulfillment);
        Task<Order> ReturnOrderRows(OrderReturn orderReturn);
        Task<Order> CancelOrderRows(OrderCancel orderCancel);
        Task<Order> WritedownOrderRows(OrderWritedown orderWritedown);
        Task<Order> PackageOrderRows(OrderPackage orderPackage);
        Task<Order> PickOrderRows(OrderPicking orderPicking);
        Task<Order> ShipOrderRows(OrderShipping orderShipping);
        Task<Order> ChargeNpuFee(OrderNpuFee orderNpuFee);
        Task<Order> RetractNpuFee(int orderId);
        Task<IEnumerable<PackageCarrier>> GetPackageCarriers();
        Task<IEnumerable<OrderReturnAddress>> GetOrderReturnAddresses();
        Task<Stream> GetDeliveryNote(OrderDeliveryNote orderDeliveryNote);
    }
}