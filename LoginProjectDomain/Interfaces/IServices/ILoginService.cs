using LoginProjectDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProjectDomain.Interfaces.IServices
{
    public interface ILoginService
    {
        bool IsExistUser(string username, string password);
        UserLocal GetUser(string username, string password);
    }
}
