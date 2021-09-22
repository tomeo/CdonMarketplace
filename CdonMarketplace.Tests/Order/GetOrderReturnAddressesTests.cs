using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CdonMarketplace.Tests.Order
{
    public class GetOrderReturnAddressesTests
    {
        [Fact(Skip = "Not a real unit test")]
        public async Task ShouldGetAllOrderReturnAddresses()
        {
            var client = OrderApiClientFactory.Create();
            var returnAddresses = await client.GetOrderReturnAddresses();
            Assert.True(returnAddresses.Count() >= 0);
        }
    }
}
