using CdonMarketplace.Clients;

namespace CdonMarketplace.Tests.Order
{
    public static class OrderApiClientFactory
    {
        public static OrderApiClient Create()
        {
            var environmentalVariables = LaunchSettingsProvider.GetEnvironmentalVariables();
            var uri = environmentalVariables["CDON_MARKETPLACE_URI"];
            var apiKey = environmentalVariables["CDON_API_KEY"];

            return new OrderApiClient(uri, apiKey);
        }
    }
}
