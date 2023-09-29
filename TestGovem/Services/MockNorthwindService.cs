using Govem.Models.Northwind;

namespace Govem.Northwind
{
    public class MockNorthwindService : INorthwindService
    {
        public Task<List<EmployeesType>> GetEmployees()
        {
            return Task.FromResult<List<EmployeesType>>(new());
        }

        public Task<List<OrdersType>> GetOrders()
        {
            return Task.FromResult<List<OrdersType>>(new());
        }
    }
}