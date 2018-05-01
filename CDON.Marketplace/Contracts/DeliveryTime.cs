using System.Xml.Serialization;

namespace CDON.Marketplace.Contracts
{
    public class DeliveryTime
    {
        [XmlAttribute("min")]
        public int Min { get; set; }
        [XmlAttribute("max")]
        public int Max { get; set; }
    }
}