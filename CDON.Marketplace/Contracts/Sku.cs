using System.Xml.Serialization;

namespace CDON.Marketplace.Contracts
{
    public class Sku
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
        [XmlElement("status")]
        public string Status { get; set; }
        [XmlElement("exposeStatus")]
        public string ExposeStatus { get; set; }
        [XmlElement("inStock")]
        public int InStock { get; set; }
        [XmlElement("gtin")]
        public Gtin Gtin { get; set; }
        [XmlElement("pickingLocation")]
        public PickingLocation PickingLocation { get; set; }
        [XmlElement("manufacturerArtNo")]
        public ManufacturerArtNo ManufacturerArtNo { get; set; }
        [XmlElement("releaseDate")]
        public ReleaseDate ReleaseDate { get; set; }
        [XmlElement("freightClass")]
        public string FreightClass { get; set; }
        [XmlElement("variation")]
        public VariationDescriptor[] VariationDescriptors { get; set; }
        [XmlArray("salesChannels")]
        [XmlArrayItem("channel")]
        public Channel[] SalesChannels { get; set; }
    }
}