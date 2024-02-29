using BlazorAppPractice.Models.Dtos;

namespace BlazorAppPractice.Web.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetItems();
        Task<ProductDto> GetItem(int id);
    }
}
