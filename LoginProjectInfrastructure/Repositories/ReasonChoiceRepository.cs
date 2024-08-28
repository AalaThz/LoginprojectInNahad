using LoginProjectDomain.Models;
using LoginProjectInfrastructure.Contexts;
using LoginProjectInfrastructure.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace LoginProjectInfrastructure.Repositories
{
    public class ReasonChoiceRepository : IReasonChoiceRepository
    {
        private readonly MyContext _db;

        public ReasonChoiceRepository(MyContext db)
        {
            _db = db;
        }

        public async Task<List<ReasonChoice>> GetAllAsync()
        {
            return await _db.ReasonChoices.ToListAsync();

        }

        public async Task<ReasonChoice> GetByIdAsync(int id)
        {
            return await _db.ReasonChoices.FirstOrDefaultAsync(r => r.Id == id);
        }

        public void Add(ReasonChoice reasonChoice)
        {
            _db.ReasonChoices.Add(reasonChoice);
            _db.SaveChanges();
        }

        public async Task Update(ReasonChoice reason)
        {
            _db.ReasonChoices.Update(reason);
            await _db.SaveChangesAsync();

            //_db.Entry(reason).State = EntityState.Modified; //این کار اطمینان می‌دهد که وضعیت آبجکت به درستی به روز می‌شود
            //_db.SaveChanges();
        }

        public void Delete(ReasonChoice reasonChoice)
        {
            _db.Remove(reasonChoice);
            _db.SaveChanges();
        }
    }
}
