using System;
using System.IO;
using System.Threading.Tasks;
using CdonMarketplace.Contracts.Order;
using Xunit;

namespace CdonMarketplace.Tests.Order
{
    public class GetDeliveryNoteTests
    {
        [Fact(Skip = "Not a real unit test")]
        public async Task ShouldGetAllOrderReturnAddresses()
        {
            var env = LaunchSettingsProvider.GetEnvironmentalVariables();
            var client = OrderApiClientFactory.Create();
            var request = new OrderDeliveryNote
            {
                AddressId = env["CDON_RETURN_ADDRESS_ID"],
                OrderId = int.Parse(env["GETORDER_ORDERID"]),
                DeliveryNoteRows = new[]
                {
                    new OrderDeliveryNoteRow
                    {
                        ProductId = "test_sku",
                        ProductName = "test_name",
                        Quantity = 1,
                        PickingLocation = "test_picking_location",
                    }
                }
            };
            var stream = await client.GetDeliveryNote(request);
            var base64 = StreamToBase64(stream);
            Assert.True(base64.Length > 30_000);
        }
        private static string StreamToBase64(Stream stream)
        {
            using var memoryStream = new MemoryStream();
            stream.CopyTo(memoryStream);
            var bytes = memoryStream.ToArray();

            return Convert.ToBase64String(bytes);
        }
    }
}
