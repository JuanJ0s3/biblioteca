﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Models
{
    public class UserModel
    { 
        public int id_user {  get; set; }
        public string nameuser { get; set; }

        public string password { get; set; }

        public string description { get; set; }
    }
}
