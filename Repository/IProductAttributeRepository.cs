using NoName.Models;

namespace NoName.Repository
{
    public interface IProductAttributeRepository
    {
        void Add(ProductAttribute productAttribute);

        ProductAttribute Update(ProductAttribute productAttribute);

        void Delete(int Id);

        Task<ProductAttribute> GetProductAttribute(int Id);

        Task<IEnumerable<ProductAttribute>> GetAllProductAttribute();
    }
}
