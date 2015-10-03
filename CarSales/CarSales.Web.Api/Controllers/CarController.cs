using CarSales.Dal;
using CarSales.Dal.Interfaces;
using CarSales.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace CarSales.Web.Api.Controllers
{
    //[RoutePrefix("api/car")]
    public class CarController : ApiController
    {
        private readonly ICarData carData;
        public CarController()
        {
            carData = new CarData();
        }
        // HttpMethod = GET
        // Example Usage: /api/car/
        public IList<Car> Get()
        {
            return GetAll();
        }
        // HttpMethod = GET
        // Example Usage: /api/car
        // Example Usage: /api/car/GetAll
        public IList<Car> GetAll()
        {
            return carData.GetAll();
        }

        // HttpMethod = GET
        // Example Usage: /api/car/GetByManufacturer?manufacturer=name
        public IList<Car> GetByManufacturer(string manufacturer)
        {
            return carData.GetByManufacturer(manufacturer);
        }

        // HttpMethod = GET
        // Example Usage: /api/car/<number>
        public Car GetById(decimal id)
        {
            return carData.GetById(id);
        }

        // HttpMethod = POST
        // Example: /api/car/Add
        // Content-Type: application/json; charset=UTF-8
        // Possible RequestBody: {"Manufacturer":"Honda","FuelType":"Diese","Variant":"CVX","Torque":10.0,"MaxSpeed":160.0,"Id":-1.0,"Name":"Amaze"}
        public decimal Add([FromBody] Car car)
        {
            return carData.Add(car);
        }

        // HttpMethod = POST
        // Example: /api/car/Update
        // Content-Type: application/json; charset=UTF-8
        // Possible RequestBody: {"Manufacturer":"Honda","FuelType":"Diese","Variant":"CVX","Torque":10.0,"MaxSpeed":160.0,"Id":-1.0,"Name":"Amaze"}
        public bool Update([FromBody] Car car)
        {
            return carData.Update(car);
        }

        [HttpDelete]
        // HttpMethod = DELETE
        // Example: /api/car/<number>
        // Content-Type: application/json; charset=UTF-8
        public bool RemoveById(decimal id)
        {
            return carData.RemoveById(id);
        }
       
    }
}
