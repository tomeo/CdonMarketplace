using System.Xml.Serialization;

namespace CDON.Marketplace.Contracts
{
    public class ProductBrand
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
    }
}