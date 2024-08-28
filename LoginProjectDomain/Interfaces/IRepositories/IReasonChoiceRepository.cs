using LoginProjectDomain.Models;

namespace LoginProjectInfrastructure.Repositories.Interface
{
    public interface IReasonChoiceRepository
    {
        Task<List<ReasonChoice>> GetAllAsync();
        Task<ReasonChoice> GetByIdAsync(int id);
        Task Update(ReasonChoice reason);
        void Add(ReasonChoice reason);
        void Delete(ReasonChoice reasonChoice);
    }
}
