using InventoryManagement.Models.InventoryApp;

namespace InventoryManagement.InventoryApp
{
    public class MockInventoryAppService : IInventoryAppService
    {
        public Task<List<NewProductsType>> GetNewProducts()
        {
            return Task.FromResult<List<NewProductsType>>(new());
        }

        public Task<List<ProductsType>> GetProducts()
        {
            return Task.FromResult<List<ProductsType>>(new());
        }
    }
}