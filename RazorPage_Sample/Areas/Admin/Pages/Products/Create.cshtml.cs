using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage_Sample.Services;

namespace RazorPage_Sample.Areas.Admin.Pages.Products
{
    public class CreateModel : PageModel
    {

        [BindProperty]
        public ProductDto Product { get; set; } = new ProductDto();

        private readonly IProductService _productService;
        public CreateModel(IProductService productService)
        {
            _productService = productService;
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            _productService.Add(Product);
        }
    }
}
