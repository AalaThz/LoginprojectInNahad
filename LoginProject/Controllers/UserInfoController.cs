using LoginProjectInfrastructure.Repositories.Implement;
using LoginProjectUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace LoginProjectUI.Controllers
{
    public class UserInfoController : Controller
    {
        private readonly UserRepository _userRepository;

        public UserInfoController(UserRepository userRepository)
        {
            _userRepository = userRepository;
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
        public IActionResult SearchById(Guid userId)
        {
 
            var user = _userRepository.GetUsers(userId);
            var userViewModel = new UsersViewModel();
            if (user != null)
            {
                userViewModel.UserId = user.UserId;
                userViewModel.UserName = user.UserName;
                userViewModel.Name = user.Name;
                userViewModel.Family = user.Family;
                userViewModel.BirthDate = user.BirthDate;
            }
            return View(userViewModel);
        }

        
    }
}
