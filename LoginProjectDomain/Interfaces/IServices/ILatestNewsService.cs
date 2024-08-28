using LoginProjectDomain.Models;
using LoginProjectDomain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProjectDomain.Interfaces.IServices
{
    public interface ILatestNewsService
    {
        Task<List<LastNewsViewModel>> GetAllNewsAsync();
        void Add(LastNewsViewModel model);
    }
}
