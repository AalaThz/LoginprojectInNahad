using LoginProjectDomain.Models;

namespace LoginProjectInfrastructure.Repositories.Interface
{
    public interface ILoginRepository
    {
        bool IsExistUser(string username, string password);
        UserLocal GetUser(string username, string password);
    }
}
