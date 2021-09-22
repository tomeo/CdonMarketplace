namespace CdonMarketplace.Contracts.Order
{
    public class OrderCancel
    {
        public int OrderId { get; set; }
        public OrderCancelRow[] Rows { get; set; }
    }
}