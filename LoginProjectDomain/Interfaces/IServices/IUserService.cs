using LoginProjectDomain.Models;
using LoginProjectDomain.ViewModels;

namespace LoginProjectDomain.Interfaces.IServices
{
    public interface IUserService
    {
        UserLocalViewModel GetUserViewModelById(int userId);
    }
}
