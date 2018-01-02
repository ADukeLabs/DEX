using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEX_Api.ViewModels
{
    public class CityViewModel
    {
        public string Name { get; set; }
        public ICollection<CompanyViewModel> Companies { get; set; }
    }

}