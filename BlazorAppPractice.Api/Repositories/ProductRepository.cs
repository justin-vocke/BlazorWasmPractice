using BlazorAppPractice.Api.Entities;
using BlazorAppPractice.Api.Repositories.Contracts;

namespace BlazorAppPractice.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task<IEnumerable<Product>> GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductCategory>> GetProductCategories()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductCategory>> GetProductCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
