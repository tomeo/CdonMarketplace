using System;
using System.Xml.Serialization;

namespace CDON.Marketplace.Contracts
{
    [XmlRoot(ElementName = "cdon_shopping_mall_import")]
    public class ExportContainer
    {
        [XmlAttribute("version")]
        public string Version { get; set; }
        [XmlAttribute("source_id")]
        public string SourceId { get; set; }
        [XmlAttribute("import_id")]
        public string ImportId { get; set; }
        [XmlAttribute("import_previous_id")]
        public string ImportPreviousId { get; set; }
        [XmlAttribute("import_type")]
        public string ImportType { get; set; }
        [XmlAttribute("import_date")]
        public DateTime ImportDate { get; set; }
        [XmlElement("documents")]
        public DocumentContainer Documents { get; set; }
    }

    [XmlInclude(typeof(SimpleProduct))]
    [XmlInclude(typeof(VariationProduct))]
    public abstract class BaseProduct
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
        [XmlElement("class")]
        public CdonProductClass[] Class { get; set; }
        [XmlElement("brand")]
        public ProductBrand Brand { get; set; }
        [XmlElement("taricNumber")]
        public TaricNumber TaricNumber { get; set; }
    }

    public class SimpleProduct : BaseProduct
    {
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
        [XmlElement("values")]
        public ProductValues Values { get; set; }
        [XmlElement("productStatus")]
        public ProductStatus ProductStatus { get; set; }
        [XmlElement("deliveryTime")]
        public DeliveryTime DeliveryTime { get; set; }
        [XmlArray("salesChannels")]
        [XmlArrayItem("channel")]
        public Channel[] SalesChannels { get; set; }
    }

    public class VariationProduct : BaseProduct
    {
        [XmlElement("values")]
        public ProductValues Values { get; set; }
        [XmlElement("productStatus")]
        public ProductStatus ProductStatus { get; set; }
        [XmlElement("deliveryTime")]
        public DeliveryTime DeliveryTime { get; set; }
        [XmlArray("productVariations")]
        [XmlArrayItem("sku")]
        public Sku[] Skus { get; set; }
    }
}
