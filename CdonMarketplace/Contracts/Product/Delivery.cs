using System;

namespace CdonMarketplace.Contracts.Product
{
    public class Delivery
    {
        public string ReceiptId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string EndPoint { get; set; }
        public string Status { get; set; }
        public string ErrorMessage { get; set; }
        public int Total { get; set; }
        public int TotalPending { get; set; }
        public int TotalSucceeded { get; set; }
        public int TotalFailed { get; set; }
        public string EstimatedTimeLeft { get; set; }
    }
}