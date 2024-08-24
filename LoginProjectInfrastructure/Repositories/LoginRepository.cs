using LoginProjectDomain.Models;
using LoginProjectInfrastructure.Contexts;
using LoginProjectInfrastructure.Repositories.Interface;

namespace LoginProjectInfrastructure.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly MyContext _dbContext;

        public LoginRepository(MyContext dbContext)
        {
            _dbContext = dbContext;
        }

        public UserLocal GetUser(string username, string password)
        {
            return _dbContext.UserLocal.FirstOrDefault(u => u.UserName == username && u.Password == password);
        }

        //Use local database
        //برای چک کردن وجود کاربر و لاگین 
        public bool IsExistUser(string username, string password)
        {
            return _dbContext.UserLocal.Any(u => u.UserName == username && u.Password == password);
        }



        //Use 228 database
        //public bool Login(string userName, string password)
        //{
        //    var values = new Dictionary<string, string>();
        //    values.Add("grant_type", "password");
        //    values.Add("userName", userName.Trim());
        //    values.Add("password", password);

        //    using HttpClient client = new HttpClient();
        //    using HttpRequestMessage request = new HttpRequestMessage
        //        (HttpMethod.Post, "https://najm.samanpl.ir/oauth/token")
        //    { Content = new FormUrlEncodedContent(values) };

        //    using var response = client.Send(request);

        //    var result = false;
        //    if (response.IsSuccessStatusCode)
        //    {
        //        result = true;
        //    }
        //    return result;
        //}
    }
}
