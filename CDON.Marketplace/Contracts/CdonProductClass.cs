using System.Xml.Serialization;

namespace CDON.Marketplace.Contracts
{
    public class CdonProductClass
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
    }
}