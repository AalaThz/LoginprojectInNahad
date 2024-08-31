using LoginProjectDomain.Interfaces.IRepositories;
using LoginProjectDomain.Models;
using LoginProjectInfrastructure.Contexts;

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
            var result = _db.LatestNews.OrderByDescending(n => n.NewsDate).Take(3).ToList();
            return result;
        }
        public async Task<List<LastNews>> GetAllBlogPage()
        {
            var result = _db.LatestNews.ToList();
            return result;
        }


        public void Add(LastNews news)
        {
            _db.LatestNews.Add(news);
            _db.SaveChanges();
        }

        public LastNews GetNewsById(int id)
        {
            var foundLastNews = new LastNews();
            if (_db.LatestNews.Any(l => l.Id == id))
            {
                foundLastNews =  _db.LatestNews.First(l => l.Id == id);
            }
            return foundLastNews;
        }

    }
}
