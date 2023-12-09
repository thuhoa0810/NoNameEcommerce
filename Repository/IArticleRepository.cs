using NoName.Models;

namespace NoName.Repository
{
    public interface IArticleRepository
    {
        void Add(Article article);

        Article Update(Article article);

        void Delete(int Id);

        Task<Article> GetArticle(int Id);

        Task<IEnumerable<Article>> GetAllArticle();
    }
}
