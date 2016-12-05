﻿using DEX.Models;
using DEX.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Data.Entity;

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
        [HttpGet]
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
        public ActionResult Create([Bind(Include = "Id,Name,Address,City")]Company company, int? id)
        {
            bool cityExists = db.Cities.Any(c => c.Name.Equals(company.City.Name));
            if (cityExists == false)
                new CityController().Create(company.City);
            company.City = db.Cities.Where(c => c.Name.Equals(company.City.Name)).FirstOrDefault();
            if (ModelState.IsValid)
                db.Companies.Add(company);
                db.SaveChanges();
                
            return RedirectToAction("Menu", "Home");
        }

        // GET: Company/Edit/1
        public ActionResult Edit(int? id)
        {
            if(id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Company company = db.Companies.Find(id);
            if (company == null)
                return HttpNotFound();
            return View(company);
        }

        // POST: Company/Edit/1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Address,City")]Company company)
        {
            bool cityExists = db.Cities.Any(c => c.Name.Equals(company.City.Name));
            if (cityExists == false)
                new CityController().Create(company.City);
            company.City = db.Cities.Where(c => c.Name.Equals(company.City.Name)).FirstOrDefault();
            if (ModelState.IsValid)
                db.Entry(company).State = EntityState.Modified;
                db.SaveChanges();
            return RedirectToAction("Menu", "Home");
        }

        //// GET: Company/Delete/1
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Company company = db.Companies.Find(id);
            if (company == null)
                return HttpNotFound();
            return View(company);
        }

        // POST: Company/Delete/1
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteComfirmed(int id)
        {
            Company company = db.Companies.Find(id);
            db.Companies.Remove(company);
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