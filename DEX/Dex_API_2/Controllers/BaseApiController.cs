using Dex_API.Models;
using DEX_Api.Repositories.Interfaces;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Web.Http;

namespace DEX_Api.Controllers
{
    public abstract class BaseApiController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        protected UserManager<ApplicationUser> UserManager { get; set; }


        protected readonly ICityRepository _cityRepository;
        protected readonly ICompanyRepository _companyRepository;

        public BaseApiController(ICityRepository cityRepository, ICompanyRepository companyRepository)
        {
            _cityRepository = cityRepository;
            _companyRepository = companyRepository;
            UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
        }

    }
}