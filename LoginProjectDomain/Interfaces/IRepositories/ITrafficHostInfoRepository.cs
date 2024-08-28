using LoginProjectDomain.Models;

namespace LoginProjectDomain.Interfaces.IRepositories
{
    public interface ITrafficHostInfoRepository
    {
        Task<List<HostInfo>> GetAllHost();
    }
}
