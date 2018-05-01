using System.Xml.Serialization;

namespace CDON.Marketplace.Contracts
{
    public class ProductValues
    {
        [XmlElement("attribute")]
        public SimpleAttribute[] Attributes { get; set; }
        [XmlArray("variations")]
        [XmlArrayItem("key")]
        public VariationAttributeKey[] Variations { get; set; }
    }
}