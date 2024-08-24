using LoginProjectDomain.Models;

namespace LoginProjectCore.Services.Implement
{
    public interface IHostInfoService
    {
        Task<List<HostInfo>> GetAllHost();
    }
}
