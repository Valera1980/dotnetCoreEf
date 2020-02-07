using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HealthApi.Services
{
  public interface IUserService
  {
    // public List<User> getUsers();
    public Task<List<User>> getUsers();
    public int deleteUser(int id);
  }
  public class UsersServices : IUserService
  {
    private AppMainContext _context;


    public UsersServices(AppMainContext ctx)
    {
      this._context = ctx;
    }
    public async Task<List<User>> getUsers()
    {
      return await this._context.Users.ToListAsync();
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