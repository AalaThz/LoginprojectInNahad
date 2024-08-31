using LoginProjectDomain.Interfaces.IServices;
using LoginProjectDomain.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LoginProjectUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LatestNewsAdminController : Controller
    {
        private readonly ILatestNewsService _latestNewsService;

        public LatestNewsAdminController(ILatestNewsService latestNewsService)
        {
            _latestNewsService=latestNewsService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> List()
        {
            var news = await _latestNewsService.GetAllNewsAsync();
            return View(news);
        }

        public IActionResult Add()
        {
            var model = new LatestNewsViewModelAdd();
            return View(model);
        }


        [HttpPost]
        public IActionResult Add(LatestNewsViewModelAdd model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            _latestNewsService.Add(model);
            return RedirectToAction("List");
        }
    }
}
