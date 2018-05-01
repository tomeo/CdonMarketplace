using System.Xml.Serialization;

namespace CDON.Marketplace.Contracts
{
    public class Gtin
    {
        [XmlAttribute("value")]
        public string Value { get; set; }
    }
}