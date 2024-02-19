using BlazorAppPractice.Api.Entities;

namespace BlazorAppPractice.Api.Repositories.Contracts
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<IEnumerable<Product>> GetProduct(int id);
        Task<IEnumerable<ProductCategory>> GetProductCategories();
        Task<IEnumerable<ProductCategory>> GetProductCategory(int id);
    }
}
