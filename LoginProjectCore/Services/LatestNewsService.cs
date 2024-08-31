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

        public async Task<List<LatestNewsViewModelList>> GetAllNewsAsync()
        {
            var news = await _lastNewsRepository.GetAll();
            var newsList = new List<LatestNewsViewModelList>();

            foreach (var item in news)
            {
                var newsView = new LatestNewsViewModelList
                {
                    Id = item.Id,
                    NewsDate = item.NewsDate,
                    UserName = item.UserName,
                    Title = item.Title,
                    NewsText = item.NewsText,
                    NewsTextSummary = item.NewsTextSummary,
                    Image = item.Image,
                };
                newsList.Add(newsView);
            }

            return newsList;
        }

        public async Task<List<LatestNewsViewModelWeblog>> GetAllNewsBlogPage()
        {
            var news = await _lastNewsRepository.GetAllBlogPage();
            var newsList = new List<LatestNewsViewModelWeblog>();

            foreach (var item in news)
            {
                var newsView = new LatestNewsViewModelWeblog
                {
                    Id = item.Id,   
                    Title = item.Title,
                    NewsTextSummary = item.NewsTextSummary,
                    Image = item.Image,
                };
                newsList.Add(newsView);
            }

            return newsList;
        }

        public void Add(LatestNewsViewModelAdd model)
        {
            var news = new LastNews();
            news.Id = model.Id;
            news.NewsDate = model.NewsDate;
            news.UserName = model.UserName;
            news.Title = model.Title;
            news.NewsText = model.NewsText;
            news.NewsTextSummary = model.NewsTextSummary;
            news.Image = model.Image;
            _lastNewsRepository.Add(news);
        } 

        public LatestNewsViewModelBlog GetNewsById(int id)
        {
            var news = _lastNewsRepository.GetNewsById(id);
            var newsModel = new LatestNewsViewModelBlog
            {
                Id = news.Id,
                Title = news.Title,
                NewsText = news.NewsText,
                NewsTextSummary = news.NewsTextSummary,
                Image = news.Image,
            };
            return newsModel;
        }
    }
}
