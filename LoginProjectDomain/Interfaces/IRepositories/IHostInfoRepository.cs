﻿using LoginProjectDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProjectInfrastructure.Repositories.Interface
{
    public interface IHostInfoRepository
    {
        Task<List<HostInfo>> GetAllHost();
    }
}
