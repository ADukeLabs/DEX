using DEX_Api.Controllers;
using DEX_Api.Repositories.Interfaces;
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

        public HomeController(ICityRepository cityRepo, ICompanyRepository companyRepo) : base(cityRepo, companyRepo)
        {
        }
        
        [HttpGet]
        [Route("api/home/getCities")]
        public IHttpActionResult GetCities()
        {

            return Ok();
        }

    }
}