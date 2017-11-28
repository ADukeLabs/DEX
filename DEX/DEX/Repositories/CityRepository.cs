using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DEX.Models;
using DEX.Repositories.RepoInterfaces;
using DEX.ViewModels;

namespace DEX.Repositories
{
    public class CityRepository : ICityRepository
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public void CreateCity(City city)
        {
            var newCity = new City {Name = city.Name};
            db.Cities.Add(newCity);
            db.SaveChanges();
        }

        public void DeleteCity(int cityId)
        {
            var city = db.Cities.Find(cityId);
            if (city == null)
                throw new NullReferenceException("There is no record of this city.");
            db.Cities.Remove(city);
            db.SaveChanges();
        }
    }
}