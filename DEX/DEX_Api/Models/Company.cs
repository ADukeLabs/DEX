using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEX_Api.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public City City { get; set; }
        public ICollection<Contact> Contacts { get; set; }
    }
}