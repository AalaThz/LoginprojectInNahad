using LoginProjectDomain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace LoginProjectUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly ILatestNewsService _latestNewsService;

        public BlogController(ILatestNewsService latestNewsService)
        {
            _latestNewsService=latestNewsService;
        }
        public async Task<IActionResult> Index()
        {
            var news =await _latestNewsService.GetAllNewsBlogPage();
            return View(news);
        }

        
        public async Task<IActionResult> Details(int id)
        {
            var news =await _latestNewsService.GetNewsById(id);
            return View(news);
        }
    }
}
