using BlazorAppPractice.Api.Entities;

namespace BlazorAppPractice.Api.Repositories.Contracts
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int id);
        Task<IEnumerable<ProductCategory>> GetProductCategories();
        Task<ProductCategory> GetProductCategory(int id);
    }
}
