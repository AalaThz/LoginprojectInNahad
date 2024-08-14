using LoginProjectDomain.Models;
using LoginProjectInfrastructure.Contexts;

namespace LoginProjectInfrastructure.Repositories.Implement
{
    public class UserRepository
    {
        private readonly MyContext _db;

        public UserRepository(MyContext db)
        {
            _db = db;
        }

        public Users GetUsers(Guid userId)
        {
            return _db.Users.Find(userId);
        }
    }
}
