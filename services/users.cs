using System.Collections.Generic;
using System.Linq;
using HealthApi.Models;

namespace HealthApi.Services
{
  public interface IUserService
  {
    public List<User> getUsers();
    public int deleteUser(int id);
  }
  public class UsersServices : IUserService
  {
    private AppMainContext _context;


    public UsersServices(AppMainContext ctx)
    {
      this._context = ctx;
    }
    public List<User> getUsers()
    {
      return this._context.Users.ToList();
    }
    public int deleteUser(int id)
    {
        var query = _context.Users;
        User user = query.Find(2, 5, 9);
        if (user != null)
        {
           return 777;
        }
        return -1;
    }
  }
}