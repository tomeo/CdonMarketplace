using System.Xml;
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
        private SimpleAttributeValue() {}

        public SimpleAttributeValue(string text) : this(null, text) {}

        public SimpleAttributeValue(string lang, string text)
        {
            Lang = lang;
            Text = new XmlNode[] {new XmlDocument().CreateCDataSection(text)};
        }
        
        [XmlAttribute("lang")]
        public string Lang { get; set; }
        
        [XmlText]
        public XmlNode[] Text { get; set; }
    }
}