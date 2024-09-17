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

        //for home page
        public async Task<List<LastNews>> GetAll()
        {
            var result = _db.LatestNews.OrderByDescending(n => n.NewsDate).Take(3).ToList();
            return result;
        }

        public async Task<List<LastNews>> GetAllAdmin()
        {
            var result = _db.LatestNews.OrderByDescending(n => n.NewsDate).ToList();
            return result;
        }

        public async Task<List<LastNews>> GetAllNewsBlogPage()
        {
            var result = _db.LatestNews.ToList();
            return result;
        }


        public async Task Add(LastNews news)
        {
            _db.LatestNews.Add(news);
            await _db.SaveChangesAsync();
        }

        public async Task<LastNews> GetNewsById(int id)
        {
            var foundLastNews = new LastNews();
            if (_db.LatestNews.Any(l => l.Id == id))
            {
                foundLastNews =  _db.LatestNews.First(l => l.Id == id);
            }
            return foundLastNews;
        }

        public async Task Update(LastNews news)
        {
            _db.LatestNews.Update(news);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(LastNews news)
        {
            var foundNews =await GetNewsById(news.Id);
            if (foundNews != null)
            {
               _db.LatestNews.Remove(foundNews);
            }
        }
    }
}
