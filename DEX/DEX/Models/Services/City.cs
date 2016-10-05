using System.Collections.Generic;

namespace DEX.Models
{
    public class City
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Company> Companies { get; set; }

        public void AddNewCity(City city)
        {
            db.Cities.Add(city);
            db.SaveChanges();        
        }

    }
}