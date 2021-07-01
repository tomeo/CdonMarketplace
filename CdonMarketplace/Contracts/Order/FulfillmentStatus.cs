namespace CdonMarketplace.Contracts.Order
{
    public enum FulfillmentStatus
    {
        Pending = 0,
        Delivered = 1,
        Cancelled = 2,
        Returned = 3,
        Invoiced = 4
    }
}