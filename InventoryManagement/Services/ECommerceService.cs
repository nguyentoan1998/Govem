using System.Net.Http.Json;
using InventoryManagement.Models.ECommerce;

namespace InventoryManagement.ECommerce
{
    public class ECommerceService: IECommerceService
    {
        private readonly HttpClient _http;

        public ECommerceService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<SalesType>> GetSales()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/f9942c71-b172-4060-4381-08da496bf5f2", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<SalesType>>().ConfigureAwait(false);
            }

            return new List<SalesType>();
        }

        public async Task<List<RevenueType>> GetRevenue()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/03e74dde-d2e1-4fee-437d-08da496bf5f2", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<RevenueType>>().ConfigureAwait(false);
            }

            return new List<RevenueType>();
        }
    }
}