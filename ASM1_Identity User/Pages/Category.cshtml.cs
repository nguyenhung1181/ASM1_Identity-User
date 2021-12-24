using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASM1_Identity_User.Pages
{
    [Authorize]
    public class CategoryModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
