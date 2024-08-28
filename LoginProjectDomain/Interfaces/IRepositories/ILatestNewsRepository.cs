using LoginProjectDomain.Models;

namespace LoginProjectDomain.Interfaces.IRepositories
{
    public interface ILatestNewsRepository
    {
        Task<List<LastNews>> GetAll();
        void Add(LastNews news);
    }
}
