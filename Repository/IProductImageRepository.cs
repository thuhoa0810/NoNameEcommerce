using NoName.Models;

namespace NoName.Repository
{
    public interface IProductImageRepository
    {
        void Add(ProductImage productImage);

        ProductImage Update(ProductImage productImage);

        void Delete(int Id);

        Task<ProductImage> GetProductImage(int Id);

        Task<IEnumerable<ProductImage>> GetAllProductImage();
    }
}
