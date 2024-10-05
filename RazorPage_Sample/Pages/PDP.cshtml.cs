using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPage_Sample.Pages
{
    public class PDPModel : PageModel
    {
        // Slug => better url for (SEO)
        public void OnGet(string Slug)
        {
            //we can find product by Slug
        }
    }
}
