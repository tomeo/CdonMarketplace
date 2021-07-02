namespace CdonMarketplace.Contracts.Order
{
    public class OrderShipping
    {
        public int OrderId { get; set; }
        public OrderShippingRow[] Products { get; set; }
    }
}
