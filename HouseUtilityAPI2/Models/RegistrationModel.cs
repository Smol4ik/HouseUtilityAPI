using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseUtilityAPI2.Models
{
    public class Registration
    {
       public int userId { get; set;  }
        public string user { get; set; }
       public string password { get; set; }

       public Registration() { }
        public Registration(int usId, string user_name, string user_password)
        {
            this.userId = usId;
            this.user = user_name;
            this.password = user_password;
        }
    }
}
