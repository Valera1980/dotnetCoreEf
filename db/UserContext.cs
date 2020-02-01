using Microsoft.EntityFrameworkCore;

namespace HealthApi.Models {
    public class UserContext: DbContext 
    {
        public UserContext(DbContextOptions<UserContext> options): base(options)
        {

        }
    }
}