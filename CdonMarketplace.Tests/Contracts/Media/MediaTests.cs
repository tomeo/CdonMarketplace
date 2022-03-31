using System.Collections.Generic;
using CdonMarketplace.Media;
using CdonMarketplace.Utils;
using Xunit;

namespace CdonMarketplace.Tests.Contracts.Media
{
    public class MediaTests
    {
        [Fact]
        public void ShouldSerializeProduct()
        {
            var marketplace = new Marketplace
            {
                Product = new List<CdonMarketplace.Media.Product>()
                {
                    new CdonMarketplace.Media.Product
                    {
                        Id = "your_id",
                        Images = new Images
                        {
                            Main = "url_to_main_image",
                            Extra = new List<string>
                            {
                                "url_to_extra_image1",
                                "url_to_extra_image2",
                            }
                        }
                    }
                }
            };

            var xml = XmlUtils.SerializeXml(marketplace);
            string expected =
                $"<?xml version=\"1.0\" encoding=\"utf-8\"?><marketplace xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"https://schemas.cdon.com/product/4.0/{ApiVersion.Product()}/media\"><product><id>your_id</id><images><main>url_to_main_image</main><extra>url_to_extra_image1</extra><extra>url_to_extra_image2</extra></images></product></marketplace>";
            Assert.Equal(expected, xml);
        }

        [Fact]
        public void ShouldHandleNullAndEmpty()
        {
            var empty = new Marketplace
            {
                Product = new List<CdonMarketplace.Media.Product>()
                {
                    new CdonMarketplace.Media.Product
                    {
                        Id = "your_id",
                        Images = new Images
                        {
                            Main = "url_to_main_image",
                        }
                    }
                }
            };

            var nullSet = new Marketplace
            {
                Product = new List<CdonMarketplace.Media.Product>()
                {
                    new CdonMarketplace.Media.Product
                    {
                        Id = "your_id",
                        Images = new Images
                        {
                            Main = "url_to_main_image",
                            Extra = null,
                        }
                    }
                }
            };

            var emptyXml = XmlUtils.SerializeXml(empty);
            var nullXml = XmlUtils.SerializeXml(nullSet);
            var expected =
                $"<?xml version=\"1.0\" encoding=\"utf-8\"?><marketplace xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"https://schemas.cdon.com/product/4.0/{ApiVersion.Product()}/media\"><product><id>your_id</id><images><main>url_to_main_image</main></images></product></marketplace>";
            Assert.Equal(expected, emptyXml);
            Assert.Equal(expected, nullXml);
        }
    }
}
