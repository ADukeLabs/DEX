using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEX_Api.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public City(string name)
        {
            Name = name;
        }
    }
}