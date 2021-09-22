namespace CdonMarketplace.Contracts.Order
{
    public class InvoiceRow
    {
        public decimal TotalPaymentAmount { get; set; }
        public decimal TotalCreditNoteAmount { get; set; }
        public PaymentStatus Status { get; set; }
        public int InvoiceRowNumber { get; set; }
        public int OrderRowId { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerUnit { get; set; }
        public decimal VatPerUnit { get; set; }
        public decimal VatPercentage { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalVat { get; set; }
    }
}