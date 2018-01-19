using DEX_Api.Repositories;
using DEX_Api.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dex_API_2.Factories.Interfaces;


namespace DEX_Api.Controllers
{
    public class CompanyController : BaseApiController
    {
        public CompanyController(ICityRepository cityRepo, ICompanyRepository companyRepo, IModelFactory modelFactory) : base(cityRepo, companyRepo, modelFactory)
        {
        }

        //[HttpGet]
        //[Route("api/company/getCompanies")]
        //public HttpResponseMessage GetCompanies()
        //{
        //    return Ok();
        //}



        //// GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}