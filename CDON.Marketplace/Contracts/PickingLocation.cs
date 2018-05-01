using System.Xml.Serialization;

namespace CDON.Marketplace.Contracts
{
    public class PickingLocation
    {
        [XmlAttribute("value")]
        public string Value { get; set; }
    }
}