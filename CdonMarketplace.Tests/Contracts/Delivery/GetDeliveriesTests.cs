using System.Threading.Tasks;
using Xunit;

namespace CdonMarketplace.Tests.Contracts.Delivery
{
    public class GetDeliveriesTests
    {
        [Fact(Skip = "Not a real unit test")]
        public async Task ShouldGetDeliveries()
        {
            var client = ProductApiClientFactory.Create();
            var deliveries = await client.GetDeliveries();
            Assert.NotEmpty(deliveries);
        }
    }
}
