using LoginProjectDomain.Interfaces.IServices;
using LoginProjectDomain.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace LoginProjectDomain.Models.Component
{
    [ViewComponent(Name ="TrafficHostVM")]
    public class TrafficHostsInfoViewComponent : ViewComponent
    {
        private readonly ITrafficHostInfoService _trafficHostInfoService;

        public TrafficHostsInfoViewComponent(ITrafficHostInfoService trafficHostInfoService)
        {
            _trafficHostInfoService=trafficHostInfoService;
        }

        public IViewComponentResult Invoke()
        {
            //Using GetAwaiter().GetResult() to synchronously wait on an asynchronous
            var hosts = _trafficHostInfoService.GetAllHost().GetAwaiter().GetResult();
            return View(hosts);
        }
    }
}
