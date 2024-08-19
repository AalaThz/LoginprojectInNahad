using LoginProjectDomain.ViewModels;
using LoginProjectInfrastructure.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LoginProjectUI.Models.Component
{
    [ViewComponent(Name = "ReasonChoiceVM")]
    public class ReasonChoiceViewComponent : ViewComponent
    {
        private readonly IReasonChoiceRepository _reasonChoiceRepository;

        public ReasonChoiceViewComponent(IReasonChoiceRepository reasonChoiceRepository)
        {
            _reasonChoiceRepository=reasonChoiceRepository;
        }

        public IViewComponentResult Invoke()
        {
            //Using GetAwaiter().GetResult() to synchronously wait on an asynchronous
            var reason = _reasonChoiceRepository.GetAllAsync().GetAwaiter().GetResult();
            var vm = new ReasonChoiceModelViewModel();

            var id = reason.Select(c => c.Id).FirstOrDefault();
            var firstReason = reason.First(i => i.Id == id);
            vm.ReasonChoice = new ReasonChoiceViewModel()
            {
                Id = firstReason.Id,
                Title = firstReason.Title,
                Description = firstReason.Description,
                Icon = firstReason.Icon,
            };

            var reasonList = new List<ReasonChoiceViewModel>();
            
            //foreach (var item in reason.OrderByDescending(s => s.OrderBy))//ترتیب نمایش 
                foreach (var item in reason)
            {
                var reasonView = new ReasonChoiceViewModel
                {
                    Id = item.Id,
                    Icon = item.Icon,
                    Title = item.Title,
                    Description = item.Description,
                    OrderBy = item.OrderBy,
                };
                reasonList.Add(reasonView);
            }
            vm.ReasonChoiceList = reasonList;
            return View(vm);
        }
    }
}
