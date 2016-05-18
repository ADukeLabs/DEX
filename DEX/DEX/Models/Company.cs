using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEX.Models
{
    public class Company
    {
        //id
        //Name
        //Description
        //Location
        //virtual list of contacts
        //virtual list of jobs applied at this company
        //userId

        public int Id { get; set; }
        public string Name { get; set; }
        public string Industry { get; set; }
        public string Location { get; set; }
        public virtual List<Job> JobsApplied { get; set; }
        public virtual List<Contact> Contacts { get; set; }

    }
}