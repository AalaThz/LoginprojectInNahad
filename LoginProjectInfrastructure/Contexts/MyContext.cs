using Microsoft.EntityFrameworkCore;
using LoginProjectDomain.Models;

namespace LoginProjectInfrastructure.Contexts
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<Users> Users { get; set; } //در 228
        public DbSet<UserLocal> UserLocal { get; set; } // در Taherzadeh    
        public DbSet<HostInfo> HostInfo { get; set; }
        public DbSet<ReasonChoice> reasonChoices { get; set; }
        public DbSet<LastNews> LatestNews { get; set; }



    }
}
