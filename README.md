# CDON Marketplace

```
Install-Package CdonMarketplace
```

## Product API

The product API uses four different types to describe a product:

| Type         | Description                            |
| ------------ | -------------------------------------- |
| Product      | Product data such as title, brand etc. |
| Price        | Prices, shipping etc.                  |
| Availability | Status, Stock levels etc.              |
| Media        | Images and videos                      |

### Creating product

```cs
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
```

#### Categories and attributes

All Google categories come from https://www.google.com/basepages/producttype/taxonomy.en-US.txt

### ProductApiClient

In Startup.cs:
```cs
services.AddSingleton<IProductApiClient>(
    new ProductApiClient(
        Configuration.Get("CDON_BASEURI"),
        Configuration.Get("CDON_APIKEY")));
```

```cs
public class ProductHandler
{
    private readonly IProductApiClient _client;

    public async Task Handle(IEnumerable<CdonMarketplace.Product.Product> products)
    {
        var productReceipt = await _client.UploadProduct(new CdonMarketplace.Product.Marketplace
        {
            Product = products
        });
    }
}
```

## Deploy package
```
docker build . --build-arg API_KEY=<API_KEY>
```