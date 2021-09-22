using System;
using System.Threading.Tasks;
using Xunit;

namespace CdonMarketplace.Tests.Order
{
    public class GetOrderTests
    {
        [Fact(Skip = "Not a real unit test")]
        public async Task ShouldGetOrder()
        {
            var orderId = LaunchSettingsProvider.GetEnvironmentalVariables()["GETORDER_ORDERID"];
            var client = OrderApiClientFactory.Create();
            var order = await client.GetOrder(Convert.ToInt32(orderId));
            Assert.NotNull(order);
        }
    }
}
