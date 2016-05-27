namespace NinjaDomain.Data.Services
{
    using System.Collections.Generic;

    using Interfaces;
    using Classes;
    using Contexts;

    public class NinjaRetriever : IRetrieveData<Ninja>
    {
        private readonly INinjaContext NinjaContext;

        public NinjaRetriever(INinjaContext ninjaContext)
        {
            NinjaContext = ninjaContext;
        }

        public List<Ninja> GetAll()
        {
            var data = new List<Ninja>
            {
                new Ninja { Id = 1, Name = "Bob" },
                new Ninja { Id = 2, Name = "Frank" }
            };

            return data;
        }
    }
}
