﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DTO
{
    public class LoginDTO
    {
        public string Email { get; set; }

        public string Password { get; set; }
        
        //override
        //public string ToString()
        //{
        //    //return "Username = "+ username + ":" +"Password = "+ password;   
        //}

    }
}
