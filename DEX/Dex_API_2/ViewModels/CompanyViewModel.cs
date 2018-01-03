using Dex_API.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEX_Api.ViewModels
{
    public class CompanyViewModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<ContactViewModel> Contacts { get; set; }
    }
}