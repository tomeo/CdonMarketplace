using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CdonMarketplace.Factories;
using CdonMarketplace.Product;
using CdonMarketplace.Utils;
using Xunit;

namespace CdonMarketplace.Tests.Utils
{
    public class SizeEstimatorTests
    {
        [Fact]
        public void Test()
        {
            var product =
                new CdonMarketplace.Product.Product {
                        Identity = new Identity { Id = "your_id", Sku = "your_sku", Gtin = "your_gtin", },
                        Title = new Title {
                            Default = "Default title", Se = "Swedish title",
                            // Dk, No, Fi...
                        },
                        Brand = "Your brand",
                        Category =
                            new Category {
                                Google = "187",
                                Attributes =
                                    AttributeFactory.Create(new[] { ("shoes_type", "athletic_footwear-paddle_shoes") }),
                            },
                        Description = new Description {
                            Default = "Default description with HTML-support",
                            Se = "Swedish description with HTML-support",
                            // Dk, No, Fi...
                        },
                        Usp = new List<UspValue> {
                            new UspValue {
                                Default = "USP 1", Se = "Swedish USP 1",
                                // Dk, No, Fi...
                            },
                            new UspValue {
                                Default = "USP 2", Se = "Swedish USP 2",
                                // Dk, No, Fi...
                            }
                        },
                        Variants = new Variants {
                            VariantBySize = new List<VariantBySize> {
                                new VariantBySize {
                                    Identity = new Identity { Id = "your_sku", Gtin = "your_gtin" },
                                    Size = new Untranslatable { Default = "44" },
                                },
                                new VariantBySize {
                                    Identity = new Identity { Id = "your_sku2", Gtin = "your_gtin2" },
                                    Size = new Untranslatable { Default = "45" },
                                }
                            }
                        }
                };

            var products = Enumerable.Range(0, 100).Select(_ => product).ToList();
            var batches = new SizeEstimator(50_000, 10).GetInBatches(products).ToList();

            Assert.Empty(products.Except(batches.SelectMany(batch => batch)));
        }
    }
}
