using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dex_API.Models.DomainModels
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public City City { get; set; }
        public ICollection<Contact> Contacts { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}