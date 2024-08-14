﻿using LoginProjectDomain.Models;
using LoginProjectInfrastructure.Contexts;
using LoginProjectInfrastructure.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProjectInfrastructure.Repositories.Implement
{
    public class HostInfoRepository : IHostInfoRepository
    {
        private readonly MyContext _db;

        public HostInfoRepository(MyContext db)
        {
            _db = db;
        }

        public List<HostInfo> GetAllHost()
        {
            return _db.HostInfo.ToList();
        }
    }
}
