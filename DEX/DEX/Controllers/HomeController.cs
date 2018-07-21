//using DEX.Models;
using DEX.Models;
using DEX.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEX.Controllers
{
    public class HomeController : Controller
    {
        
        [Authorize]
        public ActionResult Menu()
        {
            //CityViewModel cvm = new CityViewModel();
            //cvm.Cities = db.Cities.OrderBy(c => c.Name).ToList();
            //return View(cvm);
            return View();
        }

    }
}