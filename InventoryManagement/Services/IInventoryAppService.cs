using InventoryManagement.Models.InventoryApp;

namespace InventoryManagement.InventoryApp
{
    public interface IInventoryAppService
    {
        Task<List<NewProductsType>> GetNewProducts();

        Task<List<ProductsType>> GetProducts();
    }
}