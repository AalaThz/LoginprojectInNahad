using LoginProjectDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProjectInfrastructure.Repositories.Interface
{
    public interface IReasonChoiceRepository
    {
        Task<List<ReasonChoice>> GetAllAsync();
        Task<ReasonChoice> GetByIdAsync(int id);
        void Update(ReasonChoice reason);
        void Add(ReasonChoice reasonChoice);
    }
}
