using LoginProjectDomain.Models;
using LoginProjectInfrastructure.Contexts;
using LoginProjectInfrastructure.Repositories.Interface;
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

        public List<ReasonChoice> GetAllReasonChoice()
        {
            return _db.reasonChoices.ToList();
        }
    }
}
