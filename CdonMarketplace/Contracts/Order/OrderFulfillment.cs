namespace CdonMarketplace.Contracts.Order
{
    public class OrderFulfillment
    {
        public int OrderId { get; set; }
        public OrderFulfillmentRow[] Products { get; set; }
    }
}