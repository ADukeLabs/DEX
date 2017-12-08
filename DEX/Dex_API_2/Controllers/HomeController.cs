using Dex_API.Models;
using DEX_Api.Controllers;
using DEX_Api.Repositories.Interfaces;
using DEX_Api.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace DEX_API.Controllers
{
    public class HomeController : BaseApiController
    {
 
        public HomeController(ICityRepository cityRepo, ICompanyRepository companyRepo) : base(cityRepo, companyRepo){ }
        
        [HttpGet]
        [Route("api/home/getCities")]
        public IHttpActionResult GetCities()
        {
            var cities = _cityRepository.GetCities(); 
            var menuVm = new CityViewModel();
            

            return Ok(menuVm);
        }

    }
}