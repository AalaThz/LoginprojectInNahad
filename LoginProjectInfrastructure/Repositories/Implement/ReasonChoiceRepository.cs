using LoginProjectDomain.Models;
using LoginProjectInfrastructure.Contexts;
using LoginProjectInfrastructure.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProjectInfrastructure.Repositories.Implement
{
    public class ReasonChoiceRepository : IReasonChoiceRepository
    {
        private readonly MyContext _db;

        public ReasonChoiceRepository(MyContext db)
        {
            _db=db;
        }

        public async Task<List<ReasonChoice>> GetAllAsync()
        {
            try
            {
            return await _db.ReasonChoices.ToListAsync();

            }
            catch (Exception)
            {

                throw;
            }

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

        public void Update(ReasonChoice reason)
        {
            //var findReason = GetByIdAsync(reason.Id);
            //_db.Update(reason);
            _db.Entry(reason).State = EntityState.Modified; //این کار اطمینان می‌دهد که وضعیت آبجکت به درستی به روز می‌شود
            _db.SaveChanges();
        }
    }
}
