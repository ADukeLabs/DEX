﻿using DEX.Models;
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

        // GET: Company
        [HttpGet]
        public IEnumerable<Company> GetCompanies(int id)
        {
            List<Company> companies = db.Companies.Where(c => c.City.Id == id).ToList();
            return companies;
        }

        // GET: Company/Details/1
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

        //    CompanyViewModel cvm = new CompanyViewModel();
        //    cvm.Company = db.Companies.Find(id);
        //    return View(cvm);
        //}



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