using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NoName.Areas.Identity.Data;

namespace NoName.Controllers
{
    public class AppRolesController : Controller
    {
        private readonly RoleManager<ApplicationUser> _roleManager;

        public AppRolesController(RoleManager<ApplicationUser> roleManager)
        {
            _roleManager = roleManager;
        }

        //List all roles created by users
        public IActionResult Index()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole model)
        {
            return View();
        }
    }
}
