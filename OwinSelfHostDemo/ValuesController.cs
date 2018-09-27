using System.Collections.Generic;
using System.Web.Http;

namespace OwinSelfHostDemo
{
    public class ValuesController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "my first amazing value", "another incredible value" };
        }

        public string Get(int id)
        {
            return "the lonely single value";
        }

        public void Post([FromBody]string value) { }

        public void Put(int id, [FromBody] string value) { }

        public void Delete(int id) { }

    }
}

