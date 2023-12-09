using NoName.Models;

namespace NoName.Repository
{
    public interface IReviewRepository
    {
        void Add(Review review);

        Review Update(Review review);

        void Delete(int Id);

        Task<Review> GetReview(int Id);

        Task<IEnumerable<Review>> GetAllReview();
    }
}
