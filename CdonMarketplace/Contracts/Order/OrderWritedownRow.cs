namespace CdonMarketplace.Contracts.Order
{
    public class OrderWritedownRow
    {
        public int OrderRowId { get; set; }
        public int QuantityToWriteDown { get; set; }
        public int WriteDownAmountPerItem { get; set; }
    }
}