using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ModelBinding;
using DEX.Models;
using DEX.Repositories.RepoInterfaces;

namespace DEX.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public IQueryable<Company> GetAllCompanies(int cityId)
        {
            var companiesList = db.Companies.Where(c => c.City.Id == cityId);
            return companiesList;
        }

        public Company GetCompany(int companyId)
        {
            return db.Companies.Find(companyId);
        }

        public void CreateCompany(Company company, City city)
        {
            company.City = db.Cities.FirstOrDefault(c => c.Name.Equals(company.City.Name));
            db.Companies.Add(company);
            //db.Companies.SaveChanges();
        }

        public void UpdateCompany(Company company)
        {
            throw new NotImplementedException();
        }

        public void DeleteCompany(int id)
        {
            throw new NotImplementedException();
        }
    }
}