﻿using Dex_API.Models;
using Dex_API.Models.DomainModels;
using DEX_API.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DEX_API.Repositories
{
    public class CityRepository : ICityRepository
    {
        ApplicationDbContext _db = new ApplicationDbContext();
        
        public IList<City> GetCities()
        {
            return _db.Cities.Include(i => i.Companies).OrderBy(c => c.Name).ToList();
        }

        public void CreateCity(string name)
        {
            var newCity = new City{Name = name};
            _db.Cities.Add(newCity);
        }

        public void DeleteCity(int cityId)
        {
            var city = _db.Cities.Find(cityId);
            if (city == null)
                throw new NullReferenceException("There is no record of this city.");
            _db.Cities.Remove(city);
            _db.SaveChanges();
        }
    }
}