namespace NinjaDomain.Data.Services
{
    using System.Collections.Generic;
    using System.Linq;

    using Interfaces;
    using Classes;
    using Contexts;

    public class NinjaRepository : IDataRepository<Ninja>
    {
        private readonly INinjaContext NinjaContext;

        public NinjaRepository(INinjaContext ninjaContext)
        {
            NinjaContext = ninjaContext;
        }

        public List<Ninja> GetAll()
        {
            return NinjaContext.Ninjas.ToList();
        }


        public Ninja GetOne(int id)
        {
            return NinjaContext.Ninjas.FirstOrDefault(x => x.Id == id);
        }
    }
}
