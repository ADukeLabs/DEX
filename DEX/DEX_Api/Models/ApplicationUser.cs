﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DEX_Api.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}