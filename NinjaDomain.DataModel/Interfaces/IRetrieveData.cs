namespace NinjaDomain.Data.Interfaces
{
    using System.Collections.Generic;

    public interface IRetrieveData<T>
    {
        List<T> GetAll();
        T GetOne(int id);
    }
}
