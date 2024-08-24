using LoginProjectCore.Services.Implement;
using LoginProjectDomain.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace LoginProjectDomain.Models.Component
{
    [ViewComponent(Name ="TrafficHostVM")]
    public class TrafficHostsViewComponent : ViewComponent
    {
        
        private readonly IHostInfoService _hostInfoService;

        public TrafficHostsViewComponent(IHostInfoService hostInfoService)
        {
            _hostInfoService=hostInfoService;
        }
        public IViewComponentResult Invoke()
        {
            //Using GetAwaiter().GetResult() to synchronously wait on an asynchronous
            var hosts = _hostInfoService.GetAllHost().GetAwaiter().GetResult();
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
