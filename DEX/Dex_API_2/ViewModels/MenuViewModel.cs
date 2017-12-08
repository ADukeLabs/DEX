using Dex_API.ViewModels;
using DEX_Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dex_API_2.ViewModels
{
    public class MenuViewModel
    {
        public IEnumerable<CityViewModel> Cities { get; set; }
    }
}