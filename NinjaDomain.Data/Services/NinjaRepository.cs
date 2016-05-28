namespace NinjaDomain.Data.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System;

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


        public bool Add(Ninja item)
        {
            bool result;
            try
            {
                NinjaContext.Ninjas.Add(item);
                NinjaContext.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
                Console.WriteLine(ex.Message);
            }

            return result;
        }
    }
}
