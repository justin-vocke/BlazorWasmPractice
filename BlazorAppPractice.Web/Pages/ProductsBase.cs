using BlazorAppPractice.Models.Dtos;
using BlazorAppPractice.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace BlazorAppPractice.Web.Pages
{
    public class ProductsBase: ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }

        public IEnumerable<ProductDto> Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetItems();
        }

        protected IOrderedEnumerable<IGrouping<int,  ProductDto>> GetGroupedProductsByBategory() 
        {
            return from product in Products
                    group product by product.CategoryId into prodByCatGroup
                    orderby prodByCatGroup.Key
                    select prodByCatGroup;
        }

        protected string GetCategoryName(IGrouping<int, ProductDto> groupedProductDtos) 
        {
            return groupedProductDtos.FirstOrDefault(pg => pg.CategoryId == groupedProductDtos.Key).CategoryName;
        }
    }
}
