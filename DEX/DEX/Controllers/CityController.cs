using DEX.Models;
using System.Web.Mvc;

namespace DEX.Controllers
{
    public class CityController : Controller
    {

        ApplicationDbContext db = new ApplicationDbContext();

        //// GET: City
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: City/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: City/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public void Create([Bind(Include = "Id, Name")]City city)
        {
            if (ModelState.IsValid)
                db.Cities.Add(city);
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