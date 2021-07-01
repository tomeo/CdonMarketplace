using System.Collections.Generic;
using System.Threading.Tasks;
using CdonMarketplace.Availability;
using CdonMarketplace.Utils;
using Xunit;

namespace CdonMarketplace.Tests.Contracts.Availability
{
    public class AvailabilityTests
    {
        [Fact]
        public async Task ShouldSerializeProduct()
        {
            var marketplace = new Marketplace
            {
                Product = new List<CdonMarketplace.Availability.Product>
                {
                    new CdonMarketplace.Availability.Product
                    {
                        Status = Status.Offline,
                        Id = "your_sku",
                        Stock = "0",
                        Se = new MarketSE
                        {
                            DeliveryTime = new DeliveryTime
                            {
                                Min = "2",
                                Max = "3",
                            },
                            Status = Status.Offline,
                        }
                    }
                }
            };
            
            var xml = XmlUtils.SerializeXml(marketplace);
            const string expected =
                "<?xml version=\"1.0\" encoding=\"utf-8\"?><marketplace xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"https://schemas.cdon.com/product/4.0/4.9.0/availability\"><product><id>your_sku</id><status>Offline</status><stock>0</stock><se><status>Offline</status><deliveryTime><min>2</min><max>3</max></deliveryTime></se></product></marketplace>";
                Assert.Equal(expected, xml);
        }
    }
}
