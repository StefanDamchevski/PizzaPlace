using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Pages.Dashboard
{
    [Authorize(Roles = "Admin")]
    public class UsersListModel : PageModel
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UsersListModel(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        public List<IdentityUser> Users { get; set; }
        public List<IdentityRole> Roles { get; set; }
        public void OnGet()
        {
            Users = userManager.Users.ToList();
            Roles = roleManager.Roles.ToList();
        }

        public async Task<IActionResult> OnGetAddRole(string roleName, string userId)
        {
            IdentityUser user = await userManager.FindByIdAsync(userId);
            await userManager.AddToRoleAsync(user, roleName);
            return RedirectToPage();
        }

        public async Task<IActionResult> OnGetRemoveRole(string roleName, string userId)
        {
            IdentityUser user = await userManager.FindByIdAsync(userId);
            await userManager.RemoveFromRoleAsync(user, roleName);
            return RedirectToPage();
        }
        public async Task<IActionResult> OnGetDeleteUser(string id)
        {
            IdentityUser user = await userManager.FindByIdAsync(id);
            await userManager.DeleteAsync(user);
            return RedirectToPage();
        }
    }
}