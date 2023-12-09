using Microsoft.AspNetCore.Mvc;
using NoName.Repository;

namespace NoName.ViewComponents
{
    public class CategoryMenuViewComponent : ViewComponent
    {
        private readonly IMenuRepository _menuRepository;

        public CategoryMenuViewComponent(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var menus = await _menuRepository.GetAllMenu();
            return View(menus);
        }
    }
}
