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
            var product = new CdonMarketplace.Product.Product
            {
                Title = new Title
                {
                    Default = "I am a title",
                },
                Description = new Description
                {
                    Default = "<strong>I contain HTML</strong>"
                }
            };

            var xml = XmlUtils.SerializeXml(product);
            const string expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?><product xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><title xmlns=\"https://schemas.cdon.com/product/4.0/4.9.0/product\"><default>I am a title</default></title><description xmlns=\"https://schemas.cdon.com/product/4.0/4.9.0/product\"><default><![CDATA[<strong>I contain HTML</strong>]]></default></description></product>";

            Assert.Equal(expected, xml);
        }
    }
}
