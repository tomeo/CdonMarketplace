using System.Xml.Serialization;

namespace CDON.Marketplace.Contracts
{
    public class VariationDescriptor
    {
        [XmlAttribute("key")]
        public string Key { get; set; }
        [XmlAttribute("value")]
        public string Value { get; set; }
    }
}