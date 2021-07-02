namespace CdonMarketplace.Contracts.Order
{
    public class OrderRow
    {
        public int OrderRowId { get; set; }
        public FulfillmentStatus FulfillmentStatus { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public int Quantity { get; set; }
        public int DeliveredQuantity { get; set; }
        public int InvoicedQuantity { get; set; }
        public int CancelledQuantity { get; set; }
        public int ReturnedQuantity { get; set; }
        public int PickedQuantity { get; set; }
        public decimal PricePerUnit { get; set; }
        public decimal OrdinaryPricePerUnit { get; set; }
        public decimal VatPerUnit { get; set; }
        public decimal VatPercentage { get; set; }
        public string PackageId { get; set; }
        public string PackageCarrierId { get; set; }
        public string AddonToProductId { get; set; }
        public decimal DebitedAmount { get; set; }
        public decimal CreditedAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal RefundedAmount { get; set; }
    }
}