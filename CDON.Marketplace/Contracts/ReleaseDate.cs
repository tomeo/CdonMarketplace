using System.Xml.Serialization;

namespace CDON.Marketplace.Contracts
{
    public class ReleaseDate
    {
        [XmlAttribute("value")]
        public string Value { get; set; }
    }
}