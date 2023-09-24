using InventoryManagement.Models.Financial;

namespace InventoryManagement.Financial
{
    public interface IFinancialService
    {
        Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue();
    }
}