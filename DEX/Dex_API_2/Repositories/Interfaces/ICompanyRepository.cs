using Dex_API.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEX_Api.Repositories.Interfaces
{
    public interface ICompanyRepository
    {
        IQueryable<Company> GetAllCompanies(int cityId);
        Company GetCompany(int companyId);
        void CreateCompany(Company company);
        //void UpdateCompany(Company company);
        void DeleteCompany(int id);
    }
}
