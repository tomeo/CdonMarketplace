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
        protected SimpleAttributeValue() {}

        public SimpleAttributeValue(string text, bool useCdata = false) : this(null, text, useCdata) {}

        public SimpleAttributeValue(string lang, string text, bool useCdata = false)
        {
            Lang = lang;
            Text = useCdata ? 
                new XmlNode[] {new XmlDocument().CreateCDataSection(text)} :
                new XmlNode[] {new XmlDocument().CreateTextNode(text)};
        }

        [XmlAttribute("lang")]
        public string Lang { get; set; }
        
        [XmlText]
        public XmlNode[] Text { get; set; }
    }
}