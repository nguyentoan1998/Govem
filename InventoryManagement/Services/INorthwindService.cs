using InventoryManagement.Models.Northwind;

namespace InventoryManagement.Northwind
{
    public interface INorthwindService
    {
        Task<List<EmployeesType>> GetEmployees();

        Task<List<OrdersType>> GetOrders();
    }
}