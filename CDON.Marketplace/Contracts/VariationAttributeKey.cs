using System.Xml.Serialization;

namespace CDON.Marketplace.Contracts
{
    public class VariationAttributeKey
    {
        [XmlAttribute("attribute")]
        public string Attribute { get; set; }
        [XmlElement("variation")]
        public VariationAttribute[] Values { get; set; }
    }

    public class VariationAttribute
    {
        [XmlAttribute("value")]
        public string Value { get; set; }
        [XmlElement("attribute")]
        public SimpleAttribute[] Attributes { get; set; }
    }
}