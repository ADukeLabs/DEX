﻿using DEX_Api.DbContexts;
using DEX_Api.Models;
using DEX_Api.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEX_Api.Repositories
{
    public class CityRepository : ICityRepository
    {
        private CityDb _db = new CityDb();

        public void CreateCity(string name)
        {
            var newCity = new City(name);
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