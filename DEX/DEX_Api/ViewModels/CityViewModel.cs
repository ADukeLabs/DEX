using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEX_Api.ViewModels
{
    public class CityViewModel
    {
        public string CityName { get; set; }
        public IEnumerable<CompanyViewModel> Companies { get; set; }
    }

}