﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dex_API.Models.DomainModels
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Company Company { get; set; }
    }
}