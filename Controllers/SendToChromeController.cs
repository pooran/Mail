using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SendMail.Controllers
{
    public class SendToChromeController : ApiController
    {
        // GET api/sendtochrome
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/sendtochrome/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/sendtochrome
        public void Post([FromBody]string value)
        {
        }

        // PUT api/sendtochrome/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/sendtochrome/5
        public void Delete(int id)
        {
        }
    }
}
