using LoginProjectDomain.Interfaces.IRepositories;
using LoginProjectDomain.Models;
using LoginProjectInfrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProjectInfrastructure.Repositories
{
    public class TrafficHostInfoRepository : ITrafficHostInfoRepository
    {
        private readonly MyContext _db;

        public TrafficHostInfoRepository(MyContext db)
        {
            _db = db;
        }

        public async Task<List<HostInfo>> GetAllHost()
        {
            return _db.HostInfo.ToList();
        }
    }
}
