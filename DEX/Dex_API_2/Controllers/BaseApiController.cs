using DEX_Api.Repositories.Interfaces;
using System.Web.Http;

namespace DEX_Api.Controllers
{
    public abstract class BaseApiController : ApiController
    {
        protected readonly ICityRepository _cityRepository;
        protected readonly ICompanyRepository _companyRepository;

        public BaseApiController(ICityRepository cityRepository, ICompanyRepository companyRepository)
        {
            _cityRepository = cityRepository;
            _companyRepository = companyRepository;
        }

    }
}