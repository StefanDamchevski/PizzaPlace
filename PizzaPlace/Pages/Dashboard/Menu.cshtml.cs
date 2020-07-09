using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaPlace.Pages.Dashboard
{
    [Authorize]
    public class MenuModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}