namespace NinjaDomain.Data.Services
{
    using System.Collections.Generic;
    using System.Linq;

    using Interfaces;
    
    public class DataRetriever<T> : IRetrieveData<T>
    {
        public List<T> GetAll()
        {
            var data = new List<T>();

            return data;
        }
    }
}
