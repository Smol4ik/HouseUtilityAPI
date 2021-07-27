using HouseUtilityAPI2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseUtilityAPI2.Controllers.Autorization
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private static Registration[] users = new[]
        {
            new Registration(1,"Test","1234"),
            new Registration(2,"Test2","1222")
        };


        [HttpGet]
        [Route("/api/reg")]

        public IActionResult registration()
        {
            return Ok(users);
        }

        [HttpPost]
        [Route("/api/regi")]

        public IActionResult registreationPost(Registration registrationPost)
        {
            Registration User = Array.Find(users, userss => userss.user == registrationPost.user && userss.password == registrationPost.password);
            if (User != null)
            {
                return Content($"Success");
            }
            else
            {
                return NotFound($"Error");
            }
        }

        [HttpPut("{id:int}")]

        public IActionResult usersUpdate(int id, Registration userData)
        {
            int index = Array.FindIndex(users, userss => userss.userId == id); 
            if (index >= 0)
            {
                //Registration oldUserData = users[index];
                //users.SetValue(new Registration(oldUserData.userId, userData.user | oldUserData.user, ), index);
                if (userData.user != null)
                {
                    users[index].user = userData.user;
                }
                if(userData.password != null)
                {
                    users[index].password = userData.password;
                }
                return Ok(users);
            }

                    
             return BadRequest("Error");

   
        }

        [HttpDelete("{id:int}")]

        public IActionResult usersDelete(int id)
        {
            int index = Array.FindIndex(users, userss => userss.userId == id);
            if(index >= 0)
            {
                users = users.Where(userItem => userItem.userId != id).ToArray();
                return Content($"Success");
            }
            return BadRequest("Error!");
        }


    } 
}

