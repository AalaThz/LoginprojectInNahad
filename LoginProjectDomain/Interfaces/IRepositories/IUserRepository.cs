﻿using LoginProjectDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProjectDomain.Interfaces.IRepositories
{
    public interface IUserRepository
    {
        UserLocal GetUsersById(int userId);
    }
}
