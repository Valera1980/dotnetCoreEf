using Microsoft.EntityFrameworkCore;

namespace HealthApi.Models {
    public class AppMainContext: DbContext 
    {
        public DbSet<User> Users {get;  set; }
        public DbSet<News> News {get;  set; }
        public AppMainContext(DbContextOptions<AppMainContext> options): base(options)
        {

        }
    }
}