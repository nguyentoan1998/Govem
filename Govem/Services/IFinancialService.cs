using Govem.Models.Financial;

namespace Govem.Financial
{
    public interface IFinancialService
    {
        Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue();
    }
}