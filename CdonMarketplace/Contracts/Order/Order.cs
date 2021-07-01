namespace CdonMarketplace.Contracts.Order
{
    public class Order
    {
        public OrderDetails OrderDetails { get; set; }
        public string[] Invoices { get; set; }
    }
}
