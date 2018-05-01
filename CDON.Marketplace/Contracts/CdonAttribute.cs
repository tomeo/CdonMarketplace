using System.Xml.Serialization;

namespace CDON.Marketplace.Contracts
{
    public class CdonAttribute
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
        [XmlElement("value")]
        public string Value { get; set; }
    }
}