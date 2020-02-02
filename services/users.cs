using System.Collections.Generic;
using System.Linq;
using HealthApi.Models;

namespace HealthApi.Services
{
    public interface IUserService
    {
        public List<User> getUsers();
    }
    public class UsersServices : IUserService
    {
        private  AppMainContext _context;
        

        public UsersServices(AppMainContext ctx)
        {
            this._context = ctx;
        }
        public List<User> getUsers()
        {
            return this._context.Users.ToList();
        }
    }
}