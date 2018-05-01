using System.Xml.Serialization;

namespace CDON.Marketplace.Contracts
{
    public class Brand
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
        [XmlArray("values")]
        [XmlArrayItem("attribute")]
        public CdonAttribute[] Attributes { get; set; }
    }
}