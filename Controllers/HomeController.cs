using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApp.Controllers
{
    public class HomeController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Json("Get Called");
        }

        public IHttpActionResult Post()
        {
            return Json("Post Called");
        }
    }
}
