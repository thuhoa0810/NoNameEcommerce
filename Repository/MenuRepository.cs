using Microsoft.EntityFrameworkCore;
using NoName.Data;
using NoName.Models;

namespace NoName.Repository
{
    public class MenuRepository : IMenuRepository
    {
        private readonly NoNameDbContext _context;

        public MenuRepository(NoNameDbContext context)
        {
            _context = context;
        }
        public void Add(Menu menu)
        {
            _context.Menus.Add(menu);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var menu = _context.Menus.Find(Id);
            if(menu != null)
            {
                _context.Remove(menu);
                _context.SaveChanges();
            }
        }

        public async Task<IEnumerable<Menu>> GetAllMenu()
        {
            return await _context.Menus.ToListAsync<Menu>();    
        }

        public async Task<Menu> GetMenu(int Id)
        {
            return await _context.Menus.FindAsync(Id);
        }

        public Menu Update(Menu menu)
        {
            _context.Menus.Update(menu);
            _context.SaveChanges();
            return menu;
        }
    }
}
