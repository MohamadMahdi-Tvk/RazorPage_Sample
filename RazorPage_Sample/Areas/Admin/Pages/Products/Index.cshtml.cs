using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage_Sample.Services;

namespace RazorPage_Sample.Areas.Admin.Pages.Products
{
    public class IndexModel : PageModel
    {
        public List<ProductDto> Products { get; set; } = new List<ProductDto>();

        private readonly IProductService _productService;
        public IndexModel(IProductService service)
        {
            _productService = service;
        }

        public void OnGet()
        {
            Products = _productService.List();
        }
    }
}
