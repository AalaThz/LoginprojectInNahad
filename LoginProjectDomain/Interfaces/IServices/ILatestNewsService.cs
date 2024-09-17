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
        Task<List<LatestNewsViewModelList>> GetThreeNewsAsync();
        Task<List<LatestNewsViewModelList>> GetAllNewsAsync();
        Task<List<LatestNewsViewModelWeblog>> GetAllNewsBlogPage();
        Task Add(LatestNewsViewModelAdd model);
        Task<LatestNewsViewModelBlog> GetNewsById(int id);
        Task<LatestNewsViewModelUpdate> GetNewsByIdAdmin(int id);
        Task UpdateAsync(LatestNewsViewModelUpdate model);
    }
}
