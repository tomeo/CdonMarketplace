namespace CdonMarketplace.Contracts.Order
{
    public class OrderReturnAddress
    {
        public string AddressId { get; set; }
        public string DisplayName { get; set; }
        public string CompanyName { get; set; }
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string COAddress { get; set; }
        public string BoxAddress { get; set; }
        public OrderReturnAddressCountryCheckBox[] CountryCheckBoxes { get; set; }
    }
}
