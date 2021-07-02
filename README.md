# CDON Marketplace

```
Install-Package CdonMarketplace -Version 2.0.0-alpha4
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
var product = new CdonMarketplace.Product.Product
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
```

#### Categories and attributes

General information about categories and attributes in the CDON Marketplace API can be found at the CDON Marketplace Help Center [Categories, Attributes & Navigation](https://connect.marketplace.cdon.com/help/product_data_specification) page.

Quicklinks:
* [Google Category Taxonomy](https://www.google.com/basepages/producttype/taxonomy.en-US.txt)
* [Excel-file containing Google Categories and Attributes](https://mcprodsa.blob.core.windows.net/public/CDON%20-%20Categories,%20Attributes%20&%20Navigation.xlsx)

### Creating price

```cs
var price = new CdonMarketplace.Price.Product
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
        IsShippedFromEU = true,
        ShippingCost = MarketDKShippingCost.Item0,
        Vat = 25,
    },
    // No, Fi...
}
```

#### ShippingCost

Shipping costs are set per variant and per channel. The shipping cost has to be set to one of the predefined levels for each channel:

| MarketSEShippingCost | Cost     |
| -------------------- | -------- |
| Item0                | 0 SEK    |
| Item19               | 19 SEK   |
| Item29               | 29 SEK   |
| Item39               | 39 SEK   |
| Item49               | 49 SEK   |
| Item59               | 59 SEK   |
| Item79               | 79 SEK   |
| Item99               | 99 SEK   |
| Item199              | 199 SEK  |
| Item249              | 249 SEK  |
| Item295              | 295 SEK  |
| Item299              | 299 SEK  |
| Item395              | 395 SEK  |
| Item495              | 495 SEK  |
| Item499              | 499 SEK  |
| Item995              | 995 SEK  |
| Item1195             | 1195 SEK |
| Item1499             | 1499 SEK |
| Item3499             | 3499 SEK |

| MarketDKShippingCost | Cost    |
| -------------------- | ------- |
| Item0                | 0 DKK   |
| Item19               | 19 DKK  |
| Item29               | 29 DKK  |
| Item39               | 39 DKK  |
| Item49               | 49 DKK  |
| Item59               | 59 DKK  |
| Item79               | 79 DKK  |
| Item99               | 99 DKK  |
| Item199              | 199 DKK |
| Item200              | 200 DKK |
| Item299              | 299 DKK |
| Item300              | 300 DKK |
| Item495              | 495 DKK |
| Item995              | 995 DKK |

| MarketNOShippingCost | Cost    |
| -------------------- | ------- |
| Item0                | 0 NOK   |
| Item19               | 19 NOK  |
| Item39               | 39 NOK  |
| Item49               | 49 NOK  |
| Item59               | 59 NOK  |
| Item79               | 79 NOK  |
| Item99               | 99 NOK  |
| Item199              | 199 NOK |
| Item285              | 285 NOK |
| Item385              | 385 NOK |
| Item399              | 399 NOK |
| Item495              | 799 NOK |
| Item995              | 995 NOK |

| MarketFIShippingCost | Cost      |
| -------------------- | --------- |
| Item0                | 0 EUR     |
| Item1Period95        | 1.95 EUR  |
| Item2Period95        | 2.95 EUR  |
| Item3Period95        | 3.95 EUR  |
| Item4Period90        | 4.90 EUR  |
| Item4Period95        | 4.95 EUR  |
| Item5Period95        | 5.95 EUR  |
| Item7Period95        | 7.95 EUR  |
| Item9Period95        | 9.95 EUR  |
| Item19Period5        | 19.95 EUR |
| Item29               | 29 EUR    |
| Item39               | 39 EUR    |
| Item39Period5        | 39.5 EUR  |
| Item59               | 59 EUR    |
| Item79               | 79 EUR    |
| Item99Period5        | 99.5 EUR  |

### ProductApiClient
The `ProductApiClient` will post your products directly to CDON using `CDON_BASEURI` as the API-URL and `CDON_APIKEY` as the API-Key. You will find your API-Key at the bottom of the [Connect Help Page](https://connect.marketplace.cdon.com/help).

In Startup.cs:
```cs
services.AddSingleton<IProductApiClient>(
    new ProductApiClient(
        Environment.GetEnvironmentVariable("CDON_BASEURI"),
        Environment.GetEnvironmentVariable("CDON_APIKEY")));
```

### ProductApiFileSystemClient
The `ProductApiFileSystemClient` will create XML on your machine on the path `OUTPUT_PATH` that you provide. This is mainly used for debugging.

```cs
services.AddSingleton<IProductApiClient>(
    new ProductApiFileSystemClient(
        Environment.GetEnvironmentVariable("OUTPUT_PATH")));
```

### Using IProductApiClient
```cs
public class CdonHandler
{
    private readonly IProductApiClient _client;

    public async Task HandleProducts(IEnumerable<CdonMarketplace.Product.Product> products)
    {
        var productReceipt = await _client.UploadProduct(new CdonMarketplace.Product.Marketplace
        {
            Product = products
        });
    }

    public async Task HandlePrices(IEnumerable<CdonMarketplace.Price.Product> prices)
    {
        var priceReceipt = await _client.UploadProduct(new CdonMarketplace.Price.Marketplace
        {
            Product = prices
        });
    }
}
```