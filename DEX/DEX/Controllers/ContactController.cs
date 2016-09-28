using DEX.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEX.Controllers
{
    public class ContactController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        

        //// GET: Contact/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: Contact/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,Name,Title,Email,PhoneNumber")]Contact contact, int? id)
        {
            contact.Company = db.Companies.Find(id);
            if (ModelState.IsValid)
                db.Contacts.Add(contact);
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