using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEX.Models
{   
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual City City { get; set; }
        public virtual List<Contact> Contacts { get; set; }

    }
}