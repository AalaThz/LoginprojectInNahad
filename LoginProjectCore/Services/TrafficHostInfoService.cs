using LoginProjectDomain.Interfaces.IRepositories;
using LoginProjectDomain.Interfaces.IServices;
using LoginProjectDomain.ViewModels;

namespace LoginProjectCore.Services
{
    public class TrafficHostInfoService : ITrafficHostInfoService
    {
        private readonly ITrafficHostInfoRepository _hostInfoRepository;

        public TrafficHostInfoService(ITrafficHostInfoRepository hostInfoRepository) 
        {
            _hostInfoRepository=hostInfoRepository;
        }

        public async Task<List<HostInfoViewModel>> GetAllHost()
        {
            var hosts =await _hostInfoRepository.GetAllHost();
            var hostList = new List<HostInfoViewModel>();

            foreach (var host in hosts)
            {
                var hostView = new HostInfoViewModel
                {
                    Name = host.Name,
                    Id = host.Id,
                    BandWidth = host.BandWidth,
                    Price = host.Price,
                    OnlineSpace = host.OnlineSpace,
                    Support = host.Support,
                };
                hostList.Add(hostView);
            }
            return hostList;
        }

    }
}
