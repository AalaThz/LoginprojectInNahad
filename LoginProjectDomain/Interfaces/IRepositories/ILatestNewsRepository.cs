using LoginProjectDomain.Models;

namespace LoginProjectDomain.Interfaces.IRepositories
{
    public interface ILatestNewsRepository
    {
        Task<List<LastNews>> GetAll();
        Task<List<LastNews>> GetAllBlogPage();
        void Add(LastNews news);
        LastNews GetNewsById(int id);
    }
}
