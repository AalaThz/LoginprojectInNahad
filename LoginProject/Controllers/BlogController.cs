using Microsoft.AspNetCore.Mvc;

namespace LoginProjectUI.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
