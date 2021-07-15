namespace CdonMarketplace.Contracts.Order
{
    public class Order
    {
        public OrderDetails OrderDetails { get; set; }
        public Invoice[] Invoices { get; set; }
    }
}
