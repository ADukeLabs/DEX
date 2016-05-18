using DEX.Models;
using DEX.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DEX.Controllers
{
    public class CompanyController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Company
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // GET: Company/Details/1
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            CompanyViewModel cvm = new CompanyViewModel();
            cvm.Company = db.Companies.Find(id);
            return View(cvm);
        }


    }
}