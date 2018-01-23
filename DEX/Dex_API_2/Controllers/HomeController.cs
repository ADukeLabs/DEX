using DEX_API.Controllers;
using DEX_API.Repositories.Interfaces;
using DEX_API.ViewModels;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using Dex_API.Models.DomainModels;
using System.Collections.Generic;
using Dex_API_2.Models.ModelFactories.Interfaces;

namespace DEX_API.Controllers
{
    public class HomeController : BaseApiController
    {   

        public HomeController(ICityRepository cityRepo, ICompanyRepository companyRepo, IModelFactory modelFactory) : base(cityRepo, companyRepo, modelFactory){ }
        
        [HttpGet]
        [Route("api/home/getCities")]
        public IHttpActionResult GetCities()
        {
            var rawCities = _cityRepository.GetCities();
            var cities = _modelFactory.ToViewModelList(rawCities);
            return Ok(cities);
        }

    }
}