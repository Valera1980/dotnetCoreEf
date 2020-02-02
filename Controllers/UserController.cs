using System.Collections.Generic;
using HealthApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HealthApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private  AppMainContext _context;
        public UserController(AppMainContext ctx)
        {
            this._context = ctx;
        }
        [HttpGet]
        public List<User> Get()
        {
            var users = this._context.Users.ToList();
            return users;
        }
        [HttpGet]
        [Route("find")]
        public User FindUser(string param)
        {
           var query = this._context.Users;
           var usr = query.Where(u => EF.Functions.Like(u.Name, "%" + param + "%")).FirstOrDefault();
           return usr;
        }
        [HttpPost]
        [Route("create")]
        public User CreateUser(User user) {

            this._context.Add<User>(user);
            this._context.SaveChanges();

            return new User{ Name = user.Name , Email = user.Email, Id = user.Id};
       }
    //    [HttpPut]
    //    [Route("update")]
    //    public User UpdateUser(int id, User data)
    //     {
    //         if(string.IsNullOrEmpty(id.ToString())){
    //             return BadRequest()
    //         }
    //         return new User{Name="kkk"};
    //         // if (id.Any())
    //         // {
    //         //     return BadRequest("Missed id parameter");
    //         // }
    //         // return;
    //     }
        [HttpDelete]
        [Route("delete")]
        
        // public int DeleteUser([FromBody] JsonElement body) {
        public int DeleteUser(int id) {

            // if(body.id === null){
            //     return -99;
            // }
            var user = this._context.Users.SingleOrDefault(u => u.Id == id);
            if(user != null)
            {
               this._context.Remove(user);
               this._context.SaveChanges();
               return id;
            }
            return -1;
        }
    }
}