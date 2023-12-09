using NoName.Models;

namespace NoName.Repository
{
    public interface IAttributeRepository
    {
        void Add(Attribute attribute);

        Attribute Update(Attribute attribute);

        void Delete(int Id);

        Task<Attribute> GetAttribute(int Id);

        Task<IEnumerable<Attribute>> GetAllAttribute();
    }
}
