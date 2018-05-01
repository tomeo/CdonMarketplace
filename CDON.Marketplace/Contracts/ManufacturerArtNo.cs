using System.Xml.Serialization;

namespace CDON.Marketplace.Contracts
{
    public class ManufacturerArtNo
    {
        [XmlAttribute("value")]
        public string Value { get; set; }
    }
}