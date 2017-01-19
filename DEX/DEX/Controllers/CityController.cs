using DEX.Models;
using System.Linq;
using System.Web.Mvc;

namespace DEX.Controllers
{
    public class CityController : Controller
    {

        ApplicationDbContext db = new ApplicationDbContext();

        //// POST: City/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public void Create([Bind(Include = "Id, Name")]City city)
        {
            if (ModelState.IsValid)
                db.Cities.Add(city);
                db.SaveChanges(); 
        }

        // POST: City/Delete/1
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public void Delete(int id)
        {
            City city = db.Cities.Find(id);
            db.Cities.Remove(city);
            db.SaveChanges();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                db.Dispose();
            base.Dispose(disposing);
        }
    }
}