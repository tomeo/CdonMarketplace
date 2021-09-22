using System.Collections.Generic;
using CdonMarketplace.Factories;
using CdonMarketplace.Product;
using CdonMarketplace.Utils;
using Xunit;

namespace CdonMarketplace.Tests.Contracts.Product
{
    public class ProductTests
    {
        [Fact]
        public void ShouldSerializeProduct()
        {
            var marketplace = new Marketplace
            {
                Product = new List<CdonMarketplace.Product.Product>
                {
                    new CdonMarketplace.Product.Product
                    {
                        Identity = new Identity
                        {
                            Id = "your_id",
                            Sku = "your_sku",
                            Gtin = "your_gtin",
                        },
                        Title = new Title
                        {
                            Default = "Default title",
                            Se = "Swedish title",
                            // Dk, No, Fi...
                        },
                        Brand = "Your brand",
                        Category = new Category
                        {
                            Google = "187",
                            Attributes = AttributeFactory.Create(new []{ ("shoes_type", "athletic_footwear-paddle_shoes") }),
                        },
                        Description = new Description
                        {
                            Default = "Default description with HTML-support",
                            Se = "Swedish description with HTML-support",
                            // Dk, No, Fi...
                        },
                        Usp = new List<UspValue>
                        {
                            new UspValue
                            {
                                Default = "USP 1",
                                Se = "Swedish USP 1",
                                // Dk, No, Fi...
                            },
                            new UspValue
                            {
                                Default = "USP 2",
                                Se = "Swedish USP 2",
                                // Dk, No, Fi...
                            }
                        },
                        Variants = new Variants
                        {
                            VariantBySize = new List<VariantBySize>
                            {
                                new VariantBySize
                                {
                                    Identity = new Identity
                                    {
                                        Id = "your_sku",
                                        Gtin = "your_gtin"
                                    },
                                    Size = new Untranslatable
                                    {
                                        Default = "44"
                                    },
                                },
                                new VariantBySize
                                {
                                    Identity = new Identity
                                    {
                                        Id = "your_sku2",
                                        Gtin = "your_gtin2"
                                    },
                                    Size = new Untranslatable
                                    {
                                        Default = "45"
                                    },
                                }
                            }
                        },
                    }
                }
            };

            var xml = XmlUtils.SerializeXml(marketplace);
            const string expected =
                "<?xml version=\"1.0\" encoding=\"utf-8\"?><marketplace xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"https://schemas.cdon.com/product/4.0/4.9.0/product\"><product><identity><id>your_id</id><gtin>your_gtin</gtin><sku>your_sku</sku></identity><title><default>Default title</default><se>Swedish title</se></title><description><default><![CDATA[Default description with HTML-support]]></default><se><![CDATA[Swedish description with HTML-support]]></se></description><category><google>187</google><attributes><shoes_type>athletic_footwear-paddle_shoes</shoes_type></attributes></category><brand>Your brand</brand><usp><value><default>USP 1</default><se>Swedish USP 1</se></value><value><default>USP 2</default><se>Swedish USP 2</se></value></usp><variants><variantBySize><identity><id>your_sku</id><gtin>your_gtin</gtin></identity><size><default>44</default></size></variantBySize><variantBySize><identity><id>your_sku2</id><gtin>your_gtin2</gtin></identity><size><default>45</default></size></variantBySize></variants></product></marketplace>";
            Assert.Equal(expected, xml);
        }
    }
}
