using System.Collections.Generic;
using CdonMarketplace.Price;
using CdonMarketplace.Utils;
using Xunit;

namespace CdonMarketplace.Tests.Contracts.Price
{
    public class PriceTests
    {
        [Fact]
        public void ShouldSerializeProduct()
        {
            var marketplace = new Marketplace
            {
                Product = new List<CdonMarketplace.Price.Product>
                {
                    new CdonMarketplace.Price.Product
                    {
                        Id = "your_sku",
                        Se = new MarketSE
                        {
                            OriginalPrice = 1337,
                            SalePrice = 999,
                            IsShippedFromEU = true,
                            ShippingCost = MarketSEShippingCost.Item0,
                            Vat = 25,
                            Carrier = Carriers.Dhl,
                            ShippingMethod = ShippingMethods.PickupPoint,
                        },
                        Dk = new MarketDK
                        {
                            OriginalPrice = 1337,
                            SalePrice = 999,
                            ShippingCost = MarketDKShippingCost.Item0,
                            Vat = 25,
                            Carrier = Carriers.Dhl,
                            ShippingMethod = ShippingMethods.PickupPoint,
                        }
                    }
                }
            };

            var xml = XmlUtils.SerializeXml(marketplace);
            var expected =
                $"<?xml version=\"1.0\" encoding=\"utf-8\"?><marketplace xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"https://schemas.cdon.com/product/4.0/{ApiVersion.Product()}/price\"><product><id>your_sku</id><se><salePrice>999</salePrice><originalPrice>1337</originalPrice><isShippedFromEU>true</isShippedFromEU><shippingMethod>PickupPoint</shippingMethod><carrier>Dhl</carrier><shippingCost>0</shippingCost><vat>25</vat></se><dk><salePrice>999</salePrice><originalPrice>1337</originalPrice><shippingMethod>PickupPoint</shippingMethod><carrier>Dhl</carrier><shippingCost>0</shippingCost><vat>25</vat></dk></product></marketplace>";
                Assert.Equal(expected, xml);
        }
    }
}
