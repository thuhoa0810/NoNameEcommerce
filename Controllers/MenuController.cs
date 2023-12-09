using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoName.Repository;

namespace NoName.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuRepository _menuRepository;

        public MenuController(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }
        // GET: MenuController
        public async Task<ActionResult> Index()
        {
            var menus = await _menuRepository.GetAllMenu();
            return View(menus);
        }

        // GET: MenuController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MenuController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MenuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MenuController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MenuController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MenuController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MenuController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
