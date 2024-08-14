using LoginProjectDomain.Models;
using LoginProjectDomain.ViewModels;
using LoginProjectInfrastructure.Repositories.Interface;
using LoginProjectUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginProjectUI.Controllers
{
    public class HostInfoController : Controller
    {
        private readonly IHostInfoRepository _hostInfoRepository;

        public HostInfoController(IHostInfoRepository hostInfoRepository) 
        {
            _hostInfoRepository=hostInfoRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var hosts = _hostInfoRepository.GetAllHost();
            var hostList = new List<HostInfoViewModel>();
            foreach (var item in hosts)
            {
                var hostInfoView = new HostInfoViewModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    Price = item.Price,
                    BandWidth = item.BandWidth,
                    OnlineSpace = item.OnlineSpace,
                    Support = item.Support,
                };
                hostList.Add(hostInfoView);

            }

            return View(hostList.ToList());
        }


    }
}
