using LoginProjectDomain.Models;
using LoginProjectDomain.ViewModels;

namespace LoginProjectDomain.Interfaces.IServices
{
    public interface IReasonChoiceService
    {
        Task<ReasonChoiceModelViewModel> GetAllAsync();
        Task<ReasonChoice> GetByIdAsync(int id);
        Task UpdateAsync(ReasonChoiceViewModelUpdate model);
        void Add(ReasonChoiceViewModelAdd reasonChoice);
        void Delete(ReasonChoice reasonChoice);
    }
}
