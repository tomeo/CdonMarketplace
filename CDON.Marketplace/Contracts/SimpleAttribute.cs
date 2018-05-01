using System.Xml.Serialization;

namespace CDON.Marketplace.Contracts
{
    public class SimpleAttribute
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
        [XmlElement("value")]
        public SimpleAttributeValue[] Values { get; set; }
    }

    public class SimpleAttributeValue
    {
        [XmlAttribute("lang")]
        public string Lang { get; set; }
        [XmlText]
        public string Text;
    }
}