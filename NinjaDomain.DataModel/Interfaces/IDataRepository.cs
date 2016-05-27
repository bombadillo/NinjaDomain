namespace NinjaDomain.Data.Interfaces
{
    using System.Collections.Generic;

    public interface IDataRepository<T>
    {
        List<T> GetAll();
        T GetOne(int id);
        bool Add(T item);
    }
}
