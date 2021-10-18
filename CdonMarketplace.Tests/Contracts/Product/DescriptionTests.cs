using System.Collections.Generic;
using CdonMarketplace.Product;
using CdonMarketplace.Utils;
using Xunit;

namespace CdonMarketplace.Tests.Contracts.Product
{
    public class DescriptionTests
    {
        [Fact]
        public void ShouldUseCdata()
        {
            var marketplace = new Marketplace
            {
                Product = new List<CdonMarketplace.Product.Product>
                {
                    new CdonMarketplace.Product.Product
                    {
                        Title = new Title
                        {
                            Default = "I am a title"
                        },
                        Description = new Description
                        {
                            Default = "<strong>I contain HTML</strong>"
                        }
                    }
                }
            };

            var xml = XmlUtils.SerializeXml(marketplace);
            var expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><marketplace xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"https://schemas.cdon.com/product/4.0/4.11.0/product\"><product><title><default>I am a title</default></title><description><default><![CDATA[<strong>I contain HTML</strong>]]></default></description></product></marketplace>";

            Assert.Equal(expected, xml);
        }
    }
}