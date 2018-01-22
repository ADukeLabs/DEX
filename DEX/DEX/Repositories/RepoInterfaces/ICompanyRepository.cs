using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEX.Models;

namespace DEX.Repositories.RepoInterfaces
{
    public interface ICompanyRepository
    {
        IQueryable<Company> GetAllCompanies(int cityId);
        Company GetCompany(int companyId);
        void CreateCompany(Company company, City city);
        void UpdateCompany(Company company);
        void DeleteCompany(int id);
    }
}
