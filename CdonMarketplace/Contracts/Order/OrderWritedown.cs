namespace CdonMarketplace.Contracts.Order
{
    public class OrderWritedown
    {
        public int OrderId { get; set; }
        public OrderWritedownRow[] Rows { get; set; }
    }
}