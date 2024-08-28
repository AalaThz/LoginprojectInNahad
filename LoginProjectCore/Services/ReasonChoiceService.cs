using LoginProjectDomain.Interfaces.IServices;
using LoginProjectDomain.Models;
using LoginProjectDomain.ViewModels;
using LoginProjectInfrastructure.Repositories.Interface;

namespace LoginProjectCore.Services
{
    public class ReasonChoiceService : IReasonChoiceService
    {
        private readonly IReasonChoiceRepository _reasonChoiceRepository;

        public ReasonChoiceService(IReasonChoiceRepository reasonChoiceRepository)
        {
            _reasonChoiceRepository=reasonChoiceRepository;
        }

        
        public async Task<ReasonChoiceModelViewModel> GetAllAsync()
        {
            var reason =await _reasonChoiceRepository.GetAllAsync();

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
            //حذف اولین آیتم به دلیل جدا بودن از بقیه
            var otherReason = reason.Where(r => r.Id != firstReason.Id);

            var reasonList = new List<ReasonChoiceViewModel>();

            //foreach (var item in reason.OrderByDescending(s => s.OrderBy))//ترتیب نمایش 
            foreach (var item in otherReason)
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

            return vm;
        }

        public void Add(ReasonChoiceViewModelAdd model)
        {
            var reason = new ReasonChoice();
            reason.Id = model.Id;
            reason.Title = model.Title;
            reason.Description = model.Description;
            reason.OrderBy = model.OrderBy;
            if (string.IsNullOrEmpty(model.Icon))//انتخاب یک آیکون پیش فرض برای مدل
            {
                reason.Icon = "mdi mdi-security";
            }
            else
            {
                reason.Icon = model.Icon;

            }

            _reasonChoiceRepository.Add(reason);
        }


        
        public async Task UpdateAsync(ReasonChoiceViewModelUpdate model)
        {
            var existingReasonChoice =await _reasonChoiceRepository.GetByIdAsync(model.Id);
            if (existingReasonChoice != null)
            {
                existingReasonChoice.Title = model.Title;
                existingReasonChoice.Description = model.Description;
                //existingReasonChoice.OrderBy = model.OrderBy; // اگر OrderBy هم در مدل وجود دارد  
                //existingReasonChoice.Icon = model.Icon;

                await _reasonChoiceRepository.Update(existingReasonChoice);
            }
        }

        public void Delete(ReasonChoice reason)
        {
            _reasonChoiceRepository.Delete(reason);
        }


        public async Task<ReasonChoice> GetByIdAsync(int id)
        {
            return await _reasonChoiceRepository.GetByIdAsync(id);
        }

    }
}
