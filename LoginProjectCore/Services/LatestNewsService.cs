using LoginProjectDomain.Interfaces.IRepositories;
using LoginProjectDomain.Interfaces.IServices;
using LoginProjectDomain.Models;
using LoginProjectDomain.ViewModels;

namespace LoginProjectCore.Services
{
    public class LatestNewsService : ILatestNewsService
    {
        private readonly ILatestNewsRepository _lastNewsRepository;

        public LatestNewsService(ILatestNewsRepository lastNewsRepository)
        {
            _lastNewsRepository=lastNewsRepository;
        }

        public async Task<List<LastNewsViewModel>> GetAllNewsAsync()
        {
            var news = await _lastNewsRepository.GetAll();
            var newsList = new List<LastNewsViewModel>();

            foreach (var item in news)
            {
                var newsView = new LastNewsViewModel
                {
                    Id = item.Id,
                    NewsDate = item.NewsDate,
                    UserName = item.UserName,
                    Title = item.Title,
                    NewsText = item.NewsText,
                    Image = item.Image,
                };
                newsList.Add(newsView);
            }

            return newsList;
        }

        public void Add(LastNewsViewModel model)
        {
            var news = new LastNews();
            news.Id = model.Id;
            news.NewsDate = model.NewsDate;
            news.UserName = model.UserName;
            news.Title = model.Title;
            news.NewsText = model.NewsText;
            news.Image = model.Image;
            _lastNewsRepository.Add(news);
        } 
    }
}
