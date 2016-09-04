using DEX.Models;
using DEX.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace DEX.Controllers
{
    public class CompanyController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Company/GetCompanies/
        [HttpGet]
        public string GetCompanies(int id)
        {
            List<Company> companiesList = db.Companies.Where(c => c.City.Id == id).ToList();
            string companies = JsonConvert.SerializeObject(companiesList, Formatting.None, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return companies;
        }

        // GET: Company/Details/1
        //[HttpGet]
        public string Details(int id)
        {
            //if (id == null)
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Company Company = db.Companies.Find(id);
            string company = JsonConvert.SerializeObject(Company, Formatting.None, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return company;
        }



        // GET: Company/Create
        public ActionResult Create()
        {
            return View();
        }

        //POST: Company/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Industry,Location")]Company company, int? id)
        {
            company.City = db.Cities.Find(id);
            if (ModelState.IsValid)
                db.Companies.Add(company);
                db.SaveChanges();
                //var city = new CityController();
                // city.Create(company.City);
                
            return RedirectToAction("Menu", "Home");
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
                db.Dispose();
            base.Dispose(disposing);
        }
    }
}