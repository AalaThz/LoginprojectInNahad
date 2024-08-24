using LoginProjectDomain.Models;

namespace LoginProjectInfrastructure.Repositories.Interface
{
    public interface IReasonChoiceRepository
    {
        Task<List<ReasonChoice>> GetAllAsync();
        Task<ReasonChoice> GetByIdAsync(int id);
        void Update(ReasonChoice reason);
        void Add(ReasonChoice reasonChoice);
        void Delete(ReasonChoice reasonChoice);
    }
}
