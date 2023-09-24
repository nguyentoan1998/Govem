using InventoryManagement.Models.ECommerce;

namespace InventoryManagement.ECommerce
{
    public interface IECommerceService
    {
        Task<List<SalesType>> GetSales();

        Task<List<RevenueType>> GetRevenue();
    }
}