using System.Collections.Generic;
using HealthApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using HealthApi.Services;

namespace HealthApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private  IUserService _uuu;
        public UserController(IUserService ctx)
        {
            this._uuu = ctx;
        }
        [HttpGet]
        public List<User> Get()
        {
            var users = this._uuu.getUsers();
            return users;
        }
    //     [HttpGet]
    //     [Route("find")]
    //     public User FindUser(string param)
    //     {
    //        var query = this._context.Users;
    //        var usr = query.FirstOrDefault(u => EF.Functions.Like(u.Name, "%" + param + "%"));
    //        return usr;
    //     }
    //     [HttpPost]
    //     [Route("create")]
    //     public User CreateUser(User user) {

    //         this._context.Add<User>(user);
    //         this._context.SaveChanges();

    //         return new User{ Name = user.Name , Email = user.Email, Id = user.Id};
    //    }
    //     [HttpDelete]
    //     [Route("delete")]
        
    //     public int DeleteUser(int id) {

    //         var user = this._context.Users.Find(id);
    //         if(user != null)
    //         {
    //            this._context.Remove(user);
    //            this._context.SaveChanges();
    //            return id;
    //         }
    //         return -1;
    //     }
    }
}