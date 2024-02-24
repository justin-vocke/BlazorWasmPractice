using BlazorAppPractice.Models.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorAppPractice.Web.Pages
{
    public class DisplayProductsBase: ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
