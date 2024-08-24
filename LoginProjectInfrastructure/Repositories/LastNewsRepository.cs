using LoginProjectDomain.Interfaces.IRepositories;
using LoginProjectDomain.Models;
using LoginProjectDomain.ViewModels;
using LoginProjectInfrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProjectInfrastructure.Repositories
{
    public class LastNewsRepository : ILastNewsRepository
    {
        private readonly MyContext _db;

        public LastNewsRepository(MyContext db)
        {
            _db = db;
        }

        public List<LastNews> GetAll()
        {
            return _db.LatestNews.ToList();
        }
    }
}
