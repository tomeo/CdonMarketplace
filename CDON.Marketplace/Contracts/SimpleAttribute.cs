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
        [XmlIgnore]
        public string Text;
        [XmlElement("Text")]
        public System.Xml.XmlCDataSection TextCData
        {
            get => new System.Xml.XmlDocument().CreateCDataSection(Text);
            set => Text = value.Value;
        }
    }
}