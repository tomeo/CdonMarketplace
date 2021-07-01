namespace CdonMarketplace.Contracts.Order
{
    public class Fulfillment
    {
        public string OrderId { get; set; }
        public FulfillmentRow[] Products { get; set; }
    }
}