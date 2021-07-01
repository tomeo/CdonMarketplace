namespace CdonMarketplace.Contracts.Order
{
    public class OrderReturn
    {
        public int OrderId { get; set; }
        public OrderReturnRow[] Products { get; set; }
    }
}