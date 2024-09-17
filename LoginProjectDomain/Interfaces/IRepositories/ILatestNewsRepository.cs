using LoginProjectDomain.Models;

namespace LoginProjectDomain.Interfaces.IRepositories
{
    public interface ILatestNewsRepository
    {
        Task<List<LastNews>> GetAll();
        Task<List<LastNews>> GetAllAdmin();
        Task<List<LastNews>> GetAllNewsBlogPage();
        Task Add(LastNews news);
        Task<LastNews> GetNewsById(int id);
        Task Update(LastNews news);
    }
}
