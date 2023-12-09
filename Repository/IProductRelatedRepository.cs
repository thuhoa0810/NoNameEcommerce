using NoName.Models;

namespace NoName.Repository
{
    public interface IProductRelatedRepository
    {
        void Add(ProductRelated productRelated);

        ProductRelated Update(ProductRelated productRelated);

        void Delete(int Id);

        Task<ProductRelated> GetProductRelated(int Id);

        Task<IEnumerable<ProductRelated>> GetAllProductRelated();
    }
}
