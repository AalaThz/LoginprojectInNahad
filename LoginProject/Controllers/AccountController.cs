using LoginProjectInfrastructure.Repositories.Interface;
using LoginProjectUI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;


namespace LoginProjectUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILoginRepository _loginRepository;

        public AccountController(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLocalViewModel login)
        {
            if (ModelState.IsValid)
            {
                
                    // فرض بر این است که متد اعتبار سنجی کاربر Hash شده است  
                    var user = _loginRepository.GetUser(login.UserName, login.Password);
                if (user != null)
                {
                    // ورود کاربر موفقیت آمیز است  
                    // برای ذخیره نام کاربری در Claim
                    var claim = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.UserName),
                        new Claim("FullName", user.Name +" " + user.LastName)

                    };

                    var claimIdentity = new ClaimsIdentity(claim, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimPrincipal = new ClaimsPrincipal(claimIdentity);
                    var authProperties = new AuthenticationProperties
                    {
                        IsPersistent = login.RememberMe,// اگر کاربر بخواهد، اطلاعاتش را حفظ کند
                    };

                    await HttpContext.SignInAsync(claimPrincipal, authProperties);

                    //return RedirectToAction("Index", "Home");

                    return Redirect("/admin/home/index");
                }
                else
                {
                    ModelState.AddModelError("UserName", "کاربری یافت نشد");
                }
            }
            return View(login);
        }

        public IActionResult Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                 HttpContext.SignOutAsync();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}




