using System.Net.Http.Json;
using Govem.Models.Northwind;

namespace Govem.Northwind
{
    public class NorthwindService: INorthwindService
    {
        private readonly HttpClient _http;

        public NorthwindService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<EmployeesType>> GetEmployees()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("/static-data/northwind-employees-type.json", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<EmployeesType>>().ConfigureAwait(false);
            }

            return new List<EmployeesType>();
        }

        public async Task<List<OrdersType>> GetOrders()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("/static-data/northwind-orders-type.json", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<OrdersType>>().ConfigureAwait(false);
            }

            return new List<OrdersType>();
        }
    }
}