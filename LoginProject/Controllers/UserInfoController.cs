using LoginProjectDomain.Interfaces.IServices;
using LoginProjectDomain.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace LoginProjectUI.Controllers
{
    public class UserInfoController : Controller
    {
        private readonly IUserService _userService;

        public UserInfoController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SearchById()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SearchById(int userId)
        {
            var userViewModel = _userService.GetUserViewModelById(userId);
            return View(userViewModel);
        }
    }
}
