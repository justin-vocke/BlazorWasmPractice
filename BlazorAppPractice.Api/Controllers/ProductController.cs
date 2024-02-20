using BlazorAppPractice.Api.Data;
using BlazorAppPractice.Api.Extensions;
using BlazorAppPractice.Api.Repositories.Contracts;
using BlazorAppPractice.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAppPractice.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts()
        {
            try
            {
                var products = await _productRepository.GetProducts();
                var categories = await _productRepository.GetProductCategories();

                if(products is null || categories is null)
                {
                    return NotFound();
                }
                else
                {
                    var productDtos = products.ConvertToDto(categories);
                    return Ok(productDtos);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
            
        }
    }
}
