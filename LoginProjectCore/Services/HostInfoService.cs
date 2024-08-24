using LoginProjectCore.Services.Implement;
using LoginProjectDomain.Models;
using LoginProjectInfrastructure.Repositories.Interface;

namespace LoginProjectCore.Services
{
    public class HostInfoService : IHostInfoService
    {
        private readonly IHostInfoRepository _hostInfoRepository;

        public HostInfoService(IHostInfoRepository hostInfoRepository)
        {
            _hostInfoRepository = hostInfoRepository;
        }

        public async Task<List<HostInfo>> GetAllHost()
        {
            return await _hostInfoRepository.GetAllHost();
        }

    }
}
