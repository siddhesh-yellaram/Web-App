using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApp.Controllers
{
    [RoutePrefix("api/v1/aurionpro")]
    public class BrowseController : ApiController
    {
        [Route("CompanyInfo")]
        public IHttpActionResult GetCompanyInfo()
        {
            Random r = new Random();
            int randNo = r.Next(1,10);
            if(randNo > 5)
            {
                return Ok(new { 
                        Name = "Siddhesh",
                        Strength = "50",
                        Address = "Abc"
                });
            }
            return BadRequest("No Company Found");
        }
    }
}
