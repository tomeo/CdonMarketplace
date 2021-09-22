namespace CdonMarketplace.Contracts.Order
{
    public enum PaymentStatus
    {
        NotApplicable = 0,
        AwaitingPayment = 1,
        Paid = 2,
        AwaitingRefund = 3,
        Refunded = 4
    }
}