using System.Collections.Generic;
using CarSales.Dal.Interfaces.Base;
using CarSales.Models;

namespace CarSales.Dal.Interfaces
{
    public interface ICarData : IGetAll<Car>, IData<Car>
    {
        IList<Car> GetByManufacturer(string manufacturer);
    }
}
