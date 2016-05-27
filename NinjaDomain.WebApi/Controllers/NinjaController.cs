namespace NinjaDomain.WebApi.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;

    using Data.Services;
    using Data.Interfaces;
    using Classes;    

    public class NinjaController : ApiController
    {
        private readonly IDataRepository<Ninja> NinjaRepository;

        public NinjaController(IDataRepository<Ninja> dataRepository)
        {
            NinjaRepository = dataRepository;
        }

        // GET api/values
        public List<Ninja> Get()
        {
            return NinjaRepository.GetAll();
        }

        // GET api/values/5
        public Ninja Get(int id)
        {
            return NinjaRepository.GetOne(id);
        }

        // POST api/values
        public void Post([FromBody]Ninja ninja)
        {
            NinjaRepository.Add(ninja);
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
