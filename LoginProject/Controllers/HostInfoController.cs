using LoginProjectDomain.Interfaces.IServices;
using LoginProjectDomain.Models;
using LoginProjectDomain.ViewModels;
using LoginProjectInfrastructure.Repositories.Interface;
using LoginProjectUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginProjectUI.Controllers
{
    public class HostInfoController : Controller
    {
        private readonly ITrafficHostInfoService _hostInfoService;

        public HostInfoController(ITrafficHostInfoService hostInfoService) 
        {
            _hostInfoService=hostInfoService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> List()
        {
            var hosts =await _hostInfoService.GetAllHost();
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
