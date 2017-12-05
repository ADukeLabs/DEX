using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dex_API_2.Models.DomainModels
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Company> Companies { get; set; }
    }
}