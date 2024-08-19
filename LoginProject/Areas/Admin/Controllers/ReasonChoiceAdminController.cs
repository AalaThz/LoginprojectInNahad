using LoginProjectDomain.Models;
using LoginProjectDomain.ViewModels;
using LoginProjectInfrastructure.Repositories.Implement;
using LoginProjectInfrastructure.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LoginProjectUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReasonChoiceAdminController : Controller
    {
        private readonly IReasonChoiceRepository _reasonChoiceRepository;

        public ReasonChoiceAdminController(IReasonChoiceRepository reasonChoiceRepository)
        {
            _reasonChoiceRepository=reasonChoiceRepository;
        }

        
        public async Task<IActionResult> List()
        {
            var reasons = await _reasonChoiceRepository.GetAllAsync();
            var vm = new ReasonChoiceModelViewModel();

            var id = reasons.Select(x => x.Id).FirstOrDefault();

            var firstReason = reasons.FirstOrDefault(i => i.Id == id);
            vm.ReasonChoice = new ReasonChoiceViewModel
            {
                Id = firstReason.Id,
                Icon = firstReason.Icon,
                Title = firstReason.Title,
                Description = firstReason.Description,
                OrderBy = firstReason.OrderBy,
            };

            var reasonList = new List<ReasonChoiceViewModel>();
            foreach (var item in reasons)
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

        public IActionResult Add()
        {
            var model = new ReasonChoiceViewModelAdd();
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(ReasonChoiceViewModelAdd model)
        {
            if (ModelState.IsValid)
            {
                ReasonChoice reason = new ReasonChoice
                {
                    Id = model.Id,
                    Icon = model.Icon,
                    Title = model.Title,
                    Description = model.Description,
                    OrderBy = model.OrderBy,
                };
                _reasonChoiceRepository.Add(reason);
            }
            return RedirectToAction("List");
        }

        public async Task<IActionResult> Update(int id)
        {
            var find = await _reasonChoiceRepository.GetByIdAsync(id);

            var viewModel = new ReasonChoiceViewModelUpdate
            {
                Id= find.Id,
                Title= find.Title,
                Description= find.Description,
            };

            return View(viewModel);
        }

        //[HttpPost("/ReasonChoiceAdmin/Update")]
        [HttpPost]
        public async Task<IActionResult> Update(ReasonChoiceViewModelUpdate model)
        {

            if (ModelState.IsValid)
            {
                var find = await _reasonChoiceRepository.GetByIdAsync(model.Id);
                if (find != null)
                {
                    find.Id = model.Id;
                    find.Title = model.Title;
                    find.Description = model.Description;

                    _reasonChoiceRepository.Update(find);
                    return RedirectToAction("List");
                }
            }
            return View(model);
        }

    }
}
