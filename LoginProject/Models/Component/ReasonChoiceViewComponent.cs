using LoginProjectDomain.ViewModels;
using LoginProjectInfrastructure.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LoginProjectUI.Models.Component
{
    [ViewComponent(Name ="ReasonChoiceVM")]
    public class ReasonChoiceViewComponent : ViewComponent
    {
        private readonly IReasonChoiceRepository _reasonChoiceRepository;

        public ReasonChoiceViewComponent(IReasonChoiceRepository reasonChoiceRepository)
        {
            _reasonChoiceRepository=reasonChoiceRepository;
        }

        public IViewComponentResult Invoke()
        {
            var reason = _reasonChoiceRepository.GetAllReasonChoice();
            var reasonList = new List<ReasonChoiceViewModel>();

            foreach (var item in reason)
            {
                var reasonView = new ReasonChoiceViewModel
                {
                    Id = item.Id,
                    Title = item.Title,
                    Description = item.Description,
                };
                reasonList.Add(reasonView);
            }
            return View(reasonList);
        }
    }
}
