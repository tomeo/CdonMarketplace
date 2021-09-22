using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CdonMarketplace.Contracts.Order;
using CdonMarketplace.Extensions;
using Newtonsoft.Json;

namespace CdonMarketplace.Clients
{
    public class OrderApiClient : IOrderApiClient
    {
        private readonly HttpClient _client;

        public OrderApiClient(string baseUrl, string apiKey)
        {
            _client = new HttpClient(new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip
            })
            {
                BaseAddress = new Uri(baseUrl)
            };
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("api", apiKey);
        }

        public async Task<IEnumerable<Order>> GetPendingOrders(PendingOrdersOptions options = null)
        {
            options ??= new PendingOrdersOptions();

            var response = await _client.GetAsync($"/api/order{options.ToQueryString()}");
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return Array.Empty<Order>();
            }
            response.EnsureSuccessStatusCode();

            return JsonConvert.DeserializeObject<Order[]>(
                await response.Content.ReadAsStringAsync());
        }

        public async Task<IEnumerable<Order>> GetAllPendingOrders(PendingOrdersOptions options = null)
        {
            options ??= new PendingOrdersOptions();

            var fetchedOrders = Array.Empty<Order>();
            var pendingOrders = new List<Order>();
            do
            {
                fetchedOrders = (await GetPendingOrders(options)).ToArray();
                pendingOrders.AddRange(fetchedOrders);
                options.Skip += options.Take;
            } while (fetchedOrders.Length == options.Take);
            return pendingOrders;
        }

        public async Task<Order> GetOrder(int orderId) => 
            await _client.GetAsync<Order>($"/api/order/{orderId}");

        public async Task<Order> FulfillOrderRows(OrderFulfillment orderFulfillment) =>
            await _client.PostAsync<Order>("api/orderdelivery", orderFulfillment);

        public async Task<Order> ReturnOrderRows(OrderReturn orderReturn) =>
            await _client.PostAsync<Order>("api/orderreturn", orderReturn);

        public async Task<Order> CancelOrderRows(OrderCancel orderCancel) =>
            await _client.PostAsync<Order>("api/ordercancel", orderCancel);

        public async Task<Order> WritedownOrderRows(OrderWritedown orderWritedown) =>
            await _client.PostAsync<Order>("api/orderwritedown", orderWritedown);

        public async Task<Order> PackageOrderRows(OrderPackage orderPackage) =>
            await _client.PostAsync<Order>("api/orderpackage", orderPackage);

        public async Task<Order> PickOrderRows(OrderPicking orderPicking) =>
            await _client.PostAsync<Order>("api/orderpicking", orderPicking);

        public async Task<Order> ShipOrderRows(OrderShipping orderShipping) =>
            await _client.PostAsync<Order>("api/ordershipping", orderShipping);

        public async Task<Order> ChargeNpuFee(OrderNpuFee orderNpuFee) =>
            await _client.PostAsync<Order>("api/npu/chargenpufee", orderNpuFee);

        public async Task<Order> RetractNpuFee(int orderId) =>
            await _client.PostAsync<Order>($"api/npu/retractnpufee/{orderId}", null);

        public async Task<IEnumerable<PackageCarrier>> GetPackageCarriers() =>
            await _client.GetAsync<PackageCarrier[]>("api/packagecarrier");

        public async Task<IEnumerable<OrderReturnAddress>> GetOrderReturnAddresses() =>
            await _client.GetAsync<OrderReturnAddress[]>("api/returnaddress");

        public async Task<Stream> GetDeliveryNote(OrderDeliveryNote orderDeliveryNote)
        {
            const string url = "api/deliverynote";
            var response = await _client.PostJsonAsync(url, orderDeliveryNote);

            if (!response.IsSuccessStatusCode)
            {
                throw new ApiException
                (
                    (int)response.StatusCode,
                    null,
                    $"{_client.BaseAddress}/{url}"
                );
            }

            return await response.Content.ReadAsStreamAsync();
        }
    }
}
