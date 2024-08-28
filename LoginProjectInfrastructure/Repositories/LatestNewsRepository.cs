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
    public class LatestNewsRepository : ILatestNewsRepository
    {
        private readonly MyContext _db;

        public LatestNewsRepository(MyContext db)
        {
            _db = db;
        }

        public async Task<List<LastNews>> GetAll()
        {
            return _db.LatestNews.ToList();
        }

        public void Add(LastNews news)
        {
            _db.LatestNews.Add(news);
            _db.SaveChanges();
        }
    }
}
