using NoName.Models;

namespace NoName.Repository
{
    public interface IProductRepository
    {
        void Add(Product product);

        Product Update(Product product);

        void Delete(int Id);

        Task<Product> GetProduct(int Id);

        Task<IEnumerable<Product>> GetAllProduct();
    }
}
