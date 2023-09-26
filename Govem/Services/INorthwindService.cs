using Govem.Models.Northwind;

namespace Govem.Northwind
{
    public interface INorthwindService
    {
        Task<List<EmployeesType>> GetEmployees();

        Task<List<OrdersType>> GetOrders();
    }
}