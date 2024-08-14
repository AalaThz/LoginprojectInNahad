using LoginProjectDomain.ViewModels;
using LoginProjectInfrastructure.Contexts;
using LoginProjectInfrastructure.Repositories.Interface;
using LoginProjectUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LoginProjectDomain.Models.Component
{
    [ViewComponent(Name ="TrafficHostVM")]
    public class TrafficHostsViewComponent : ViewComponent
    {
        
        private readonly IHostInfoRepository _hostInfoRepository;

        public TrafficHostsViewComponent(IHostInfoRepository hostInfoRepository)
        {
            _hostInfoRepository=hostInfoRepository;
        }
        public IViewComponentResult Invoke()
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
            return View(hostList);
        }
    }
}
