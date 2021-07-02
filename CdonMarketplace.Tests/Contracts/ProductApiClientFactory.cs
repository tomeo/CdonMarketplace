using CdonMarketplace.Clients;

namespace CdonMarketplace.Tests.Contracts
{
    public static class ProductApiClientFactory
    {
        public static ProductApiClient Create()
        {
            var environmentalVariables = LaunchSettingsProvider.GetEnvironmentalVariables();
            var uri = environmentalVariables["CDON_PRODUCT_API_URI"];
            var apiKey = environmentalVariables["CDON_API_KEY"];

            return new ProductApiClient(uri, apiKey);
        }
    }
}
