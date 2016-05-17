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
        public string Description { get; set; }
        public string Location { get; set; }
        public List<Job> JobsApplied { get; set; }
        public List<Contact> Contacts { get; set; }

    }
}