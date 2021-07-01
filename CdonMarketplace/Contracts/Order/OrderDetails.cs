using System;

namespace CdonMarketplace.Contracts.Order
{
    public class OrderDetails
    {
        public string OrderKey { get; set; }
        public string OrderId { get; set; }
        public FulfillmentStatus State { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public DateTime LastModifiedDateUtc { get; set; }
        public string MerchantId { get; set; }
        public string CountryCode { get; set; }
        public string CurrencyCode { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalAmountExcludingVat { get; set; }
        public decimal TotalSalesAmount { get; set; }
        public int HoursPastDeliverySla { get; set; }
        public CustomerInfo CustomerInfo { get; set; }
        public OrderRow[] OrderRows { get; set; }
        public decimal TotalVat { get; set; }
        public bool IsSplitOrder { get; set; }
    }
}