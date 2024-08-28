using LoginProjectCore.Utilities;
using LoginProjectDomain.Interfaces.IServices;
using LoginProjectDomain.Models;
using LoginProjectInfrastructure.Repositories.Interface;

namespace LoginProjectCore.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        public UserLocal GetUser(string username, string password)
        {
            //استفاده از کلاس استاتیک CheckText برای پیشگیری از Sql Injection
            var sanitizedUsername = username.CheckText().Trim();
            var sanitizedPassword = password.CheckText();
            return _loginRepository.GetUser(sanitizedUsername, sanitizedPassword);
        }

        public bool IsExistUser(string username, string password)
        {
            //استفاده از کلاس استاتیک CheckText برای پیشگیری از Sql Injection
            var sanitizedUsername = username.CheckText().Trim();
            var sanitizedPassword = password.CheckText();
            return _loginRepository.IsExistUser(sanitizedUsername, sanitizedPassword);
        }

    }
}
