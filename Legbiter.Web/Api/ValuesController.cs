using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Legbiter.Web.Api
{
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello", "World" };
        }
    }
}
