namespace CdonMarketplace.Contracts.Order
{
    public class OrderDeliveryNoteRow
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string PickingLocation { get; set; }
    }
}