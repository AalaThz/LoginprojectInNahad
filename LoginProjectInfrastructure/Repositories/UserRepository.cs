using LoginProjectDomain.Interfaces.IRepositories;
using LoginProjectDomain.Models;
using LoginProjectInfrastructure.Contexts;

namespace LoginProjectInfrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MyContext _db;

        public UserRepository(MyContext db)
        {
            _db = db;
        }

        public UserLocal GetUsersById(int userId)
        {
            return _db.UserLocal.Find(userId);
        }
    }
}
