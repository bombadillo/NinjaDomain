namespace NinjaDomain.WebApi.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;

    using Data.Services;
    using Data.Interfaces;
    using Classes;    

    public class NinjaController : ApiController
    {
        private readonly IRetrieveData<Ninja> DataRetriever;

        public NinjaController(IRetrieveData<Ninja> dataRetriever)
        {
            DataRetriever = dataRetriever;
        }

        // GET api/values
        public List<Ninja> Get()
        {
            return DataRetriever.GetAll();
        }

        // GET api/values/5
        public Ninja Get(int id)
        {
            return DataRetriever.GetOne(id);
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
