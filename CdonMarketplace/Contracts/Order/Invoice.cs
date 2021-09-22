using System;

namespace CdonMarketplace.Contracts.Order
{
    public class Invoice
    {
        public PaymentStatus Status { get; set; }
        public string InvoiceNumber { get; set; }
        public string MerchantId { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public DateTime BookingDateUtc { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalVat { get; set; }
        public string CurrencyCode { get; set; }
        public InvoiceRow[] Rows { get; set; }
    }
}