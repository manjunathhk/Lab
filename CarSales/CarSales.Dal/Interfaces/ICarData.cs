using CarSales.Dal.Interfaces.Base;
using CarSales.Models;
using System.Collections.Generic;

namespace CarSales.Dal.Interfaces
{
    public interface ICarData : IGetAll<Car>, IData<Car>
    {
        IList<Car> GetByManufacturer(string manufacturer);
    }
}
