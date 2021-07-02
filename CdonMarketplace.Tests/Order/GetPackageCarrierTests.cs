using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CdonMarketplace.Tests.Order
{
    public class GetPackageCarrierTests
    {
        [Fact(Skip = "Not a real unit test")]
        public async Task ShouldGetAllPackageCarriers()
        {
            var client = OrderApiClientFactory.Create();
            var packageCarriers = await client.GetPackageCarriers();
            Assert.True(packageCarriers.Count() >= 0);
        }
    }
}
