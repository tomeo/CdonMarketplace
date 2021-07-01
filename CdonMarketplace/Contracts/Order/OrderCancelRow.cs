namespace CdonMarketplace.Contracts.Order
{
    public class OrderCancelRow
    {
        public int? OrderRowId { get; set; }
        public int QuantityToCancel { get; set; }
    }
}