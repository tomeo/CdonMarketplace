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
                        },
                        Dk = new MarketDK
                        {
                            OriginalPrice = 1337,
                            SalePrice = 999,
                            ShippingCost = MarketDKShippingCost.Item0,
                            Vat = 25,
                        }
                    }
                }
            };

            var xml = XmlUtils.SerializeXml(marketplace);
            const string expected =
                "<?xml version=\"1.0\" encoding=\"utf-8\"?><marketplace xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"https://schemas.cdon.com/product/4.0/4.9.0/price\"><product><id>your_sku</id><se><salePrice>999</salePrice><originalPrice>1337</originalPrice><isShippedFromEU>true</isShippedFromEU><shippingCost>0</shippingCost><vat>25</vat></se><dk><salePrice>999</salePrice><originalPrice>1337</originalPrice><shippingCost>0</shippingCost><vat>25</vat></dk></product></marketplace>";
                Assert.Equal(expected, xml);
        }
    }
}
