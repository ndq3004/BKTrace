﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BKTrace.Models
{
    public class AuthenticateModel
    {
        [Required]
        public string user_name { get; set; }

        [Required]
        public string password { get; set; }
    }
}
