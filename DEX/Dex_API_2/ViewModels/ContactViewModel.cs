using DEX_API.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dex_API.ViewModels
{
    public class ContactViewModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}