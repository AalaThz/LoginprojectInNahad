using LoginProjectDomain.Interfaces.IRepositories;
using LoginProjectDomain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LoginProjectUI.Models.Component
{
    [ViewComponent(Name ="LastNewsVM")]
    public class LastNewsViewComponent : ViewComponent
    {
        private readonly ILastNewsRepository _lastNewsRepository;

        public LastNewsViewComponent(ILastNewsRepository lastNewsRepository)
        {
            _lastNewsRepository=lastNewsRepository;
        }

        public IViewComponentResult Invoke()
        {
            var news = _lastNewsRepository.GetAllNews();
            var newsList = new List<LastNewsViewModel>();

            foreach (var item in news)
            {
                var newsView = new LastNewsViewModel
                {
                    NewsDate = item.NewsDate,
                    UserName = item.UserName,
                    Title = item.Title,
                    NewsText = item.NewsText,
                    Image = item.Image,
                };
                newsList.Add(newsView);
            }
            return View(newsList);
        }
    }
}
