﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
         public string UserName {  get; set; }
        public string Password { get; set; }
    }
}
