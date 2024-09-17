using LoginProjectDomain.Interfaces.IServices;
using LoginProjectDomain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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


        //Get: Admin/LatestNewsAdmin/Create
        public async Task<IActionResult> Create()
        {
            var model = new LatestNewsViewModelAdd();
            return View(model);
        }

        //POST : Admin
        [HttpPost]
        public async Task<IActionResult> Create(LatestNewsViewModelAdd model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _latestNewsService.Add(model);
            return RedirectToAction("List");
        }


        //Get: Admin
        public async Task<IActionResult> Update(int id)
        {
            var news = await _latestNewsService.GetNewsByIdAdmin(id);
            if (news == null)
                return NotFound();

            return View(news);
        }

        //POST: Admin/LatestNewsAdmin
        [HttpPost]
        public async Task<IActionResult> Update(LatestNewsViewModelUpdate model)
        {
            if (!ModelState.IsValid)
                return View(model);
            await _latestNewsService.UpdateAsync(model);
            return RedirectToAction("List");
        }

        //Get: Admin/LatestNewsAdmin
        //Delete



        //Comment for news
        public IActionResult AddComment(int id, string name, string email, string comment)
        {
            //از سایت تاپ لرن ببینم. بخش 21 پروزه mvc
            return null;
        }
    }
}
