using LoginProjectDomain.ViewModels;

namespace LoginProjectDomain.Interfaces.IServices
{
    public interface ITrafficHostInfoService
    {
        Task<List<HostInfoViewModel>> GetAllHost();
    }
}
