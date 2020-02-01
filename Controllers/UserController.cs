using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace HealthApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return new List<User>() { new User { Name = "Valera" } };
        }
        [HttpPost]
        [Route("create")]
        public User CreateUser(User user) {
            
            return new User{ Name = user.Name + "yyyy" , Email = user.Email, Id = user.Id};
       }
       [HttpPost]
        [Route("delete")]
        public int DeleteUser() {
            return 888;
        }
    }
}