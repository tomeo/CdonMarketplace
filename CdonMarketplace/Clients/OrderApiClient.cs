using System;
using System.Collections.Generic;
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

        public async Task<Order> GetOrder(int orderId)
        {
            var response = await _client.GetAsync($"/api/order/{orderId}");
            response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<Order>(
                await response.Content.ReadAsStringAsync());
        }

        public async Task<Order> FulfillOrderRows(OrderFulfillment orderFulfillment)
        {
            var response = await _client.PostJson("api/orderdelivery", orderFulfillment);
            response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<Order>(
                await response.Content.ReadAsStringAsync());
        }

        public async Task<Order> ReturnOrderRows(OrderReturn orderReturn)
        {
            var response = await _client.PostJson("api/orderreturn", orderReturn);
            response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<Order>(
                await response.Content.ReadAsStringAsync());
        }

        public async Task<Order> CancelOrderRows(OrderCancel orderCancel)
        {
            var response = await _client.PostJson("api/ordercancel", orderCancel);
            response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<Order>(
                await response.Content.ReadAsStringAsync());
        }
    }
}
