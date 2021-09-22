namespace CdonMarketplace.Contracts.Order
{
    public class OrderDeliveryNote
    {

        public int OrderId { get; set; }
        
        public string AddressId { get; set; }
        
        public OrderDeliveryNoteRow[] DeliveryNoteRows { get; set; }
    }
}
