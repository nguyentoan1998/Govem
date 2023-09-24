using InventoryManagement.Models.ECommerce;

namespace InventoryManagement.ECommerce
{
    public class MockECommerceService : IECommerceService
    {
        public Task<List<SalesType>> GetSales()
        {
            return Task.FromResult<List<SalesType>>(new());
        }

        public Task<List<RevenueType>> GetRevenue()
        {
            return Task.FromResult<List<RevenueType>>(new());
        }
    }
}