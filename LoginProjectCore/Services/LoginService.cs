using LoginProjectDomain.Interfaces.IServices;
using LoginProjectDomain.Models;
using LoginProjectInfrastructure.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return _loginRepository.GetUser(username, password);
        }

        public bool IsExistUser(string username, string password)
        {
            return _loginRepository.IsExistUser(username, password);
        }

        //Use local database

    }
}
