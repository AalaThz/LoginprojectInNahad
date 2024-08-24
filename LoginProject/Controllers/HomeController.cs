using LoginProject.Models;
using LoginProjectDomain.Models;
using LoginProjectInfrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LoginProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BaseRepository _baseRepository;

        public HomeController(ILogger<HomeController> logger,
                              BaseRepository baseRepository)
        {
            _logger = logger;
            _baseRepository=baseRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            var model = new HostInfo();
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(HostInfo model)
        {
            if (ModelState.IsValid)
            {
                var hostInfo = new HostInfo
                {
                    Id = model.Id,
                    Name = model.Name,
                    BandWidth = model.BandWidth,
                    OnlineSpace = model.OnlineSpace,
                    Price = model.Price,
                    Support = model.Support,
                };
                _baseRepository.Add(hostInfo);
            }
            return View(model);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
