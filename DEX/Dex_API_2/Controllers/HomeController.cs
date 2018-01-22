using DEX_Api.Controllers;
using DEX_Api.Repositories.Interfaces;
using DEX_Api.ViewModels;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using Dex_API.Models.DomainModels;
using System.Collections.Generic;
using Dex_API.Factories;
using Dex_API.Factories.Interfaces;

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
            var cities = _modelFactory.CityToCityViewModel(rawCities);
            return Ok(cities);
        }

    }
}