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

        public void CreateCity(CityViewModel cityVm)
        {
            City city = new City(cityVm);
            db.Cities.Add(city);
        }

        public void DeleteCity(int cityId)
        {
            var city = db.Cities.Find(cityId);
            db.Cities.Remove(city);
            db.SaveChanges();
        }
    }
}