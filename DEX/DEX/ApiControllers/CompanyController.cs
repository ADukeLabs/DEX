using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using DEX.Models;
using DEX.Repositories;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Newtonsoft.Json;

namespace DEX.ApiControllers
{
    public class CompanyController : ApiController
    {
        private readonly CityRepository _cityRepository;
        private readonly CompanyRepository _companyRepository;
        private ApplicationDbContext db = new ApplicationDbContext();
        protected UserManager<ApplicationUser> UserManager { get; set; }

        public CompanyController()
        {
            UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            _cityRepository = new CityRepository();
            _companyRepository = new CompanyRepository();
        }


        // GET api/<controller>
        [Authorize]
        [HttpGet]
        [Route("api/company/getAllCompanies/{userId}")]
        public IHttpActionResult GetAllCompanies(int userId)
        {
            var companyList = _companyRepository.GetAllCompanies(userId);
            var companies = JsonConvert.SerializeObject(companyList, Formatting.None, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Ok(companies);
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}