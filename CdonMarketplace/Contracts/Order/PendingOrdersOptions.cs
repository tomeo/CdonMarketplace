using System.Text;

namespace CdonMarketplace.Contracts.Order
{
    public class PendingOrdersOptions
    {
        public int Take { get; set; } = 200;
        public int Skip { get; set; } = 0;
        public string CustomerType { get; set; }
        public string CountryCode { get; set; }
        public string DateTimeRangeMin { get; set; }
        public string DateTimeRangeMax { get; set; }
        public int? LastFetchedOrderId { get; set; }
        public string SortBy { get; set; }
        public string SortDirection { get; set; }

        public string ToQueryString()
        {
            var sb = new StringBuilder($"?take={Take}&skip={Skip}");

            if (!string.IsNullOrWhiteSpace(CustomerType))
            {
                sb.Append($"&customerType={CustomerType}");
            }

            if (!string.IsNullOrWhiteSpace(CountryCode))
            {
                sb.Append($"&countryCode={CountryCode}");
            }

            if (!string.IsNullOrWhiteSpace(DateTimeRangeMin))
            {
                sb.Append($"&dateTimeRangeMin={DateTimeRangeMin}");
            }

            if (!string.IsNullOrWhiteSpace(DateTimeRangeMax))
            {
                sb.Append($"&dateTimeRangeMax={DateTimeRangeMax}");
            }

            if (LastFetchedOrderId.HasValue)
            {
                sb.Append($"&lastFetchedOrderId={LastFetchedOrderId}");
            }

            if (!string.IsNullOrWhiteSpace(SortBy))
            {
                sb.Append($"&sortBy={SortBy}");
            }

            if (!string.IsNullOrWhiteSpace(SortDirection))
            {
                sb.Append($"&sortDirection={SortDirection}");
            }

            return sb.ToString();
        }
    }
}
