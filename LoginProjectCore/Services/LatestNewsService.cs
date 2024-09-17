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


        //for home page
        public async Task<List<LatestNewsViewModelList>> GetThreeNewsAsync()
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
                    ImageName = item.Image,
                };
                newsList.Add(newsView);
            }

            return newsList;
        }


        public async Task<List<LatestNewsViewModelList>> GetAllNewsAsync()
        {
            var news = await _lastNewsRepository.GetAllAdmin();
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
                    ImageName = item.Image,
                };
                newsList.Add(newsView);
            }

            return newsList;
        }

        public async Task<List<LatestNewsViewModelWeblog>> GetAllNewsBlogPage()
        {
            var news = await _lastNewsRepository.GetAllNewsBlogPage();
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

        public async Task Add(LatestNewsViewModelAdd model)
        {
            var news = new LastNews();
            news.Id = model.Id;
            news.NewsDate = model.NewsDate;
            news.UserName = model.UserName;
            news.Title = model.Title;
            news.NewsText = model.NewsText;
            news.NewsTextSummary = model.NewsTextSummary;
            news.Image = model.Image;
            await _lastNewsRepository.Add(news);
        }

        /// <summary>
        /// for show in Home
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<LatestNewsViewModelBlog> GetNewsById(int id)
        {
            var news = await _lastNewsRepository.GetNewsById(id);
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


        public async Task<LatestNewsViewModelUpdate> GetNewsByIdAdmin(int id)
        {
            var news = await _lastNewsRepository.GetNewsById(id);
            var newsModel = new LatestNewsViewModelUpdate
            {
                Id = news.Id,
                NewsDate = news.NewsDate,
                UserName = news.UserName,
                Title = news.Title,
                NewsText = news.NewsText,
                NewsTextSummary = news.NewsTextSummary,
                Image = news.Image
            };
            return newsModel;
        }

        public async Task UpdateAsync(LatestNewsViewModelUpdate model)
        {
            var existsNews = await _lastNewsRepository.GetNewsById(model.Id);
            if (existsNews != null)
            {
                // به روزرسانی نام و متن خبر  
                existsNews.NewsDate = model.NewsDate;
                existsNews.UserName = model.UserName;
                existsNews.Title = model.Title;
                existsNews.NewsText = model.NewsText;
                existsNews.NewsTextSummary = model.NewsTextSummary;

                if (model.ImageFile != null && model.ImageFile.Length > 0)
                {
                    // نام تصویر و پسوند آن  
                    string imageName = Path.GetFileNameWithoutExtension(model.ImageFile.FileName);
                    string imageExtension = Path.GetExtension(model.ImageFile.FileName);

                    // مسیر تصویر جدید  
                    string imagePath = Path.Combine("wwwroot/Theme/images/blog", $"{imageName}{imageExtension}");

                    // حذف تصویر قبلی اگر وجود داشته باشد  
                    //var oldImagePath = Path.Combine("wwwroot/Theme/images/blog", existsNews.Image);
                    //if (System.IO.File.Exists(oldImagePath))
                    //{
                    //    System.IO.File.Delete(oldImagePath);
                    //}

                    existsNews.Image = $"{imageName}{imageExtension}";


                    // ذخیره تصویر جدید  
                    using (var filestream = new FileStream(imagePath, FileMode.Create))
                    {
                        await model.ImageFile.CopyToAsync(filestream);
                    }

                    // به روز رسانی نام تصویر در موجودیت  
                    existsNews.Image = $"{imageName}{imageExtension}";
                }

                await _lastNewsRepository.Update(existsNews);
            }
        }


    }
}
