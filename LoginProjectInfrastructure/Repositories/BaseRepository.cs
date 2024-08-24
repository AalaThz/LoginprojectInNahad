using LoginProjectDomain.Models;
using LoginProjectDomain.ViewModels;
using LoginProjectInfrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProjectInfrastructure.Repositories
{
    public class BaseRepository
    {
        private readonly MyContext _db;

        public BaseRepository(MyContext db)
        {
            _db = db;
        }

        public HostInfo Add(HostInfo hostInfo)
        {
            _db.Add(hostInfo);
            _db.SaveChanges();
            return hostInfo;
        }
    }
}
