namespace CdonMarketplace.Contracts.Order
{
    public class OrderNpuFee
    {
        public int OrderId { get; set; }
        public OrderNpuFeeRow[] Products { get; set; }
    }
}
