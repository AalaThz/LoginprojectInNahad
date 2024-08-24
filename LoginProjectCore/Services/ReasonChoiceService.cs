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

            return vm;
        }

        public async Task<ReasonChoice> GetByIdAsync(int id)
        {
            return await _reasonChoiceRepository.GetByIdAsync(id);
        }

        public void Add(ReasonChoice reasonChoice)
        {
            _reasonChoiceRepository.Add(reasonChoice);
        }
        public void Update(ReasonChoice reason)
        {
            _reasonChoiceRepository.Update(reason);
        }

        public void Delete(ReasonChoice reason)
        {
            _reasonChoiceRepository.Delete(reason);
        }
        
    }
}
