using System.Collections.Generic;
using System.Linq;
using System.Xml;
using CdonMarketplace.Product;
using CdonMarketplace.Utils;
using Xunit;

namespace CdonMarketplace.Tests.Contracts.Product
{
    public class AttributeTests
    {
        [Fact]
        public void ShouldUseLists()
        {
            var marketplace = new Marketplace
            {
                Product = new List<CdonMarketplace.Product.Product>
                {
                    new CdonMarketplace.Product.Product
                    {
                        Category = new Category()
                        {
                            Attributes = new Attributes { Any = new[] { CreateAttribute("name", "value") }.ToList() }
                        }
                    }
                }
            };

        var xml = XmlUtils.SerializeXml(marketplace);
        var expected =
            $"<?xml version=\"1.0\" encoding=\"utf-8\"?><marketplace xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"https://schemas.cdon.com/product/4.0/{ApiVersion.Product()}/product\"><product><category><attributes><name>value</name></attributes></category></product></marketplace>";

            Assert.Equal(expected, xml);
        }

        private static XmlElement CreateAttribute(string name, string value)
        {
	        var doc = new XmlDocument();
            var element = doc.CreateElement(name);
            element.InnerText = value;
            return element;
        }
    }
}
