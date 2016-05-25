namespace NinjaDomain.WebApi.Controllers
{    
    using System.Collections.Generic;
    using System.Web.Http;

    using Data.Services;
    using Classes;

    public class NinjaController : ApiController
    {
        // GET api/values
        public List<Ninja> Get()
        {
            var ninjaRepository = new DataRetriever<Ninja>();
            return ninjaRepository.GetAll();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
