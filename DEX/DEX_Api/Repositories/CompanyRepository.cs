using DEX_Api.DbContexts;
using DEX_Api.Models;
using DEX_Api.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DEX_Api.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private CompanyDb _dbCompany = new CompanyDb();
        private CityDb _dbCity = new CityDb();
        private ICityRepository _cityRepository;

        public CompanyRepository()
        {
            _cityRepository = new CityRepository();
        }

        public IQueryable<Company> GetAllCompanies(int cityId)
        {
            return _dbCompany.Companies.Where(c => c.City.Id == cityId);
        }

        public Company GetCompany(int companyId)
        {
            return _dbCompany.Companies.FirstOrDefault(c => c.Id == companyId);
        }

        public void CreateCompany(Company company)
        {
            if (_dbCity.Cities.Find(company.City.Name) == null)
            {
                _cityRepository.CreateCity(company.City.Name);
            }
            company.City = _dbCity.Cities.FirstOrDefault(c => c.Name == company.City.Name);
        }

    }
}