using System.Xml.Serialization;

namespace CDON.Marketplace.Contracts
{
    public class Channel
    {
        [XmlAttribute("iso")]
        public string Iso { get; set; }
        [XmlElement("price")]
        public Price Price { get; set; }
        [XmlElement("sellable")]
        public bool Sellable { get; set; }
        [XmlElement("deliveryTime")]
        public DeliveryTime DeliveryTime { get; set; }
        [XmlElement("freightClass")]
        public string FreightClass { get; set; }
    }
}