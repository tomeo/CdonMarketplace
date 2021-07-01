using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CdonMarketplace.Tests.Order
{
    public class PendingOrderTests
    {
        [Fact(Skip = "Not a real unit test")]
        public async Task ShouldGetAllPendingOrders()
        {
            var client = OrderApiClientFactory.Create();
            var orders = await client.GetAllPendingOrders();
            Assert.True(orders.Count() >= 0);
        }
    }
}
