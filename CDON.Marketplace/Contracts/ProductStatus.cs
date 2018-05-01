using System.Xml.Serialization;

namespace CDON.Marketplace.Contracts
{
    public class ProductStatus
    {
        [XmlElement("status")]
        public string Status { get; set; }
        [XmlElement("exposeStatus")]
        public string ExposeStatus { get; set; }
        [XmlElement("inStock")]
        public int? InStock { get; set; }
    }
}