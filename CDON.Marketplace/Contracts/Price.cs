using System.Xml.Serialization;

namespace CDON.Marketplace.Contracts
{
    public class Price
    {
        [XmlAttribute("current")]
        public decimal Current { get; set; }
        [XmlAttribute("ordinary")]
        public decimal Ordinary { get; set; }
        [XmlAttribute("vat")]
        public decimal Vat { get; set; }
        [XmlAttribute("currency")]
        public string Currency { get; set; }
    }
}