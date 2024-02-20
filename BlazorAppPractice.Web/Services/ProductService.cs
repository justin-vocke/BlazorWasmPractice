using BlazorAppPractice.Models.Dtos;
using BlazorAppPractice.Web.Services.Contracts;

namespace BlazorAppPractice.Web.Services
{
    public class ProductService : IProductService
    {
        public Task<IEnumerable<ProductDto>> GetItems()
        {
            throw new NotImplementedException();
        }
    }
}
