using LoginProjectDomain.Models;
using LoginProjectDomain.ViewModels;

namespace LoginProjectDomain.Interfaces.IServices
{
    public interface IReasonChoiceService
    {
        Task<ReasonChoiceModelViewModel> GetAllAsync();
        Task<ReasonChoice> GetByIdAsync(int id);
        void Update(ReasonChoice reason);
        void Add(ReasonChoice reasonChoice);
        //void Delete(int id);
    }
}
