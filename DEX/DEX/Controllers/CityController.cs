using DEX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEX.Controllers
{
    public class CityController : Controller
    {

        ApplicationDbContext db = new ApplicationDbContext();

        // GET: City
        public ActionResult Index()
        {
            return View();
        }

        // GET: City/Create


        [HttpPost]
        [ValidateAntiForgeryToken]
        public void Create([Bind(Include = "Id, Name")]City city)
        {
            if (ModelState.IsValid)
                db.Cities.Add(city);
                db.SaveChanges();   
        }
    }
}