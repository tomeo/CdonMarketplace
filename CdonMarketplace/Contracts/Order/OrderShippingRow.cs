using System;

namespace CdonMarketplace.Contracts.Order
{
    public class OrderShippingRow
    {
        public int OrderRowId { get; set; }
        public int QuantityToShip { get; set; }
        public DateTime ShippingDate { get; set; }
    }
}