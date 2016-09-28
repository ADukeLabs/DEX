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

        // GET: /Contact/GetContacts/
        [HttpGet]
        public string GetContacts(int companyId)
        {
            List<Contact> contactList = db.Contacts.Where(c => c.Company.Id == companyId).ToList();
            string contacts = JsonConvert.SerializeObject(contactList, Formatting.None, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return contacts;
        }
    }
}