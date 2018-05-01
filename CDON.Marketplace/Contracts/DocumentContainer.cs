using System.Xml.Serialization;

namespace CDON.Marketplace.Contracts
{
    public class DocumentContainer
    {
        [XmlArray("brands")]
        [XmlArrayItem("brand")]
        public Brand[] Brands { get; set; }

        [XmlArray("products")]
        [XmlArrayItem("product")]
        public BaseProduct[] Products { get; set; }
    }
}