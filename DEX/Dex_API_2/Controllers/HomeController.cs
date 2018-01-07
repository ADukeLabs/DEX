using DEX_Api.Controllers;
using DEX_Api.Repositories.Interfaces;
using DEX_Api.ViewModels;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using Dex_API.Models.DomainModels;
using System.Collections.Generic;

namespace DEX_API.Controllers
{
    public class HomeController : BaseApiController
    {   

        public HomeController(ICityRepository cityRepo, ICompanyRepository companyRepo) : base(cityRepo, companyRepo){ }
        
        [HttpGet]
        [Route("api/home/getCities")]
        public IHttpActionResult GetCities()
        {
            var rawCities = _cityRepository.GetCities();
            var cities = Mapper.Map<CityViewModel>(rawCities);
            return Ok(cities);
        }

    }
}