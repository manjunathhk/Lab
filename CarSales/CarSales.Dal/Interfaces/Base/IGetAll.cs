using System.Collections.Generic;

namespace CarSales.Dal.Interfaces.Base
{
    public interface IGetAll<T>
    {
        IList<T> GetAll();
    }
}
