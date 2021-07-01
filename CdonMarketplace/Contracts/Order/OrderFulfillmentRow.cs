namespace CdonMarketplace.Contracts.Order
{
    public class OrderFulfillmentRow
    {
        public int? OrderRowId { get; set; }
        public int QuantityToDeliver { get; set; }
        public string PackageId { get; set; }
        public int PackageCarrierId { get; set; }
    }
}