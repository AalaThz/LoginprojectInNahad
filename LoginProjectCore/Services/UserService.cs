using LoginProjectDomain.Interfaces.IRepositories;
using LoginProjectDomain.Interfaces.IServices;
using LoginProjectDomain.Models;
using LoginProjectDomain.ViewModels;

namespace LoginProjectCore.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserLocalViewModel GetUserViewModelById(int userId)
        {
            var user = _userRepository.GetUsersById(userId);

            // نگاشت در اینجا انجام می‌شود  
            var userViewModel = new UserLocalViewModel();
            if (user != null)
            {
                userViewModel.UserId = user.UserId;
                userViewModel.UserName = user.UserName;
                userViewModel.Name = user.Name;
                userViewModel.LastName = user.LastName;
            }

            return userViewModel;
        }
    }
}
