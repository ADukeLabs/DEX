using Dex_API.Models;
using Dex_API.Models.DomainModels;
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
        private ICityRepository _cityRepository;
        private ApplicationDbContext _db = new ApplicationDbContext();

        public CompanyRepository()
        {
            _cityRepository = new CityRepository();
        }

        public IQueryable<Company> GetAllCompanies(int cityId)
        {
            return _db.Companies.Where(c => c.City.Id == cityId);
        }

        public Company GetCompany(int companyId)
        {
            return _db.Companies.FirstOrDefault(c => c.Id == companyId);
        }

        public void CreateCompany(Company company)
        {
            if (_db.Cities.Find(company.City.Name) == null)
            {
                _cityRepository.CreateCity(company.City.Name);
            }
            company.City = _db.Cities.FirstOrDefault(c => c.Name == company.City.Name);
        }

        public void DeleteCompany(int id)
        {
            var companyToDelete = _db.Companies.Find(id);
            _db.Companies.Remove(companyToDelete);
            _db.SaveChanges();
        }

    }
}