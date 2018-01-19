using Dex_API.Models;
using DEX_Api.Repositories.Interfaces;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Web.Http;
using Dex_API_2.Factories.Interfaces;

namespace DEX_Api.Controllers
{
    public abstract class BaseApiController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        protected UserManager<ApplicationUser> UserManager { get; set; }

        protected readonly ICityRepository _cityRepository;
        protected readonly ICompanyRepository _companyRepository;
        protected readonly IModelFactory _modelFactory;

        public BaseApiController(ICityRepository cityRepository, ICompanyRepository companyRepository, IModelFactory modelFactory)
        {
            _cityRepository = cityRepository;
            _companyRepository = companyRepository;
            _modelFactory = modelFactory;
            UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
        }

    }
}