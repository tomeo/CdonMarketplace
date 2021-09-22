using System.Collections.Generic;
using System.Linq;
using System.Xml;
using CdonMarketplace.Product;

namespace CdonMarketplace.Factories
{
    public static class AttributeFactory
    {
        private static XmlElement Create(string name, string value)
        {
            var doc = new XmlDocument();
            var element = doc.CreateElement(name);
            element.InnerText = value;
            return element;
        }

        public static Attributes Create(IEnumerable<(string Name, string Value)> attributes) => new Attributes
        {
            Any = attributes.Select(a => Create(a.Name, a.Value)).ToList()
        };
    }
}
