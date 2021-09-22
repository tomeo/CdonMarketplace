namespace CdonMarketplace.Contracts.Order
{
    public class OrderPackage
    {
        public int OrderId { get; set; }
        public OrderPackageRow[] Rows { get; set; }
    }
}