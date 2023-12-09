using NoName.Models;

namespace NoName.Repository
{
    public interface IMenuRepository
    {
        void Add(Menu menu);

        Menu Update(Menu menu);

        void Delete(int Id);

        Task<Menu> GetMenu(int Id);

        Task<IEnumerable<Menu>> GetAllMenu();
    }
}
