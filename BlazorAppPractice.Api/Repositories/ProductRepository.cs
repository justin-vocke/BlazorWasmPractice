using BlazorAppPractice.Api.Data;
using BlazorAppPractice.Api.Entities;
using BlazorAppPractice.Api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppPractice.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShopOnlineContext _context;

        public ProductRepository(ShopOnlineContext shopOnlineContext)
        {
            _context = shopOnlineContext;
        }
        public Task<Product> GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductCategory>> GetProductCategories()
        {
            return await _context.ProductCategories.ToListAsync();
        }

        public async Task<ProductCategory> GetProductCategory(int id)
        {
            return await _context.ProductCategories.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
