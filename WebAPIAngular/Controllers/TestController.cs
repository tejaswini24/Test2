using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIAngular.Controllers
{
    public class TestController : ApiController
    {
        public List<string> GetDetails()
        {

            return new List<string> { "Hello", "First Program"};
        }
    }
}
