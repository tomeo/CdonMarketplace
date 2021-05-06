using System.Collections.Generic;
using CdonMarketplace.Product;
using CdonMarketplace.Utils;
using Xunit;

namespace CdonMarketplace.Tests.Contracts.Product
{
    public class ProductTests
    {
        [Fact]
        public void ShouldNotUseNamespacesOnElements()
        {
            var marketplace = new Marketplace
            {
                Product = new List<CdonMarketplace.Product.Product>
                {
                    new CdonMarketplace.Product.Product
                    {
                        Identity = new Identity
                        {
                            Id = "Test"
                        }
                    }
                }
            };

            var xml = XmlUtils.SerializeXml(marketplace);
            const string expected =
                "<?xml version=\"1.0\" encoding=\"utf-8\"?><marketplace xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"https://schemas.cdon.com/product/4.0/4.9.0/product\"><product><identity><id>Test</id></identity></product></marketplace>";

            Assert.Equal(expected, xml);
        }
    }
}
