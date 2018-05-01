using System.Xml.Serialization;

namespace CDON.Marketplace.Contracts
{
    public class TaricNumber
    {
        [XmlAttribute("value")]
        public string Value { get; set; }
    }
}