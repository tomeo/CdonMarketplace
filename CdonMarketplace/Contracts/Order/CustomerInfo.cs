namespace CdonMarketplace.Contracts.Order
{
    public class CustomerInfo
    {
        public int CustomerId { get; set; }
        public string EmailAddress { get; set; }
        public Address ShippingAddress { get; set; }
        public Address BillingAddress { get; set; }
        public Phones Phones { get; set; }
        public string SocialSecurityNumber { get; set; }
    }
}