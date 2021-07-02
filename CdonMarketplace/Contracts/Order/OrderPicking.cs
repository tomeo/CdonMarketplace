namespace CdonMarketplace.Contracts.Order
{
    public class OrderPicking {
        public int OrderId { get; set; }
        public OrderPickingRow[] Rows { get; set; }
    }
}