using LoginProjectDomain.Interfaces.IRepositories;
using LoginProjectDomain.Interfaces.IServices;
using LoginProjectDomain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LoginProjectUI.Models.Component
{
    [ViewComponent(Name ="LastNewsVM")]
    public class LastNewsViewComponent : ViewComponent
    {
        private readonly ILatestNewsService _lastNewsService;

        public LastNewsViewComponent(ILatestNewsService lastNewsService)
        {
            _lastNewsService=lastNewsService;
        }

        public IViewComponentResult Invoke()
        {
            //Using GetAwaiter().GetResult() to synchronously wait on an asynchronous
            var news = _lastNewsService.GetAllNewsAsync().GetAwaiter().GetResult();
            return View(news);
        }
    }
}
